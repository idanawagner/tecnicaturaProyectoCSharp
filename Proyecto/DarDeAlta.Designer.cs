namespace Proyecto_2_Tema_2
{
    partial class DarDeAlta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmbTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.cmbModeloTesla = new System.Windows.Forms.ComboBox();
            this.cmbModeloSpaceX = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.grpModelo = new System.Windows.Forms.GroupBox();
            this.errorProviderCmbTipo = new System.Windows.Forms.ErrorProvider(this.components);
            this.rbtnClienteNuevo = new System.Windows.Forms.RadioButton();
            this.rbtnClienteExistente = new System.Windows.Forms.RadioButton();
            this.grpNuevoCliente = new System.Windows.Forms.GroupBox();
            this.btnCrearPersona = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.numericId = new System.Windows.Forms.NumericUpDown();
            this.grpDatosVehiculo = new System.Windows.Forms.GroupBox();
            this.cmbDuenioSpaceX = new System.Windows.Forms.ComboBox();
            this.btnAltaTesla = new System.Windows.Forms.Button();
            this.numericCargasRealizadas = new System.Windows.Forms.NumericUpDown();
            this.lblCargas = new System.Windows.Forms.Label();
            this.numericAutonomiaActual = new System.Windows.Forms.NumericUpDown();
            this.lblAutonomiaActual = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.cmbColorTesla = new System.Windows.Forms.ComboBox();
            this.numericKilometrajeActual = new System.Windows.Forms.NumericUpDown();
            this.lblKilometrajeActual = new System.Windows.Forms.Label();
            this.lblAnio = new System.Windows.Forms.Label();
            this.numericAnio = new System.Windows.Forms.NumericUpDown();
            this.lblSeleccionarCliente = new System.Windows.Forms.Label();
            this.cmbDuenioTesla = new System.Windows.Forms.ComboBox();
            this.errorProviderCmbColorTesla = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCmbDuenio = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpModelo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCmbTipo)).BeginInit();
            this.grpNuevoCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericId)).BeginInit();
            this.grpDatosVehiculo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCargasRealizadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAutonomiaActual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericKilometrajeActual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAnio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCmbColorTesla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCmbDuenio)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbTipoVehiculo
            // 
            this.cmbTipoVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoVehiculo.FormattingEnabled = true;
            this.cmbTipoVehiculo.Items.AddRange(new object[] {
            "",
            "Tesla",
            "SpaceX"});
            this.cmbTipoVehiculo.Location = new System.Drawing.Point(36, 70);
            this.cmbTipoVehiculo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTipoVehiculo.Name = "cmbTipoVehiculo";
            this.cmbTipoVehiculo.Size = new System.Drawing.Size(121, 26);
            this.cmbTipoVehiculo.TabIndex = 0;
            this.cmbTipoVehiculo.SelectedIndexChanged += new System.EventHandler(this.cmbTipoVehiculo_SelectedIndexChanged);
            this.cmbTipoVehiculo.Validating += new System.ComponentModel.CancelEventHandler(this.cmbTipoVehiculo_Validating);
            // 
            // cmbModeloTesla
            // 
            this.cmbModeloTesla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbModeloTesla.FormattingEnabled = true;
            this.cmbModeloTesla.Items.AddRange(new object[] {
            "",
            "ModeloS",
            "ModeloX",
            "Cybertruck"});
            this.cmbModeloTesla.Location = new System.Drawing.Point(191, 70);
            this.cmbModeloTesla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbModeloTesla.Name = "cmbModeloTesla";
            this.cmbModeloTesla.Size = new System.Drawing.Size(121, 26);
            this.cmbModeloTesla.TabIndex = 1;
            this.cmbModeloTesla.Visible = false;
            this.cmbModeloTesla.SelectedIndexChanged += new System.EventHandler(this.cmbModeloTesla_SelectedIndexChanged);
            // 
            // cmbModeloSpaceX
            // 
            this.cmbModeloSpaceX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbModeloSpaceX.FormattingEnabled = true;
            this.cmbModeloSpaceX.Items.AddRange(new object[] {
            "",
            "Starship",
            "Falcon9"});
            this.cmbModeloSpaceX.Location = new System.Drawing.Point(348, 70);
            this.cmbModeloSpaceX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbModeloSpaceX.Name = "cmbModeloSpaceX";
            this.cmbModeloSpaceX.Size = new System.Drawing.Size(121, 26);
            this.cmbModeloSpaceX.TabIndex = 2;
            this.cmbModeloSpaceX.Visible = false;
            this.cmbModeloSpaceX.SelectedIndexChanged += new System.EventHandler(this.cmbModeloSpaceX_SelectedIndexChanged);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(21, 36);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(117, 18);
            this.lblTipo.TabIndex = 3;
            this.lblTipo.Text = "Tipo de Vehiculo";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(179, 36);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(58, 18);
            this.lblModelo.TabIndex = 4;
            this.lblModelo.Text = "Modelo";
            this.lblModelo.Visible = false;
            // 
            // grpModelo
            // 
            this.grpModelo.Controls.Add(this.cmbModeloTesla);
            this.grpModelo.Controls.Add(this.lblModelo);
            this.grpModelo.Controls.Add(this.cmbTipoVehiculo);
            this.grpModelo.Controls.Add(this.lblTipo);
            this.grpModelo.Controls.Add(this.cmbModeloSpaceX);
            this.grpModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpModelo.Location = new System.Drawing.Point(24, 40);
            this.grpModelo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpModelo.Name = "grpModelo";
            this.grpModelo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpModelo.Size = new System.Drawing.Size(653, 127);
            this.grpModelo.TabIndex = 5;
            this.grpModelo.TabStop = false;
            this.grpModelo.Text = "Tipo y Modelo de Vehículo";
            // 
            // errorProviderCmbTipo
            // 
            this.errorProviderCmbTipo.ContainerControl = this;
            // 
            // rbtnClienteNuevo
            // 
            this.rbtnClienteNuevo.AutoSize = true;
            this.rbtnClienteNuevo.Location = new System.Drawing.Point(48, 188);
            this.rbtnClienteNuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnClienteNuevo.Name = "rbtnClienteNuevo";
            this.rbtnClienteNuevo.Size = new System.Drawing.Size(121, 22);
            this.rbtnClienteNuevo.TabIndex = 6;
            this.rbtnClienteNuevo.TabStop = true;
            this.rbtnClienteNuevo.Text = "Cliente Nuevo";
            this.rbtnClienteNuevo.UseVisualStyleBackColor = true;
            this.rbtnClienteNuevo.Visible = false;
            this.rbtnClienteNuevo.CheckedChanged += new System.EventHandler(this.rbtnClienteNuevo_CheckedChanged);
            // 
            // rbtnClienteExistente
            // 
            this.rbtnClienteExistente.AutoSize = true;
            this.rbtnClienteExistente.Location = new System.Drawing.Point(215, 188);
            this.rbtnClienteExistente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnClienteExistente.Name = "rbtnClienteExistente";
            this.rbtnClienteExistente.Size = new System.Drawing.Size(138, 22);
            this.rbtnClienteExistente.TabIndex = 7;
            this.rbtnClienteExistente.TabStop = true;
            this.rbtnClienteExistente.Text = "Cliente Existente";
            this.rbtnClienteExistente.UseVisualStyleBackColor = true;
            this.rbtnClienteExistente.Visible = false;
            this.rbtnClienteExistente.CheckedChanged += new System.EventHandler(this.rbtnClienteExistente_CheckedChanged);
            // 
            // grpNuevoCliente
            // 
            this.grpNuevoCliente.Controls.Add(this.btnCrearPersona);
            this.grpNuevoCliente.Controls.Add(this.lblNombre);
            this.grpNuevoCliente.Controls.Add(this.txtNombre);
            this.grpNuevoCliente.Controls.Add(this.lblID);
            this.grpNuevoCliente.Controls.Add(this.numericId);
            this.grpNuevoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNuevoCliente.Location = new System.Drawing.Point(24, 232);
            this.grpNuevoCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpNuevoCliente.Name = "grpNuevoCliente";
            this.grpNuevoCliente.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpNuevoCliente.Size = new System.Drawing.Size(653, 111);
            this.grpNuevoCliente.TabIndex = 8;
            this.grpNuevoCliente.TabStop = false;
            this.grpNuevoCliente.Text = "Cliente Nuevo";
            this.grpNuevoCliente.Visible = false;
            // 
            // btnCrearPersona
            // 
            this.btnCrearPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearPersona.Location = new System.Drawing.Point(477, 56);
            this.btnCrearPersona.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCrearPersona.Name = "btnCrearPersona";
            this.btnCrearPersona.Size = new System.Drawing.Size(155, 31);
            this.btnCrearPersona.TabIndex = 4;
            this.btnCrearPersona.Text = "Crear Cliente";
            this.btnCrearPersona.UseVisualStyleBackColor = true;
            this.btnCrearPersona.Click += new System.EventHandler(this.btnCrearPersona_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(21, 30);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(131, 18);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre Completo";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(36, 63);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(187, 24);
            this.txtNombre.TabIndex = 2;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(255, 30);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(41, 18);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "CUIL";
            // 
            // numericId
            // 
            this.numericId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericId.Location = new System.Drawing.Point(268, 63);
            this.numericId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericId.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numericId.Name = "numericId";
            this.numericId.Size = new System.Drawing.Size(177, 24);
            this.numericId.TabIndex = 0;
            // 
            // grpDatosVehiculo
            // 
            this.grpDatosVehiculo.Controls.Add(this.cmbDuenioSpaceX);
            this.grpDatosVehiculo.Controls.Add(this.btnAltaTesla);
            this.grpDatosVehiculo.Controls.Add(this.numericCargasRealizadas);
            this.grpDatosVehiculo.Controls.Add(this.lblCargas);
            this.grpDatosVehiculo.Controls.Add(this.numericAutonomiaActual);
            this.grpDatosVehiculo.Controls.Add(this.lblAutonomiaActual);
            this.grpDatosVehiculo.Controls.Add(this.lblColor);
            this.grpDatosVehiculo.Controls.Add(this.cmbColorTesla);
            this.grpDatosVehiculo.Controls.Add(this.numericKilometrajeActual);
            this.grpDatosVehiculo.Controls.Add(this.lblKilometrajeActual);
            this.grpDatosVehiculo.Controls.Add(this.lblAnio);
            this.grpDatosVehiculo.Controls.Add(this.numericAnio);
            this.grpDatosVehiculo.Controls.Add(this.lblSeleccionarCliente);
            this.grpDatosVehiculo.Controls.Add(this.cmbDuenioTesla);
            this.grpDatosVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatosVehiculo.Location = new System.Drawing.Point(24, 361);
            this.grpDatosVehiculo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDatosVehiculo.Name = "grpDatosVehiculo";
            this.grpDatosVehiculo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDatosVehiculo.Size = new System.Drawing.Size(653, 321);
            this.grpDatosVehiculo.TabIndex = 9;
            this.grpDatosVehiculo.TabStop = false;
            this.grpDatosVehiculo.Text = "Datos Vehículo";
            this.grpDatosVehiculo.Visible = false;
            // 
            // cmbDuenioSpaceX
            // 
            this.cmbDuenioSpaceX.FormattingEnabled = true;
            this.cmbDuenioSpaceX.Location = new System.Drawing.Point(310, 57);
            this.cmbDuenioSpaceX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDuenioSpaceX.Name = "cmbDuenioSpaceX";
            this.cmbDuenioSpaceX.Size = new System.Drawing.Size(251, 26);
            this.cmbDuenioSpaceX.TabIndex = 13;
            this.cmbDuenioSpaceX.Visible = false;
            // 
            // btnAltaTesla
            // 
            this.btnAltaTesla.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAltaTesla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaTesla.Location = new System.Drawing.Point(417, 272);
            this.btnAltaTesla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAltaTesla.Name = "btnAltaTesla";
            this.btnAltaTesla.Size = new System.Drawing.Size(215, 32);
            this.btnAltaTesla.TabIndex = 12;
            this.btnAltaTesla.Text = "Dar de Alta";
            this.btnAltaTesla.UseVisualStyleBackColor = false;
            this.btnAltaTesla.Click += new System.EventHandler(this.btnAltaTesla_Click);
            // 
            // numericCargasRealizadas
            // 
            this.numericCargasRealizadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericCargasRealizadas.Location = new System.Drawing.Point(325, 203);
            this.numericCargasRealizadas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericCargasRealizadas.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericCargasRealizadas.Name = "numericCargasRealizadas";
            this.numericCargasRealizadas.Size = new System.Drawing.Size(123, 24);
            this.numericCargasRealizadas.TabIndex = 11;
            // 
            // lblCargas
            // 
            this.lblCargas.AutoSize = true;
            this.lblCargas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargas.Location = new System.Drawing.Point(307, 170);
            this.lblCargas.Name = "lblCargas";
            this.lblCargas.Size = new System.Drawing.Size(127, 18);
            this.lblCargas.TabIndex = 10;
            this.lblCargas.Text = "Cargas realizadas";
            // 
            // numericAutonomiaActual
            // 
            this.numericAutonomiaActual.DecimalPlaces = 1;
            this.numericAutonomiaActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericAutonomiaActual.Location = new System.Drawing.Point(325, 132);
            this.numericAutonomiaActual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericAutonomiaActual.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericAutonomiaActual.Name = "numericAutonomiaActual";
            this.numericAutonomiaActual.Size = new System.Drawing.Size(120, 24);
            this.numericAutonomiaActual.TabIndex = 9;
            // 
            // lblAutonomiaActual
            // 
            this.lblAutonomiaActual.AutoSize = true;
            this.lblAutonomiaActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutonomiaActual.Location = new System.Drawing.Point(307, 98);
            this.lblAutonomiaActual.Name = "lblAutonomiaActual";
            this.lblAutonomiaActual.Size = new System.Drawing.Size(123, 18);
            this.lblAutonomiaActual.TabIndex = 8;
            this.lblAutonomiaActual.Text = "Autonomia Actual";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(21, 242);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(45, 18);
            this.lblColor.TabIndex = 7;
            this.lblColor.Text = "Color";
            // 
            // cmbColorTesla
            // 
            this.cmbColorTesla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbColorTesla.FormattingEnabled = true;
            this.cmbColorTesla.Items.AddRange(new object[] {
            "",
            "Negro",
            "Blanco",
            "Gris",
            "Rojo",
            "Azul"});
            this.cmbColorTesla.Location = new System.Drawing.Point(36, 272);
            this.cmbColorTesla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbColorTesla.Name = "cmbColorTesla";
            this.cmbColorTesla.Size = new System.Drawing.Size(121, 26);
            this.cmbColorTesla.TabIndex = 6;
            this.cmbColorTesla.Validating += new System.ComponentModel.CancelEventHandler(this.cmbColorTesla_Validating);
            // 
            // numericKilometrajeActual
            // 
            this.numericKilometrajeActual.DecimalPlaces = 1;
            this.numericKilometrajeActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericKilometrajeActual.Location = new System.Drawing.Point(36, 203);
            this.numericKilometrajeActual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericKilometrajeActual.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericKilometrajeActual.Name = "numericKilometrajeActual";
            this.numericKilometrajeActual.Size = new System.Drawing.Size(120, 24);
            this.numericKilometrajeActual.TabIndex = 5;
            // 
            // lblKilometrajeActual
            // 
            this.lblKilometrajeActual.AutoSize = true;
            this.lblKilometrajeActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKilometrajeActual.Location = new System.Drawing.Point(21, 170);
            this.lblKilometrajeActual.Name = "lblKilometrajeActual";
            this.lblKilometrajeActual.Size = new System.Drawing.Size(126, 18);
            this.lblKilometrajeActual.TabIndex = 4;
            this.lblKilometrajeActual.Text = "Kilometraje Actual";
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnio.Location = new System.Drawing.Point(21, 98);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(229, 18);
            this.lblAnio.TabIndex = 3;
            this.lblAnio.Text = "Año (Permitidos del 2020 al 2023)";
            // 
            // numericAnio
            // 
            this.numericAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericAnio.Location = new System.Drawing.Point(36, 132);
            this.numericAnio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericAnio.Maximum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.numericAnio.Minimum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.numericAnio.Name = "numericAnio";
            this.numericAnio.Size = new System.Drawing.Size(120, 24);
            this.numericAnio.TabIndex = 2;
            this.numericAnio.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            // 
            // lblSeleccionarCliente
            // 
            this.lblSeleccionarCliente.AutoSize = true;
            this.lblSeleccionarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionarCliente.Location = new System.Drawing.Point(21, 25);
            this.lblSeleccionarCliente.Name = "lblSeleccionarCliente";
            this.lblSeleccionarCliente.Size = new System.Drawing.Size(135, 18);
            this.lblSeleccionarCliente.TabIndex = 1;
            this.lblSeleccionarCliente.Text = "Seleccionar Cliente";
            // 
            // cmbDuenioTesla
            // 
            this.cmbDuenioTesla.FormattingEnabled = true;
            this.cmbDuenioTesla.Location = new System.Drawing.Point(36, 57);
            this.cmbDuenioTesla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDuenioTesla.Name = "cmbDuenioTesla";
            this.cmbDuenioTesla.Size = new System.Drawing.Size(251, 26);
            this.cmbDuenioTesla.TabIndex = 0;
            this.cmbDuenioTesla.Visible = false;
            // 
            // errorProviderCmbColorTesla
            // 
            this.errorProviderCmbColorTesla.ContainerControl = this;
            // 
            // errorProviderCmbDuenio
            // 
            this.errorProviderCmbDuenio.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkCyan;
            this.groupBox1.Controls.Add(this.grpModelo);
            this.groupBox1.Controls.Add(this.grpDatosVehiculo);
            this.groupBox1.Controls.Add(this.rbtnClienteExistente);
            this.groupBox1.Controls.Add(this.grpNuevoCliente);
            this.groupBox1.Controls.Add(this.rbtnClienteNuevo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(902, 726);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // DarDeAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1280, 770);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DarDeAlta";
            this.Text = "DarDeAlta";
            this.grpModelo.ResumeLayout(false);
            this.grpModelo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCmbTipo)).EndInit();
            this.grpNuevoCliente.ResumeLayout(false);
            this.grpNuevoCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericId)).EndInit();
            this.grpDatosVehiculo.ResumeLayout(false);
            this.grpDatosVehiculo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCargasRealizadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAutonomiaActual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericKilometrajeActual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAnio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCmbColorTesla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCmbDuenio)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTipoVehiculo;
        private System.Windows.Forms.ComboBox cmbModeloTesla;
        private System.Windows.Forms.ComboBox cmbModeloSpaceX;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.GroupBox grpModelo;
        private System.Windows.Forms.ErrorProvider errorProviderCmbTipo;
        private System.Windows.Forms.RadioButton rbtnClienteExistente;
        private System.Windows.Forms.RadioButton rbtnClienteNuevo;
        private System.Windows.Forms.GroupBox grpNuevoCliente;
        private System.Windows.Forms.Button btnCrearPersona;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.NumericUpDown numericId;
        private System.Windows.Forms.GroupBox grpDatosVehiculo;
        private System.Windows.Forms.Label lblSeleccionarCliente;
        private System.Windows.Forms.ComboBox cmbDuenioTesla;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.NumericUpDown numericAnio;
        private System.Windows.Forms.NumericUpDown numericKilometrajeActual;
        private System.Windows.Forms.Label lblKilometrajeActual;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.NumericUpDown numericAutonomiaActual;
        private System.Windows.Forms.Label lblAutonomiaActual;
        private System.Windows.Forms.NumericUpDown numericCargasRealizadas;
        private System.Windows.Forms.Label lblCargas;
        private System.Windows.Forms.Button btnAltaTesla;
        private System.Windows.Forms.ComboBox cmbColorTesla;
        private System.Windows.Forms.ErrorProvider errorProviderCmbColorTesla;
        private System.Windows.Forms.ErrorProvider errorProviderCmbDuenio;
        private System.Windows.Forms.ComboBox cmbDuenioSpaceX;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}