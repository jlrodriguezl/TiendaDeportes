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
    public partial class FrmCategorias : Form
    {
        public FrmCategorias()
        {
            InitializeComponent();
        }

        public void listCategorias()
        {
            using(tiendaEntities db = new tiendaEntities())
            {
                var lstCategorias = from f in db.CATEGORIAS
                                     select new
                                     {
                                         ID_CATEGORIA = f.ID_CATEGORIA,
                                         NOM_CATEGORIA = f.NOM_CATEGORIA,
                                         ID_CATEGORIA_PADRE = f.ID_CATEGORIA_PADRE
                                     };
                grdDatos.DataSource = lstCategorias.ToList();
            }
        }

        public void listarCategorias()
        {
            using (tiendaEntities db = new tiendaEntities())
            {
                var firstItem = new List<dynamic>()
                {
                    new { ID_CATEGORIA = 0, NOM_CATEGORIA = "Todos"}
                };

                //Escribir consulta a BD con LINQ
                var lstCategorias = (from p1 in firstItem select p1).Union(from p in db.CATEGORIAS
                                                                           select new
                                                                           {
                                                                            ID_CATEGORIA =    p.ID_CATEGORIA,
                                                                            NOM_CATEGORIA = p.NOM_CATEGORIA
                                                                        });
                this.cboCategoria.DataSource = lstCategorias.ToList();
                this.cboCategoria.DisplayMember = "NOM_CATEGORIA";
                this.cboCategoria.ValueMember = "ID_CATEGORIA";
                
            }
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            listCategorias();
            listarCategorias();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            using (tiendaEntities db = new tiendaEntities())
            {
                //consultar todos los fabricantes a través de LINQ
                var lstCategorias = from f in db.CATEGORIAS
                                    select new
                                    {
                                        ID_CATEGORIA = f.ID_CATEGORIA,
                                        NOM_CATEGORIA = f.NOM_CATEGORIA,
                                        ID_CATEGORIA_PADRE = f.ID_CATEGORIA_PADRE
                                    };

                //Aplicar filtros dependiendo de lo que haya escrito o seleccionado el usuario
                if (!string.IsNullOrEmpty(this.txtNombre.Text))
                {
                    //filtrar por nombre de fabricante a través de EF
                    lstCategorias = lstCategorias.Where(f => f.NOM_CATEGORIA.Contains(this.txtNombre.Text));
                }
                if (!this.cboCategoria.SelectedValue.ToString().Equals("0") )
                {
                    //filtrar por pais de fabricante a través de EF
                    lstCategorias = lstCategorias.Where(p =>
                                p.ID_CATEGORIA_PADRE.Equals(this.cboCategoria.SelectedValue));
                }

                grdDatos.DataSource = lstCategorias.ToList();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.txtNombre.Text = "";
            this.cboCategoria.SelectedValue = "0";
            listarCategorias();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmCategoriasGestion frmCategoriasGestion = new FrmCategoriasGestion();
            frmCategoriasGestion.ShowDialog();
            listCategorias();
        }
    }
    
}
