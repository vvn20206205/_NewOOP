namespace Tuan12Bai2 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing&&(components!=null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.logInControl1 = new Tuan12Bai2.LogInControl();
            this.SuspendLayout();
            // 
            // logInControl1
            // 
            this.logInControl1.CancelText = "button2";
            this.logInControl1.Location = new System.Drawing.Point(30, 26);
            this.logInControl1.LogInText = "button1";
            this.logInControl1.Name = "logInControl1";
            this.logInControl1.PasswordText = "label2";
            this.logInControl1.Size = new System.Drawing.Size(150, 150);
            this.logInControl1.TabIndex = 0;
            this.logInControl1.UserNameText = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logInControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private LogInControl logInControl1;
    }
}

