using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace is_takip_proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Formlar.FromAnaForm frm1;
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm1 == null || frm1.IsDisposed)
            {
                frm1 = new Formlar.FromAnaForm();
                frm1.MdiParent = this;
                frm1.Show();
            }
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormDepartmanlar frm = new Formlar.FormDepartmanlar();
            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnPersonelListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormPersoneller frm = new Formlar.FormPersoneller();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormPersonelistatistik frm = new Formlar.FormPersonelistatistik();
            frm.MdiParent = this;
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Formlar.FormGorevListesi frm;
        private void BtnGorevListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm == null || frm.IsDisposed)
            {
                frm = new Formlar.FormGorevListesi();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void BtnYeniGorevTanimla_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormGorev frm = new Formlar.FormGorev();
            frm.Show();
        }

        private void BtnGorevDetay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormGorevDetay frm = new Formlar.FormGorevDetay();
            frm.Show();
        }

        Formlar.FormAktifCagrilar frmAktifCagrilar;
        private void btnAktifCagrilar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            if (frmAktifCagrilar == null || frmAktifCagrilar.IsDisposed)
            {
                frmAktifCagrilar = new Formlar.FormAktifCagrilar();
                frmAktifCagrilar.MdiParent = this;
                frmAktifCagrilar.Show();
            }
        }
    }
}
