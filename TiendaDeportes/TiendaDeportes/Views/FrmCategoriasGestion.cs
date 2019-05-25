﻿using System;
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
    public partial class FrmCategoriasGestion : Form
    {
        CATEGORIAS oCategorias = null;
        private int? idCategoria;
        
        public FrmCategoriasGestion(int? idCategoria )
        {
            //Dibujar el formulario
            InitializeComponent();
            //Recibir el dato de la PK (Si es nulo es modo inserción)
            this.idCategoria = idCategoria;

            //Si hay datos (edición)
            if (idCategoria != null)
            {
                cargarDatos();
            }
        }

        private void cargarDatos()
        {
            using (tiendaEntities db = new tiendaEntities())
            {
                //Consultar datos a editar de la base de datos
                oCategorias = db.CATEGORIAS.Find(idCategoria);
                txtNomCategoria.Text = oCategorias.NOM_CATEGORIA;
                txtIdCatPadre.Text = oCategorias.ID_CATEGORIA_PADRE.ToString();
            }
        }

        public void listCategorias()
        {
            using (tiendaEntities db = new tiendaEntities())
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

        private void FrmCategoriasGestion_Load(object sender, EventArgs e)
        {
            listCategorias();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtNomCategoria.Text) ||
               string.IsNullOrEmpty(this.txtIdCatPadre.Text))
            {
                MessageBox.Show("Los campos marcados con (*) son obligatorios");
            }
            else
            {
                using (tiendaEntities db = new tiendaEntities())
                {
                    //Si es modo inserción, inicializamos el objeto de fabricantes
                    if (this.idCategoria == null)
                    {
                        oCategorias = new CATEGORIAS();
                    }
                    //Armar el objeto con los datos registrados en el formulario
                    oCategorias.NOM_CATEGORIA = this.txtNomCategoria.Text;
                    oCategorias.ID_CATEGORIA_PADRE = int.Parse(this.txtIdCatPadre.Text);

                    if (this.idCategoria == null)
                    {
                        //Insertar nuevo fabricante
                        db.CATEGORIAS.Add(oCategorias);
                    }
                    else
                    {
                        //Modificar fabricante existente
                        db.Entry(oCategorias).State = System.Data.Entity.EntityState.Modified;
                    }

                    //Confirmar cambios en la BD
                    db.SaveChanges();
                    //Cerrar formulario de gestión de fabricantes
                    this.Close();
                }
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
