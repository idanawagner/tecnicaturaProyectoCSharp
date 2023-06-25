using Proyecto_2_Tema_2.Entidades.Duenios.TiposDePersonas;
using Proyecto_2_Tema_2.Entidades.ProductosMusk;
using Proyecto_2_Tema_2.Entidades.ProductosMusk.SpaceX;
using Proyecto_2_Tema_2.Entidades.ProductosMusk.Teslas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_2_Tema_2
{
    public partial class Eliminar : Form
    {
        public Eliminar()
        {
            InitializeComponent();
        }

        // Cargamos los datos en el Data grid view
        private void Eliminar_Load(object sender, EventArgs e)
        {
            DgvTabla.DataSource = Producto.ListaProductos();
        }

        // Eventos que bloquean los ComboBox "Modelo" en base al RadioButton seleccionado
        private void RbTesla_CheckedChanged(object sender, EventArgs e)
        {
            CbTesla.Visible = true;
            CbSpaceX.Visible = false;
            DgvTabla.DataSource = Tesla.ListaTeslas();
        }

        private void RbSpaceX_CheckedChanged(object sender, EventArgs e)
        {
            CbSpaceX.Visible = true;
            CbTesla.Visible = false;
            DgvTabla.DataSource = SpaceX.ListaSpaceX();                                 // <-------------------------------- Agregar lista SpaceX
        }

        // Evento del botón Actualizar
        // Revisa si la lista de vehículos está vacía: si lo está devuelve error
        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (RbTesla.Checked)
            {
                if (Tesla.ListaTeslas().Count == 0)
                {
                    MessageBox.Show("La lista de clientes está vacía.", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    DgvTabla.DataSource = Tesla.ListaTeslas();
                }
            }
            else if (RbSpaceX.Checked)
            {
                if (SpaceX.ListaSpaceX().Count == 0)
                {
                    MessageBox.Show("La lista de clientes está vacía.", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    DgvTabla.DataSource = SpaceX.ListaSpaceX();
                }
            }
        }

        // Evento al clickear un botón de la columna eliminar
        // Elimina el elemento de la lista de teslas.
        private void DgvTabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                
                DataGridViewRow row = DgvTabla.Rows[e.RowIndex];

                try
                {
                    Tesla tesla = (Tesla)row.DataBoundItem;
                    Tesla.RemoveTesla(tesla);
                    Producto.RemoveProducto(tesla);

                }

                catch 
                {
                    SpaceX spacex = (SpaceX)row.DataBoundItem;
                    SpaceX.RemoveSpaceX(spacex);

                }


                //Tesla tesla = (Tesla)row.DataBoundItem;
                //SpaceX spacex = (SpaceX)row.DataBoundItem;
                //Producto producto = (Producto)row.DataBoundItem;
                //Tesla.RemoveTesla(tesla);
                //Producto.RemoveProducto(producto);
                //SpaceX.RemoveSpaceX(spacex);
                //DgvTabla.DataSource = null;
                //DgvTabla.DataSource = Tesla.ListaTeslas();
            }
        }
    }
}
