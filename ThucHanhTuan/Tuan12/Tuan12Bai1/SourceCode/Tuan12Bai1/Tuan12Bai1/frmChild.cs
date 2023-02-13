using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan12Bai1 {
    public partial class frmChild : Form {
        public frmChild() {
            InitializeComponent();
        }

        private void newFileToolStripMenuItem_Click(object sender,EventArgs e) {
            frmChild childform = new frmChild();
            childform.MdiParent=this;
            childform.Show();
        }
    }
}
