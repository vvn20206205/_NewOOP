// Vũ Văn Nghĩa 20206205
using AmountException;
using CONST;
using Microsoft.VisualBasic;
using System;
using System.Text;
namespace Tuan5Bai2 {
    internal class Program {
        static void Main(string[] args) {
            try {
                Console.OutputEncoding=Encoding.UTF8;

                Tutors objTutors = GetInputTutors();
                GetOutputTutors(objTutors);
                Test_Tutors(objTutors);

                Console.WriteLine("You have exited the program!");
                Console.WriteLine("Press any key!");
                Console.ReadKey();
            } catch(Exception e) {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }
        public static Tutors GetInputTutors() {
            Console.WriteLine("* Nhập thông tin:");
            string _input;
            // Nhập tên 
            Console.Write("- Nhập tên: ");
            _input=Console.ReadLine();
            string _tempName = _input;
            // Chọn cấp bậc 
            int _choise;
            bool _isValitateNumber;
            string _tempRank = "";
            do {
                Console.WriteLine("- Chọn cấp bậc:");
                Console.WriteLine("1. Senior");
                Console.WriteLine("2. Junior");
                Console.WriteLine("3. Internship");
                Console.WriteLine("4. Fresher");
                Console.Write("ENTER (1->4): ");
                _input=Console.ReadLine();
                _isValitateNumber=int.TryParse(_input,out _choise);
            } while(!_isValitateNumber||(int)CHOOSE.Senior>_choise||_choise>(int)CHOOSE.Fresher);

            switch(_choise) {
                case (int)CHOOSE.Senior:
                    _tempRank=Rank.Senior;
                    break;
                case (int)CHOOSE.Junior:
                    _tempRank=Rank.Junior;
                    break;
                case (int)CHOOSE.Internship:
                    _tempRank=Rank.Internship;
                    break;
                case (int)CHOOSE.Fresher:
                    _tempRank=Rank.Fresher;
                    break;
            }
            // Nhập lương 
            double _tempSalary;
            do {
                Console.Write("- Nhập lương (USD): ");
                _input=Console.ReadLine();
                _isValitateNumber=double.TryParse(_input,out _tempSalary);
            } while(!_isValitateNumber);
            // Nhập thưởng 
            double _tempBonus;
            do {
                Console.Write("- Nhập thưởng (USD): ");
                _input=Console.ReadLine();
                _isValitateNumber=double.TryParse(_input,out _tempBonus);
            } while(!_isValitateNumber);
            return new Tutors(_tempName,_tempRank,_tempSalary,_tempBonus);
        }

        public static void GetOutputTutors(Tutors _iTutor) {
            Console.Clear();
            Console.WriteLine("=> Thông tin:");
            Console.WriteLine(_iTutor.ToString());
        }
        public static void Test_Tutors(Tutors _iTutor) {
            Console.WriteLine("\n\tChương trình kiểm tra:");
            if(_iTutor.Bonus>10000) {
                throw new Bonus_Exception();
            }
            if(_iTutor.Rank==Rank.Senior&&_iTutor.Salary<60000) {
                throw new Senior_Exception();
            }
            Console.WriteLine("\n\tKết thúc kiểm tra.");
        }

    }
}
