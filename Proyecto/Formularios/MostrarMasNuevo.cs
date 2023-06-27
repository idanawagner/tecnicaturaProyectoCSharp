using Proyecto_2_Tema_2.Entidades.ProductosMusk.Teslas;
using Proyecto_2_Tema_2.Entidades.ProductosMusk.Teslas.Modelos;
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
            // Se creo una variable con los datos de la lista de Teslas
            var teslasOrdenados = Tesla.ListaTeslas()
                .OrderByDescending(t => t.Anio)  // Se ordena por año de forma descendente
                .ThenByDescending(t => t.Id);   //  Se ordenan a su vez los mas nuevos por Id de forma descendente


            if (teslasOrdenados.ToList().Count > 0) // Comprueba que la lista no esta vacia

            {
                Tesla teslaMasNuevo = teslasOrdenados.First(); // Obtiene el primer elemento de la lista

                // Se muestra el nombre del modelo dependiendo de si tesla mas nuevo es una instancia de ModeloS, ModeloX o Cybertruck, 
                if(teslaMasNuevo is ModeloX)
                {
                    lblModelo.Text = "ModeloX";
                } else if ( teslaMasNuevo is ModeloS)
                {
                    lblModelo.Text = "ModeloS";
                } else if (teslaMasNuevo is Cybertruck)
                {
                    lblModelo.Text = "Cybertruck";
                }

                //Se cargan el resto de los datos en los labels

                lblAnio.Text = teslaMasNuevo.Anio.ToString(); 
                lblColor.Text = teslaMasNuevo.Color.ToString();
                lblKilometraje.Text = teslaMasNuevo.UsoActual.ToString();
                lblDuenioNombre.Text = teslaMasNuevo.Duenio.Nombre.ToString();
                lblDuenioId.Text = teslaMasNuevo.Duenio.Id.ToString();
                lblCargas.Text = teslaMasNuevo.Cargas.ToString();
                lblUsoActual.Text = teslaMasNuevo.UsoActual.ToString();
                lblAutonomiaActual.Text = teslaMasNuevo.AutonomiaActual.ToString();
            }
            else // Si la lista esta vacia, muestra un mensaje
            {
                MessageBox.Show("El listado de Teslas esta vacio");
            }
        }
    }
}
