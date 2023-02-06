using System;
using System.IO;

class MainClass {
    public static void Main(string[] args) {
        FileInfo file = new FileInfo(@"../../../../Bai3/test.txt");

        // Display directory information.
        DirectoryInfo dir = file.Directory;

        Console.WriteLine("Checking directory: "+dir.Name);
        Console.Write("Directory exists: ");
        Console.WriteLine(dir.Exists.ToString());
    }
}

