using System;
using System.Text;
namespace Tuan2Bai1 {
    internal class Program {
      private  static List<Atom> AtomList = new List<Atom>();
        private static int NumberOfAtoms;
        static void Main(string[] args) {
       
            try {
               
               Console.OutputEncoding=Encoding.UTF8;
            Input();
            Output();

           
            Console.WriteLine("\nPress any key!");
            Console.ReadKey();
   
            } catch(Exception ex) {
                   Console.WriteLine(ex.Message);
            Console.WriteLine("\nPress any key!");
            Console.ReadKey();
            }
      
            }
        public static void Input() {
            Console.WriteLine("Atomic Information");
            Console.WriteLine("=====================================================");
            bool _checkInput = false;
            do {
                Console.Write("Enter the number of Atoms (less than 10): ");
                string _inputNumberOfAtoms = Console.ReadLine();
                _checkInput=int.TryParse(_inputNumberOfAtoms,out NumberOfAtoms);
            } while(!_checkInput||NumberOfAtoms>10);

            for(int i = 0;i<NumberOfAtoms;i++) {
                Console.WriteLine(i+1);
                Atom _TempAtom = new Atom();
                do {
                    Console.Write("Enter atomic number : ");
                    _TempAtom.AtomicNumber=Console.ReadLine();

                    Console.Write("Enter symbol : ");
                    _TempAtom.Symbol=Console.ReadLine();

                    Console.Write("Enter full name : ");
                    _TempAtom.FullName=Console.ReadLine();

                    Console.Write("Enter atomic weight : ");
                    _TempAtom.AtomicWeight=Console.ReadLine();
                } while(!_TempAtom.Accept());
                AtomList.Add(_TempAtom);
            }
        } 
        public static void Output() {
            Console.WriteLine("\nTable Atomic Information");
            Console.WriteLine("Atomic Number\tSymbol\tFullName\tAtomic Weight");
            Console.WriteLine("-----------------------------------------------------");

            for(int i = 0;i<NumberOfAtoms;i++) {
                Console.WriteLine(AtomList[i].Display());
            }
        }
    }
}