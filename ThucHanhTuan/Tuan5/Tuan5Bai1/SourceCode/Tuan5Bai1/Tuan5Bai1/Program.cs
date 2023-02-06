// Vũ Văn Nghĩa 20206205
using CCONST;
using CCustomerSpace;
using COrderSpace;
using System;
using System.Text;
namespace Tuan5Bai1 {
    internal class Program {
        static void Main(string[] args) {
            try {
                Console.OutputEncoding=Encoding.UTF8;

                SelectMenu();

                Console.WriteLine("You have exited the program!");
               Console.WriteLine("\nPress any key!");
            Console.ReadKey();
         
            } catch(Exception ex) {
                   Console.WriteLine(ex.Message);
            Console.WriteLine("\nPress any key!");
            Console.ReadKey();
            }
      
       
        }
        public static void SelectMenu() {
            Customer objCustomer = new Customer();

            int _choice;
            do {

                Console.WriteLine("1 - ChangeCustomerName\n2 - Choice Grocery Items\n3 - Choice Bakery Items\n0 - Exit");
                do {
                    bool isValitate = false;
                    do {
                        Console.Write("\tEnter your choice (0 -> 3): ");
                        string _input = Console.ReadLine();
                        isValitate=int.TryParse(_input,out _choice);
                    } while(!isValitate);
                } while(0>_choice||_choice>3);
                switch(_choice) {
                    case (int)eCHOOSE.CHANGE_CUSTOMER_NAME:
                        SolveChangeCustomerName(objCustomer);
                        break;
                    case (int)eCHOOSE.CHOICE_GROCERY_ITEMS:
                        GroceryOrder objGrocery = new GroceryOrder(objCustomer);
                        Console.WriteLine(objGrocery.Choose());
                        break;
                    case (int)eCHOOSE.CHOICE_BAKERY_ITEMS:

                        BreadOrder objBakery = new BreadOrder(objCustomer);
                        Console.WriteLine(objBakery.Choose());
                        break;
                }
            } while(_choice!=(int)eCHOOSE.EXIT);
        }
        public static void SolveChangeCustomerName(Customer inputCustomer) {
            Console.Write("Enter your name :");
            string _nameNew = Console.ReadLine();
            inputCustomer.ChangeCustomerName(_nameNew);
        }
    }
}