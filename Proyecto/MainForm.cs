using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Proyecto_2_Tema_2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void AbrirformHija(object formhija)
        {
            if (this.PanelCentral.Controls.Count > 0)
            {
                this.PanelCentral.Controls.RemoveAt(0);
            }
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelCentral.Controls.Add(fh);
            this.PanelCentral.Tag = fh;
            fh.Show();
        }

        // Configuración para poder mover la ventana del MainForm en la pantalla
        [DllImport("User32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("User32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int Iparam);

        // Evento que acciona el movimiento de la pantalla
        private void PanelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // Evento del botón Dar de Alta (abre el formulario "Alta")
        private void BtnDarAlta_Click(object sender, EventArgs e)
        {
            AbrirformHija(new DarDeAlta());
        }

        // Evento del botón Eliminar (abre el formulario "Eliminar")
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            AbrirformHija(new Eliminar());
        }

        // Evento del botón Mostrar Tesla (abre el formulario "MostrarMasNuevo")
        private void BtnMasNuevo_Click(object sender, EventArgs e)
        {
            AbrirformHija(new MostrarMasNuevo());
        }

        // Evento del botón Escanear un Vehículo (abre el formulario "Escanear")
        private void BtnEscanear_Click(object sender, EventArgs e)
        {
            AbrirformHija(new Escanear());
        }

        // Evento del botón Ver Combustible (abre el formulario "VerCombustibleYBateria")
        private void BtnCombustible_Click(object sender, EventArgs e)
        {
            AbrirformHija(new VerCombustibleYBateria());
        }

        // Evento del picture box cerrar
        private void PbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Evento del picture box maximizar
        private void PbMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            PbMaximizar.Visible = false;
            PbRestaurar.Visible = true;
        }

        // Evento del picture box restaurar
        private void PbRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            PbRestaurar.Visible = false;
            PbMaximizar.Visible = true;
        }

        // Evento del picture box minimizar
        private void PbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
