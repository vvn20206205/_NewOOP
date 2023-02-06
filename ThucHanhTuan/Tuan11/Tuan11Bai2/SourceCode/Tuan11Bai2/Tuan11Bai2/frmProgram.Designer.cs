namespace Tuan11Bai2 {
    partial class frmProgram {
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
            this.pnlFather = new System.Windows.Forms.Panel();
            this.tvFather = new System.Windows.Forms.TreeView();
            this.pnlChild = new System.Windows.Forms.Panel();
            this.lvChild = new System.Windows.Forms.ListView();
            this.pnlFather.SuspendLayout();
            this.pnlChild.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFather
            // 
            this.pnlFather.Controls.Add(this.tvFather);
            this.pnlFather.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlFather.Location = new System.Drawing.Point(0, 0);
            this.pnlFather.Name = "pnlFather";
            this.pnlFather.Size = new System.Drawing.Size(200, 450);
            this.pnlFather.TabIndex = 0;
            // 
            // tvFather
            // 
            this.tvFather.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvFather.Location = new System.Drawing.Point(0, 0);
            this.tvFather.Name = "tvFather";
            this.tvFather.Size = new System.Drawing.Size(200, 450);
            this.tvFather.TabIndex = 0;
            this.tvFather.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvFather_BeforeExpand);
            this.tvFather.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvFather_AfterSelect);
            // 
            // pnlChild
            // 
            this.pnlChild.Controls.Add(this.lvChild);
            this.pnlChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChild.Location = new System.Drawing.Point(200, 0);
            this.pnlChild.Name = "pnlChild";
            this.pnlChild.Size = new System.Drawing.Size(600, 450);
            this.pnlChild.TabIndex = 1;
            // 
            // lvChild
            // 
            this.lvChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvChild.HideSelection = false;
            this.lvChild.Location = new System.Drawing.Point(0, 0);
            this.lvChild.Name = "lvChild";
            this.lvChild.Size = new System.Drawing.Size(600, 450);
            this.lvChild.TabIndex = 0;
            this.lvChild.UseCompatibleStateImageBehavior = false;
            this.lvChild.View = System.Windows.Forms.View.List;
            // 
            // frmProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlChild);
            this.Controls.Add(this.pnlFather);
            this.Name = "frmProgram";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlFather.ResumeLayout(false);
            this.pnlChild.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFather;
        private System.Windows.Forms.TreeView tvFather;
        private System.Windows.Forms.Panel pnlChild;
        private System.Windows.Forms.ListView lvChild;
    }
}

