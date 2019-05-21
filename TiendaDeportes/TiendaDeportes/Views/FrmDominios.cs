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

        public void refrescarTabla()
        {
            using (tiendaEntities db = new tiendaEntities())
            {
                var lstDominios= from d in db.DOMINIOS
                                     select new
                                     {
                                         ID_DOMINIO = d.ID_DOMINIO,
                                         TIPO_DOMINIO = d.TIPO_DOMINIO,
                                         VLR_DOMINIO = d.VLR_DOMINIO
                                     };
                grdDominios.DataSource = lstDominios.ToList();
            }
        }
        public void listarDominios()
        {
            using (tiendaEntities db = new tiendaEntities())
            {
             
                var firstItem = new List<dynamic>()
                {
                    new { ID_DOMINIO = "N", VLR_DOMINIO = "Ninguno"}
                };

                //Escribir consulta a BD con LINQ
                var lstDominios = (from d1 in firstItem select d1).Union(from d in db.DOMINIOS
                                                                       //where d.TIPO_DOMINIO.Equals("DOCUMENTO")
                                                                       orderby d.ID_DOMINIO
                                                                       select new
                                                                       {
                                                                           ID_DOMINIO = d.ID_DOMINIO,
                                                                           VLR_DOMINIO = d.VLR_DOMINIO
                                                                       });
                this.cboTipoDominio.DataSource = lstDominios.ToList();
                this.cboTipoDominio.DisplayMember = "VLR_DOMINIO";
                this.cboTipoDominio.ValueMember = "ID_DOMINIO";
            }
        }

        private void FrmDominios_Load(object sender, EventArgs e)
        {
            refrescarTabla();
            listarDominios();
        }
    }
}
