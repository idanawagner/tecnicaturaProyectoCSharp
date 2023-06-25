using Proyecto_2_Tema_2.Entidades.ProductosMusk;
using Proyecto_2_Tema_2.Entidades.ProductosMusk.SpaceX;
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
        // Cada vez que se hace click en "Actualizar" el programa hace lo siguiente:
        // 1. Comprueba el estado de los chechbox
        // 2. Entra en el condicional que corresponde a dicho caso
        // 3. Vacia los datos de la tabla
        // 4. Carga los nuevos datos de la lista que corresponde al caso
        // 5. Finalmente crea las columnas ID, Año, Autonomía y Cargas Administradas y las vincula a los datos correspondientes.
        private void BActualizar_Click(object sender, EventArgs e)
        {

            bool mostrarTeslas = CbBateria.Checked;
            bool mostrarSpaceX = CbCombustible.Checked;

            if (mostrarTeslas && mostrarSpaceX)
            {
                DgvTabla.DataSource = null;
                DgvTabla.DataSource = Producto.ListaProductos();
            }
            else if (mostrarTeslas)
            {
                DgvTabla.DataSource = null;
                DgvTabla.DataSource = Tesla.ListaTeslas();
            }
            else if (mostrarSpaceX)
            {
                DgvTabla.DataSource = null;
                DgvTabla.DataSource = SpaceX.ListaSpaceX();
            }
            else if (!mostrarTeslas && !mostrarSpaceX)
            {
                DgvTabla.DataSource = null;
                DgvTabla.DataSource = Producto.ListaProductos();
            }

            //DataGridViewTextBoxColumn columnaId = new DataGridViewTextBoxColumn();
            //columnaId.HeaderText = "ID";
            //columnaId.DataPropertyName = "Id";

            //DataGridViewTextBoxColumn columnaAnio = new DataGridViewTextBoxColumn();
            //columnaAnio.HeaderText = "Año";
            //columnaAnio.DataPropertyName = "Anio";

            //DataGridViewTextBoxColumn columnaAutonomia = new DataGridViewTextBoxColumn();
            //columnaAutonomia.HeaderText = "Autonomia";
            //columnaAutonomia.DataPropertyName = "Autonomia";

            //DataGridViewTextBoxColumn columnaCargas = new DataGridViewTextBoxColumn();
            //columnaCargas.HeaderText = "Cargas administradas";
            //columnaCargas.DataPropertyName = "Cargas";

            //DgvTabla.Columns.Add(columnaId);
            //DgvTabla.Columns.Add(columnaAnio);
            //DgvTabla.Columns.Add(columnaAutonomia);
            //DgvTabla.Columns.Add(columnaCargas);

        }
    }
}
