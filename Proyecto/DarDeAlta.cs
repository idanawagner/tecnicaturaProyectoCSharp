using Proyecto_2_Tema_2.Entidades.Duenios;
using Proyecto_2_Tema_2.Entidades.Duenios.TiposDePersonas;
using Proyecto_2_Tema_2.Entidades.ProductosMusk.SpaceX.Modelos;
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
    /// <summary>
    /// El WindowsForm DarDeAlta es el formulario desde donde se hará la carga de datos de los productos del sr. Elon Musk. Este formulario prentede ir llevando al usuario en una carga paso a paso que impida el alta de vehiculos cuyos datos sean incorrectos o insuficientes. Para ello, se desarrollo de manera en que los requerimiento se van a ir mostrando de a poco y en orden, a medida que vayan siendo necesarios de acuerdo a la informacion que vaya aportando el usuario.
    /// 
    /// Al finalizar el aporte de informacion el usuario podra dar de alta el producto deseado, ya sea una Tesla o un Sapcex en cualquiera de sus modelos disponibles.
    /// 
    /// A grandes rasgos, se identifican tres grupos de datos relavantes: los relacionados al tipo de producto, los relacionados al cliente, y los relacionados al estado actual del vehiculo.
    /// 
    /// Se explica la funcion de cada uno de los eventos implementados en este formulario.
    /// 
    /// </summary>
    public partial class DarDeAlta : Form
    {
        // Evento que inicia el formulario.
        public DarDeAlta()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Este metodo limpia y cambia la visibilidad de todos aquellos campos que puedan llegar a dar error frente a un cambio en la decision del usuario con respecto a que tipo de producto desea dar de alta. Complmentariamente, de acuerdo a lo elegido le habilita nuevos campos para continuar con el proceso de carga.
        /// </summary>
        private void cmbTipoVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cada vez que el usuario interactua con cmbTipoVehiculo se limpian las opciones que puedan generar inconsistencias al momento de llamar al constructor de una clase
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
            cmbColor.SelectedIndex = 0;
            chk0km.Checked = true;
            numericAnio.Value = 2023;
            numericUsoActual.Value = 0;
            numericAutonomiaActual.Value = 0;
            numericCargasRealizadas.Value = 0;


            // Se asigna el ComboBox a una variable mediante la conversion explicita del objeto sender.

            ComboBox modelo = (ComboBox)sender;

            // Se obtiene el índice seleccionado por el usuario
            int indiceSeleccionado = modelo.SelectedIndex;

            // En funcion del indice seleccionado, se muestran las opciones de dueño disponible
            if (modelo.SelectedIndex == 1) // La opcion uno equivale a "Tesla"
            {
                lblModelo.Visible = true;
                cmbModeloTesla.Visible = true;
                cmbModeloSpaceX.Visible = false;
                cmbModeloSpaceX.SelectedIndex = 0;

            }
            else if (modelo.SelectedIndex == 2) //La opcion dos equivale a SpaceX
            {
                lblModelo.Visible = true;
                cmbModeloSpaceX.Visible = true;
                cmbModeloTesla.Visible = false;
                cmbModeloTesla.SelectedIndex = 0;
                lblKilometrajeActual.Text = "Horas de vuelo actuales";
       
            }
            //Si el usario eligiera el indice cero (la opcion vacía) la opcion seria invalida de acuerdo al método cmbTipoVehiculo_Validating
        }
        /// <summary>
        /// Este metodo valida la eleccion del usuario con respecto a que tipo de producto quiere dar de alta: Tesla o SpaceX. Al ser el unico comando visible al abrir el formulario, impide que el usario cargue información errorea o incluso pueda enfocarse en otro campo que no sea exclusivamente este. Si en su eleccion, elige la opcion en blanco (que aparece por defecto, el programa le indicará que debe elegir una opcion valida y le mantendra el focus en este comando. Cuando elija correctamente podra continuar trabajando con el resto del formulario.
        /// </summary>
        private void cmbTipoVehiculo_Validating(object sender, CancelEventArgs e)
        {
            // Se asigna el ComboBox a una variable mediante la conversion explicita del objeto sender.
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
        /// <summary>
        /// Al igual que el metodo cmbTipoVehiculo_SelectedIndexChanged limpia valores que podrian generar carga de datos erroneas y luego, en funcion de la opcion elegida por el usuario, habilita los proximos campos a ser completados y setea los valores de autonomia actual maxima. El campo cmbModeloTesla permite elegir el modelo de Tesla a ser creado por lo que para que aparezca el usuario deberá haber seleccionado la opcion de tipo de vehiculo Tesla.
        /// </summary>
        private void cmbModeloTesla_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Seteo de campos que puedan generar errores o mejorar la experiencia de usario reduciendo la cantidad de valores a introducir si el vehiculo es nuevo
            cmbColor.SelectedIndex = 0;
            chk0km.Checked = true;
            numericAnio.Value = 2023;
            numericUsoActual.Value = 0;
            numericAutonomiaActual.Value = 0;
            numericCargasRealizadas.Value = 0;

            if (cmbModeloTesla.SelectedIndex != 0)
            {
                rbtnClienteNuevo.Visible = true;
                rbtnClienteExistente.Visible = true;
                switch (cmbModeloTesla.SelectedIndex)
                {
                    case 1:
                        numericAutonomiaActual.Maximum = 650; // Seteo de autonomia actual maxima segun el modelo elegido
                        break;
                    case 2:
                        numericAutonomiaActual.Maximum = 560; // Seteo de autonomia actual maxima segun el modelo elegido
                        break;
                    case 3:
                        numericAutonomiaActual.Maximum = 800; // Seteo de autonomia actual maxima segun el modelo elegido
                        break;
                }
            }
            else
            {
                // Cambios en la visibilidad y seteo de campos que puedan generar errores.
                rbtnClienteNuevo.Visible = false;
                rbtnClienteExistente.Visible = false;
                rbtnClienteNuevo.Checked = false;
                rbtnClienteExistente.Checked = false;
            }
        }
        /// <summary>
        /// Al igual que el metodo cmbTipoVehiculo_SelectedIndexChanged limpia valores que podrian generar carga de datos erroneas y luego, en funcion de la opcion elegida por el usuario, habilita los proximos campos a ser completados y setea los valores de autonomia actual maxima. El campo cmbModeloSpaceX permite elegir el modelo de SpaceX a ser creado por lo que para que aparezca el usuario deberá haber seleccionado la opcion de tipo de vehiculo SpaceX.
        /// </summary>
        private void cmbModeloSpaceX_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Seteo de campos que puedan generar errores o mejorar la experiencia de usario reduciendo la cantidad de valores a introducir si el vehiculo es nuevo
            cmbColor.SelectedIndex = 0;
            chk0km.Checked = true;
            numericAnio.Value = 2023;
            numericUsoActual.Value = 0;
            numericAutonomiaActual.Value = 0;
            numericCargasRealizadas.Value = 0;

            if (cmbModeloSpaceX.SelectedIndex != 0)
            {
                rbtnClienteNuevo.Visible = true;
                rbtnClienteExistente.Visible = true;
                switch (cmbModeloSpaceX.SelectedIndex)
                {
                    case 1:
                        numericAutonomiaActual.Maximum = 500; // Seteo de autonomia actual maxima segun el modelo elegido
                        break;
                    case 2:
                        numericAutonomiaActual.Maximum = 200; // Seteo de autonomia actual  maxima segun el modelo elegido
                        break;                    
                }
            }
            else
            {
                // Cambios en la visibilidad y seteo de campos que puedan generar errores.
                rbtnClienteNuevo.Visible = false;
                rbtnClienteExistente.Visible = false;
                rbtnClienteNuevo.Checked = false;
                rbtnClienteExistente.Checked = false;
            }
        }
        /// <summary>
        /// Este metodo hace visible la carga de datos de un cliente nuevo si fuera el caso o bien, vacia los campos correspondientes a un cliente nuevo para evitar errores.
        /// </summary>
        private void rbtnClienteNuevo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnClienteNuevo.Checked == true) // Si el boton es chequeado
            {
                grpNuevoCliente.Visible = true; // Se visibiliza el GroupBox con los datos del cliente nuevo a ser creado.
            }
            else // Si el boton no esta chequeado
            {
                grpNuevoCliente.Visible = false; // se invisibiliza el GroupBox con los datos del cliente nuevo a ser creado.
                txtNombre.Text = string.Empty; // Se vacia el campo de texto donde se completa el nombre
                numericId.Value = 0; // Se asigana valor cero al campo Id
            }
        }
        /// <summary>
        /// Este metodo se desencadena cuando se hace click en el boton Crear Cliente. el cual esta disponible si el usuario chequeo el radio button de cliente nuevo. Lo que hace este metodo es crear una persona fisica o juridica segun las elecciones que fue tomando el usuario previamente. En esencia, si va a dar de alta un Tesla o un SpaceX.
        /// </summary>
        private void btnCrearPersona_Click(object sender, EventArgs e)
        {
            
            // Se toman datos necesarios para crear la persona
            int idPersona = (int)numericId.Value; // Se hace la conversion explicita a entero ya que el constructor de Personas (ya sea fisica o juridica) tiene como id una variable de tipo entero
            string nombrePersona = txtNombre.Text.Trim(); // Al texto ingresado por el usario se le aplica el método Trim para borrar espacios en blanco previos y posteriores.

            if (cmbTipoVehiculo.SelectedIndex == 1) // Si va a crear un Tesla
            {
                if (PersonaFisica.VerificarIdUnico(idPersona))
                {
                    // El ID es único, se puede instanciar PersonaFisica
                    PersonaFisica persona = new PersonaFisica(nombrePersona, idPersona);

                    // Se muestra los datos para corroborar se haya creado exitosamente
                    MessageBox.Show(persona.ToString(), "Nuevo cliente creado", MessageBoxButtons.OK);
                    grpModelo.Visible = true;

                    // Se obtiene la lista de personas físicas
                    List<PersonaFisica> personasFisicas = PersonaFisica.ListaPersonasFisicas();

                    //Se establece la fuente de datos del ComboBox cmbDuenio

                    cmbDuenioTesla.DataSource = personasFisicas;
                    cmbDuenioTesla.DisplayMember = "Nombre"; // Mostrar el nombre en el ComboBox
                    cmbDuenioTesla.ValueMember = "Id"; // Utilizar el ID como valor seleccionado

                    // Para mostrar ambos atributos en cada fila del ComboBox se personalizo el formato de visualización utilizando el evento Format
                    cmbDuenioTesla.Format += (s, args) =>
                    {
                        PersonaFisica personaFisicaLista = (PersonaFisica)args.ListItem;
                        args.Value = $"ID: {personaFisicaLista.Id} - Nombre: {personaFisicaLista.Nombre}";
                    };

                    // Se habilitan nuevos campos y se inhabilitan otros que no corresponden al tipo de vehiculo que se pretende dar de alta.
                    grpDatosVehiculo.Visible = true;
                    cmbDuenioTesla.Visible  = true;
                    cmbDuenioSpaceX.Visible = false;
                }
                else
                {
                    // El ID no es único, se muestra un mensaje de error al usuario
                    MessageBox.Show("El ID ya existe. Debe ser único.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    grpDatosVehiculo.Visible = false;
                }
            }
            else if (cmbTipoVehiculo.SelectedIndex == 2) //Si va a crear un SpaceX
            {
                if (PersonaJuridica.VerificarIdUnico(idPersona))
                {
                    // El ID es único, se puede instanciar PersonaFisica
                    PersonaJuridica persona = new PersonaJuridica(nombrePersona, idPersona);

                    // Se muestra los datos para corroborar se haya creado exitosamente
                    MessageBox.Show(persona.ToString(), "Nueva empresa creada", MessageBoxButtons.OK);
                    grpModelo.Visible = true;
                    // Obtén la lista de personas físicas
                    List<PersonaJuridica> personasJuridicas = PersonaJuridica.ListaPersonasJuridicas();

                    //Establece la fuente de datos del ComboBox cmbDuenio

                    cmbDuenioSpaceX.DataSource = personasJuridicas;
                    cmbDuenioSpaceX.DisplayMember = "Nombre"; // Mostrar el nombre en el ComboBox
                    cmbDuenioSpaceX.ValueMember = "Id"; // Utilizar el ID como valor seleccionado

                    // Para mostrar ambos atributos en cada fila del ComboBox se personalizo el formato de visualización utilizando el evento Format
                    cmbDuenioSpaceX.Format += (s, args) =>
                    {
                        PersonaJuridica personaJuridicaLista = (PersonaJuridica)args.ListItem;
                        args.Value = $"ID: {personaJuridicaLista.Id} - Nombre: {personaJuridicaLista.Nombre}";
                    };
                    // Se habilitan nuevos campos y se inhabilitan otros que no corresponden al tipo de vehiculo que se pretende dar de alta.
                    grpDatosVehiculo.Visible = true;
                    cmbDuenioSpaceX.Visible  = true;
                    cmbDuenioTesla.Visible = false;
                }
                else
                {
                    // El ID no es único, se muestra un mensaje de error al usuario
                    MessageBox.Show("El ID ya existe. Debe ser único.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    grpDatosVehiculo.Visible = false;
                }
            }


        }
        /// <summary>
        /// Este metodo se desencadena con el evento checkched change. Si el radio button esta chequeado y ya hay alguna persona fisica o juridica creada (de acuerdo al producto que se desee dar de alta) habilita la parte de carga de los datos que faltan para el alta del producto deseado. Si no, le muestra al usario un cartel informandole que no hay un cliente creado y no le habilitará nuevos controles.
        /// </summary>
        private void rbtnClienteExistente_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnClienteExistente.Checked == true && cmbTipoVehiculo.SelectedIndex == 1) // Boton chequedo y se pretende dar de alta un Tesla.
            {
                
                // Obtén la lista de personas físicas
                List<PersonaFisica> personasFisicas = PersonaFisica.ListaPersonasFisicas();

                if (personasFisicas.Count != 0)
                {
                    //Establece la fuente de datos del ComboBox cmbDuenio

                    cmbDuenioTesla.DataSource = personasFisicas;
                    cmbDuenioTesla.DisplayMember = "Nombre"; // Mostrar el nombre en el ComboBox
                    cmbDuenioTesla.ValueMember = "Id"; // Utilizar el ID como valor seleccionado

                    // Para mostrar ambos atributos en cada fila del ComboBox se personalizo el formato de visualización utilizando el evento Format
                    cmbDuenioTesla.Format += (s, args) =>
                    {
                        PersonaFisica personaFisicaLista = (PersonaFisica)args.ListItem;
                        args.Value = $"CUIL: {personaFisicaLista.Id} - Nombre: {personaFisicaLista.Nombre}";
                    };

                    // Se visibilizan nuevos campos y se invisibilizan otros que no corresponden al tipo de vehiculo que se pretende dar de alta.
                    grpDatosVehiculo.Visible = true;
                    cmbDuenioTesla.Visible  = true;
                    cmbDuenioSpaceX.Visible = false;
                }
                else
                {
                    MessageBox.Show("Debes crear al menos un cliente primero.", "Lista de clientes vacía", MessageBoxButtons.OK, MessageBoxIcon.Error); // Mensaje en caso de que la lista de clientes este vacía
                }

                    
            }
            else if (rbtnClienteExistente.Checked == true && cmbTipoVehiculo.SelectedIndex == 2) // Boton chequedo y se pretende dar de alta un Tesla.
            {

                // Obtén la lista de personas físicas
                List<PersonaJuridica> personasJuridicas = PersonaJuridica.ListaPersonasJuridicas();
                if (personasJuridicas.Count != 0)
                {
                    //Establece la fuente de datos del ComboBox cmbDuenio

                    cmbDuenioSpaceX.DataSource = personasJuridicas;
                    cmbDuenioSpaceX.DisplayMember = "Nombre"; // Mostrar el nombre en el ComboBox
                    cmbDuenioSpaceX.ValueMember = "Id"; // Utilizar el ID como valor seleccionado

                    // Para mostrar ambos atributos en cada fila del ComboBox se personalizo el formato de visualización utilizando el evento Format
                    cmbDuenioSpaceX.Format += (s, args) =>
                    {
                        PersonaJuridica personaJuridicaLista = (PersonaJuridica)args.ListItem;
                        args.Value = $"CUIT: {personaJuridicaLista.Id} - Nombre: {personaJuridicaLista.Nombre}";
                    };
                    // Se visibilizan nuevos campos y se invisibilizan otros que no corresponden al tipo de vehiculo que se pretende dar de alta.
                    grpDatosVehiculo.Visible = true;
                    cmbDuenioSpaceX.Visible  = true;
                    cmbDuenioTesla.Visible = false;
                }
                else
                {
                    MessageBox.Show("Debes crear al menos un cliente primero", "Lista de clientes vacía", MessageBoxButtons.OK, MessageBoxIcon.Error); // Mensaje en caso de que la lista de clientes este vacía
                }
            }
            
              
        
        }
        /// <summary>
        /// Este metodo valida que el usuario, al interactuar con el control elia un color valido y que no lo deje vacío.
        /// </summary>
        private void cmbColorTesla_Validating(object sender, CancelEventArgs e)
        {
            // Se asigna el ComboBox a una variable mediante la conversion explicita del objeto sender.
            ComboBox color = (ComboBox)sender;

            // Obtener el índice seleccionado
            int indiceSeleccionado = color.SelectedIndex;

            // Validar si el índice seleccionado es 0 (la primera opción vacía)
            if (indiceSeleccionado == 0)
            {
                errorProviderCmbColorTesla.SetError(color, "Debe seleccionar un color válido");               
                e.Cancel = true; // Cancelar el evento Validating para evitar que se pierda el foco


            }
            else
            {
                errorProviderCmbColorTesla.SetError(color, null); // Limpiar el mensaje de error

            }
        }
        /// <summary>
        /// Este metodo se desencadena frente a un cambio en el chequeo del checkbox Vehiculo Nuevo. Lo que permite es que si el vehiculo es nuevo, el usario no deba cargar datos de manera innecesaria como por ejemplo la cantidad de kilometros u horas de vuelos actuales, autonomia actual, Año, etc.
        /// </summary>
        private void chk0km_CheckedChanged(object sender, EventArgs e)
        {
            if (chk0km.Checked) // Si esta chequeado, setea los datos correpsondientes a un vehiculo nuevo.
            {
                numericAnio.Value = 2023;
                numericUsoActual.Value = 0;
                numericCargasRealizadas.Value = 0;
                numericAutonomiaActual.Value = 0;
                cmbColor.Visible = true;
                panelNot0Km.Visible = false;
            }
            else //Si no esta chequeado habilita el panel con los datos a ser vargados para el caso de vehiculos usados.
            {
                panelNot0Km.Visible = true;
                cmbColor.Visible = true;
            }
        }
        /// <summary>
        /// Estemetod se desencadena con el evento click en el boton Dar de Alta. Asigna valores a las variables completadas por el usario (o auto completadas segun el caso) y mediante una estructura de control de flujo switch anidada en otra estructura de datos switch, determina a que constructor llamar.
        /// </summary>
        private void btnAltaVehiculo_Click(object sender, EventArgs e)
        {
            // Declaracion de variables.
            int anio;
            double usoActual;
            string color;
            double autonomiaActual;
            int cargas;
            PersonaFisica duenioTesla;
            PersonaJuridica duenioSpaceX;

            //Validacion del campo color en caso de que el usuario no haya interactuado con el campo color.

            if (cmbColor.SelectedIndex == 0)
            {
                cmbColor.Focus();
                MessageBox.Show("¡Debes seleccionar un color!", "Color inválido", MessageBoxButtons.OK);
                return;
            }
            
            // Estructura swich en donde primero se determina si se va a instanciar un Tesla o un SpaceX y luego en funcion de donde entra, qué modelo de ese vehiculo se instnacia.
            switch (cmbTipoVehiculo.SelectedItem)
            {

                case "Tesla":
                    switch (cmbModeloTesla.SelectedItem)
                    {
                        case "ModeloX":
                            // Inicializacion de variables con conversiones explicitas a los tipos de datos correspondientes.
                            anio = (int)numericAnio.Value;
                            usoActual = (double)numericUsoActual.Value;
                            color = (string)cmbColor.Text;
                            autonomiaActual = (double)numericAutonomiaActual.Value;
                            cargas = (int)numericCargasRealizadas.Value;
                            duenioTesla = (PersonaFisica)cmbDuenioTesla.SelectedItem;

                            //Llamado al constructor
                            ModeloX nuevoModeloX = new ModeloX(anio,usoActual,color,autonomiaActual,cargas,duenioTesla);

                            // Mensaje de creacion exitosa
                            MessageBox.Show( "Nuevo ModeloX creado", "Exito!", MessageBoxButtons.OK);

                            break;

                        case "ModeloS":
                            // Inicializacion de variables con conversiones explicitas a los tipos de datos correspondientes.
                            anio = (int)numericAnio.Value;
                            usoActual = (double)numericUsoActual.Value;
                            color = (string)cmbColor.Text;
                            autonomiaActual = (double)numericAutonomiaActual.Value;
                            cargas = (int)numericCargasRealizadas.Value;
                            duenioTesla = (PersonaFisica)cmbDuenioTesla.SelectedItem;

                            //Llamado al constructor
                            ModeloS nuevoModeloS = new ModeloS(anio, usoActual, color, autonomiaActual, cargas, duenioTesla);

                            // Mensaje de creacion exitosa
                            MessageBox.Show( "Nuevo ModeloS creado", "Exito!", MessageBoxButtons.OK);

                            break;

                        case "Cybertruck":
                            // Inicializacion de variables con conversiones explicitas a los tipos de datos correspondientes.
                            anio = (int)numericAnio.Value;
                            usoActual = (double)numericUsoActual.Value;
                            color = (string)cmbColor.Text;
                            autonomiaActual = (double)numericAutonomiaActual.Value;
                            cargas = (int)numericCargasRealizadas.Value;
                            duenioTesla = (PersonaFisica)cmbDuenioTesla.SelectedItem;

                            //Llamado al constructor
                            Cybertruck nuevoCybertruckS = new Cybertruck(anio, usoActual, color, autonomiaActual, cargas, duenioTesla);

                            // Mensaje de creacion exitosa
                            MessageBox.Show("Nuevo Cybertruck creado", "Exito!", MessageBoxButtons.OK);

                            break;                           
                    }

                    break;
                case "SpaceX":
                    switch (cmbModeloSpaceX.SelectedItem)
                    {
                        case "Starship":
                            // Inicializacion de variables con conversiones explicitas a los tipos de datos correspondientes.
                            anio = (int)numericAnio.Value;
                            usoActual = (double)numericUsoActual.Value;
                            color = (string)cmbColor.Text;
                            autonomiaActual = (double)numericAutonomiaActual.Value;
                            cargas = (int)numericCargasRealizadas.Value;
                            duenioSpaceX = (PersonaJuridica)cmbDuenioSpaceX.SelectedItem;

                            //Llamado al constructor
                            Starship nuevoStarship = new Starship(anio, usoActual, color, autonomiaActual, cargas, duenioSpaceX);

                            // Mensaje de creacion exitosa
                            MessageBox.Show("Nuevo Starship creado", "Exito!", MessageBoxButtons.OK);


                            break;
                        case "Falcon9":
                            // Inicializacion de variables con conversiones explicitas a los tipos de datos correspondientes.
                            anio = (int)numericAnio.Value;
                            usoActual = (double)numericUsoActual.Value;
                            color = (string)cmbColor.Text;
                            autonomiaActual = (double)numericAutonomiaActual.Value;
                            cargas = (int)numericCargasRealizadas.Value;
                            duenioSpaceX = (PersonaJuridica)cmbDuenioSpaceX.SelectedItem;

                            //Llamado al constructor
                            Falcon9 nuevoFalcon9 = new Falcon9(anio, usoActual, color, autonomiaActual, cargas, duenioSpaceX);

                            // Mensaje de creacion exitosa
                            MessageBox.Show("Nuevo Falcon9 creado", "Exito!", MessageBoxButtons.OK);
                            break;
                    }


                    break;
                    
            }
        }

    }
}
