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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        public void refrescarTabla()

        {
            using (tiendaEntities db = new tiendaEntities())
            {
                var listProductos = from f in db.PRODUCTOS
                                      select new
                                      {
                                          id_producto = f.ID_PRODUCTO,
                                          nombre_producto = f.NOM_PRODUCTO,
                                          precio_productos = f.PRECIO_ACTUAL,
                                      };
                grdDatos.DataSource = listProductos.ToList();
            }
        }
        public void listarproductos()
        {
            using (tiendaEntities db = new tiendaEntities())
            {
                var firstIem = new List<dynamic>()
                {
                    new{
                        ID_PRODUCTO =0,CATEGORIAS= "TODOS"
                    }
                };
                
                var lisCATEGORIAS = (from p1 in firstIem select p1).Union(from p in db.PRODUCTOS
                                                                     
                                                                           orderby p.ID_PRODUCTO
                                                                           orderby p.NOM_PRODUCTO.Equals("Nombre_PRODUCTO")
                                                                           orderby p.NOM_PRODUCTO
                                                                         

                                                                    select new
                                                                      {
                                                                          ID_PRODUCTO = p.ID_PRODUCTO,
                                                                          NOMBRE_PRODUCTO =p.NOM_PRODUCTO
                                                                          

                                                                      });
                this.cboCategoria.DataSource = lisCATEGORIAS.ToList();
                this.cboCategoria.DisplayMember = "Nombre_PRODUCTO";
                this.cboCategoria.DisplayMember = "ID_PRODUCTO";


            }

        }

        private PRODUCTOS getSelectedItem()
        {
            PRODUCTOS F = new PRODUCTOS();
            try
            {
                F.ID_PRODUCTO= int.Parse(grdDatos.Rows[grdDatos.CurrentRow.Index].Cells[0].Value.ToString());
                return F;

            }
            catch
            {
                return null;
            }
        }

        
        private void Productos_Load_1(object sender, EventArgs e)
        {
            refrescarTabla();
            listarproductos();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (tiendaEntities db = new tiendaEntities())

            {
               
                var listproductos = from f in db.PRODUCTOS
                                      select new
                                      {


                                          id_productos = f.ID_PRODUCTO,
                                          nombre_producto = f.NOM_PRODUCTO,
                                          precio_producto = f.PRECIO_ACTUAL
                                      };
                
                if (!string.IsNullOrEmpty(this.txtNombre.Text))
                {
                   
                    listproductos = listproductos.Where(f => f.nombre_producto.Contains(this.txtNombre.Text));
                }
                if (!this.cboCategoria.SelectedValue.ToString().Equals("T"))
                {
                    listproductos = listproductos.Where(f =>
                     f.precio_producto.Equals(this.cboCategoria.SelectedValue.ToString()));
                }
                grdDatos.DataSource = listproductos.ToList();
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNombre.Text = "";
            this.cboCategoria.SelectedValue = "";
            refrescarTabla();
        }

        
        }
    }



