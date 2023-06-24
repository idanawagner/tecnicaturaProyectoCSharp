namespace Proyecto_2_Tema_2
{
    partial class Eliminar
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
            this.GbFiltro = new System.Windows.Forms.GroupBox();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.TbDuenio = new System.Windows.Forms.TextBox();
            this.CbSpaceX = new System.Windows.Forms.ComboBox();
            this.LModelo = new System.Windows.Forms.Label();
            this.LDuenio = new System.Windows.Forms.Label();
            this.CbTesla = new System.Windows.Forms.ComboBox();
            this.GbEmpresa = new System.Windows.Forms.GroupBox();
            this.RbSpaceX = new System.Windows.Forms.RadioButton();
            this.RbTesla = new System.Windows.Forms.RadioButton();
            this.Indicaciones = new System.Windows.Forms.Label();
            this.DgvTabla = new System.Windows.Forms.DataGridView();
            this.EliminarVehiculo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.GbFiltro.SuspendLayout();
            this.GbEmpresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // GbFiltro
            // 
            this.GbFiltro.Controls.Add(this.BtnActualizar);
            this.GbFiltro.Controls.Add(this.TbDuenio);
            this.GbFiltro.Controls.Add(this.CbSpaceX);
            this.GbFiltro.Controls.Add(this.LModelo);
            this.GbFiltro.Controls.Add(this.LDuenio);
            this.GbFiltro.Controls.Add(this.CbTesla);
            this.GbFiltro.Controls.Add(this.GbEmpresa);
            this.GbFiltro.Controls.Add(this.Indicaciones);
            this.GbFiltro.Location = new System.Drawing.Point(16, 15);
            this.GbFiltro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GbFiltro.Name = "GbFiltro";
            this.GbFiltro.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GbFiltro.Size = new System.Drawing.Size(371, 650);
            this.GbFiltro.TabIndex = 2;
            this.GbFiltro.TabStop = false;
            this.GbFiltro.Text = "Filtro";
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Location = new System.Drawing.Point(8, 258);
            this.BtnActualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(328, 28);
            this.BtnActualizar.TabIndex = 10;
            this.BtnActualizar.Text = "Actualizar Lista";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // TbDuenio
            // 
            this.TbDuenio.Location = new System.Drawing.Point(175, 156);
            this.TbDuenio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TbDuenio.Name = "TbDuenio";
            this.TbDuenio.Size = new System.Drawing.Size(160, 22);
            this.TbDuenio.TabIndex = 9;
            // 
            // CbSpaceX
            // 
            this.CbSpaceX.FormattingEnabled = true;
            this.CbSpaceX.Items.AddRange(new object[] {
            "Starship",
            "Falcon 9"});
            this.CbSpaceX.Location = new System.Drawing.Point(175, 209);
            this.CbSpaceX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CbSpaceX.Name = "CbSpaceX";
            this.CbSpaceX.Size = new System.Drawing.Size(160, 24);
            this.CbSpaceX.TabIndex = 8;
            this.CbSpaceX.Visible = false;
            // 
            // LModelo
            // 
            this.LModelo.AutoSize = true;
            this.LModelo.Location = new System.Drawing.Point(56, 213);
            this.LModelo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LModelo.Name = "LModelo";
            this.LModelo.Size = new System.Drawing.Size(53, 16);
            this.LModelo.TabIndex = 6;
            this.LModelo.Text = "Modelo";
            // 
            // LDuenio
            // 
            this.LDuenio.AutoSize = true;
            this.LDuenio.Location = new System.Drawing.Point(21, 156);
            this.LDuenio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LDuenio.Name = "LDuenio";
            this.LDuenio.Size = new System.Drawing.Size(121, 16);
            this.LDuenio.TabIndex = 5;
            this.LDuenio.Text = "Nombre del Dueño";
            // 
            // CbTesla
            // 
            this.CbTesla.FormattingEnabled = true;
            this.CbTesla.Items.AddRange(new object[] {
            "Modelo X",
            "Modelo S",
            "Cybertruck"});
            this.CbTesla.Location = new System.Drawing.Point(175, 209);
            this.CbTesla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CbTesla.Name = "CbTesla";
            this.CbTesla.Size = new System.Drawing.Size(160, 24);
            this.CbTesla.TabIndex = 4;
            // 
            // GbEmpresa
            // 
            this.GbEmpresa.Controls.Add(this.RbSpaceX);
            this.GbEmpresa.Controls.Add(this.RbTesla);
            this.GbEmpresa.Location = new System.Drawing.Point(8, 57);
            this.GbEmpresa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GbEmpresa.Name = "GbEmpresa";
            this.GbEmpresa.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GbEmpresa.Size = new System.Drawing.Size(349, 69);
            this.GbEmpresa.TabIndex = 3;
            this.GbEmpresa.TabStop = false;
            this.GbEmpresa.Text = "A que empresa pertenece el vehículo a eliminar?";
            // 
            // RbSpaceX
            // 
            this.RbSpaceX.AutoSize = true;
            this.RbSpaceX.Location = new System.Drawing.Point(205, 34);
            this.RbSpaceX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RbSpaceX.Name = "RbSpaceX";
            this.RbSpaceX.Size = new System.Drawing.Size(76, 20);
            this.RbSpaceX.TabIndex = 2;
            this.RbSpaceX.Text = "SpaceX";
            this.RbSpaceX.UseVisualStyleBackColor = true;
            this.RbSpaceX.CheckedChanged += new System.EventHandler(this.RbSpaceX_CheckedChanged);
            // 
            // RbTesla
            // 
            this.RbTesla.AutoSize = true;
            this.RbTesla.Checked = true;
            this.RbTesla.Location = new System.Drawing.Point(39, 34);
            this.RbTesla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RbTesla.Name = "RbTesla";
            this.RbTesla.Size = new System.Drawing.Size(63, 20);
            this.RbTesla.TabIndex = 1;
            this.RbTesla.TabStop = true;
            this.RbTesla.Text = "Tesla";
            this.RbTesla.UseVisualStyleBackColor = true;
            this.RbTesla.CheckedChanged += new System.EventHandler(this.RbTesla_CheckedChanged);
            // 
            // Indicaciones
            // 
            this.Indicaciones.AutoSize = true;
            this.Indicaciones.Location = new System.Drawing.Point(4, 20);
            this.Indicaciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Indicaciones.Name = "Indicaciones";
            this.Indicaciones.Size = new System.Drawing.Size(331, 16);
            this.Indicaciones.TabIndex = 0;
            this.Indicaciones.Text = "Ingrese la información correspondiente a continuación:";
            // 
            // DgvTabla
            // 
            this.DgvTabla.AllowUserToAddRows = false;
            this.DgvTabla.BackgroundColor = System.Drawing.Color.Teal;
            this.DgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EliminarVehiculo});
            this.DgvTabla.Location = new System.Drawing.Point(396, 15);
            this.DgvTabla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DgvTabla.Name = "DgvTabla";
            this.DgvTabla.RowHeadersWidth = 51;
            this.DgvTabla.Size = new System.Drawing.Size(1376, 650);
            this.DgvTabla.TabIndex = 3;
            this.DgvTabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTabla_CellContentClick);
            // 
            // EliminarVehiculo
            // 
            this.EliminarVehiculo.HeaderText = "Eliminar";
            this.EliminarVehiculo.MinimumWidth = 6;
            this.EliminarVehiculo.Name = "EliminarVehiculo";
            this.EliminarVehiculo.Text = "Borrar";
            this.EliminarVehiculo.Width = 125;
            // 
            // Eliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1812, 684);
            this.Controls.Add(this.DgvTabla);
            this.Controls.Add(this.GbFiltro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Eliminar";
            this.Text = "Eliminar";
            this.Load += new System.EventHandler(this.Eliminar_Load);
            this.GbFiltro.ResumeLayout(false);
            this.GbFiltro.PerformLayout();
            this.GbEmpresa.ResumeLayout(false);
            this.GbEmpresa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox GbFiltro;
        private System.Windows.Forms.Label LDuenio;
        private System.Windows.Forms.GroupBox GbEmpresa;
        private System.Windows.Forms.RadioButton RbSpaceX;
        private System.Windows.Forms.RadioButton RbTesla;
        private System.Windows.Forms.Label Indicaciones;
        private System.Windows.Forms.TextBox TbDuenio;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.DataGridView DgvTabla;
        private System.Windows.Forms.ComboBox CbSpaceX;
        private System.Windows.Forms.Label LModelo;
        private System.Windows.Forms.ComboBox CbTesla;
        private System.Windows.Forms.DataGridViewButtonColumn EliminarVehiculo;
    }
}