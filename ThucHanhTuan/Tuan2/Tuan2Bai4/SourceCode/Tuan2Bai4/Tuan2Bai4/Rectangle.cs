using System;
namespace Tuan2Bai4 {
public class Rectangle : AShape {
    private double length;
    private double width;

        public double Length { get => length; set => length=value; }
        public double Width { get => width; set => width=value; }

        public Rectangle() {
    }
    public Rectangle(double iLength,double iWidth) {
            Length=iLength;
            Width=iWidth;
    }
    public override string ToString() {
        return "Hình chữ nhật có chiều dài: "+Length+", có chiều rộng: "+Width;
    }
    public override string GetPerimeter() {
        return "Hình chữ nhật có chu vi: "+2*(Length+Width);
    }
    public override string GetArea() {
        return "Hình chữ nhật có diện tích: "+Length*Width;
    }
}
}