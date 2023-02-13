using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tuan12Bai2 {
    public partial class LogInControl : UserControl {
        public LogInControl() {
            InitializeComponent();
        }

        public string UserNameText {
            get { return label1.Text; }
            set { label1.Text=value; }
        }

        public string PasswordText {
            get { return label2.Text; }
            set { label2.Text=value; }
        }

        public string UserNameValue {
            get { return textBox1.Text; }
        }

        public string PasswordValue {
            get { return textBox2.Text; }
        }

        public string LogInText {
            get { return button1.Text; }
            set { button1.Text=value; }
        }

        public string CancelText {
            get { return button2.Text; }
            set { button2.Text=value; }
        }

        public event EventHandler NoInput;
        public event EventHandler LogInClick;
        public event EventHandler CancelClick;

        private void button1_Click(object sender,EventArgs e) {
            if(string.IsNullOrEmpty(textBox1.Text)||string.IsNullOrEmpty(textBox2.Text)) {
                NoInput?.Invoke(this,EventArgs.Empty);
            } else {
                LogInClick?.Invoke(this,EventArgs.Empty);
            }
        }

        private void button2_Click(object sender,EventArgs e) {
            CancelClick?.Invoke(this,EventArgs.Empty);
        }
    }
}
