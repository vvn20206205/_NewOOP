using System;
using System.Text;

namespace CCustomerSpace
{
    // class Customer
    public class Customer
    {
        // Thuộc tính Customer

        private string strName;
        // Properties Customer
        public string StrName
        {
            get { return strName; }
            set { strName = value; }
        }
        // Customer constructor
        // Default constructor
        public Customer()
        {
            StrName = "Vũ Văn Nghĩa 20206205";
        }
        public Customer(string istrName)
        {
            StrName = istrName;
        }
        // Customer method 
        public void ChangeCustomerName(string iName)
        {
              
            StrName = iName;
        }
        public override string ToString()
        {
            return $"{StrName}";
        }
    }
}