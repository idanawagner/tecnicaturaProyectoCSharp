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
    public partial class MostrarMasNuevo : Form
    {
        public MostrarMasNuevo()
        {
            InitializeComponent();
        }

        private void MostrarMasNuevo_Load(object sender, EventArgs e)
        {
            var teslasOrdenados = Tesla.ListaTeslas()
                .OrderByDescending(t => t.Anio)
                .ThenByDescending(t => t.Id);


            if (teslasOrdenados.ToList().Count > 0)

            {
                Tesla teslaMasNuevo = teslasOrdenados.First();


                // Mostrar cada atributo en los TextBoxes correspondientes
                lblModelo.Text = "ModeloX";
                lblAnio.Text = teslaMasNuevo.Anio.ToString();
                lblColor.Text = teslaMasNuevo.Color.ToString();
                lblKilometraje.Text = teslaMasNuevo.UsoActual.ToString();
                lblDuenioNombre.Text = teslaMasNuevo.Duenio.Nombre.ToString();
                lblDuenioId.Text = teslaMasNuevo.Duenio.Id.ToString();
                lblCargas.Text = teslaMasNuevo.Cargas.ToString();
                lblUsoActual.Text = teslaMasNuevo.UsoActual.ToString();
                lblAutonomiaActual.Text = teslaMasNuevo.AutonomiaActual.ToString();
            }
            else
            {
                MessageBox.Show("El listado de Teslas esta vacio");
            }
        }
    }
}
