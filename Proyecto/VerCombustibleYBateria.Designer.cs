namespace Proyecto_2_Tema_2
{
    partial class VerCombustibleYBateria
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
            this.BActualizar = new System.Windows.Forms.Button();
            this.GbFiltro = new System.Windows.Forms.GroupBox();
            this.CbCombustible = new System.Windows.Forms.CheckBox();
            this.CbBateria = new System.Windows.Forms.CheckBox();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DgvTabla = new System.Windows.Forms.DataGridView();
            this.GbFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // BActualizar
            // 
            this.BActualizar.Location = new System.Drawing.Point(12, 127);
            this.BActualizar.Name = "BActualizar";
            this.BActualizar.Size = new System.Drawing.Size(116, 23);
            this.BActualizar.TabIndex = 5;
            this.BActualizar.Text = "Actualizar";
            this.BActualizar.UseVisualStyleBackColor = true;
            this.BActualizar.Click += new System.EventHandler(this.BActualizar_Click);
            // 
            // GbFiltro
            // 
            this.GbFiltro.Controls.Add(this.CbCombustible);
            this.GbFiltro.Controls.Add(this.CbBateria);
            this.GbFiltro.Location = new System.Drawing.Point(12, 12);
            this.GbFiltro.Name = "GbFiltro";
            this.GbFiltro.Size = new System.Drawing.Size(116, 100);
            this.GbFiltro.TabIndex = 3;
            this.GbFiltro.TabStop = false;
            this.GbFiltro.Text = "Filtro de Búsqueda";
            // 
            // CbCombustible
            // 
            this.CbCombustible.AutoSize = true;
            this.CbCombustible.Location = new System.Drawing.Point(6, 67);
            this.CbCombustible.Name = "CbCombustible";
            this.CbCombustible.Size = new System.Drawing.Size(83, 17);
            this.CbCombustible.TabIndex = 1;
            this.CbCombustible.Text = "Combustible";
            this.CbCombustible.UseVisualStyleBackColor = true;
            // 
            // CbBateria
            // 
            this.CbBateria.AutoSize = true;
            this.CbBateria.Location = new System.Drawing.Point(6, 33);
            this.CbBateria.Name = "CbBateria";
            this.CbBateria.Size = new System.Drawing.Size(61, 17);
            this.CbBateria.TabIndex = 0;
            this.CbBateria.Text = "Batería";
            this.CbBateria.UseVisualStyleBackColor = true;
            // 
            // DgvTabla
            // 
            this.DgvTabla.BackgroundColor = System.Drawing.Color.Teal;
            this.DgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTabla.Location = new System.Drawing.Point(139, 20);
            this.DgvTabla.Name = "DgvTabla";
            this.DgvTabla.Size = new System.Drawing.Size(969, 341);
            this.DgvTabla.TabIndex = 6;
            // 
            // VerCombustibleYBateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1116, 374);
            this.Controls.Add(this.DgvTabla);
            this.Controls.Add(this.BActualizar);
            this.Controls.Add(this.GbFiltro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VerCombustibleYBateria";
            this.Text = "Ver Combustible y Batería";
            this.Load += new System.EventHandler(this.VerCombustibleYBateria_Load);
            this.GbFiltro.ResumeLayout(false);
            this.GbFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BActualizar;
        private System.Windows.Forms.GroupBox GbFiltro;
        private System.Windows.Forms.CheckBox CbCombustible;
        private System.Windows.Forms.CheckBox CbBateria;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private System.Windows.Forms.DataGridView DgvTabla;
    }
}