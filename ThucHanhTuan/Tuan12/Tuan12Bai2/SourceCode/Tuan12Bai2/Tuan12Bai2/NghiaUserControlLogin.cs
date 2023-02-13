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
    public partial class NghiaUserControlLogin : UserControl {
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;

        public NghiaUserControlLogin() {
            label1=new Label();
            label2=new Label();
            textBox1=new TextBox();
            textBox2=new TextBox();
            button1=new Button();
            button2=new Button();

            label1.Text="User Name:";
            label2.Text="Password:";
            button1.Text="Log In";
            button2.Text="Cancel";

            label1.Location=new System.Drawing.Point(10,10);
            label2.Location=new System.Drawing.Point(10,40);
            textBox1.Location=new System.Drawing.Point(80,10);
            textBox2.Location=new System.Drawing.Point(80,40);
            button1.Location=new System.Drawing.Point(80,70);
            button2.Location=new System.Drawing.Point(160,70);

            label1.Size=new System.Drawing.Size(70,13);
            label2.Size=new System.Drawing.Size(70,13);
            textBox1.Size=new System.Drawing.Size(100,20);
            textBox2.Size=new System.Drawing.Size(100,20);
            button1.Size=new System.Drawing.Size(75,23);
            button2.Size=new System.Drawing.Size(75,23);

            this.Controls.Add(label1);
            this.Controls.Add(label2);
            this.Controls.Add(textBox1);
            this.Controls.Add(textBox2);
            this.Controls.Add(button1);
            this.Controls.Add(button2);

            this.Size=new System.Drawing.Size(250,100);

            button1.Click+=new EventHandler(Button1_Click);
            button2.Click+=new EventHandler(Button2_Click);
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
        private void Button1_Click(object sender,EventArgs e) {
            if(string.IsNullOrEmpty(textBox1.Text)||string.IsNullOrEmpty(textBox2.Text)) {
                NoInput?.Invoke(this,EventArgs.Empty);
            } else {
                LogInClick?.Invoke(this,EventArgs.Empty);
            }
        }

        private void Button2_Click(object sender,EventArgs e) {
            CancelClick?.Invoke(this,EventArgs.Empty);
        }

    }
}
