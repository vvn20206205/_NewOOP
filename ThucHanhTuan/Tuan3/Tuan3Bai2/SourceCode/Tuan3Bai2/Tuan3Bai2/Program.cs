using System.Text;
namespace Tuan3Bai1 {
    internal class Program {
        static void Main(string[] args) {
            try {
                Console.OutputEncoding=Encoding.UTF8;
                Student _Test1 = new Student("Vũ Văn Nghĩa test 1","0397562283 test 1","nghia test 1@gmail.com","Toán Tin");
                Console.WriteLine(_Test1.ToString());

                Faculty _Test2 = new Faculty("Vũ Văn Nghĩa test 2","0397562283 test 2","nghia test 2@gmail.com","Quản lí test 2",2000,new System.DateTime(2015,3,10,2,15,10),"123","Senior Lecturer");
                Console.WriteLine(_Test2.ToString());

                Faculty _Test3 = new Faculty("Vũ Văn Nghĩa test 3","0397562283 test 3","nghia test 3@gmail.com","Quản lí test 3",1000,new System.DateTime(2015,3,10,2,15,10),"123","Junior Lecturer");
                Console.WriteLine(_Test3.ToString());

                Staff _Test4 = new Staff("Vũ Văn Nghĩa test 4","0397562283 test 4","nghia test 4@gmail.com","Phục vụ test 4",100,new System.DateTime(2020,3,10,2,15,10),"Nhân viên phục vụ cấp độ 1");
                Console.WriteLine(_Test4.ToString());

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