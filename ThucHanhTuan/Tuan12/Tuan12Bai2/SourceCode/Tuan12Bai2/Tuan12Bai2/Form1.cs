using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan12Bai2 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            logInControl1.NoInput+=LoginControl1_NoInput;
            logInControl1.LogInClick+=LoginControl1_LogInClick;
            logInControl1.CancelClick+=LoginControl1_CancelClick;
        }

        private void LoginControl1_NoInput(object sender,EventArgs e) {
            MessageBox.Show("Please enter a username and password");
        }

        private void LoginControl1_LogInClick(object sender,EventArgs e) {
            MessageBox.Show("Log In clicked");
        }

        private void LoginControl1_CancelClick(object sender,EventArgs e) {
            MessageBox.Show("Cancel clicked");
        }
    }
}
