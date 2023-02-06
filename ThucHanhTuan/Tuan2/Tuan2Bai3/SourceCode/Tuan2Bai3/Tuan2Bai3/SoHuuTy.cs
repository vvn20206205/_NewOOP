using System;
using System.Net;
// declare the SoHuuTy class
internal class SoHuuTy
{
    //declare the SoHuuTy fields
    private int tuSo;
    private int mauSo;
    public int TuSo{get { return tuSo; }set { tuSo = value; }}
    public int MauSo{get { return mauSo; }set { mauSo = value; }}
    //SoHuuTy constructor 
    public SoHuuTy()
    {
    }
    public SoHuuTy(int ituSo, int imauSo)
    {
        TuSo = ituSo;
        MauSo = imauSo;
    }
    //define the SoHuuTy method
    public void NhapSoHuuTy()
    {
        bool kt = false;
        do
        {
            Console.Write("Nhập số hữu tỉ (VD: 3/5): ");
            string inputString = Console.ReadLine();
            kt = XuliString(inputString);
        } while (!kt);
    }
    public Boolean XuliString(string inputString)
    {
        //xóa space đầu, cuối
        inputString = inputString.Trim();
        //thay thế 1 space bằng "" (nếu có)
        inputString = inputString.Replace(" ", "");
        //split số hữu tỉ bằng /
        string[] nghia = inputString.Split("/");
        bool kt = false;

        int ts, ms;
        kt = int.TryParse(nghia[0], out ts);
        TuSo = ts;
        if (kt == false) { return kt; }
        kt = int.TryParse(nghia[1], out ms);
        if (kt == false) { return kt; }
        MauSo = ms;
        if (MauSo == 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    public void XuatSoHuuTy()
    {
        Console.WriteLine("Số hữu tỉ đã nhập là: " + ToString());
    }
    public void RutGonSoHuuTy()
    {
        int USCLN = TimUSCLN(TuSo, MauSo);
        TuSo /= USCLN;
        MauSo /= USCLN;
    }
    public int TimUSCLN(int a, int b)
    {
        a = Math.Abs(a);
        b = Math.Abs(b);
        int USCLN = 1;
        if (a == 0 || b == 0)
        {
            USCLN = (a + b);
        }
        else
        {
            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
            USCLN = a;
        }
        return USCLN;
    }
    override public string ToString()
    {
        RutGonSoHuuTy();
        string MyString = "";
        if (TuSo * MauSo == 0)
        {
            MyString = " 0 ";
            return MyString;
        }
        else if (MauSo < 0)
        {
            TuSo *= -1;
            MauSo *= -1;
        }
        MyString = "(" + TuSo + "/" + MauSo + ")";
        return MyString;
    }
    //căn, lũy thừa, nghịch đảo, số đối. 
    public double Can()
    {
        double c = new double();
        c = Math.Sqrt(TuSo / MauSo);
        return c;
    }
    public SoHuuTy LuyThua(int n)
    {
        SoHuuTy c = new SoHuuTy();
        for (int i = 0; i < n; i++)
        {
            c = this * this;
        }
        return c;
    }
    public SoHuuTy NghichDao()
    {
        SoHuuTy c = new SoHuuTy();
        if (TuSo == 0)
        {
            Console.WriteLine("Lỗi do chia cho 0!");
            throw new ArgumentNullException("Lỗi do chia cho 0!");
        }
        else
        {
            c.TuSo = MauSo;
            c.MauSo = TuSo;
            return c;
        }
    }
    public SoHuuTy SoDoi()
    {
        SoHuuTy c = new SoHuuTy();
        c.TuSo = -TuSo;
        c.MauSo = MauSo;
        return c;
    }
    //Nạp chồng toán tử
    //+, -, x, /,
    public static SoHuuTy operator +(SoHuuTy a, SoHuuTy b)
    {
        SoHuuTy c = new SoHuuTy();
        c.TuSo = a.TuSo * b.MauSo + a.MauSo * b.TuSo;
        c.MauSo = a.MauSo * b.MauSo;
        return c;
    }
    public static SoHuuTy operator -(SoHuuTy a, SoHuuTy b)
    {
        SoHuuTy c = new SoHuuTy();
        c.TuSo = a.TuSo * b.MauSo - a.MauSo * b.TuSo;
        c.MauSo = a.MauSo * b.MauSo;
        return c;
    }
    public static SoHuuTy operator *(SoHuuTy a, SoHuuTy b)
    {
        SoHuuTy c = new SoHuuTy();
        c.TuSo = a.TuSo * b.TuSo;
        c.MauSo = a.MauSo * b.MauSo;
        return c;
    }
    public static SoHuuTy operator /(SoHuuTy a, SoHuuTy b)
    {
        SoHuuTy c = new SoHuuTy();
        if (b.TuSo == 0)
        {
            Console.WriteLine("Lỗi do chia cho 0!");
            throw new ArgumentNullException("Lỗi do chia cho 0!");
        }
        else
        {
            c.TuSo = a.TuSo * b.MauSo;
            c.MauSo = a.MauSo * b.TuSo;
            return c;
        }
    }
}