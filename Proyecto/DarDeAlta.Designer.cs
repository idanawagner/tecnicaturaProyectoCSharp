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
            this.panelNot0Km = new System.Windows.Forms.Panel();
            this.lblKilometrajeActual = new System.Windows.Forms.Label();
            this.numericAnio = new System.Windows.Forms.NumericUpDown();
            this.lblAnio = new System.Windows.Forms.Label();
            this.numericUsoActual = new System.Windows.Forms.NumericUpDown();
            this.numericCargasRealizadas = new System.Windows.Forms.NumericUpDown();
            this.numericAutonomiaActual = new System.Windows.Forms.NumericUpDown();
            this.lblCargas = new System.Windows.Forms.Label();
            this.lblAutonomiaActual = new System.Windows.Forms.Label();
            this.chk0km = new System.Windows.Forms.CheckBox();
            this.cmbDuenioSpaceX = new System.Windows.Forms.ComboBox();
            this.btnAltaVehiculo = new System.Windows.Forms.Button();
            this.lblColor = new System.Windows.Forms.Label();
            this.cmbColor = new System.Windows.Forms.ComboBox();
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
            this.panelNot0Km.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAnio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUsoActual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCargasRealizadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAutonomiaActual)).BeginInit();
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
            this.cmbModeloSpaceX.Location = new System.Drawing.Point(191, 70);
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
            this.grpModelo.TabIndex = 0;
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
            this.rbtnClienteNuevo.TabIndex = 3;
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
            this.rbtnClienteExistente.TabIndex = 4;
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
            this.btnCrearPersona.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCrearPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearPersona.Location = new System.Drawing.Point(457, 59);
            this.btnCrearPersona.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCrearPersona.Name = "btnCrearPersona";
            this.btnCrearPersona.Size = new System.Drawing.Size(175, 32);
            this.btnCrearPersona.TabIndex = 7;
            this.btnCrearPersona.Text = "Crear Cliente";
            this.btnCrearPersona.UseVisualStyleBackColor = false;
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
            this.txtNombre.TabIndex = 5;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(271, 33);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(23, 18);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "Id ";
            // 
            // numericId
            // 
            this.numericId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericId.Location = new System.Drawing.Point(268, 63);
            this.numericId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericId.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericId.Name = "numericId";
            this.numericId.Size = new System.Drawing.Size(177, 24);
            this.numericId.TabIndex = 6;
            // 
            // grpDatosVehiculo
            // 
            this.grpDatosVehiculo.Controls.Add(this.panelNot0Km);
            this.grpDatosVehiculo.Controls.Add(this.chk0km);
            this.grpDatosVehiculo.Controls.Add(this.cmbDuenioSpaceX);
            this.grpDatosVehiculo.Controls.Add(this.btnAltaVehiculo);
            this.grpDatosVehiculo.Controls.Add(this.lblColor);
            this.grpDatosVehiculo.Controls.Add(this.cmbColor);
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
            // panelNot0Km
            // 
            this.panelNot0Km.Controls.Add(this.lblKilometrajeActual);
            this.panelNot0Km.Controls.Add(this.numericAnio);
            this.panelNot0Km.Controls.Add(this.lblAnio);
            this.panelNot0Km.Controls.Add(this.numericUsoActual);
            this.panelNot0Km.Controls.Add(this.numericCargasRealizadas);
            this.panelNot0Km.Controls.Add(this.numericAutonomiaActual);
            this.panelNot0Km.Controls.Add(this.lblCargas);
            this.panelNot0Km.Controls.Add(this.lblAutonomiaActual);
            this.panelNot0Km.Location = new System.Drawing.Point(12, 88);
            this.panelNot0Km.Name = "panelNot0Km";
            this.panelNot0Km.Size = new System.Drawing.Size(457, 164);
            this.panelNot0Km.TabIndex = 15;
            this.panelNot0Km.Visible = false;
            // 
            // lblKilometrajeActual
            // 
            this.lblKilometrajeActual.AutoSize = true;
            this.lblKilometrajeActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKilometrajeActual.Location = new System.Drawing.Point(9, 87);
            this.lblKilometrajeActual.Name = "lblKilometrajeActual";
            this.lblKilometrajeActual.Size = new System.Drawing.Size(126, 18);
            this.lblKilometrajeActual.TabIndex = 4;
            this.lblKilometrajeActual.Text = "Kilometraje Actual";
            // 
            // numericAnio
            // 
            this.numericAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericAnio.Location = new System.Drawing.Point(12, 48);
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
            this.numericAnio.TabIndex = 12;
            this.numericAnio.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnio.Location = new System.Drawing.Point(9, 14);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(229, 18);
            this.lblAnio.TabIndex = 3;
            this.lblAnio.Text = "Año (Permitidos del 2020 al 2023)";
            // 
            // numericUsoActual
            // 
            this.numericUsoActual.DecimalPlaces = 1;
            this.numericUsoActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUsoActual.Location = new System.Drawing.Point(16, 117);
            this.numericUsoActual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUsoActual.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.numericUsoActual.Name = "numericUsoActual";
            this.numericUsoActual.Size = new System.Drawing.Size(120, 24);
            this.numericUsoActual.TabIndex = 14;
            // 
            // numericCargasRealizadas
            // 
            this.numericCargasRealizadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericCargasRealizadas.Location = new System.Drawing.Point(294, 117);
            this.numericCargasRealizadas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericCargasRealizadas.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericCargasRealizadas.Name = "numericCargasRealizadas";
            this.numericCargasRealizadas.Size = new System.Drawing.Size(123, 24);
            this.numericCargasRealizadas.TabIndex = 15;
            // 
            // numericAutonomiaActual
            // 
            this.numericAutonomiaActual.DecimalPlaces = 1;
            this.numericAutonomiaActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericAutonomiaActual.Location = new System.Drawing.Point(297, 48);
            this.numericAutonomiaActual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericAutonomiaActual.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericAutonomiaActual.Name = "numericAutonomiaActual";
            this.numericAutonomiaActual.Size = new System.Drawing.Size(120, 24);
            this.numericAutonomiaActual.TabIndex = 13;
            // 
            // lblCargas
            // 
            this.lblCargas.AutoSize = true;
            this.lblCargas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargas.Location = new System.Drawing.Point(294, 87);
            this.lblCargas.Name = "lblCargas";
            this.lblCargas.Size = new System.Drawing.Size(127, 18);
            this.lblCargas.TabIndex = 10;
            this.lblCargas.Text = "Cargas realizadas";
            // 
            // lblAutonomiaActual
            // 
            this.lblAutonomiaActual.AutoSize = true;
            this.lblAutonomiaActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutonomiaActual.Location = new System.Drawing.Point(294, 14);
            this.lblAutonomiaActual.Name = "lblAutonomiaActual";
            this.lblAutonomiaActual.Size = new System.Drawing.Size(123, 18);
            this.lblAutonomiaActual.TabIndex = 8;
            this.lblAutonomiaActual.Text = "Autonomia Actual";
            // 
            // chk0km
            // 
            this.chk0km.AutoSize = true;
            this.chk0km.Checked = true;
            this.chk0km.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk0km.Location = new System.Drawing.Point(488, 59);
            this.chk0km.Name = "chk0km";
            this.chk0km.Size = new System.Drawing.Size(144, 22);
            this.chk0km.TabIndex = 11;
            this.chk0km.Text = "Vehiculo nuevo";
            this.chk0km.UseVisualStyleBackColor = true;
            this.chk0km.CheckedChanged += new System.EventHandler(this.chk0km_CheckedChanged);
            // 
            // cmbDuenioSpaceX
            // 
            this.cmbDuenioSpaceX.FormattingEnabled = true;
            this.cmbDuenioSpaceX.Location = new System.Drawing.Point(24, 57);
            this.cmbDuenioSpaceX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDuenioSpaceX.Name = "cmbDuenioSpaceX";
            this.cmbDuenioSpaceX.Size = new System.Drawing.Size(270, 26);
            this.cmbDuenioSpaceX.TabIndex = 9;
            this.cmbDuenioSpaceX.Visible = false;
            // 
            // btnAltaVehiculo
            // 
            this.btnAltaVehiculo.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAltaVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaVehiculo.Location = new System.Drawing.Point(457, 272);
            this.btnAltaVehiculo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAltaVehiculo.Name = "btnAltaVehiculo";
            this.btnAltaVehiculo.Size = new System.Drawing.Size(175, 32);
            this.btnAltaVehiculo.TabIndex = 16;
            this.btnAltaVehiculo.Text = "Dar de Alta";
            this.btnAltaVehiculo.UseVisualStyleBackColor = false;
            this.btnAltaVehiculo.Click += new System.EventHandler(this.btnAltaVehiculo_Click);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(305, 25);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(45, 18);
            this.lblColor.TabIndex = 7;
            this.lblColor.Text = "Color";
            // 
            // cmbColor
            // 
            this.cmbColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Items.AddRange(new object[] {
            "",
            "Negro",
            "Blanco",
            "Gris",
            "Rojo",
            "Azul"});
            this.cmbColor.Location = new System.Drawing.Point(308, 57);
            this.cmbColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(121, 26);
            this.cmbColor.TabIndex = 10;
            this.cmbColor.Validating += new System.ComponentModel.CancelEventHandler(this.cmbColorTesla_Validating);
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
            this.cmbDuenioTesla.Location = new System.Drawing.Point(25, 57);
            this.cmbDuenioTesla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDuenioTesla.Name = "cmbDuenioTesla";
            this.cmbDuenioTesla.Size = new System.Drawing.Size(269, 26);
            this.cmbDuenioTesla.TabIndex = 8;
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
            this.groupBox1.TabIndex = 0;
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
            this.panelNot0Km.ResumeLayout(false);
            this.panelNot0Km.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAnio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUsoActual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCargasRealizadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAutonomiaActual)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numericUsoActual;
        private System.Windows.Forms.Label lblKilometrajeActual;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.NumericUpDown numericAutonomiaActual;
        private System.Windows.Forms.Label lblAutonomiaActual;
        private System.Windows.Forms.NumericUpDown numericCargasRealizadas;
        private System.Windows.Forms.Label lblCargas;
        private System.Windows.Forms.Button btnAltaVehiculo;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.ErrorProvider errorProviderCmbColorTesla;
        private System.Windows.Forms.ErrorProvider errorProviderCmbDuenio;
        private System.Windows.Forms.ComboBox cmbDuenioSpaceX;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chk0km;
        private System.Windows.Forms.Panel panelNot0Km;
    }
}