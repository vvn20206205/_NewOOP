﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tuan10Bai1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private void Form1_Load(object sender,EventArgs e) {
        }

        private void btnMC_Click(object sender,EventArgs e) {
                       MessageBox.Show("Chưa phát triển?");
        }
        private void btnMR_Click(object sender,EventArgs e) {
                       MessageBox.Show("Chưa phát triển?");
        }
        private void btnMS_Click(object sender,EventArgs e) {
                       MessageBox.Show("Chưa phát triển?");
        }
        private void btnMplus_Click(object sender,EventArgs e) {
                       MessageBox.Show("Chưa phát triển?");
        } 
        private void btnBackspace_Click(object sender,EventArgs e) {
            txtResult.Text=txtResult.Text.Substring(0,txtResult.Text.Length-1);
        }

        private void btnCE_Click(object sender,EventArgs e) {
            txtResult.Text="";
        }

        private void btnC_Click(object sender,EventArgs e) {
            txtResult.Text="";
        }


        private void btnPhanTram_Click(object sender,EventArgs e) {
            txtResult.Text+="%";
        }

        private void btnCong_Click(object sender,EventArgs e) {
            txtResult.Text+="+";
        }
        private void btnTru_Click(object sender,EventArgs e) {
            txtResult.Text+="-";
        }
        private void btnNhan_Click(object sender,EventArgs e) {
            txtResult.Text+="*";
        }
        private void btnChia_Click(object sender,EventArgs e) {
            txtResult.Text+="/";
        }

        private void btnDot_Click(object sender,EventArgs e) {
            txtResult.Text+=".";
        }

        private void btn0_Click(object sender,EventArgs e) {
            txtResult.Text+="0";

        }
        private void btn1_Click(object sender,EventArgs e) {
            txtResult.Text+="1";

        }

        private void btn2_Click(object sender,EventArgs e) {
            txtResult.Text+="2";

        }

        private void btn3_Click(object sender,EventArgs e) {
            txtResult.Text+="3";

        }
        private void btn4_Click(object sender,EventArgs e) {
            txtResult.Text+="4";

        }

        private void btn5_Click(object sender,EventArgs e) {
            txtResult.Text+="5";

        }

        private void btn6_Click(object sender,EventArgs e) {
            txtResult.Text+="6";

        }
        private void btn7_Click(object sender,EventArgs e) {
            txtResult.Text+="7";
        }

        private void btn8_Click(object sender,EventArgs e) {
            txtResult.Text+="8";

        }

        private void btn9_Click(object sender,EventArgs e) {
            txtResult.Text+="9";

        }
        private void btnResult_Click(object sender,EventArgs e) {
            txtResult.Text=txtResult.Text.Replace("%","/100");
            System.Data.DataTable table = new System.Data.DataTable();
            double _result = Convert.ToDouble(table.Compute(txtResult.Text," "));
            txtResult.Text=(_result).ToString(); 
        }
        private void btnsqrt_Click(object sender,EventArgs e) {
            MessageBox.Show("Chưa phát triển?");
        }

        private void btnNghichDao_Click(object sender,EventArgs e) {
            MessageBox.Show("Chưa phát triển?");
        }

        private void btnCongTru_Click(object sender,EventArgs e) {
            MessageBox.Show("Chưa phát triển?");
        }
    }
}
