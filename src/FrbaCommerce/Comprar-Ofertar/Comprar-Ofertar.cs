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

        private const int IndexColumnaClienteID = 10;
        private const int IndexColumnaEmpresaID = 11;

        int offset = 0;
        int LIMITE = 20;
        GD1C2014DataSet.tl_PublicacionesDataTable tablaTemporal = new GD1C2014DataSet.tl_PublicacionesDataTable();


        public Comprar_Ofertar()
        {
            InitializeComponent();
        }

        public void setID(int user_ID)
        {
            UserID = user_ID;
        }

        private void tl_PublicacionesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tl_PublicacionesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gD1C2014DataSet);

        }

        private void Comprar_Ofertar_Load(object sender, EventArgs e)
        {
            //Cargo las tablas necesarias en los dataTable correspondientes, por motivos de performance
            //la tabla de publicaciones solo se cargará al momento de buscar una publicación
            this.tl_RubrosTableAdapter.Fill(this.gD1C2014DataSet.tl_Rubros);
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
                llenarPublicaciones();
            }
        }

        private void llenarPublicaciones()
        {
            //Aplica los filtros de descripción, rubro.
            //No muestra las publicaciones en estado borrador y finalizada
            //Aplica el criterio de visibilidad
            this.tl_PublicacionesTableAdapter.FillByFilter(tablaTemporal, armarLike(textBoxDescripcion.Text), Convert.ToInt32(comboBoxRubros.SelectedValue));
            //Una vez que tengo la tabla filtrada llamo al método paginar
            paginar(tablaTemporal);
        }
        private void paginar(GD1C2014DataSet.tl_PublicacionesDataTable unaTabla )
        {
            //Pagino la tabla
            dataGridViewPublicaciones.DataSource = this.tl_PublicacionesTableAdapter.GetDataByPaginador(offset, LIMITE, unaTabla);            
        }

        private string armarLike(string descripcion)
        {
            //La consulta del where es LIKE %Descripcion%
            return "%"+textBoxDescripcion.Text.ToString()+"%";
        }
        private void dataGridViewPublicaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Si quiero hacer una pregunta
            if (e.ColumnIndex == 8)
            {
                //Cargo en una fila (DataGridViewRow) el registro deseado
                DataGridViewRow fila = dataGridViewPublicaciones.Rows[e.RowIndex];
                //Si la publicación acepta preguntas && valido que no sea una auto-pregunta
                if (Convert.ToBoolean(fila.Cells[7].Value) &&  ( !mismoCliente(fila) ))
                {
                    //Creo un formulario de nueva pregunta y le mando el ID de la publicación para cargarlo en la tabla
                    Gestion_de_Preguntas.Nueva_Pregunta frame = new Gestion_de_Preguntas.Nueva_Pregunta();
                    frame.setIDPublicacion(Convert.ToInt32(fila.Cells[0].Value));
                    frame.ShowDialog();
                }
            }
            //si quiero hacer una compra
            if (e.ColumnIndex == 9)
            {
                //Cargo en una fila (DataGridViewRow) el registro deseado
                DataGridViewRow fila = dataGridViewPublicaciones.Rows[e.RowIndex];
                //Verifico que no me quiera auto-comprar
                if (!mismoCliente(fila))
                {
                    if(!(fila.Cells[6].Value.ToString().Equals("Pausada")))
                    {
                        if (fila.Cells[5].Value.ToString().Equals("Subasta"))
                            MessageBox.Show("Es Subasta");
                        else
                        {
                            NuevaCompra frame = new NuevaCompra();
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
                            llenarPublicaciones();
                        }
                    }
                }
            }
        }
        private bool mismoCliente(DataGridViewRow registro)
        {
            if (isPublicacionDeEmpresa(registro))
            {
                return (Convert.ToInt32(registro.Cells[11].Value) == this.UserID);
            }
            else
                return (Convert.ToInt32(registro.Cells[10].Value) == this.UserID);
            
        }

        private static bool isPublicacionDeEmpresa(DataGridViewRow registro)
        {
            return (Convert.ToInt32(registro.Cells[10].Value.ToString().Length)) == 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            offset = 0;
            paginar(tablaTemporal);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            offset -= LIMITE;
            paginar(tablaTemporal);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            offset += LIMITE;
            paginar(tablaTemporal);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            offset = Convert.ToInt32(tablaTemporal.Count) - LIMITE;
            paginar(tablaTemporal);
        }
    }
}
