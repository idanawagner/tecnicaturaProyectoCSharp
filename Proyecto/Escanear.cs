using Proyecto_2_Tema_2.Entidades.ProductosMusk.SpaceX;
using Proyecto_2_Tema_2.Entidades.ProductosMusk.SpaceX.Modelos;
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
    public partial class Escanear : Form
    {
        public Escanear()
        {
            InitializeComponent();
        }

        private void cmbTipoDeVehiculo_Validating(object sender, CancelEventArgs e)
        {
            ComboBox modelo = (ComboBox)sender;

            // Obtener el índice seleccionado del combobox
            int indiceSeleccionado = modelo.SelectedIndex;

            // Validar si el índice seleccionado es 0 (la primera opción vacía)
            if (indiceSeleccionado == 0)
            {
                errorProviderCmbTipo.SetError(modelo, "Debe seleccionar una opción válida");
                panelVehiculo.Visible = false;
                
                
                e.Cancel = true; // Cancelar el evento Validating para evitar que se pierda el foco

            }
            else
            {
                errorProviderCmbTipo.SetError(modelo, null); // Limpiar el mensaje de error
                panelVehiculo.Visible = true;
            }
        }

        private void cmbTipoDeVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cada vez que el usuario interactua con cmbTipoVehiculo se limpian las opciones que puedan generar inconsistencias al momento de llamar al metodo de escaneo
            
            cmbTeslas.DataSource = null;
            cmbTeslas.Items.Clear();
            cmbSpaceX.DataSource = null;
            cmbSpaceX.Items.Clear();
            panelVehiculo.Visible = false;


            ComboBox modelo = (ComboBox)sender;

            // Obtener el índice seleccionado
            int indiceSeleccionado = modelo.SelectedIndex;

            // En funcion del indice seleccionado, se muestran los vehiculos disponibles

            
            if (modelo.SelectedIndex == 1)
            {
                panelVehiculo.Visible= true;
                cmbTeslas.Visible = true;
                cmbSpaceX.Visible=false;
                List<Tesla> listaTeslas =Tesla.ListaTeslas();
                cmbTeslas.DataSource = listaTeslas;



            }
            else if (modelo.SelectedIndex == 2)
            {
                panelVehiculo.Visible= true;
                cmbSpaceX.Visible = true;
                cmbTeslas.Visible = false;
                List<SpaceX> listaSpacex = SpaceX.ListaSpaceX();
                cmbSpaceX.DataSource = listaSpacex;

                
            }
        }

        private void btnEscanear_Click(object sender, EventArgs e)
        {
            if(cmbTipoDeVehiculo.SelectedIndex == 1)
            {
                object TeslaSeleccionado = cmbTeslas.SelectedItem;
                
                if (TeslaSeleccionado is ModeloX modeloXSeleccionado)
                {
                    string resultadoEscaneo = modeloXSeleccionado.RealizarService();
                    txtResultadoEscaneo.Text = resultadoEscaneo;
                }
                else if (TeslaSeleccionado is ModeloS modeloSSeleccionado)
                {
                    string resultadoEscaneo = modeloSSeleccionado.RealizarService();
                    txtResultadoEscaneo.Text = resultadoEscaneo;
                }
                else if (TeslaSeleccionado is Cybertruck CybertruckSeleccionado)
                {
                    string resultadoEscaneo = CybertruckSeleccionado.RealizarService();
                    txtResultadoEscaneo.Text = resultadoEscaneo;
                }
            }
            else if (cmbTipoDeVehiculo.SelectedIndex == 2)
            {
                object SpaceXSeleccionado = cmbSpaceX.SelectedItem;

                if (SpaceXSeleccionado is Starship starshipSeleccionado)
                {
                    string resultadoEscaneo = starshipSeleccionado.RealizarService();
                    txtResultadoEscaneo.Text = resultadoEscaneo;
                }
                else if (SpaceXSeleccionado is Falcon9 falcon9Seleccionado)
                {
                    string resultadoEscaneo = falcon9Seleccionado.RealizarService();
                    txtResultadoEscaneo.Text = resultadoEscaneo;
                }
            }
        }
    }
}
