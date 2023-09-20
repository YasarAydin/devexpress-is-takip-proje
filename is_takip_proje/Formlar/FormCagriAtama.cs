using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace is_takip_proje.Formlar
{
    public partial class FormCagriAtama : Form
    {
        public FormCagriAtama()
        {
            InitializeComponent();
        }

        public int id;
        private void FormCagriAtama_Load(object sender, EventArgs e)
        {
            TxtCagriID.Text = id.ToString();
        }
    }
}
