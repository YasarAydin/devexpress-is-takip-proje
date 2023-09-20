using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Data.WcfLinq.Helpers;
using is_takip_proje.Entity;
using is_takip_proje.Formlar;

namespace is_takip_proje.Formlar
{
    public partial class FormPersonelistatistik : Form
    {
        public FormPersonelistatistik()
        {
            InitializeComponent();
        }

        DbisTakipEntities db = new DbisTakipEntities();

        private void FormPersonelistatistik_Load(object sender, EventArgs e)
        {
            LblToplamDepartman.Text = db.TblDepartmanlar.Count().ToString();
            LblToplamPersonel.Text = db.TblPersonel.Count().ToString();
            LblFirmalar.Text = db.TblFirmalar.Count().ToString();


            LblAktifis.Text = db.TblGorevler.Count(x => x.Durum == true).ToString();
            LblPasifis.Text = db.TblGorevler.Count(x => x.Durum == false).ToString();
            LblSonGorev.Text = db.TblGorevler.OrderByDescending(x => x.ID)
                .Select(x => x.Aciklama).FirstOrDefault();

            LblSonGorevTarih.Text = db.TblGorevDetaylar.OrderByDescending(x => x.ID).Select(x => x.Tarih)
                .FirstOrDefault().ToString();

            LblSehirSayisi.Text = db.TblFirmalar.Select(x=>x.il).Distinct()
                .Count().ToString();

            LblSektorSayisi.Text = db.TblFirmalar.Select(x => x.Sektor).Distinct()
                .Count().ToString();

            DateTime bugun = DateTime.Today;
            LblBugunAcilanGorevler.Text = db.TblGorevler.Count(x => x.Tarih == bugun).ToString();


            var d1 = db.TblGorevler.GroupBy(x => x.GorevAlan)
                .OrderByDescending(z => z.Count()).Select(y => y.Key).FirstOrDefault();
            LblAyinPersoneli.Text = db.TblPersonel.Where(x=>x.ID == d1)
                .Select(y => y.Ad + " " + y.Soyad).FirstOrDefault().ToString();

            LblAyinDepartmani.Text = db.TblDepartmanlar.Where(x => x.ID == db.TblPersonel
                .Where(t => t.ID == d1).Select(z => z.Departman).FirstOrDefault())
                .Select(y => y.AD).FirstOrDefault().ToString();
           
              
        }

        private void LblAyinDepartmani_Click(object sender, EventArgs e)
        {

        }
    }
}
