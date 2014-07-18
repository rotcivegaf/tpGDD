using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using FrbaCommerce.Gestion_de_Preguntas;

namespace FrbaCommerce.Comprar_Ofertar
{
    public partial class Comprar_Ofertar : Form
    {
        private int UserID;

        int offset = 1;
        int LIMITE;
        int QtyRegistros;
        GD1C2014DataSet.tl_PublicacionesDataTable tablaTemporal = new GD1C2014DataSet.tl_PublicacionesDataTable();

        public Comprar_Ofertar()
        {
            InitializeComponent();
        }

        public void abrir(int user_ID)
        {
            UserID = user_ID;
            int calificacionesPendientes = Convert.ToInt32(tl_UsuariosTableAdapter.getCalificacionesPendientes(UserID));
            if (calificacionesPendientes > 5)
            {
                MessageBox.Show("Debe calificar antes de seguir comprando");
            }
            else
            {
                this.ShowDialog();
            }
        }

        private bool validar()
        {

            return (!(commons.algunoVacio(textBoxRubro) ));

        }

        private void buttonBuscarPublicacion_Click(object sender, EventArgs e)
        {
            //Si pasa la validación, es decir si el campo rubro no está vacios
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
                this.publicacionesTableAdapter.getParaComprar(
                    UserID,
                    textBoxDescripcion.Text,
                    Convert.ToInt32(textBoxRubro.Tag),
                    commons.getDate(),
                    offset,LIMITE,ref TotalRegistros);

            QtyRegistros = (int)TotalRegistros;
        }

        private void dataGridViewPublicaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                if (e.ColumnIndex == Preguntar.Index)//Si quiero hacer una pregunta
                {
                    //Cargo en una fila (DataGridViewRow) el registro deseado
                    DataGridViewRow fila = dataGridViewPublicaciones.Rows[e.RowIndex];
                    //Si la publicación acepta preguntas
                    if (Convert.ToBoolean(fila.Cells[Permite_Preguntas.Index].Value))
                    {
                        //Creo un formulario de nueva pregunta y le mando el ID de Usuario y Codigo de la Publicación
                        Nueva_Pregunta frame = new Nueva_Pregunta();
                        frame.abrir(UserID, Convert.ToInt32(fila.Cells[Codigo.Index].Value));
                    }
                    else
                    {
                        MessageBox.Show("La publicacion no permite preguntas");
                    }
                }else if (e.ColumnIndex == Comprar.Index)//si quiero hacer una compra
                {
                    int calificacionesPendientes = Convert.ToInt32(tl_UsuariosTableAdapter.getCalificacionesPendientes(UserID));
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
                                Convert.ToInt32(fila.Cells[Codigo.Index].Value),
                                Convert.ToDecimal(fila.Cells[Precio.Index].Value));
                        }
                        else //Compra Inmediata
                        {
                            if (fila.Cells[Estado.Index].Value.ToString().Equals("Pausada"))
                            {
                                MessageBox.Show("No puede comprar porque la publicacion esta pausada");
                            }
                            else
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

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxDescripcion.Clear();
            textBoxRubro.Clear();
            textBoxRubro.Tag = 0;
            llenarPublicaciones();
        }

        private void btnSeleccionarRubro_Click(object sender, EventArgs e)
        {
            SeleccionarRubro frame = new SeleccionarRubro();
            if (frame.seleccionar())
            {
                textBoxRubro.Text = frame.rubroDescripcion;
                textBoxRubro.Tag = frame.rubroID;
            }
        }

        private void Comprar_Ofertar_Load(object sender, EventArgs e)
        {
            cmbCantidadRegistros.SelectedIndex = 0;
        }

        private void cmbCantidadRegistros_SelectedIndexChanged(object sender, EventArgs e)
        {
            LIMITE = Convert.ToInt32(cmbCantidadRegistros.Text);
        }
    }
}
