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
    public partial class FrmFabricantesGestion : Form
    {
        FABRICANTES oFabricantes = null;
        private int? idFabricante;

        public FrmFabricantesGestion(int? idFabricante)
        {
            //Dibujar el formulario
            InitializeComponent();
            //Recibir el dato de la PK (Si es nulo es modo inserción)
            this.idFabricante = idFabricante;

            //Si hay datos (edición)
            if(idFabricante != null)
            {
                cargarDatos();
            }
        }

        private void cargarDatos()
        {
            using (tiendaEntities db = new tiendaEntities())
            {
                //Consultar datos a editar de la base de datos
                oFabricantes = db.FABRICANTES.Find(idFabricante);
                txtNombre.Text = oFabricantes.NOM_FABRICANTE;               
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
                                                                       select new
                                                                       {
                                                                           ID_DOMINIO = p.ID_DOMINIO,
                                                                           VLR_DOMINIO = p.VLR_DOMINIO
                                                                       });
                this.cboPais.DataSource = lstPaises.ToList();
                this.cboPais.DisplayMember = "VLR_DOMINIO";
                this.cboPais.ValueMember = "ID_DOMINIO";
            }
        }

        private void FrmFabricantesGestion_Load(object sender, EventArgs e)
        {
            listarPaises();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(this.txtNombre.Text) ||
               this.cboPais.SelectedValue.ToString() == "T")
            {
                MessageBox.Show("Los campos marcados con (*) son obligatorios");
            }
            else
            {
                using (tiendaEntities db = new tiendaEntities())
                {
                    //Si es modo inserción, inicializamos el objeto de fabricantes
                    if(this.idFabricante == null)
                    {
                        oFabricantes = new FABRICANTES();
                    }
                    //Armar el objeto con los datos registrados en el formulario
                    oFabricantes.NOM_FABRICANTE = this.txtNombre.Text;
                    oFabricantes.PAIS_FABRICANTE = this.cboPais.SelectedValue.ToString();

                    if(this.idFabricante == null)
                    {
                        //Insertar nuevo fabricante
                        db.FABRICANTES.Add(oFabricantes);
                    }
                    else
                    {
                        //Modificar fabricante existente
                        db.Entry(oFabricantes).State = System.Data.Entity.EntityState.Modified;
                    }

                    //Confirmar cambios en la BD
                    db.SaveChanges();
                    //Cerrar formulario de gestión de fabricantes
                    this.Close();
                }
            }
        }
    }
}
