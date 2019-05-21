namespace TiendaDeportes.Views
{
    partial class FrmCategorias
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
            this.pnlCategorias = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCatPadre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCatPadre = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlListCategorias = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlCategorias.SuspendLayout();
            this.pnlListCategorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCategorias
            // 
            this.pnlCategorias.Controls.Add(this.button1);
            this.pnlCategorias.Controls.Add(this.btnBuscar);
            this.pnlCategorias.Controls.Add(this.txtCatPadre);
            this.pnlCategorias.Controls.Add(this.txtNombre);
            this.pnlCategorias.Controls.Add(this.lblCatPadre);
            this.pnlCategorias.Controls.Add(this.lblNombre);
            this.pnlCategorias.Location = new System.Drawing.Point(32, 31);
            this.pnlCategorias.Name = "pnlCategorias";
            this.pnlCategorias.Size = new System.Drawing.Size(734, 191);
            this.pnlCategorias.TabIndex = 0;
            this.pnlCategorias.TabStop = false;
            this.pnlCategorias.Text = "Categorias";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(15, 36);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 17);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCatPadre
            // 
            this.lblCatPadre.AutoSize = true;
            this.lblCatPadre.Location = new System.Drawing.Point(15, 95);
            this.lblCatPadre.Name = "lblCatPadre";
            this.lblCatPadre.Size = new System.Drawing.Size(130, 17);
            this.lblCatPadre.TabIndex = 1;
            this.lblCatPadre.Text = "Id Categoria Padre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(83, 36);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 22);
            this.txtNombre.TabIndex = 2;
            // 
            // txtCatPadre
            // 
            this.txtCatPadre.Location = new System.Drawing.Point(151, 95);
            this.txtCatPadre.Name = "txtCatPadre";
            this.txtCatPadre.Size = new System.Drawing.Size(132, 22);
            this.txtCatPadre.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(356, 67);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 50);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(506, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pnlListCategorias
            // 
            this.pnlListCategorias.Controls.Add(this.dataGridView1);
            this.pnlListCategorias.Location = new System.Drawing.Point(32, 243);
            this.pnlListCategorias.Name = "pnlListCategorias";
            this.pnlListCategorias.Size = new System.Drawing.Size(734, 195);
            this.pnlListCategorias.TabIndex = 1;
            this.pnlListCategorias.TabStop = false;
            this.pnlListCategorias.Text = "Lista de categorias";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 41);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(697, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // FrmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pnlListCategorias);
            this.Controls.Add(this.pnlCategorias);
            this.Name = "FrmCategorias";
            this.Text = "FrmCategorias";
            this.pnlCategorias.ResumeLayout(false);
            this.pnlCategorias.PerformLayout();
            this.pnlListCategorias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox pnlCategorias;
        private System.Windows.Forms.Label lblCatPadre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtCatPadre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox pnlListCategorias;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}