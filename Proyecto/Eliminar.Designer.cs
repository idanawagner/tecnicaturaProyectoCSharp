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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GbFiltro = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TbDuenio = new System.Windows.Forms.TextBox();
            this.LDuenio = new System.Windows.Forms.Label();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.GbEmpresa = new System.Windows.Forms.GroupBox();
            this.RbSpaceX = new System.Windows.Forms.RadioButton();
            this.RbTesla = new System.Windows.Forms.RadioButton();
            this.DgvTabla = new System.Windows.Forms.DataGridView();
            this.EliminarVehiculo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.GbFiltro.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.GbEmpresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // GbFiltro
            // 
            this.GbFiltro.Controls.Add(this.groupBox1);
            this.GbFiltro.Controls.Add(this.BtnActualizar);
            this.GbFiltro.Controls.Add(this.GbEmpresa);
            this.GbFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbFiltro.Location = new System.Drawing.Point(44, 33);
            this.GbFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.GbFiltro.Name = "GbFiltro";
            this.GbFiltro.Padding = new System.Windows.Forms.Padding(4);
            this.GbFiltro.Size = new System.Drawing.Size(324, 713);
            this.GbFiltro.TabIndex = 2;
            this.GbFiltro.TabStop = false;
            this.GbFiltro.Text = "Filtros";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TbDuenio);
            this.groupBox1.Controls.Add(this.LDuenio);
            this.groupBox1.Location = new System.Drawing.Point(34, 176);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 118);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar por dueño:";
            // 
            // TbDuenio
            // 
            this.TbDuenio.Location = new System.Drawing.Point(30, 68);
            this.TbDuenio.Margin = new System.Windows.Forms.Padding(4);
            this.TbDuenio.Name = "TbDuenio";
            this.TbDuenio.Size = new System.Drawing.Size(190, 26);
            this.TbDuenio.TabIndex = 9;
            // 
            // LDuenio
            // 
            this.LDuenio.AutoSize = true;
            this.LDuenio.Location = new System.Drawing.Point(7, 34);
            this.LDuenio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LDuenio.Name = "LDuenio";
            this.LDuenio.Size = new System.Drawing.Size(73, 20);
            this.LDuenio.TabIndex = 5;
            this.LDuenio.Text = "Nombre:";
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Location = new System.Drawing.Point(34, 333);
            this.BtnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(255, 28);
            this.BtnActualizar.TabIndex = 10;
            this.BtnActualizar.Text = "Actualizar Lista";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // GbEmpresa
            // 
            this.GbEmpresa.Controls.Add(this.RbSpaceX);
            this.GbEmpresa.Controls.Add(this.RbTesla);
            this.GbEmpresa.Location = new System.Drawing.Point(34, 45);
            this.GbEmpresa.Margin = new System.Windows.Forms.Padding(4);
            this.GbEmpresa.Name = "GbEmpresa";
            this.GbEmpresa.Padding = new System.Windows.Forms.Padding(4);
            this.GbEmpresa.Size = new System.Drawing.Size(255, 93);
            this.GbEmpresa.TabIndex = 3;
            this.GbEmpresa.TabStop = false;
            this.GbEmpresa.Text = "Filtrar por tipo de vehículo";
            // 
            // RbSpaceX
            // 
            this.RbSpaceX.AutoSize = true;
            this.RbSpaceX.Location = new System.Drawing.Point(132, 34);
            this.RbSpaceX.Margin = new System.Windows.Forms.Padding(4);
            this.RbSpaceX.Name = "RbSpaceX";
            this.RbSpaceX.Size = new System.Drawing.Size(88, 24);
            this.RbSpaceX.TabIndex = 2;
            this.RbSpaceX.Text = "SpaceX";
            this.RbSpaceX.UseVisualStyleBackColor = true;
            this.RbSpaceX.CheckedChanged += new System.EventHandler(this.RbSpaceX_CheckedChanged);
            // 
            // RbTesla
            // 
            this.RbTesla.AutoSize = true;
            this.RbTesla.Checked = true;
            this.RbTesla.Location = new System.Drawing.Point(30, 34);
            this.RbTesla.Margin = new System.Windows.Forms.Padding(4);
            this.RbTesla.Name = "RbTesla";
            this.RbTesla.Size = new System.Drawing.Size(71, 24);
            this.RbTesla.TabIndex = 1;
            this.RbTesla.TabStop = true;
            this.RbTesla.Text = "Tesla";
            this.RbTesla.UseVisualStyleBackColor = true;
            this.RbTesla.CheckedChanged += new System.EventHandler(this.RbTesla_CheckedChanged);
            // 
            // DgvTabla
            // 
            this.DgvTabla.AllowUserToAddRows = false;
            this.DgvTabla.AllowUserToDeleteRows = false;
            this.DgvTabla.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.DgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EliminarVehiculo});
            this.DgvTabla.Location = new System.Drawing.Point(387, 59);
            this.DgvTabla.Margin = new System.Windows.Forms.Padding(4);
            this.DgvTabla.Name = "DgvTabla";
            this.DgvTabla.ReadOnly = true;
            this.DgvTabla.RowHeadersWidth = 10;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvTabla.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvTabla.RowTemplate.Height = 33;
            this.DgvTabla.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvTabla.Size = new System.Drawing.Size(952, 658);
            this.DgvTabla.TabIndex = 3;
            this.DgvTabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTabla_CellContentClick);
            // 
            // EliminarVehiculo
            // 
            this.EliminarVehiculo.HeaderText = "Eliminar";
            this.EliminarVehiculo.MinimumWidth = 6;
            this.EliminarVehiculo.Name = "EliminarVehiculo";
            this.EliminarVehiculo.ReadOnly = true;
            this.EliminarVehiculo.Text = "Borrar";
            this.EliminarVehiculo.Width = 70;
            // 
            // Eliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1812, 805);
            this.Controls.Add(this.DgvTabla);
            this.Controls.Add(this.GbFiltro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Eliminar";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Eliminar";
            this.Load += new System.EventHandler(this.Eliminar_Load);
            this.GbFiltro.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.TextBox TbDuenio;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.DataGridView DgvTabla;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewButtonColumn EliminarVehiculo;
    }
}