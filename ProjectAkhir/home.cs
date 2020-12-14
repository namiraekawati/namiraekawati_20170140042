using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAkhir
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

       

        private void lokasiDalamNegeriToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            DalamNegeri dn = new DalamNegeri();
            dn.Tag = this;
            dn.Show(this);
            Hide();
        }

        private void lokasiLuarNegeriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LuarNegeri ln = new LuarNegeri();
            ln.Tag = this;
            ln.Show(this);
            Hide();
        }

        private void createDataToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void keluarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
