using System;
using System.IO;

class MainClass {
    public static void Main(string[] args) {
        FileInfo file = new FileInfo(@"../../../../Bai3/test.txt");

        // Display directory information
        DirectoryInfo dir = file.Directory;

        if(dir.Exists) {
            Console.Write("Directory attribute list: ");
            Console.WriteLine(dir.Attributes.ToString());
            Console.WriteLine("Directory contains: "
            +dir.GetFiles().Length.ToString()+" files");
        }
    }
}

