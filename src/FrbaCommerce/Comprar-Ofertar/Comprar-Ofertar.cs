using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaCommerce.Comprar_Ofertar
{
    public partial class Comprar_Ofertar : Form
    {
        private int UserID;

        int offset = 1;
        int LIMITE = 20;
        int QtyRegistros;
        GD1C2014DataSet.tl_PublicacionesDataTable tablaTemporal = new GD1C2014DataSet.tl_PublicacionesDataTable();

        public Comprar_Ofertar()
        {
            InitializeComponent();
        }

        public void abrir(int user_ID)
        {
            UserID = user_ID;
            int calificacionesPendientes = (int)queriesTableAdapter1.calificacionesPendientesDeUsuario(UserID);
            if (calificacionesPendientes > 5)
            {
                MessageBox.Show("Debe calificar antes de seguir comprando");
            }
            else
            {
                //llenarPublicaciones();
                this.ShowDialog();
            }
        }
        /*
        public void setID(int user_ID)
        {
            UserID = user_ID;
        }
        */
        /*
        private void tl_PublicacionesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tl_PublicacionesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gD1C2014DataSet);

        }
        */
        private void Comprar_Ofertar_Load(object sender, EventArgs e)
        {
            //Cargo las tablas necesarias en los dataTable correspondientes, por motivos de performance
            //la tabla de publicaciones solo se cargará al momento de buscar una publicación
            this.tl_RubrosTableAdapter.Fill(this.gD1C2014DataSet.tl_Rubros);
            llenarPublicaciones();
            //this.tl_Publicaciones_RubrosTableAdapter.Fill(this.gD1C2014DataSet.tl_Publicaciones_Rubros);
        }

        private bool validar()
        {

            return (!(commons.algunoVacio(textBoxDescripcion) ));

        }

        private void buttonBuscarPublicacion_Click(object sender, EventArgs e)
        {
            //Si pasa la validación, es decir si el campo descripción no está vacio
            if (this.validar())
            {
                offset = 1;
                llenarPublicaciones();
            }
        }

        private void llenarPublicaciones()
        {
            int? TotalRegistros = 0;

            this.publicacionesBindingSource.DataSource = 
                this.publicacionesTableAdapter.GetParaComprar(
                    UserID,
                    textBoxDescripcion.Text,
                    Convert.ToInt32(comboBoxRubros.SelectedValue),
                    commons.getDate(),
                    offset,LIMITE,ref TotalRegistros);

            QtyRegistros = (int)TotalRegistros;
            //Aplica los filtros de descripción, rubro.
            //No muestra las publicaciones en estado borrador y finalizada
            //Aplica el criterio de visibilidad
            //this.tl_PublicacionesTableAdapter.FillByFilter(tablaTemporal, armarLike(textBoxDescripcion.Text), Convert.ToInt32(comboBoxRubros.SelectedValue));
            //QtyRegistros = Convert.ToInt32(tablaTemporal.Rows.Count);
            //Una vez que tengo la tabla filtrada llamo al método paginar
            //paginar(tablaTemporal);
        }

        private void paginar(GD1C2014DataSet.tl_PublicacionesDataTable unaTabla )
        {
            //Pagino la tabla
            dataGridViewPublicaciones.DataSource = this.tl_PublicacionesTableAdapter.GetDataByPaginador(offset, LIMITE, unaTabla);            
        }

        /*
        private string armarLike(string descripcion)
        {
            //La consulta del where es LIKE %Descripcion%
            return "%"+textBoxDescripcion.Text.ToString()+"%";
        }
        */
        private void dataGridViewPublicaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int CodigoColumnIndex = dataGridViewPublicaciones.Columns["Codigo"].Index;
            //int TipoColumnIndex = dataGridViewPublicaciones.Columns["Tipo"].Index;
            //int PermitePreguntasColumnIndex = dataGridViewPublicaciones.Columns["Permite_Preguntas"].Index;
            //int PreguntarColumnIndex = dataGridViewPublicaciones.Columns["Preguntar"].Index;
            //int ComprarColumnIndex = dataGridViewPublicaciones.Columns["Comprar"].Index; ;

            //Si quiero hacer una pregunta
            if (e.ColumnIndex == Preguntar.Index)// PreguntarColumnIndex)
            {
                //Cargo en una fila (DataGridViewRow) el registro deseado
                DataGridViewRow fila = dataGridViewPublicaciones.Rows[e.RowIndex];
                //Si la publicación acepta preguntas && valido que no sea una auto-pregunta && el estado no es borrador
                //if (Convert.ToBoolean(fila.Cells[7].Value) &&  ( !mismoCliente(fila) ) && !(fila.Cells[6].Value.ToString().Equals("Pausada")) )
                if (Convert.ToBoolean(fila.Cells[Permite_Preguntas.Index].Value))
                {
                    //Creo un formulario de nueva pregunta y le mando el ID de la publicación para cargarlo en la tabla
                    Gestion_de_Preguntas.Nueva_Pregunta frame = new Gestion_de_Preguntas.Nueva_Pregunta();
                    frame.setIDPublicacion(Convert.ToInt32(fila.Cells[Codigo.Index].Value));
                    frame.ShowDialog();
                }
            }
            //si quiero hacer una compra
            if (e.ColumnIndex == Comprar.Index)
            {
                int calificacionesPendientes = (int)queriesTableAdapter1.calificacionesPendientesDeUsuario(UserID);
                if (calificacionesPendientes > 5)
                {
                    MessageBox.Show("Debe calificar antes de seguir comprando");
                }
                else
                {

                    //Cargo en una fila (DataGridViewRow) el registro deseado
                    DataGridViewRow fila = dataGridViewPublicaciones.Rows[e.RowIndex];
                    //Verifico que no me quiera auto-comprar
                    //if (!mismoCliente(fila))
                    //{
                    //if(!(fila.Cells[6].Value.ToString().Equals("Pausada")))
                    //{
                    if (fila.Cells[Tipo.Index].Value.ToString().Equals("Subasta"))
                    {
                        NuevaOferta frmOferta = new NuevaOferta();
                        frmOferta.abrir(
                            UserID,
                            Convert.ToInt32(fila.Cells[Codigo.Index].Value));
                    }
                    else //Compra Inmediata
                    {
                        NuevaCompra frame = new NuevaCompra();
                        frame.sendData(
                            UserID,
                            Convert.ToInt32(fila.Cells[Codigo.Index].Value),
                            Convert.ToInt32(fila.Cells[Stock.Index].Value),
                            Convert.ToInt32(fila.Cells[Visibilidad_Codigo.Index].Value),
                            Convert.ToDecimal(fila.Cells[Precio.Index].Value),
                            Convert.ToInt32(fila.Cells[Usuario_ID.Index].Value));
                        frame.ShowDialog();
                        /*
                        if (isPublicacionDeEmpresa(fila)) //es Empresa
                        {
                            frame.sendData(this.UserID,
                            Convert.ToInt32(fila.Cells[0].Value),
                            Convert.ToInt32(fila.Cells[2].Value),
                            Convert.ToInt32(fila.Cells[12].Value),
                            Convert.ToInt32(fila.Cells[4].Value),
                            Convert.ToInt32(fila.Cells[11].Value));
                            frame.ShowDialog();
                        }
                        else //es Cliente
                        {
                            frame.sendData(this.UserID,
                            Convert.ToInt32(fila.Cells[0].Value),
                            Convert.ToInt32(fila.Cells[2].Value),
                            Convert.ToInt32(fila.Cells[12].Value),
                            Convert.ToInt32(fila.Cells[4].Value),
                            Convert.ToInt32(fila.Cells[10].Value));
                            frame.ShowDialog();
                        }
                        */
                        llenarPublicaciones();
                    }
                    //}
                    //}
                }
            }
        }
        /*
        private bool mismoCliente(DataGridViewRow registro)
        {
            if (isPublicacionDeEmpresa(registro))
            {
                return (Convert.ToInt32(registro.Cells[11].Value) == this.UserID);
            }
            else
                return (Convert.ToInt32(registro.Cells[10].Value) == this.UserID);  
        }
        */
        /*
        private static bool isPublicacionDeEmpresa(DataGridViewRow registro)
        {
            return (Convert.ToInt32(registro.Cells[10].Value.ToString().Length)) == 0;
        }
        */

        private void buttonPrincipio_Click(object sender, EventArgs e)
        {
            offset = 1;
            llenarPublicaciones();
            //paginar(tablaTemporal);
        }

        private void buttonAnterior_Click(object sender, EventArgs e)
        {
            if (offset > LIMITE)
                offset -= LIMITE;
            else
                offset = 1;
            llenarPublicaciones(); 
            //paginar(tablaTemporal);
        }

        private void buttonSiguiente_Click(object sender, EventArgs e)
        {
            if (offset <= QtyRegistros - LIMITE)
            {
                offset += LIMITE;
                llenarPublicaciones();
            }
            //paginar(tablaTemporal);
        }

        private void buttonFin_Click(object sender, EventArgs e)
        {
            offset = QtyRegistros - LIMITE + 1;
            llenarPublicaciones();
            //paginar(tablaTemporal);
        }
    }
}
