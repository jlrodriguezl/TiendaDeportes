namespace TiendaDeportes.Views
{
    partial class FrmFabricantes
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
            this.pnlFiltro = new System.Windows.Forms.GroupBox();
            this.pnlDatos = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cboPais = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.grdDatos = new System.Windows.Forms.DataGridView();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.pnlFiltro.SuspendLayout();
            this.pnlDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFiltro
            // 
            this.pnlFiltro.Controls.Add(this.btnLimpiar);
            this.pnlFiltro.Controls.Add(this.btnBuscar);
            this.pnlFiltro.Controls.Add(this.cboPais);
            this.pnlFiltro.Controls.Add(this.txtNombre);
            this.pnlFiltro.Controls.Add(this.lblPais);
            this.pnlFiltro.Controls.Add(this.lblNombre);
            this.pnlFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pnlFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlFiltro.Location = new System.Drawing.Point(13, 13);
            this.pnlFiltro.Name = "pnlFiltro";
            this.pnlFiltro.Size = new System.Drawing.Size(534, 113);
            this.pnlFiltro.TabIndex = 0;
            this.pnlFiltro.TabStop = false;
            this.pnlFiltro.Text = "Filtros";
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.grdDatos);
            this.pnlDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pnlDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlDatos.Location = new System.Drawing.Point(13, 169);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(578, 256);
            this.pnlDatos.TabIndex = 1;
            this.pnlDatos.TabStop = false;
            this.pnlDatos.Text = "Fabricantes";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(7, 31);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 15);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(10, 75);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(39, 15);
            this.lblPais.TabIndex = 1;
            this.lblPais.Text = "País:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(76, 31);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 21);
            this.txtNombre.TabIndex = 2;
            // 
            // cboPais
            // 
            this.cboPais.FormattingEnabled = true;
            this.cboPais.Location = new System.Drawing.Point(76, 75);
            this.cboPais.Name = "cboPais";
            this.cboPais.Size = new System.Drawing.Size(200, 23);
            this.cboPais.TabIndex = 3;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(298, 47);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 30);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(418, 47);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 30);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // grdDatos
            // 
            this.grdDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDatos.Location = new System.Drawing.Point(3, 17);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.Size = new System.Drawing.Size(572, 236);
            this.grdDatos.TabIndex = 0;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(16, 451);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(100, 30);
            this.btnRegresar.TabIndex = 2;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            // 
            // FrmFabricantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 496);
            this.ControlBox = false;
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.pnlFiltro);
            this.Name = "FrmFabricantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Fabricantes";
            this.pnlFiltro.ResumeLayout(false);
            this.pnlFiltro.PerformLayout();
            this.pnlDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox pnlFiltro;
        private System.Windows.Forms.GroupBox pnlDatos;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cboPais;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridView grdDatos;
        private System.Windows.Forms.Button btnRegresar;
    }
}