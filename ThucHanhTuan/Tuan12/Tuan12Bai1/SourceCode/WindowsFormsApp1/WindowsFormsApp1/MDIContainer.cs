using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class MDIContainer : Form {
        public MDIContainer() {
            InitializeComponent();
        }

        private void newFileToolStripMenuItem_Click(object sender,EventArgs e) {

            MyForm childform = new MyForm();
            childform.MdiParent=this;
            childform.Show();
        }

        private void openFileToolStripMenuItem_Click(object sender,EventArgs e) {
            OpenFileDialog openFileDialog1.InitialDirectory=Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog1.RestoreDirectory=true;
            openFileDialog1.Filter="Text Files (*.txt)|*.txt| Rich Text Format (*.rtf)|*.rtf|"+"All Files (*.*)|*.*";









        }
    }
