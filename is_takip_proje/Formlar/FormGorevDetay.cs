using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using is_takip_proje.Entity;

namespace is_takip_proje.Formlar
{
    public partial class FormGorevDetay : Form
    {
        public FormGorevDetay()
        {
            InitializeComponent();
        }

        DbisTakipEntities db = new DbisTakipEntities();

        private void FormGorevDetay_Load(object sender, EventArgs e)
        {
            db.TblGorevDetaylar.Load();
            bindingSource1.DataSource = db.TblGorevDetaylar.Local;
        }

        private void gridView1_CellValueChanged(object sender, 
            DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            db.SaveChanges();
        }

        private void gridView1_CellValueChanging(object sender, 
            DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            
        }

        private void görevDetaySilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingSource1.RemoveCurrent(); // üzerinde tıklanmış olan satırı sil
            db.SaveChanges();
        }
    }
}
