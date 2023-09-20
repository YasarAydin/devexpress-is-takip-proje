using DevExpress.XtraEditors;
using is_takip_proje.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace is_takip_proje.Login
{
    public partial class FromLogin : Form
    {
        public FromLogin()
        {
            InitializeComponent();
        }

        DbisTakipEntities db = new DbisTakipEntities();

        private void FromLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var adminvalue = db.TblAdmin.Where(x => x.Kullanici == txtEditKullaniciAdi.Text 
            && x.Sifre == txtEditSifre.Text).FirstOrDefault();
            if (adminvalue != null)
            {
                XtraMessageBox.Show("Hoşgeldiniz");
                Form1 fr = new Form1();
                fr.Show();
                this.Hide();
            }
            else 
            {
                XtraMessageBox.Show("Hatalı Giriş");
            }
        }

        private void btnPersonel_Click(object sender, EventArgs e)
        {
            var personel = db.TblPersonel.Where(x => x.Mail == txtEditKullaniciAdi.Text
            && x.Sifre == txtEditSifre.Text).FirstOrDefault();
            if (personel != null)
            {
                PersonelGorevFormlari.FormPersonelFormu fr = new PersonelGorevFormlari.FormPersonelFormu();
                fr.mail = txtEditKullaniciAdi.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                XtraMessageBox.Show("Hatalı Giriş");
            }
        }
    }
}
