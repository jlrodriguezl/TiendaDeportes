namespace TiendaDeportes.Views
{
    partial class FrmCategoriasGestion
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
            this.grNuevo = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtIdCatPadre = new System.Windows.Forms.TextBox();
            this.txtNomCategoria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNomCategoria = new System.Windows.Forms.Label();
            this.grpCategorias = new System.Windows.Forms.GroupBox();
            this.grdDatos = new System.Windows.Forms.DataGridView();
            this.grNuevo.SuspendLayout();
            this.grpCategorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // grNuevo
            // 
            this.grNuevo.Controls.Add(this.btnGuardar);
            this.grNuevo.Controls.Add(this.btnCancelar);
            this.grNuevo.Controls.Add(this.txtIdCatPadre);
            this.grNuevo.Controls.Add(this.txtNomCategoria);
            this.grNuevo.Controls.Add(this.label1);
            this.grNuevo.Controls.Add(this.lblNomCategoria);
            this.grNuevo.Location = new System.Drawing.Point(15, 12);
            this.grNuevo.Name = "grNuevo";
            this.grNuevo.Size = new System.Drawing.Size(664, 140);
            this.grNuevo.TabIndex = 0;
            this.grNuevo.TabStop = false;
            this.grNuevo.Text = "Ingresar Datos";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(490, 37);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(116, 33);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(490, 93);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(116, 33);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // txtIdCatPadre
            // 
            this.txtIdCatPadre.Location = new System.Drawing.Point(164, 96);
            this.txtIdCatPadre.Name = "txtIdCatPadre";
            this.txtIdCatPadre.Size = new System.Drawing.Size(52, 22);
            this.txtIdCatPadre.TabIndex = 3;
            // 
            // txtNomCategoria
            // 
            this.txtNomCategoria.Location = new System.Drawing.Point(164, 42);
            this.txtNomCategoria.Name = "txtNomCategoria";
            this.txtNomCategoria.Size = new System.Drawing.Size(258, 22);
            this.txtNomCategoria.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id categoria padre";
            // 
            // lblNomCategoria
            // 
            this.lblNomCategoria.AutoSize = true;
            this.lblNomCategoria.Location = new System.Drawing.Point(17, 45);
            this.lblNomCategoria.Name = "lblNomCategoria";
            this.lblNomCategoria.Size = new System.Drawing.Size(141, 17);
            this.lblNomCategoria.TabIndex = 0;
            this.lblNomCategoria.Text = "Nombre de categoria";
            // 
            // grpCategorias
            // 
            this.grpCategorias.Controls.Add(this.grdDatos);
            this.grpCategorias.Location = new System.Drawing.Point(12, 158);
            this.grpCategorias.Name = "grpCategorias";
            this.grpCategorias.Size = new System.Drawing.Size(670, 280);
            this.grpCategorias.TabIndex = 1;
            this.grpCategorias.TabStop = false;
            this.grpCategorias.Text = "Categorias Existentes";
            // 
            // grdDatos
            // 
            this.grdDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDatos.Location = new System.Drawing.Point(3, 18);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.RowTemplate.Height = 24;
            this.grdDatos.Size = new System.Drawing.Size(664, 259);
            this.grdDatos.TabIndex = 0;
            // 
            // FrmCategoriasGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 450);
            this.ControlBox = false;
            this.Controls.Add(this.grpCategorias);
            this.Controls.Add(this.grNuevo);
            this.Name = "FrmCategoriasGestion";
            this.Text = "Gestion de categorias";
            this.Load += new System.EventHandler(this.FrmCategoriasGestion_Load);
            this.grNuevo.ResumeLayout(false);
            this.grNuevo.PerformLayout();
            this.grpCategorias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grNuevo;
        private System.Windows.Forms.Label lblNomCategoria;
        private System.Windows.Forms.TextBox txtIdCatPadre;
        private System.Windows.Forms.TextBox txtNomCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpCategorias;
        private System.Windows.Forms.DataGridView grdDatos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}