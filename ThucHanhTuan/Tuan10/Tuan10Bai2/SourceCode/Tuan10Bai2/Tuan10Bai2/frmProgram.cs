using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan10Bai2 {
    public partial class frmProgram : Form {
        #region Fields
        private List<string> words = new List<string>();
        private List<string> meanings = new List<string>();
        #endregion
        #region Properties
        #endregion
        #region Constructor
        public frmProgram() {
            InitializeComponent();
        }
        #endregion
        #region Methods
        #endregion
        #region Operator
        #endregion
        #region Events
        private void btnAdd_Click(object sender,EventArgs e) {
            words.Add(txtxWord.Text);
            lsbWord.Items.Add(txtxWord.Text);
            meanings.Add(txtMeaning.Text);
            lsbMeaning.Items.Add(txtMeaning.Text);

            txtxWord.Clear();
            txtMeaning.Clear();
        }

        private void btnRemove_Click(object sender,EventArgs e) {
            int _SelectedIndex = lsbWord.SelectedIndex;
            words.RemoveAt(_SelectedIndex);
            lsbWord.Items.RemoveAt(_SelectedIndex);
            meanings.RemoveAt(_SelectedIndex);
            lsbMeaning.Items.RemoveAt(_SelectedIndex);

        }

        private void txtSearch_TextChanged(object sender,EventArgs e) {
            string _SearchText = txtSearch.Text;

            lsbWord.Items.Clear();
            lsbMeaning.Items.Clear();

            for(int i = 0;i<words.Count;i++) {
                string word = words[i];
                string meaning = meanings[i];
                if(word.Contains(_SearchText)||meaning.Contains(_SearchText)) {
                    lsbWord.Items.Add(word);
                    lsbMeaning.Items.Add(meaning);
                }
            }
        }
        private void lsbWord_SelectedValueChanged(object sender,EventArgs e) {
            int selectedIndex = lsbWord.SelectedIndex;
            lsbMeaning.SelectedIndex=selectedIndex;
        }
        #endregion
    }
}
