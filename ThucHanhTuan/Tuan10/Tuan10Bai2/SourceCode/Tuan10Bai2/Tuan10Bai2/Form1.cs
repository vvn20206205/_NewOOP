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
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        List<string> words = new List<string>();
        List<string> meanings = new List<string>();

        private void button1_Click(object sender,EventArgs e) {
            words .Add(wordTextBox.Text);
            wordListBox.Items.Add(wordTextBox.Text);
            meanings .Add(meaningTextBox.Text);
            meaningListBox.Items.Add(meaningTextBox.Text);

            wordTextBox.Clear();
            meaningTextBox.Clear();
        }

        private void button2_Click(object sender,EventArgs e) {

 

                int selectedIndex = wordListBox.SelectedIndex;
            words. RemoveAt(selectedIndex);
            wordListBox.Items.RemoveAt(selectedIndex);
            meanings .RemoveAt(selectedIndex);
            meaningListBox.Items.RemoveAt(selectedIndex);

        }

        private void textBox3_TextChanged(object sender,EventArgs e) {
            string searchText = textBox3.Text;

            wordListBox.Items.Clear();
            meaningListBox.Items.Clear();

            for(int i = 0;i<words.Count;i++) {
                string word = words[i];
                string meaning = meanings[i];
                if(word.Contains(searchText)||meaning.Contains(searchText)) {
                    wordListBox.Items.Add(word);
                    meaningListBox.Items.Add(meaning);
                }
            }
        }
        private void wordListBox_SelectedValueChanged(object sender,EventArgs e) {
            int selectedIndex = wordListBox.SelectedIndex;
            meaningListBox.SelectedIndex=selectedIndex;
        }
    }
}
