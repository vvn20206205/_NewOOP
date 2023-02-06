using System;
using System.Drawing;
using System.IO;
namespace KiThuatLapTrinh {
    class Program {
        static string path;
        static int pixelInterval = 8;
        static double brightnessMultiplier = 1;
        static void Main() {
            Console.OutputEncoding=System.Text.Encoding.UTF8;
            Console.WriteLine("Đây là phần mềm chuyển đổi ảnh thành file txt.");
            Console.WriteLine("Hãy nhập vào đường dẫn file ảnh:");
            Console.WriteLine("Ví dụ: \"C:/Tuan7Bai2/HUST.png\"");
            string NhapPath = Console.ReadLine();
            path=NhapPath;

            File.WriteAllText("../../../OUTPUT.txt","");
            ConvertToText();

        }

        static void ConvertToText() {
            Bitmap bmp = (Bitmap)Image.FromFile(path);
            string WrittenLine = "";
            for(int y = 0;y<bmp.Size.Height-(bmp.Size.Height%pixelInterval);y+=pixelInterval) {
                    Console.Write($"Dòng y={y}");
                for(int x = 0;x<bmp.Size.Width;x++) {
                    Console.Write(bmp.GetPixel(x,y));
                    Console.Write($"\t");
                    //Console.WriteLine((bmp.GetPixel(x,y).GetBrightness()*brightnessMultiplier));
                    if(x%pixelInterval==0||x%pixelInterval==1) {
                        WrittenLine+=GetSymbolFromBrightness(bmp.GetPixel(x,y).GetBrightness()*brightnessMultiplier);
                    }
                }
                Console.WriteLine();
                File.AppendAllText("../../../OUTPUT.txt","\n"+WrittenLine);
                WrittenLine="";
            }
            Console.WriteLine("Chạy chương trình thành công!");
            Console.WriteLine("Kết quả: OUTPUT.txt");
            Console.WriteLine("Nhấn phím bất kì kết thúc chương trình.");
            Console.ReadKey();
        }

        static string GetSymbolFromBrightness(double brightness) {
            switch((int)(brightness*10)) {
                case 0:
                    return "@";
                case 1:
                    return "$";
                case 2:
                    return "#";
                case 3:
                    return "*";
                case 4:
                    return "!";
                case 5:
                    return "+";
                case 6:
                    return ":";
                case 7:
                    return "~";
                case 8:
                    return "-";
                case 9:
                    return ".";
                default:
                    return " ";
            }
        }
    }
}