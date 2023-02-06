using CCONST;
using System;
using System.Text;
using System.IO;
using System.IO.Pipes;

namespace Tuan7Bai1 {
    internal class Program {
        static void Main(string[] args) {
            try {
                Console.OutputEncoding=Encoding.UTF8;
                SelectMenu();
                Console.WriteLine("You have exited the program!");
                 Console.WriteLine("\nPress any key!");
            Console.ReadKey();
            } catch(Exception ex) {
                Console.WriteLine("Đã xảy ra lỗi. Vui lòng thử lại sau!");
                Console.WriteLine(ex.Message);
            Console.WriteLine("\nPress any key!");
            Console.ReadKey();   }
        }
        public static void PrintMenu() {
            Console.Clear();
            Console.WriteLine("\t+==========================================+");
            Console.WriteLine("\t+ MENU                                     +");
            Console.WriteLine("\t+==========================================+");
            Console.WriteLine("\t+ 1. Save to File.                         +");
            Console.WriteLine("\t+ 2. Read File.                            +");
            Console.WriteLine("\t+ 3. Exit.                                 +");
            Console.WriteLine("\t+==========================================+");
        }
        public static int GetInputChoice() {
            int _choice;
            bool _isValitate = false;
            do {
                Console.Write("\tYour choice (1/2/3): ");
                string _input = Console.ReadLine();
                _isValitate=int.TryParse(_input,out _choice);
            } while(!_isValitate||(int)eCHOOSE.SAVE_TO_FILE>_choice||_choice>(int)eCHOOSE.EXIT);
            return _choice;
        }
        public static void SelectMenu() {
            int _inputChoice;
            do {
                PrintMenu();
                _inputChoice=GetInputChoice();
                switch(_inputChoice) {
                    case (int)eCHOOSE.SAVE_TO_FILE:
                        Console.WriteLine("1. Save to File.");
                        SaveToFile();
                        Console.WriteLine("Nhấn phím bất kỳ để tiếp tục chương trình!");
                        Console.ReadKey();
                        break;
                    case (int)eCHOOSE.READ_FILE:
                        Console.WriteLine("2. Read File.");
                        ReadFile();

                        Console.WriteLine("Nhấn phím bất kỳ để tiếp tục chương trình!");
                        Console.ReadKey();
                        break;
                }
            } while(_inputChoice!=(int)eCHOOSE.EXIT);
        }
        public static void SaveToFile() {
            using(StreamWriter sw = new StreamWriter("../../../sv.txt")) {
                Console.Write("Số lượng sinh viên thêm vào file: ");
                int count = int.Parse(Console.ReadLine());
                Student[] students = new Student[count];

                for(int i = 0;i<count;i++) {
                    Student student = new Student();
                    Console.Write("Tên sinh viên: ");
                    student.Name=Console.ReadLine();
                    Console.Write("Tuổi: ");
                    student.Age=int.Parse(Console.ReadLine());
                    Console.Write("Điểm: ");
                    student.Mark=double.Parse(Console.ReadLine());
                    students[i]=student;
                    sw.WriteLine(student);
                }

                sw.Close();
            }
        }
        public static void ReadFile() {
            FileStream fileStream = new FileStream("../../../sv.txt",FileMode.OpenOrCreate,FileAccess.Read);
            using StreamReader sr = new StreamReader(fileStream);
            string txt = sr.ReadToEnd();
            string[] lines = txt.Split("\n");
            Student[] students = new Student[lines.Length-1];
            for(int i = 0;i<students.Length;i++) {
                Student student = new Student();
                string[] fields = lines[i].Split("\t\t");
                foreach(var field in fields) {
                    string[] kv = field.Split(": ");
                    switch(kv[0]) {
                        case "Name":
                            student.Name=kv[1];
                            break;
                        case "Age":
                            student.Age=int.Parse(kv[1]);
                            break;
                        case "Mark":
                            student.Mark=double.Parse(kv[1]);
                            break;
                        default:
                            break;
                    }
                }
                students[i]=student;
            }

            foreach(var student in students) {
                Console.WriteLine(student);
            }
            fileStream.Close();
        }
    }
}