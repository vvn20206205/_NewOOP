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
            this.nghiaUserControlLogin3 = new Tuan12Bai2.NghiaUserControlLogin();
            this.nghiaUserControlLogin2 = new Tuan12Bai2.NghiaUserControlLogin();
            this.nghiaUserControlLogin1 = new Tuan12Bai2.NghiaUserControlLogin();
            this.SuspendLayout();
            // 
            // nghiaUserControlLogin3
            // 
            this.nghiaUserControlLogin3.CancelText = "Cancel";
            this.nghiaUserControlLogin3.Location = new System.Drawing.Point(50, 272);
            this.nghiaUserControlLogin3.LogInText = "Log In";
            this.nghiaUserControlLogin3.Name = "nghiaUserControlLogin3";
            this.nghiaUserControlLogin3.PasswordText = "Password:";
            this.nghiaUserControlLogin3.Size = new System.Drawing.Size(264, 95);
            this.nghiaUserControlLogin3.TabIndex = 2;
            this.nghiaUserControlLogin3.UserNameText = "User Name:";
            // 
            // nghiaUserControlLogin2
            // 
            this.nghiaUserControlLogin2.CancelText = "Cancel";
            this.nghiaUserControlLogin2.Location = new System.Drawing.Point(50, 154);
            this.nghiaUserControlLogin2.LogInText = "Log In";
            this.nghiaUserControlLogin2.Name = "nghiaUserControlLogin2";
            this.nghiaUserControlLogin2.PasswordText = "Password:";
            this.nghiaUserControlLogin2.Size = new System.Drawing.Size(264, 112);
            this.nghiaUserControlLogin2.TabIndex = 1;
            this.nghiaUserControlLogin2.UserNameText = "User Name:";
            // 
            // nghiaUserControlLogin1
            // 
            this.nghiaUserControlLogin1.CancelText = "Cancel";
            this.nghiaUserControlLogin1.Location = new System.Drawing.Point(50, 48);
            this.nghiaUserControlLogin1.LogInText = "Log In";
            this.nghiaUserControlLogin1.Name = "nghiaUserControlLogin1";
            this.nghiaUserControlLogin1.PasswordText = "Password:";
            this.nghiaUserControlLogin1.Size = new System.Drawing.Size(250, 100);
            this.nghiaUserControlLogin1.TabIndex = 0;
            this.nghiaUserControlLogin1.UserNameText = "User Name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 394);
            this.Controls.Add(this.nghiaUserControlLogin3);
            this.Controls.Add(this.nghiaUserControlLogin2);
            this.Controls.Add(this.nghiaUserControlLogin1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private NghiaUserControlLogin nghiaUserControlLogin1;
        private NghiaUserControlLogin nghiaUserControlLogin2;
        private NghiaUserControlLogin nghiaUserControlLogin3;
    }
}

