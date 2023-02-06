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
    public partial class Form1 : Form {
        ErrorProvider gErrorProvider = new ErrorProvider();
        // Create an array of countries
        string[] countries = { "Vietnam","Afghanistan", "Albania", "Algeria",
            "Andorra", "Angola", "Antigua and Barbuda", "Argentina", 
            "Armenia", "Australia", "Austria", "Azerbaijan", "Bahamas", 
            "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin", "Bhutan",
            "Bolivia", "Bosnia and Herzegovina", "Botswana", "Brazil", "Brunei", "Bulgaria", "Burkina Faso",
            "Burundi", "Cabo Verde", "Cambodia", "Cameroon", "Canada", "Central African Republic", "Chad",
            "Chile", "China", "Colombia", "Comoros", "Congo", "Costa Rica", "Croatia", "Cuba", "Cyprus", 
            "Czech Republic", "Democratic Republic of the Congo", "Denmark", "Djibouti", "Dominica", "Dominican Republic",
            "Ecuador", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Eswatini", "Ethiopia", "Fiji",
            "Finland", "France", "Gabon", "Gambia", "Georgia", "Germany", "Ghana", "Greece", "Grenada", "Guatemala", "Guinea",
            "Guinea-Bissau", "Guyana", "Haiti", "Honduras", "Hungary", "Iceland", "India", "Indonesia", "Iran", "Iraq",
            "Ireland", "Israel", "Italy", "Ivory Coast", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya", "Kiribati", 
            "Kosovo", "Kuwait", "Kyrgyzstan", "Laos", "Latvia", "Lebanon", "Lesotho", "Liberia", "Libya", "Liechtenstein", 
            "Lithuania", "Luxembourg", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands",
            "Mauritania", "Mauritius", "Mexico", "Micronesia", "Moldova", "Monaco", "Mongolia", "Montenegro", "Morocco",
            "Mozambique", "Myanmar", "Namibia", "Nauru", "Nepal", "Netherlands", "New Zealand", "Nicaragua", "Niger", "Nigeria",
            "North Korea", "North Macedonia", "Norway", "Oman", "Pakistan", "Palau", "Panama", "Papua New Guinea", "Paraguay",
            "Peru", "Philippines", "Poland", "Portugal", "Qatar", "Romania", "Russia", "Rwanda", "Saint Kitts and Nevis", 
            "Saint Lucia", "Saint Vincent and the Grenadines", "Samoa", "San Marino", "Sao Tome and Principe", "Saudi Arabia",
            "Senegal", "Serbia", "Seychelles", "Sierra Leone","Singapore", "Slovakia", "Slovenia", "Solomon Islands",
            "Somalia", "South Africa", "South Korea", "South Sudan", "Spain", "Sri Lanka", "Sudan", "Suriname", "Sweden",
            "Switzerland", "Syria", "Taiwan", "Tajikistan", "Tanzania", "Thailand", "Timor-Leste", "Togo", "Tonga", 
            "Trinidad and Tobago", "Tunisia", "Turkey", "Turkmenistan", "Tuvalu", "Uganda", "Ukraine", "United Arab Emirates",
            "United Kingdom", "United States", "Uruguay", "Uzbekistan", "Vanuatu", "Vatican City", "Venezuela",
            "Yemen", "Zambia", "Zimbabwe"};

    public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender,EventArgs e) {

            foreach(string country in countries) {
                comboBox1.Items.Add(country);
            } 
        } 
        private void button1_Click(object sender,EventArgs e) { 
            gErrorProvider.Clear();
            CheckEmail();
            CheckPhoneNo();
            CheckExtension();
            CheckPostalCode();
            CheckCountryComboBox(); 
            CheckAllTextBoxIsNullOrWhiteSpace();
            MessageBox.Show($"Information:" +
                $"\nCustomer ID: {textBox1.Text}"+
           $"\nCustomer Name: {textBox3.Text}"+
           $"\nEmail: {textBox4.Text}"+
           $"\nPhone No: {textBox5.Text}"+
           $"\nExtension: {textBox6.Text}"+
           $"\nAddress: {textBox7.Text}"+
           $"\nCountry: {comboBox1.Text}"+
           $"\nPostal Code: {textBox9.Text}"
           ); 
            }
              private void button2_Click(object sender,EventArgs e) {
            Application.Exit();
        }
          private void CheckTextBoxIsNullOrWhiteSpace(TextBox objTextBox) {
            if(string.IsNullOrWhiteSpace(objTextBox.Text)) {
                gErrorProvider.SetError(objTextBox,"Nhập thông tin!");
            }
        }
        //Tất cả các trường đều yêu cầu nhập
        private void CheckAllTextBoxIsNullOrWhiteSpace() {
            foreach(Control control in this.Controls) {
                if(control is TextBox) {
                    CheckTextBoxIsNullOrWhiteSpace((TextBox)(control));
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
            Match match = Regex.Match(textBox4.Text,pattern);
            if(!match.Success) {
                gErrorProvider.SetError(textBox4,"Email cần đúng định dạng(hint: cần có dấu (@) và(.) ở các vị trí hợp lý)");
            }
        }
        //Phone no cần theo định dạng(000)-000-0000 với 0 biểu diễn cho 1 số 0-9 
        private void CheckPhoneNo() {
            if(!Regex.IsMatch(textBox5.Text,@"^\(\d{3}\)\-\d{3}\-\d{4}$")) {
                gErrorProvider.SetError(textBox5,"Phone no cần theo định dạng(000)-000-0000 với 0 biểu diễn cho 1 số 0-9 ");
            }
        }
        //Extension cần là số và tối đa 3 ký tự
        private void CheckExtension() {
            int number;
            if(!(int.TryParse(textBox6.Text,out number))) {
                gErrorProvider.SetError(textBox6,"Extension cần là số và tối đa 3 ký tự");
            }
        }
        // chứa một số lựa chọn về quốc và chỉ cho phép người sử dụng chọn trong đó không nhập được các quốc gia mới
   private void CheckCountryComboBox() {
            if(string.IsNullOrWhiteSpace(comboBox1.Text)) {
                gErrorProvider.SetError(comboBox1,"Lựa chọn về quốc gia!");
            } 
        }
        //Postal code cần là số và chứa tối đa 3 ký tự
        private void CheckPostalCode() {
            int number;
            if(!(int.TryParse(textBox9.Text,out number))) {
                gErrorProvider.SetError(textBox9,"Postal code cần là số và chứa tối đa 3 ký tự");
            }
        }
    }
}
