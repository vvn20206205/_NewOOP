using System;
using System.IO;

class MainClass {
    public static void Main() {

        StreamWriter fstr_out;
        try {
            fstr_out=new StreamWriter(@"../../../test.txt");
        } catch(IOException exc) {
            Console.WriteLine(exc.Message+"Cannot open file.");
            return;
        }
        try {
            fstr_out.Write("Hello Aptech");
        } catch(IOException exc) {
            Console.WriteLine(exc.Message+"File Error");
            return;
        }
        fstr_out.Close();
    }
}
