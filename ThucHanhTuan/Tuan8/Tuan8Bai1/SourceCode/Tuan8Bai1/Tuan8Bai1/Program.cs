using System;
using System.Runtime.InteropServices;
using System.Text;

namespace ConsoleApplication {
    class Program {
        [DllImport("kernel32.dll",CharSet = CharSet.Auto)]
        public static extern int GetComputerName(StringBuilder buffer,ref int size);

        static void Main(string[] args) {
          
            try {
               
            StringBuilder computerName = new StringBuilder();

            int size = computerName.Capacity;

            int result = GetComputerName(computerName,ref size);

            if(result==0) {
                Console.WriteLine("Failed to get computer name.");
                return;
            }

            Console.WriteLine("Computer name: "+computerName);
               Console.WriteLine("\nPress any key!");
            Console.ReadKey();
            } catch(Exception ex) {
                   Console.WriteLine(ex.Message);
            Console.WriteLine("\nPress any key!");
            Console.ReadKey();
            }
      
       
        }
    }
}
