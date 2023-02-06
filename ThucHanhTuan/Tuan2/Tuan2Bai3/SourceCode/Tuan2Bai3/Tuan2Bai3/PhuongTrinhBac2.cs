using System;
internal class PhuongTrinhBac2
{
    protected SoPhuc heSoa;
    protected SoPhuc heSob;
    protected SoPhuc heSoc;
    public SoPhuc HeSoa
    {
        get { return heSoa; }
        set { heSoa = value; }
    }
    public SoPhuc HeSob
    {
        get { return heSob; }
        set { heSob = value; }
    }
    public SoPhuc HeSoc
    {
        get { return heSoc; }
        set { heSoc = value; }
    }
    //PhuongTrinhBac2 constructor 
    public PhuongTrinhBac2()
    {
    }
    public PhuongTrinhBac2(SoPhuc heSoa, SoPhuc heSob, SoPhuc heSoc)
    {
        HeSoa = heSoa;
        HeSob = heSob;
        HeSoc = heSoc;
    }
    //define the PhuongTrinhBac2 method
    public virtual void NhapPhuongTrinh()
    {
        Console.WriteLine("Chương trình giải PT bậc 2.");
        Console.WriteLine("Phương trình bậc hai có dạng ax^2 + bx +c = 0");
        Console.WriteLine("Nhập hệ số a,b,c:");
        Console.Write("Nhập hệ số a (VD: 3+5i): ");
        SoPhuc a = new SoPhuc();
        a.NhapSoPhuc();
        a.XuatSoPhuc();
        Console.Write("Nhập hệ số b (VD: 3+5i): ");
        SoPhuc b = new SoPhuc();
        b.NhapSoPhuc();
        b.XuatSoPhuc();
        Console.Write("Nhập hệ số c (VD: 3+5i): ");
        SoPhuc c = new SoPhuc();
        c.NhapSoPhuc();
        c.XuatSoPhuc();
        HeSoa = a;
        HeSob = b;
        HeSoc = c;
    }
    public void XuatPhuongTrinh()
    {
        Console.WriteLine("==========================================");
        Console.WriteLine("Phương trình đã nhập là: \n" + ToString());
    }
    //Giải phương trình 
    public virtual void GiaiPhuongTrinh()
    {
        //Console.WriteLine("Phương trình bậc 2 đã nhập là: \n" + ToString());
        //Tạo số phức 4 của delta =b^2-4ac
        //Tạo số phức 0 và 2
        SoPhuc Bon = new SoPhuc(4, 0);
        SoPhuc Khong = new SoPhuc(0, 0);
        SoPhuc Hai = new SoPhuc(2, 0);
        if (HeSoa.HeSoThuc == Khong.HeSoThuc && HeSoa.HeSoAo == Khong.HeSoAo)
        {
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
        else
        {
            //Tính delta
            SoPhuc delta = new SoPhuc();
            delta = HeSob.LuyThua(2) - Bon * HeSoa * HeSoc;
            if (delta.HeSoThuc == 0 && delta.HeSoAo == 0)
            {
                SoPhuc NghiemSo0 = new SoPhuc();
                NghiemSo0 = (Khong - HeSob) / Hai * HeSoa;
                Console.Write("Nghiệm của phương trình đã cho là: x1 = x2 = " + NghiemSo0.ToString() + " ( nghiệm kép )");
            }
            else
            {
                //Tính căn delta
                SoPhuc CanDeltaMot = new SoPhuc();
                SoPhuc CanDeltaHai = new SoPhuc();
                CanDeltaMot = delta.Can();
                CanDeltaHai = Khong - CanDeltaMot;
                //Tính nghiệm
                SoPhuc NghiemSo1 = new SoPhuc();
                SoPhuc NghiemSo2 = new SoPhuc();
                NghiemSo1 = ((Khong - HeSob) + CanDeltaMot) / (Hai * HeSoa);
                NghiemSo2 = ((Khong - HeSob) + CanDeltaHai) / (Hai * HeSoa);
                Console.WriteLine("Nghiệm của phương trình đã cho là:\n\n\tx1 = " + NghiemSo1.ToString() + "\n\tx2 = " + NghiemSo2.ToString());
            }
        }
    }
    override public string ToString()
    {
        string MyString = "";
        MyString += HeSoa.ToString() + " x^2 + ";
        MyString += HeSob.ToString() + " x + ";
        MyString += HeSoc.ToString() + " = 0";
        return MyString;
    }
}