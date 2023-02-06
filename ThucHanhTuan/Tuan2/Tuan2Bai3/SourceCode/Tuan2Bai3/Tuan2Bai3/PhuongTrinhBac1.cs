using System;
internal class PhuongTrinhBac1 : PhuongTrinhBac2
{

    //PhuongTrinhBac1 constructor 
    public PhuongTrinhBac1()
    {
        SoPhuc Khong = new SoPhuc(0, 0);
        HeSoa = Khong;
    }
    public PhuongTrinhBac1(SoPhuc heSob, SoPhuc heSoc)
    {
        SoPhuc Khong = new SoPhuc(0, 0);
        HeSoa = Khong;
        HeSob = heSob;
        HeSoc = heSoc;
    }
    //define the PhuongTrinhBac1 method
    public override void NhapPhuongTrinh()
    {
        Console.WriteLine("Chương trình giải PT bậc 1.");
        Console.WriteLine("Phương trình bậc 1 có dạng bx +c = 0");
        Console.WriteLine("Nhập hệ số b,c:");
        Console.Write("Nhập hệ số b (VD: 3+5i): ");
        SoPhuc b = new SoPhuc();
        b.NhapSoPhuc();
        b.XuatSoPhuc();
        Console.Write("Nhập hệ số c (VD: 3+5i): ");
        SoPhuc c = new SoPhuc();
        c.NhapSoPhuc();
        c.XuatSoPhuc();
        HeSob = b;
        HeSoc = c;
    }
    public void XuatPhuongTrinh()
    {
        Console.WriteLine("==========================================");
        Console.WriteLine("Phương trình đã nhập là: \n" + ToString());
    }
    //Giải phương trình 
    public override void GiaiPhuongTrinh()
    {
        SoPhuc Khong = new SoPhuc(0, 0);
        if (HeSob.HeSoThuc == Khong.HeSoThuc && HeSob.HeSoAo == Khong.HeSoAo)
        {
            if (HeSoc.HeSoThuc == Khong.HeSoThuc && HeSoc.HeSoAo == Khong.HeSoAo)
            {
                Console.WriteLine("Phương trình vô số nghiệm!");
            }
            else
            {
                Console.WriteLine("Phương trình vô nghiệm!");
            }
        }
        else
        {
            Console.WriteLine("Phương trình có 1 nghiệm: x = {0}", ((Khong - HeSoc) / HeSob));
        }
    }
    override public string ToString()
    {
        string MyString = "";
        MyString += HeSob.ToString() + " x + ";
        MyString += HeSoc.ToString() + " = 0";
        return MyString;
    }
}