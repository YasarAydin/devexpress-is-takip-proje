using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using is_takip_proje.Entity;

namespace is_takip_proje.Formlar
{
    public partial class FormGorevListesi : Form
    {
        public FormGorevListesi()
        {
            InitializeComponent();
        }

        DbisTakipEntities db = new DbisTakipEntities();

        private void FormGorevListesi_Load(object sender, EventArgs e)
        {
            var degerler = (from x in db.TblGorevler
                            select new
                            {
                                x.Aciklama
                            }).ToList();
            gridControl1.DataSource = degerler;

            LblAktifGorevsayisi.Text = db.TblGorevler.Where(x => x.Durum == true).Count().ToString();
            LblPasifGorevSayisi.Text = db.TblGorevler.Where(x => x.Durum == false).Count().ToString();
            LblToplamDepartman.Text = db.TblDepartmanlar.Count().ToString();

            chartControl1.Series["Durum"].Points.AddPoint("Aktif Görevler", int.Parse(LblAktifGorevsayisi.Text));
            chartControl1.Series["Durum"].Points.AddPoint("Pasif Görevler", int.Parse(LblPasifGorevSayisi.Text));
        }
    }
}
