using System;
using System.Runtime.InteropServices;
using System.Text;

namespace ConsoleApplication {
    class Program {
        [DllImport("kernel32.dll",CharSet = CharSet.Auto)]
        public static extern int GetComputerName(StringBuilder buffer,ref int size);

        static void Main(string[] args) {
            StringBuilder computerName = new StringBuilder();

            int size = computerName.Capacity;

            int result = GetComputerName(computerName,ref size);

            if(result==0) {
                Console.WriteLine("Failed to get computer name.");
                return;
            }

            Console.WriteLine("Computer name: "+computerName);
        }
    }
}
