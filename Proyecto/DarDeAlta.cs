﻿using Proyecto_2_Tema_2.Entidades.Duenios;
using Proyecto_2_Tema_2.Entidades.Duenios.TiposDePersonas;
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
    public partial class DarDeAlta : Form
    {
        public DarDeAlta()
        {
            InitializeComponent();
        }

        private void cmbTipoVehiculo_Validating(object sender, CancelEventArgs e)
        {
            ComboBox modelo = (ComboBox)sender;

            // Obtener el índice seleccionado del combobox
            int indiceSeleccionado = modelo.SelectedIndex;

            // Validar si el índice seleccionado es 0 (la primera opción vacía)
            if (indiceSeleccionado == 0)
            {
                errorProviderCmbTipo.SetError(modelo, "Debe seleccionar una opción válida");

                // Se limpian datos y se ocultan campos para evitar errores.
                lblModelo.Visible = false;
                cmbModeloTesla.Visible = false;
                cmbModeloTesla.SelectedIndex = 0;
                cmbModeloSpaceX.Visible = false;
                cmbModeloSpaceX.SelectedIndex = 0;

                e.Cancel = true; // Cancelar el evento Validating para evitar que se pierda el foco

            }
            else
            {
                errorProviderCmbTipo.SetError(modelo, null); // Limpiar el mensaje de error
            }
        }

        private void cmbTipoVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cada vez que el usuario interactua con cmbTipoVehiculo se limpian las opciones que puedan generar inconsistencias al momento de llamar al constructor
            cmbModeloTesla.Visible = false;
            cmbModeloSpaceX.Visible = false;
            lblModelo.Visible=false;
            cmbModeloSpaceX.SelectedIndex = 0;
            cmbModeloTesla.SelectedIndex = 0;
            rbtnClienteNuevo.Visible = false;
            rbtnClienteExistente.Visible = false;
            rbtnClienteNuevo.Checked = false;
            rbtnClienteExistente.Checked = false;
            grpDatosVehiculo.Visible = false;
            cmbDuenioTesla.Visible=false;
            cmbDuenioTesla.DataSource = null;
            cmbDuenioTesla.Items.Clear();
            cmbDuenioSpaceX.DataSource = null;
            cmbDuenioSpaceX.Visible=false;
            ComboBox modelo = (ComboBox)sender;

            // Obtener el índice seleccionado
            int indiceSeleccionado = modelo.SelectedIndex;

            // En funcion del indice seleccionado, se muestran las opciones de dueño disponible
            if (modelo.SelectedIndex == 1)
            {
                lblModelo.Visible = true;
                cmbModeloTesla.Visible = true;
                cmbModeloSpaceX.Visible = false;
                cmbModeloSpaceX.SelectedIndex = 0;
                lblID.Text = "CUIL";
                
                
                // grpDatosVehiculo.Visible = true;

            }
            else if (modelo.SelectedIndex == 2)
            {
                lblModelo.Visible = true;
                cmbModeloSpaceX.Visible = true;
                cmbModeloTesla.Visible = false;
                cmbModeloTesla.SelectedIndex = 0;
                lblID.Text = "CUIT";

                //grpDatosVehiculo.Visible = true;
            }
        }
        private void cmbModeloTesla_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbModeloTesla.SelectedIndex != 0)
            {
                rbtnClienteNuevo.Visible = true;
                rbtnClienteExistente.Visible = true;
            }
            else
            {
                rbtnClienteNuevo.Visible = false;
                rbtnClienteExistente.Visible = false;
                rbtnClienteNuevo.Checked = false;
                rbtnClienteExistente.Checked = false;
            }
        }
        private void cmbModeloSpaceX_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbModeloSpaceX.SelectedIndex != 0)
            {
                rbtnClienteNuevo.Visible = true;
                rbtnClienteExistente.Visible = true;
            }
            else
            {
                rbtnClienteNuevo.Visible = false;
                rbtnClienteExistente.Visible = false;
                rbtnClienteNuevo.Checked = false;
                rbtnClienteExistente.Checked = false;
            }
        }
        private void rbtnClienteNuevo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnClienteNuevo.Checked == true)
            {
                grpNuevoCliente.Visible = true;
            }
            else
            {
                grpNuevoCliente.Visible = false;
                txtNombre.Text = string.Empty;
                numericId.Value = 0;

            }
        }

        private void btnCrearPersona_Click(object sender, EventArgs e)
        {
            
            // Se toman datos necesarios para crear la persona
            int idPersona = (int)numericId.Value;
            string nombrePersona = txtNombre.Text.Trim();

            if (cmbTipoVehiculo.SelectedIndex == 1)
            {
                if (PersonaFisica.VerificarIdUnico(idPersona))
                {
                    // El ID es único, se puede instanciar PersonaFisica
                    PersonaFisica persona = new PersonaFisica(nombrePersona, idPersona);

                    // Se muestra los datos para corroboran se haya creado exitosamente
                    MessageBox.Show(persona.ToString(), "Nuevo cliente creado", MessageBoxButtons.OK);
                    grpModelo.Visible = true;

                    // Obtén la lista de personas físicas
                    List<PersonaFisica> personasFisicas = PersonaFisica.ListaPersonasFisicas();

                    //Establece la fuente de datos del ComboBox cmbDuenio

                    cmbDuenioTesla.DataSource = personasFisicas;
                    cmbDuenioTesla.DisplayMember = "Nombre"; // Mostrar el nombre en el ComboBox
                    cmbDuenioTesla.ValueMember = "Id"; // Utilizar el ID como valor seleccionado

                    // Para mostrar ambos atributos en cada fila del ComboBox
                    // sepersonalizo el formato de visualización utilizando el evento Format
                    cmbDuenioTesla.Format += (s, args) =>
                    {
                        PersonaFisica personaFisicaLista = (PersonaFisica)args.ListItem;
                        args.Value = $"CUIL: {personaFisicaLista.Id} - Nombre: {personaFisicaLista.Nombre}";
                    };
                    grpDatosVehiculo.Visible = true;
                    cmbDuenioTesla.Visible  = true;
                    cmbDuenioSpaceX.Visible = false;
                }
                else
                {
                    // El ID no es único, se muestra un mensaje de error al usuario
                    MessageBox.Show("El CUIL ya existe. Debe ser único.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    grpDatosVehiculo.Visible = false;
                }
            }
            else if (cmbTipoVehiculo.SelectedIndex == 2)
            {
                if (PersonaJuridica.VerificarIdUnico(idPersona))
                {
                    // El ID es único, se puede instanciar PersonaFisica
                    PersonaJuridica persona = new PersonaJuridica(nombrePersona, idPersona);

                    // Se muestra los datos para corroboran se haya creado exitosamente
                    MessageBox.Show(persona.ToString(), "Nuevo cliente creado", MessageBoxButtons.OK);
                    grpModelo.Visible = true;
                    // Obtén la lista de personas físicas
                    List<PersonaJuridica> personasJuridicas = PersonaJuridica.ListaPersonasJuridicas();

                    //Establece la fuente de datos del ComboBox cmbDuenio

                    cmbDuenioSpaceX.DataSource = personasJuridicas;
                    cmbDuenioSpaceX.DisplayMember = "Nombre"; // Mostrar el nombre en el ComboBox
                    cmbDuenioSpaceX.ValueMember = "Id"; // Utilizar el ID como valor seleccionado

                    // Para mostrar ambos atributos en cada fila del ComboBox
                    // sepersonalizo el formato de visualización utilizando el evento Format
                    cmbDuenioSpaceX.Format += (s, args) =>
                    {
                        PersonaJuridica personaJuridicaLista = (PersonaJuridica)args.ListItem;
                        args.Value = $"CUIT: {personaJuridicaLista.Id} - Nombre: {personaJuridicaLista.Nombre}";
                    };
                    grpDatosVehiculo.Visible = true;
                    cmbDuenioSpaceX.Visible  = true;
                    cmbDuenioTesla.Visible = false;
                }
                else
                {
                    // El ID no es único, se muestra un mensaje de error al usuario
                    MessageBox.Show("El CUIT ya existe. Debe ser único.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    grpDatosVehiculo.Visible = false;
                }
            }


        }

        private void rbtnClienteExistente_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnClienteExistente.Checked == true && cmbTipoVehiculo.SelectedIndex == 1)
            {
                
                // Obtén la lista de personas físicas
                List<PersonaFisica> personasFisicas = PersonaFisica.ListaPersonasFisicas();

                if (personasFisicas.Count != 0)
                {
                    //Establece la fuente de datos del ComboBox cmbDuenio

                    cmbDuenioTesla.DataSource = personasFisicas;
                    cmbDuenioTesla.DisplayMember = "Nombre"; // Mostrar el nombre en el ComboBox
                    cmbDuenioTesla.ValueMember = "Id"; // Utilizar el ID como valor seleccionado

                    // Para mostrar ambos atributos en cada fila del ComboBox
                    // sepersonalizo el formato de visualización utilizando el evento Format
                    cmbDuenioTesla.Format += (s, args) =>
                    {
                        PersonaFisica personaFisicaLista = (PersonaFisica)args.ListItem;
                        args.Value = $"CUIL: {personaFisicaLista.Id} - Nombre: {personaFisicaLista.Nombre}";
                    };
                    grpDatosVehiculo.Visible = true;
                    cmbDuenioTesla.Visible  = true;
                    cmbDuenioSpaceX.Visible = false;
                }
                else
                {
                    MessageBox.Show("Debes crear al menos un cliente primero.", "Lista de clientes vacía", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                    
            }
            else if (rbtnClienteExistente.Checked == true && cmbTipoVehiculo.SelectedIndex == 2)
            {

                // Obtén la lista de personas físicas
                List<PersonaJuridica> personasJuridicas = PersonaJuridica.ListaPersonasJuridicas();
                if (personasJuridicas.Count != 0)
                {
                    //Establece la fuente de datos del ComboBox cmbDuenio

                    cmbDuenioSpaceX.DataSource = personasJuridicas;
                    cmbDuenioSpaceX.DisplayMember = "Nombre"; // Mostrar el nombre en el ComboBox
                    cmbDuenioSpaceX.ValueMember = "Id"; // Utilizar el ID como valor seleccionado

                    // Para mostrar ambos atributos en cada fila del ComboBox
                    // sepersonalizo el formato de visualización utilizando el evento Format
                    cmbDuenioSpaceX.Format += (s, args) =>
                    {
                        PersonaJuridica personaJuridicaLista = (PersonaJuridica)args.ListItem;
                        args.Value = $"CUIT: {personaJuridicaLista.Id} - Nombre: {personaJuridicaLista.Nombre}";
                    };
                    grpDatosVehiculo.Visible = true;
                    cmbDuenioSpaceX.Visible  = true;
                    cmbDuenioTesla.Visible = false;
                }
                else
                {
                    MessageBox.Show("Debes crear al menos un cliente primero", "Lista de clientes vacía", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
              
        
        }

        private void cmbColorTesla_Validating(object sender, CancelEventArgs e)
        {
            ComboBox color = (ComboBox)sender;

            // Obtener el índice seleccionado
            int indiceSeleccionado = color.SelectedIndex;

            // Validar si el índice seleccionado es 0 (la primera opción vacía)
            if (indiceSeleccionado == 0)
            {
                errorProviderCmbColorTesla.SetError(color, "Debe seleccionar un color válido");               
                //e.Cancel = true; // Cancelar el evento Validating para evitar que se pierda el foco


            }
            else
            {
                errorProviderCmbColorTesla.SetError(color, null); // Limpiar el mensaje de error

            }
        }

        

        private void btnAltaTesla_Click(object sender, EventArgs e)
        {
            int anio;
            double kilometrajeActual;
            string color;
            double autonomiaActual;
            int cargas;
            PersonaFisica duenioTesla;
            PersonaJuridica duenioSpaceX;

            switch (cmbTipoVehiculo.SelectedItem)
            {

                case "Tesla":
                    switch (cmbModeloTesla.SelectedItem)
                    {

                        case "ModeloX":

                            anio = (int)numericAnio.Value;
                            kilometrajeActual = (double)numericKilometrajeActual.Value;
                            color = (string)cmbColorTesla.Text;
                            autonomiaActual = (double)numericAutonomiaActual.Value;
                            cargas = (int)numericCargasRealizadas.Value;
                            duenioTesla = (PersonaFisica)cmbDuenioTesla.SelectedItem;

                            ModeloX nuevoTesla = new ModeloX(anio, kilometrajeActual, color, autonomiaActual, cargas, duenioTesla);
                            MessageBox.Show("Exito!", "Nuevo cliente creado", MessageBoxButtons.OK);

                            break;

                        case "ModeloS":
                            


                            break;

                        //Continuar con swich del resto de modelos de Tesla

                        case "ModeloY":


                            break;




                    }

                    ///

                    break;
                case "SpaceX":
                    break;
                    //Continuar con resto de modelos spacex
            }
        }

       
    }
}