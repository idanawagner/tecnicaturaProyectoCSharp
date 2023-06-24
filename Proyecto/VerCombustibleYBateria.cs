using Proyecto_2_Tema_2.Entidades.ProductosMusk;
using Proyecto_2_Tema_2.Entidades.ProductosMusk.Teslas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_2_Tema_2
{
    public partial class VerCombustibleYBateria : Form
    {
        public VerCombustibleYBateria()
        {
            InitializeComponent();
        }

        // Evento que carga los datos al data grid view
        private void VerCombustibleYBateria_Load(object sender, EventArgs e)
        {
            DgvTabla.DataSource = Producto.ListaProductos();
        }


        // Evento del botón actualizar, se muestra una lista modificada en base a los CheckBox seleccionados
        private void BActualizar_Click(object sender, EventArgs e)
        {
            if (CbCombustible.Checked & CbBateria.Checked)
            {
                DgvTabla.DataSource = null;
                DgvTabla.DataSource = Producto.ListaProductos();
            }
            else if (CbBateria.Checked && !CbCombustible.Checked)
            {
                DgvTabla.DataSource = null;
                DgvTabla.DataSource = Tesla.ListaTeslas();
            }
            else if (CbCombustible.Checked && !CbBateria.Checked)
            {
                DgvTabla.DataSource = null;
                //dataGridView1.DataSource = SpaceX.ListaSpaceX
            }
            else if (!CbBateria.Checked & !CbCombustible.Checked)
            {
                DgvTabla.DataSource = null;
                DgvTabla.DataSource = Producto.ListaProductos();
            }
        }

    }
}
