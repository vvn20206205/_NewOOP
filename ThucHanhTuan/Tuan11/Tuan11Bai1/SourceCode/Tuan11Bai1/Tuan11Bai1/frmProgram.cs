using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Tuan11Bai1 {
    public partial class frmProgram : Form {
        #region Fields
        ErrorProvider ErrorProvider = new ErrorProvider();
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




        private void Form1_Load(object sender,EventArgs e) {

            foreach(string itemCountry in CONFIG.COUNTRIES) {
                cboCountry.Items.Add(itemCountry);
            }
        }
        private void btnSave_Click(object sender,EventArgs e) {
            ErrorProvider.Clear();
            CheckEmail();
            CheckPhoneNo();
            CheckExtension();
            CheckPostalCode();
            CheckCountryComboBox();
            CheckAllTextBoxIsNullOrWhiteSpace();
            MessageBox.Show($"Information:"+
                $""+
                $"\nCustomer ID: {txtCustomerID.Text}"+
               $"\nCustomer Name: {txtCustomerName.Text}"+
               $"\nEmail: {txtEmail.Text}"+
               $"\nPhone No: {txtPhone.Text}"+
               $"\nExtension: {txtExtension.Text}"+
               $"\nAddress: {txtAddress.Text}"+
               $"\nCountry: {cboCountry.Text}"+
               $"\nPostal Code: {txtPostalCode.Text}"
           );
        }
        private void btnClose_Click(object sender,EventArgs e) {
            Application.Exit();
        }
        #region kiểm tra điều kiện
        private void CheckTextBoxIsNullOrWhiteSpace(TextBox objTextBox) {
            if(string.IsNullOrWhiteSpace(objTextBox.Text)) {
                ErrorProvider.SetError(objTextBox,"Nhập thông tin!");
            }
        }
        //Tất cả các trường đều yêu cầu nhập
        private void CheckAllTextBoxIsNullOrWhiteSpace() {
            foreach(Control itemControl in Controls) {
                if(itemControl is TextBox) {
                    CheckTextBoxIsNullOrWhiteSpace((TextBox)(itemControl));
                }
            }
        }
        //Customer ID chấp nhận tối đa 5 ký tự, tất cả các ký tự yêu cầu viết hoa
        private void textBox1_KeyPress(object sender,KeyPressEventArgs e) {
            if(char.IsLower(e.KeyChar)) {
                e.KeyChar=char.ToUpper(e.KeyChar);
            }
        }
        //Email cần đúng định dạng(hint: cần có dấu (@) và(.) ở các vị trí hợp lý)
        private void CheckEmail() {
            string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            Match match = Regex.Match(txtEmail.Text,pattern);
            if(!match.Success) {
                ErrorProvider.SetError(txtEmail,"Email cần đúng định dạng(hint: cần có dấu (@) và(.) ở các vị trí hợp lý)");
            }
        }
        //Phone no cần theo định dạng(000)-000-0000 với 0 biểu diễn cho 1 số 0-9 
        private void CheckPhoneNo() {
            if(!Regex.IsMatch(txtPhone.Text,@"^\(\d{3}\)\-\d{3}\-\d{4}$")) {
                ErrorProvider.SetError(txtPhone,"Phone no cần theo định dạng(000)-000-0000 với 0 biểu diễn cho 1 số 0-9 ");
            }
        }
        //Extension cần là số và tối đa 3 ký tự
        private void CheckExtension() {
            int number;
            if(!(int.TryParse(txtExtension.Text,out number))) {
                ErrorProvider.SetError(txtExtension,"Extension cần là số và tối đa 3 ký tự");
            }
        }
        // chứa một số lựa chọn về quốc và chỉ cho phép người sử dụng chọn trong đó không nhập được các quốc gia mới
        private void CheckCountryComboBox() {
            if(string.IsNullOrWhiteSpace(cboCountry.Text)) {
                ErrorProvider.SetError(cboCountry,"Lựa chọn về quốc gia!");
            }
        }
        //Postal code cần là số và chứa tối đa 3 ký tự
        private void CheckPostalCode() {
            int number;
            if(!(int.TryParse(txtPostalCode.Text,out number))) {
                ErrorProvider.SetError(txtPostalCode,"Postal code cần là số và chứa tối đa 3 ký tự");
            }
        }
        #endregion
        #endregion
    }
}
