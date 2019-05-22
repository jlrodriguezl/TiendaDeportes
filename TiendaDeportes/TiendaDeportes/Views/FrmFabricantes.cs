using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiendaDeportes.Models;

namespace TiendaDeportes.Views
{
    public partial class FrmFabricantes : Form
    {
        public FrmFabricantes()
        {
            InitializeComponent();
        }
        #region helper
        public void refrescarTabla() {
            using (tiendaEntities db = new tiendaEntities())
            {
                var lstFabricantes = from f in db.CATEGORIAS
                                     select new {
                                         
                                     };
                grdDatos.DataSource = lstFabricantes.ToList();
            }
        }

        public void listarPaises()
        {
            using (tiendaEntities db = new tiendaEntities())
            {
                var firstItem = new List<dynamic>()
                {
                    new { ID_DOMINIO = "T", VLR_DOMINIO = "Todos"}
                };

                //Escribir consulta a BD con LINQ
                var lstPaises = (from p1 in firstItem select p1).Union(from p in db.DOMINIOS
                                where p.TIPO_DOMINIO.Equals("PAISES")
                                orderby p.VLR_DOMINIO
                                select new {
                                    ID_DOMINIO = p.ID_DOMINIO,
                                    VLR_DOMINIO = p.VLR_DOMINIO
                                });
                this.cboPais.DataSource = lstPaises.ToList();
                this.cboPais.DisplayMember = "VLR_DOMINIO";
                this.cboPais.ValueMember = "ID_DOMINIO";
            }
        }

        private FABRICANTES getSelectedItem()
        {
            FABRICANTES f = new FABRICANTES();
            try
            {
                f.ID_FABRICANTE = int.Parse(grdDatos.Rows[grdDatos.CurrentRow.Index].Cells[0].Value.ToString());
                return f;
            }
            catch
            {
                return null;
            }
        }
        #endregion

        private void FrmFabricantes_Load(object sender, EventArgs e)
        {
            refrescarTabla();
            this.txtNombre.Focus();
            listarPaises();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (tiendaEntities db = new tiendaEntities())
            {
                //consultar todos los fabricantes a través de LINQ
                var lstFabricantes = from f in db.FABRICANTES
                                     select new
                                     {
                                         ID_FABRICANTE = f.ID_FABRICANTE,
                                         NOM_FABRICANTE = f.NOM_FABRICANTE,
                                         PAIS_FABRICANTE = f.PAIS_FABRICANTE
                                     };

                //Aplicar filtros dependiendo de lo que haya escrito o seleccionado el usuario
                if (!string.IsNullOrEmpty(this.txtNombre.Text))
                {
                    //filtrar por nombre de fabricante a través de EF
                    lstFabricantes = lstFabricantes.Where(f => f.NOM_FABRICANTE.Contains(this.txtNombre.Text));
                }
                if (!this.cboPais.SelectedValue.ToString().Equals("T"))
                {
                    //filtrar por pais de fabricante a través de EF
                    lstFabricantes = lstFabricantes.Where(f => 
                                f.PAIS_FABRICANTE.Equals(this.cboPais.SelectedValue.ToString()));
                }

                grdDatos.DataSource = lstFabricantes.ToList();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNombre.Text = "";
            this.cboPais.SelectedValue = "T";
            refrescarTabla();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmFabricantesGestion frmFabricantesGestion = new FrmFabricantesGestion(null);
            frmFabricantesGestion.ShowDialog();
            refrescarTabla();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Retornar valor seleccionado en la tabla
            FABRICANTES f = getSelectedItem();
            if(f != null)
            {
                //Llamar formulario en modo edicion
                FrmFabricantesGestion frmFabricantesGestion = new FrmFabricantesGestion(f.ID_FABRICANTE);
                frmFabricantesGestion.ShowDialog();
                refrescarTabla();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Obtener la fila que se va a eliminar
            FABRICANTES f = this.getSelectedItem();
            //Validar si hubo selección
            if (f != null)
            {
                if (MessageBox.Show("Está seguro de eliminar este registro?",
                    "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    using (tiendaEntities db = new tiendaEntities())
                    {
                        //Buscar en la BD el fabricante a eliminar
                        FABRICANTES fabEliminar = db.FABRICANTES.Find(f.ID_FABRICANTE);
                        db.FABRICANTES.Remove(fabEliminar);
                        db.SaveChanges();
                    }
                    refrescarTabla();
                }
            }
        }
    }
}
