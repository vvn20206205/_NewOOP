using System;
using System.Text;
namespace Tuan2Bai1 {
    internal class Program {
        static List<CAtom> AtomList = new List<CAtom>();
        static int NumberOfAtoms;
        static void Main(string[] args) {
            Console.OutputEncoding=Encoding.UTF8;

            Solve();

            Console.WriteLine("Press any key!");
            Console.ReadKey();
        }
        public static void Solve() {
            Input();
            Output();
        }
        public static void Input() {
            Console.WriteLine("Atomic Information");
            Console.WriteLine("=====================================================");
            bool _check = false;
            do {
                Console.Write("Enter the number of Atoms (less than 10): ");
                string _temp_str = Console.ReadLine();
                _check=int.TryParse(_temp_str,out NumberOfAtoms);
            } while(!_check||NumberOfAtoms>10);

            for(int i = 0;i<NumberOfAtoms;i++) {
                Console.WriteLine(i+1);
                CAtom _temp_Atom = new CAtom();
                _check=false;
                do {
                    Console.Write("Enter atomic number : ");
                    string stringAtomicNumber = Console.ReadLine();

                    Console.Write("Enter symbol : ");
                    string stringSymbol = Console.ReadLine();

                    Console.Write("Enter full name : ");
                    string stringFullName = Console.ReadLine();

                    Console.Write("Enter atomic weight : ");
                    string stringAtomicWeight = Console.ReadLine();

                    _check=_temp_Atom.Accept(stringAtomicNumber,stringSymbol,stringFullName,stringAtomicWeight);
                } while(!_check);
                AtomList.Add(_temp_Atom);
            }
        }
        public static void Output() {
            Console.WriteLine("\nTable Atomic Information");
            Console.WriteLine($"Atomic Number\tSymbol\tFullName\tAtomic Weight");
            Console.WriteLine("-----------------------------------------------------");

            for(int i = 0;i<NumberOfAtoms;i++) {
                Console.WriteLine(AtomList[i].Display());
            }
        }
    }
}