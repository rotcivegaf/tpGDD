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
            int calificacionesPendientes = Convert.ToInt32(queriesTableAdapter1.calificacionesPendientesDeUsuario(UserID));
            if (calificacionesPendientes > 5)
            {
                MessageBox.Show("Debe calificar antes de seguir comprando");
            }
            else
            {
                this.ShowDialog();
            }
        }
        
        private void Comprar_Ofertar_Load(object sender, EventArgs e)
        {
            this.tl_RubrosTableAdapter.Fill(this.gD1C2014DataSet.tl_Rubros);
            llenarPublicaciones();
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
        }

        private void dataGridViewPublicaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Si quiero hacer una pregunta
            if (e.ColumnIndex == Preguntar.Index)// PreguntarColumnIndex)
            {
                //Cargo en una fila (DataGridViewRow) el registro deseado
                DataGridViewRow fila = dataGridViewPublicaciones.Rows[e.RowIndex];
                //Si la publicación acepta preguntas
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
                int calificacionesPendientes = Convert.ToInt32(queriesTableAdapter1.calificacionesPendientesDeUsuario(UserID));
                if (calificacionesPendientes > 5)
                {
                    MessageBox.Show("Debe calificar antes de seguir comprando");
                }
                else
                {

                    //Cargo en una fila (DataGridViewRow) el registro deseado
                    DataGridViewRow fila = dataGridViewPublicaciones.Rows[e.RowIndex];
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
                        llenarPublicaciones();
                    }
                }
            }
        }
        
        private void buttonPrincipio_Click(object sender, EventArgs e)
        {
            offset = 1;
            llenarPublicaciones();
        }

        private void buttonAnterior_Click(object sender, EventArgs e)
        {
            if (offset > LIMITE)
                offset -= LIMITE;
            else
                offset = 1;
            llenarPublicaciones();
        }

        private void buttonSiguiente_Click(object sender, EventArgs e)
        {
            if (offset <= QtyRegistros - LIMITE)
            {
                offset += LIMITE;
                llenarPublicaciones();
            }
        }

        private void buttonFin_Click(object sender, EventArgs e)
        {
            offset = QtyRegistros - LIMITE + 1;
            llenarPublicaciones();
        }
    }
}
