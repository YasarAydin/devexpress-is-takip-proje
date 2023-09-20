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
    public partial class FormDepartmanlar : Form
    {
        public FormDepartmanlar()
        {
            InitializeComponent();
        }

        DbisTakipEntities db = new DbisTakipEntities();

        void Listele()
        {           
            var degerler = (from x in db.TblDepartmanlar
                            select new
                            {
                                x.ID,
                                x.AD
                            }).ToList();
            gridControl1.DataSource = degerler;
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            TblDepartmanlar t = new TblDepartmanlar();
            t.AD = TxtAd.Text;
            db.TblDepartmanlar.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Departman başarılı bir şekilde sisteme kaydedildi", "Bilgi", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int x = int.Parse(TxtID.Text);
            var deger = db.TblDepartmanlar.Find(x);
            db.TblDepartmanlar.Remove(deger);
            db.SaveChanges();
            XtraMessageBox.Show("Departman başarılı bir şekilde sistemden silindi", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Listele();
        }

        private void gridView1_FocusedRowChanged(object sender, 
            DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int x = int.Parse(TxtID.Text);
            var deger = db.TblDepartmanlar.Find(x);
            deger.AD = TxtAd.Text;
            db.SaveChanges();
            XtraMessageBox.Show("Departman başarılı bir şekilde güncellendi", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Listele();
        }
    }
}
