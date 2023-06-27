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
            DgvTabla.DataSource = Tesla.ListaTeslas();
        }

        // Eventos de los Radial Button que modifican qué lista se carga en el Data grid View
        private void RbTesla_CheckedChanged(object sender, EventArgs e)
        {
            DgvTabla.DataSource = null;
            DgvTabla.Rows.Clear();
            DgvTabla.DataSource = Tesla.ListaTeslas();
        }

        private void RbSpaceX_CheckedChanged(object sender, EventArgs e)
        {
            DgvTabla.DataSource = null;
            DgvTabla.Rows.Clear();
            DgvTabla.DataSource = SpaceX.ListaSpaceX();
        }

        // Evento del botón Actualizar
        // Primero revisa el estado de los Radio Button, ya que en base a lo seleccionado es la lista a la que se va a acceder
        // Luego revisa que dicha lista no esté vacía, y si lo está devuelve un mensaje de error
        // Si la lista no está vacía entonces consulta si hay algo escrito en TbDuenio (Textbox "Nombre de dueño")
        // Si hay texto entonces devuelve una lista filtrada basandose en el Dueño, si no hay texto, devuelve la lista completa de Teslas o SpaceX
        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            bool listaTesla = RbTesla.Checked;
            bool listaSpaceX = RbSpaceX.Checked;

            if (listaTesla)
            {
                if (Tesla.ListaTeslas().Count == 0)
                {
                    MessageBox.Show("La lista de vehículos está vacía.", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    if (TbDuenio.Text != "")
                    {
                        List<Tesla> nuevaLista = new List<Tesla>();

                        foreach (Tesla t in Tesla.ListaTeslas())
                        {
                            if (t.Duenio.Nombre.ToString() == TbDuenio.Text)
                            {
                                nuevaLista.Add(t);
                            }
                        }
                        DgvTabla.DataSource = nuevaLista;
                    }
                    else
                    {
                        DgvTabla.DataSource = null;
                        DgvTabla.Rows.Clear();
                        DgvTabla.DataSource = Tesla.ListaTeslas();
                    }
                }
            }

            else if (listaSpaceX)
            {
                if (SpaceX.ListaSpaceX().Count == 0)
                {
                    MessageBox.Show("La lista de vehículos está vacía.", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    if (TbDuenio.Text != "")
                    {
                        List<SpaceX> nuevaLista = new List<SpaceX>();

                        foreach (SpaceX s in SpaceX.ListaSpaceX())
                        {
                            if (s.Duenio.Nombre.ToString() == TbDuenio.Text)
                            {
                                nuevaLista.Add(s);
                            }
                        }
                        DgvTabla.DataSource = nuevaLista;
                    }
                    else
                    {
                        
                        DgvTabla.DataSource = null;
                        DgvTabla.Rows.Clear();
                        DgvTabla.DataSource = SpaceX.ListaSpaceX();
                    }
                }
            }
        }

        // Evento al hacer click sobre un botón en la columna eliminar
        // Comienza revisando el estado de los checkbox
        // Luego revisa si el índice es mayor o igual a 0 para evitar errores
        // --> Cabe destacar que si el índice no cumple esta condición, el botón Eliminar no genera error pero tampoco hace nada
        // --> Esto se hizo de esta forma para evitar futuras complicaciones
        // Finalmente se elimina el vehículo ubicado en la misma fila del botón seleccionado
        // --> Se elimina tanto de su lista como de la lista general Producto.ListaProductos()
        private void DgvTabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (RbTesla.Checked)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = DgvTabla.Rows[e.RowIndex];
                    Tesla tesla = (Tesla)row.DataBoundItem;
                    Producto producto = (Producto)row.DataBoundItem;
                    Tesla.RemoveTesla(tesla);
                    Producto.RemoveProducto(producto);
                    DgvTabla.DataSource = null;
                    DgvTabla.Rows.Clear();
                    DgvTabla.DataSource = Tesla.ListaTeslas();
                }
            }
            else if (RbSpaceX.Checked)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = DgvTabla.Rows[e.RowIndex];
                    SpaceX spaceX = (SpaceX)row.DataBoundItem;
                    Producto producto = (Producto)row.DataBoundItem;
                    SpaceX.RemoveSpaceX(spaceX);
                    Producto.RemoveProducto(producto);
                    DgvTabla.DataSource = null;
                    DgvTabla.Rows.Clear();
                    DgvTabla.DataSource = SpaceX.ListaSpaceX();
                }
            }
        }
    }
}
