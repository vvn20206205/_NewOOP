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
    public partial class frmMDIContainer : Form {
        public frmMDIContainer() {
            InitializeComponent();
        }
        private void MyNew() {
            frmChild childform = new frmChild();
            childform.MdiParent=this;
            childform.Show();
        }
        private void MyOpen() {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter="Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex=1;
            openFileDialog.RestoreDirectory=true;
            if(openFileDialog.ShowDialog()==DialogResult.OK) {
                frmChild frmChild = new frmChild();
                frmChild.MdiParent=this;
                frmChild.txtChild.LoadFile(openFileDialog.FileName,RichTextBoxStreamType.PlainText);
                frmChild.Text=openFileDialog.SafeFileName;
                frmChild.Show();
                saveCtrSDisabledToolStripMenuItem.Enabled=true;
                saveAsCtrADisabledToolStripMenuItem.Enabled=true;
                toolStripButton3.Enabled=true;
            }
        }
        private void MySave() {
            frmChild subForm = (frmChild)ActiveMdiChild;
            if(subForm!=null) {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter="Text files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.FilterIndex=1;
                saveFileDialog.RestoreDirectory=true;
                saveFileDialog.FileName=subForm.Text;

                if(saveFileDialog.ShowDialog()==DialogResult.OK) {
                    subForm.txtChild.SaveFile(saveFileDialog.FileName,RichTextBoxStreamType.PlainText);
                }
            }
        }
        private void newCtrNToolStripMenuItem_Click(object sender,EventArgs e) {
            MyOpen();
        }
        private void openCtrOToolStripMenuItem_Click(object sender,EventArgs e) {
            MyNew();
        }
        private void arrangeIconsToolStripMenuItem_Click(object sender,EventArgs e) {
            LayoutMdi(MdiLayout.Cascade);
        }
        private void cascadeToolStripMenuItem_Click(object sender,EventArgs e) {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }
        private void tileHorizontalToolStripMenuItem_Click(object sender,EventArgs e) {
            LayoutMdi(MdiLayout.TileHorizontal);
        }
        private void tileVerticalToolStripMenuItem_Click(object sender,EventArgs e) {
            LayoutMdi(MdiLayout.TileVertical);
        }
        private void toolStripButton1_Click(object sender,EventArgs e) {
            MyNew();
        }
        private void toolStripButton2_Click(object sender,EventArgs e) {
            MyOpen();
        }
        private void toolStripButton3_Click(object sender,EventArgs e) {
            MySave();
        }
        private void frmMDIContainer_MdiChildActivate(object sender,EventArgs e) {
            if(ActiveMdiChild==null) {
                saveCtrSDisabledToolStripMenuItem.Enabled=false;
                saveAsCtrADisabledToolStripMenuItem.Enabled=false;
                toolStripButton3.Enabled=false;
            } else {
                saveCtrSDisabledToolStripMenuItem.Enabled=true;
                saveAsCtrADisabledToolStripMenuItem.Enabled=true;
                toolStripButton3.Enabled=true;
            }
        }
        private void saveCtrSDisabledToolStripMenuItem_Click(object sender,EventArgs e) {
            MySave();
        }

        private void saveAsCtrADisabledToolStripMenuItem_Click(object sender,EventArgs e) {
            MySave();
        }
    }
}
