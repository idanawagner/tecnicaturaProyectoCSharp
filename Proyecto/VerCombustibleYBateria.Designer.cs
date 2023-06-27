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
            this.DgvTabla = new System.Windows.Forms.DataGridView();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GbFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BActualizar
            // 
            this.BActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BActualizar.Location = new System.Drawing.Point(92, 200);
            this.BActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.BActualizar.Name = "BActualizar";
            this.BActualizar.Size = new System.Drawing.Size(224, 28);
            this.BActualizar.TabIndex = 5;
            this.BActualizar.Text = "Actualizar";
            this.BActualizar.UseVisualStyleBackColor = true;
            this.BActualizar.Click += new System.EventHandler(this.BActualizar_Click);
            // 
            // GbFiltro
            // 
            this.GbFiltro.Controls.Add(this.CbCombustible);
            this.GbFiltro.Controls.Add(this.CbBateria);
            this.GbFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbFiltro.Location = new System.Drawing.Point(45, 46);
            this.GbFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.GbFiltro.Name = "GbFiltro";
            this.GbFiltro.Padding = new System.Windows.Forms.Padding(4);
            this.GbFiltro.Size = new System.Drawing.Size(324, 123);
            this.GbFiltro.TabIndex = 3;
            this.GbFiltro.TabStop = false;
            this.GbFiltro.Text = "Filtro de Búsqueda";
            // 
            // CbCombustible
            // 
            this.CbCombustible.AutoSize = true;
            this.CbCombustible.Location = new System.Drawing.Point(8, 82);
            this.CbCombustible.Margin = new System.Windows.Forms.Padding(4);
            this.CbCombustible.Name = "CbCombustible";
            this.CbCombustible.Size = new System.Drawing.Size(124, 24);
            this.CbCombustible.TabIndex = 1;
            this.CbCombustible.Text = "Combustible";
            this.CbCombustible.UseVisualStyleBackColor = true;
            // 
            // CbBateria
            // 
            this.CbBateria.AutoSize = true;
            this.CbBateria.Location = new System.Drawing.Point(8, 41);
            this.CbBateria.Margin = new System.Windows.Forms.Padding(4);
            this.CbBateria.Name = "CbBateria";
            this.CbBateria.Size = new System.Drawing.Size(85, 24);
            this.CbBateria.TabIndex = 0;
            this.CbBateria.Text = "Batería";
            this.CbBateria.UseVisualStyleBackColor = true;
            // 
            // DgvTabla
            // 
            this.DgvTabla.BackgroundColor = System.Drawing.Color.Teal;
            this.DgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTabla.Location = new System.Drawing.Point(391, 46);
            this.DgvTabla.Margin = new System.Windows.Forms.Padding(4);
            this.DgvTabla.Name = "DgvTabla";
            this.DgvTabla.RowHeadersWidth = 51;
            this.DgvTabla.Size = new System.Drawing.Size(962, 420);
            this.DgvTabla.TabIndex = 6;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataSource = typeof(Proyecto_2_Tema_2.Entidades.ProductosMusk.Producto);
            // 
            // VerCombustibleYBateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1599, 803);
            this.Controls.Add(this.DgvTabla);
            this.Controls.Add(this.BActualizar);
            this.Controls.Add(this.GbFiltro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VerCombustibleYBateria";
            this.Text = "Ver Combustible y Batería";
            this.Load += new System.EventHandler(this.VerCombustibleYBateria_Load);
            this.GbFiltro.ResumeLayout(false);
            this.GbFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
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