using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using is_takip_proje.Entity;

namespace is_takip_proje.Formlar
{
    public partial class FormGorev : Form
    {
        public FormGorev()
        {
            InitializeComponent();
        }

        DbisTakipEntities db = new DbisTakipEntities();

        private void ButtonVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonKaydet_Click(object sender, EventArgs e)
        {
            TblGorevler t = new TblGorevler();
            t.GorevVeren = 1;
            t.Aciklama = TxtAciklama.Text;
            t.Durum = true;
            t.GorevAlan = int.Parse(lookUpEdit1.EditValue.ToString());
            t.Tarih = DateTime.Parse(TxtTarih.Text);
            db.TblGorevler.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Görev başarılı bir şekilde tanımlandı", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void FormGorev_Load(object sender, EventArgs e)
        {
            var degerler = (from x in db.TblPersonel
                            select new
                            {
                                x.ID,
                                AdSoyad = x.Ad + x.Soyad
                            }).ToList();
            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "AdSoyad";
            lookUpEdit1.Properties.DataSource = degerler;
        }
    }
}
