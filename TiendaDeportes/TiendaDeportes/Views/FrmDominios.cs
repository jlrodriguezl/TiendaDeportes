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
    public partial class FrmDominios : Form
    {
        public FrmDominios()
        {
            InitializeComponent();
        }

        private void FrmDominios_Load(object sender, EventArgs e)
        {
            this.txtIdDominio.Focus();
            refrescarTabla();
            
        }
        public void refrescarTabla()
        {
            using (tiendaEntities db = new tiendaEntities())
            {
                var lstDominios = from d in db.DOMINIOS
                                  select new
                                  {
                                      ID_DOMINIO = d.ID_DOMINIO,
                                      TIPO_DOMINIO = d.TIPO_DOMINIO,
                                      VLR_DOMINIO = d.VLR_DOMINIO
                                  };
                grdDominios.DataSource = lstDominios.ToList();
            }
        }

        private void BtmBuscar_Click(object sender, EventArgs e)
        {
            using (tiendaEntities db = new tiendaEntities())
            {
                //consultar todos los dominios a través de LINQ
                var lstDominios = from d in db.DOMINIOS
                                     select new
                                     {
                                         ID_DOMINIO = d.ID_DOMINIO,
                                         TIPO_DOMINIO = d.TIPO_DOMINIO,
                                         VLR_DOMINIO = d.VLR_DOMINIO
                                     };

                //Aplicar filtros dependiendo de lo que haya escrito o seleccionado el usuario
                if (!string.IsNullOrEmpty(this.txtIdDominio.Text))
                {
                    //filtrar por nombre de ID de dominio a través de EF
                    lstDominios = lstDominios.Where(d => d.ID_DOMINIO.Contains(this.txtIdDominio.Text));
                }
                if (!string.IsNullOrEmpty(this.txtTipoDominio.Text))
                {
                    //filtrar por nombre de tipo de dominio a través de EF
                    lstDominios = lstDominios.Where(d => d.TIPO_DOMINIO.Contains(this.txtTipoDominio.Text));
                }
                if (!string.IsNullOrEmpty(this.txtVlrDominio.Text))
                {
                    //filtrar por nombre de valor de dominio a través de EF
                    lstDominios = lstDominios.Where(d => d.VLR_DOMINIO.Contains(this.txtVlrDominio.Text));
                }


                grdDominios.DataSource = lstDominios.ToList();
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtIdDominio.Text = "";
            this.txtTipoDominio.Text = "";
            this.txtVlrDominio.Text = "";
            refrescarTabla();
        }
    }
}
