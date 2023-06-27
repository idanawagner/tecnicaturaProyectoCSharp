namespace Proyecto_2_Tema_2
{
    partial class Escanear
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
            this.cmbTipoDeVehiculo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTeslas = new System.Windows.Forms.ComboBox();
            this.cmbSpaceX = new System.Windows.Forms.ComboBox();
            this.errorProviderCmbTipo = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnEscanear = new System.Windows.Forms.Button();
            this.lblSeleccionar = new System.Windows.Forms.Label();
            this.panelVehiculo = new System.Windows.Forms.Panel();
            this.txtResultadoEscaneo = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCmbTipo)).BeginInit();
            this.panelVehiculo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbTipoDeVehiculo
            // 
            this.cmbTipoDeVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoDeVehiculo.FormattingEnabled = true;
            this.cmbTipoDeVehiculo.Items.AddRange(new object[] {
            "",
            "Tesla",
            "SpaceX"});
            this.cmbTipoDeVehiculo.Location = new System.Drawing.Point(148, 63);
            this.cmbTipoDeVehiculo.Name = "cmbTipoDeVehiculo";
            this.cmbTipoDeVehiculo.Size = new System.Drawing.Size(413, 26);
            this.cmbTipoDeVehiculo.TabIndex = 0;
            this.cmbTipoDeVehiculo.SelectedIndexChanged += new System.EventHandler(this.cmbTipoDeVehiculo_SelectedIndexChanged);
            this.cmbTipoDeVehiculo.Validating += new System.ComponentModel.CancelEventHandler(this.cmbTipoDeVehiculo_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vehiculo a escanear";
            // 
            // cmbTeslas
            // 
            this.cmbTeslas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTeslas.FormattingEnabled = true;
            this.cmbTeslas.Location = new System.Drawing.Point(148, 143);
            this.cmbTeslas.Name = "cmbTeslas";
            this.cmbTeslas.Size = new System.Drawing.Size(413, 26);
            this.cmbTeslas.TabIndex = 2;
            // 
            // cmbSpaceX
            // 
            this.cmbSpaceX.FormattingEnabled = true;
            this.cmbSpaceX.Location = new System.Drawing.Point(148, 143);
            this.cmbSpaceX.Name = "cmbSpaceX";
            this.cmbSpaceX.Size = new System.Drawing.Size(413, 24);
            this.cmbSpaceX.TabIndex = 3;
            // 
            // errorProviderCmbTipo
            // 
            this.errorProviderCmbTipo.ContainerControl = this;
            // 
            // btnEscanear
            // 
            this.btnEscanear.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnEscanear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscanear.Location = new System.Drawing.Point(431, 186);
            this.btnEscanear.Name = "btnEscanear";
            this.btnEscanear.Size = new System.Drawing.Size(130, 32);
            this.btnEscanear.TabIndex = 4;
            this.btnEscanear.Text = "Escanear";
            this.btnEscanear.UseVisualStyleBackColor = false;
            this.btnEscanear.Click += new System.EventHandler(this.btnEscanear_Click);
            // 
            // lblSeleccionar
            // 
            this.lblSeleccionar.AutoSize = true;
            this.lblSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionar.Location = new System.Drawing.Point(115, 102);
            this.lblSeleccionar.Name = "lblSeleccionar";
            this.lblSeleccionar.Size = new System.Drawing.Size(163, 20);
            this.lblSeleccionar.TabIndex = 5;
            this.lblSeleccionar.Text = "Seleccionar vehiculo";
            // 
            // panelVehiculo
            // 
            this.panelVehiculo.Controls.Add(this.lblSeleccionar);
            this.panelVehiculo.Controls.Add(this.cmbTeslas);
            this.panelVehiculo.Controls.Add(this.label1);
            this.panelVehiculo.Controls.Add(this.cmbSpaceX);
            this.panelVehiculo.Controls.Add(this.cmbTipoDeVehiculo);
            this.panelVehiculo.Controls.Add(this.btnEscanear);
            this.panelVehiculo.Location = new System.Drawing.Point(30, 21);
            this.panelVehiculo.Name = "panelVehiculo";
            this.panelVehiculo.Size = new System.Drawing.Size(739, 240);
            this.panelVehiculo.TabIndex = 6;
            // 
            // txtResultadoEscaneo
            // 
            this.txtResultadoEscaneo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultadoEscaneo.Location = new System.Drawing.Point(114, 267);
            this.txtResultadoEscaneo.Name = "txtResultadoEscaneo";
            this.txtResultadoEscaneo.ReadOnly = true;
            this.txtResultadoEscaneo.Size = new System.Drawing.Size(539, 392);
            this.txtResultadoEscaneo.TabIndex = 7;
            this.txtResultadoEscaneo.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkCyan;
            this.groupBox1.Controls.Add(this.panelVehiculo);
            this.groupBox1.Controls.Add(this.txtResultadoEscaneo);
            this.groupBox1.Location = new System.Drawing.Point(84, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(812, 710);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // Escanear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1028, 799);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Escanear";
            this.Text = "Escanear";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCmbTipo)).EndInit();
            this.panelVehiculo.ResumeLayout(false);
            this.panelVehiculo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTipoDeVehiculo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTeslas;
        private System.Windows.Forms.ComboBox cmbSpaceX;
        private System.Windows.Forms.ErrorProvider errorProviderCmbTipo;
        private System.Windows.Forms.Panel panelVehiculo;
        private System.Windows.Forms.Label lblSeleccionar;
        private System.Windows.Forms.Button btnEscanear;
        private System.Windows.Forms.RichTextBox txtResultadoEscaneo;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}