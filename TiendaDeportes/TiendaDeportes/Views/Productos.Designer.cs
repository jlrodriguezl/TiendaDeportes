namespace TiendaDeportes.Views
{
    partial class Productos
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
            this.plnDeportes = new System.Windows.Forms.GroupBox();
            this.tbnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pnlDeportes = new System.Windows.Forms.GroupBox();
            this.grdDatos = new System.Windows.Forms.DataGridView();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.tbnEliminar = new System.Windows.Forms.Button();
            this.plnDeportes.SuspendLayout();
            this.pnlDeportes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // plnDeportes
            // 
            this.plnDeportes.Controls.Add(this.cboCategoria);
            this.plnDeportes.Controls.Add(this.tbnLimpiar);
            this.plnDeportes.Controls.Add(this.btnBuscar);
            this.plnDeportes.Controls.Add(this.txtNombre);
            this.plnDeportes.Controls.Add(this.lblCategoria);
            this.plnDeportes.Controls.Add(this.lblNombre);
            this.plnDeportes.Location = new System.Drawing.Point(45, 35);
            this.plnDeportes.Name = "plnDeportes";
            this.plnDeportes.Size = new System.Drawing.Size(567, 164);
            this.plnDeportes.TabIndex = 0;
            this.plnDeportes.TabStop = false;
            this.plnDeportes.Text = "Gestion de productos";
            // 
            // tbnLimpiar
            // 
            this.tbnLimpiar.Location = new System.Drawing.Point(453, 66);
            this.tbnLimpiar.Name = "tbnLimpiar";
            this.tbnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.tbnLimpiar.TabIndex = 2;
            this.tbnLimpiar.Text = "Limpiar";
            this.tbnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(350, 66);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(116, 38);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(180, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(25, 95);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 0;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(25, 38);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // pnlDeportes
            // 
            this.pnlDeportes.Controls.Add(this.grdDatos);
            this.pnlDeportes.Location = new System.Drawing.Point(45, 218);
            this.pnlDeportes.Name = "pnlDeportes";
            this.pnlDeportes.Size = new System.Drawing.Size(592, 241);
            this.pnlDeportes.TabIndex = 1;
            this.pnlDeportes.TabStop = false;
            this.pnlDeportes.Text = "productos";
            // 
            // grdDatos
            // 
            this.grdDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDatos.Location = new System.Drawing.Point(3, 16);
            this.grdDatos.MultiSelect = false;
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDatos.Size = new System.Drawing.Size(586, 222);
            this.grdDatos.TabIndex = 0;
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(116, 86);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(121, 21);
            this.cboCategoria.TabIndex = 3;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(45, 465);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(136, 465);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(236, 465);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 2;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            // 
            // tbnEliminar
            // 
            this.tbnEliminar.Location = new System.Drawing.Point(331, 465);
            this.tbnEliminar.Name = "tbnEliminar";
            this.tbnEliminar.Size = new System.Drawing.Size(75, 23);
            this.tbnEliminar.TabIndex = 2;
            this.tbnEliminar.Text = "Eliminar";
            this.tbnEliminar.UseVisualStyleBackColor = true;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(834, 494);
            this.ControlBox = false;
            this.Controls.Add(this.tbnEliminar);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.pnlDeportes);
            this.Controls.Add(this.plnDeportes);
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load_1);
            this.plnDeportes.ResumeLayout(false);
            this.plnDeportes.PerformLayout();
            this.pnlDeportes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox plnDeportes;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button tbnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.GroupBox pnlDeportes;
        private System.Windows.Forms.DataGridView grdDatos;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button tbnEliminar;
    }
}