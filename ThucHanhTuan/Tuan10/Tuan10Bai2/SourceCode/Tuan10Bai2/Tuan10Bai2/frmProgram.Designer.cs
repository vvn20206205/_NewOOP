namespace Tuan10Bai2 {
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
            this.pnlAbove = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtMeaning = new System.Windows.Forms.TextBox();
            this.txtxWord = new System.Windows.Forms.TextBox();
            this.lblMean = new System.Windows.Forms.Label();
            this.lblWord = new System.Windows.Forms.Label();
            this.lblAddNewWord = new System.Windows.Forms.Label();
            this.pnlBelow = new System.Windows.Forms.Panel();
            this.lsbMeaning = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lsbWord = new System.Windows.Forms.ListBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnlAbove.SuspendLayout();
            this.pnlBelow.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAbove
            // 
            this.pnlAbove.Controls.Add(this.btnAdd);
            this.pnlAbove.Controls.Add(this.txtMeaning);
            this.pnlAbove.Controls.Add(this.txtxWord);
            this.pnlAbove.Controls.Add(this.lblMean);
            this.pnlAbove.Controls.Add(this.lblWord);
            this.pnlAbove.Controls.Add(this.lblAddNewWord);
            this.pnlAbove.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAbove.Location = new System.Drawing.Point(0, 0);
            this.pnlAbove.Name = "pnlAbove";
            this.pnlAbove.Size = new System.Drawing.Size(321, 134);
            this.pnlAbove.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(88, 105);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtMeaning
            // 
            this.txtMeaning.Location = new System.Drawing.Point(88, 70);
            this.txtMeaning.Name = "txtMeaning";
            this.txtMeaning.Size = new System.Drawing.Size(203, 20);
            this.txtMeaning.TabIndex = 4;
            // 
            // txtxWord
            // 
            this.txtxWord.Location = new System.Drawing.Point(88, 31);
            this.txtxWord.Name = "txtxWord";
            this.txtxWord.Size = new System.Drawing.Size(203, 20);
            this.txtxWord.TabIndex = 3;
            // 
            // lblMean
            // 
            this.lblMean.AutoSize = true;
            this.lblMean.Location = new System.Drawing.Point(44, 70);
            this.lblMean.Name = "lblMean";
            this.lblMean.Size = new System.Drawing.Size(37, 13);
            this.lblMean.TabIndex = 2;
            this.lblMean.Text = "Mean:";
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Location = new System.Drawing.Point(44, 34);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(36, 13);
            this.lblWord.TabIndex = 1;
            this.lblWord.Text = "Word:";
            // 
            // lblAddNewWord
            // 
            this.lblAddNewWord.AutoSize = true;
            this.lblAddNewWord.Location = new System.Drawing.Point(12, 9);
            this.lblAddNewWord.Name = "lblAddNewWord";
            this.lblAddNewWord.Size = new System.Drawing.Size(81, 13);
            this.lblAddNewWord.TabIndex = 0;
            this.lblAddNewWord.Text = "-Add new word-";
            // 
            // pnlBelow
            // 
            this.pnlBelow.Controls.Add(this.lsbMeaning);
            this.pnlBelow.Controls.Add(this.btnRemove);
            this.pnlBelow.Controls.Add(this.lsbWord);
            this.pnlBelow.Controls.Add(this.txtSearch);
            this.pnlBelow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBelow.Location = new System.Drawing.Point(0, 134);
            this.pnlBelow.Name = "pnlBelow";
            this.pnlBelow.Size = new System.Drawing.Size(321, 245);
            this.pnlBelow.TabIndex = 1;
            // 
            // lsbMeaning
            // 
            this.lsbMeaning.FormattingEnabled = true;
            this.lsbMeaning.Location = new System.Drawing.Point(169, 41);
            this.lsbMeaning.Name = "lsbMeaning";
            this.lsbMeaning.Size = new System.Drawing.Size(140, 186);
            this.lsbMeaning.TabIndex = 8;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(234, 9);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lsbWord
            // 
            this.lsbWord.FormattingEnabled = true;
            this.lsbWord.Location = new System.Drawing.Point(24, 41);
            this.lsbWord.Name = "lsbWord";
            this.lsbWord.Size = new System.Drawing.Size(139, 186);
            this.lsbWord.TabIndex = 1;
            this.lsbWord.SelectedValueChanged += new System.EventHandler(this.lsbWord_SelectedValueChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(24, 9);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(139, 20);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // frmProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 379);
            this.Controls.Add(this.pnlBelow);
            this.Controls.Add(this.pnlAbove);
            this.Name = "frmProgram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vũ Văn Nghĩa 20206205 Dictionary";
            this.pnlAbove.ResumeLayout(false);
            this.pnlAbove.PerformLayout();
            this.pnlBelow.ResumeLayout(false);
            this.pnlBelow.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAbove;
        private System.Windows.Forms.Panel pnlBelow;
        private System.Windows.Forms.Label lblMean;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Label lblAddNewWord;
        private System.Windows.Forms.TextBox txtMeaning;
        private System.Windows.Forms.TextBox txtxWord;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ListBox lsbWord;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListBox lsbMeaning;

    }
}

