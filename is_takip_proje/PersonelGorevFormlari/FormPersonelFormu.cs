using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace is_takip_proje.PersonelGorevFormlari
{
    public partial class FormPersonelFormu : Form
    {
        public FormPersonelFormu()
        {
            InitializeComponent();
        }

        public string mail;

        private void btnAktifGorevler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PersonelGorevFormlari.FormAktifGorevler frm = new PersonelGorevFormlari.FormAktifGorevler();
            frm.MdiParent = this;
            frm.mail2 = mail;
            frm.Show();
        }

        private void btnPasifGorevler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PersonelGorevFormlari.FormPasifGorevler frm = new PersonelGorevFormlari.FormPasifGorevler();
            frm.MdiParent = this;
            frm.mail2 = mail;
            frm.Show();
        }

        private void btnCagriListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PersonelGorevFormlari.FromCagriKabul frm = new PersonelGorevFormlari.FromCagriKabul();
            frm.MdiParent = this;
            frm.mail2 = mail;
            frm.Show();
        }

        private void FormPersonelFormu_Load(object sender, EventArgs e)
        {
           // this.Text = mail.ToString();
        }
    }
}
