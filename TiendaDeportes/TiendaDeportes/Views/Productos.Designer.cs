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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pnlDeportes = new System.Windows.Forms.GroupBox();
            this.grdDatos = new System.Windows.Forms.DataGridView();
            this.plnDeportes.SuspendLayout();
            this.pnlDeportes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // plnDeportes
            // 
            this.plnDeportes.Controls.Add(this.tbnLimpiar);
            this.plnDeportes.Controls.Add(this.btnBuscar);
            this.plnDeportes.Controls.Add(this.textBox2);
            this.plnDeportes.Controls.Add(this.textBox1);
            this.plnDeportes.Controls.Add(this.label1);
            this.plnDeportes.Controls.Add(this.lblNombre);
            this.plnDeportes.Location = new System.Drawing.Point(45, 35);
            this.plnDeportes.Name = "plnDeportes";
            this.plnDeportes.Size = new System.Drawing.Size(567, 164);
            this.plnDeportes.TabIndex = 0;
            this.plnDeportes.TabStop = false;
            this.plnDeportes.Text = "Gestion de deportes";
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(116, 92);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(180, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(116, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Precio";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(25, 38);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // pnlDeportes
            // 
            this.pnlDeportes.Controls.Add(this.grdDatos);
            this.pnlDeportes.Location = new System.Drawing.Point(45, 218);
            this.pnlDeportes.Name = "pnlDeportes";
            this.pnlDeportes.Size = new System.Drawing.Size(592, 241);
            this.pnlDeportes.TabIndex = 1;
            this.pnlDeportes.TabStop = false;
            this.pnlDeportes.Text = "Deportes";
            // 
            // grdDatos
            // 
            this.grdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDatos.Location = new System.Drawing.Point(3, 16);
            this.grdDatos.MultiSelect = false;
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDatos.Size = new System.Drawing.Size(586, 222);
            this.grdDatos.TabIndex = 0;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pnlDeportes);
            this.Controls.Add(this.plnDeportes);
            this.Enabled = false;
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
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
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox pnlDeportes;
        private System.Windows.Forms.DataGridView grdDatos;
    }
}