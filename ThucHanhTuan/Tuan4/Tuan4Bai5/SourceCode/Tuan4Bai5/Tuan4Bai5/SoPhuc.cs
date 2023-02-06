using System;
// declare the SoPhuc class
public class SoPhuc
{
    //declare the SoPhuc fields
    private double heSoThuc;
    private double heSoAo;
    public double HeSoThuc
    {
        get { return heSoThuc; }
        set { heSoThuc = value; }
    }
    public double HeSoAo
    {
        get { return heSoAo; }
        set { heSoAo = value; }
    }
    //SoPhuc constructor 
    public SoPhuc()
    {
        HeSoThuc = 0;
        HeSoAo = 0;
    }
    public SoPhuc(double heSoThuc, double heSoAo)
    {
        HeSoThuc = heSoThuc;
        HeSoAo = heSoAo;
    }
    //define the SoPhuc method
    public void NhapSoPhuc()
    {
        //Console.Write("Nhập số phức (VD: 3+5i): ");
        string inputString = Console.ReadLine();
        XuliString(inputString);
    }
    public void XuliString(string inputString)
    {
        //xóa space đầu, cuối
        inputString = inputString.Trim();
        //thay thế 1 space bằng "" (nếu có)
        inputString = inputString.Replace(" ", "");
        //split số phức bằng i..............
        string[] nghia = inputString.Split("/");
        int ViTriDauCong = inputString.LastIndexOf("+");
        int ViTriDauTru = inputString.LastIndexOf("-");
        int ViTriPhanAoI = inputString.LastIndexOf("i");
        if (ViTriPhanAoI < 0)
        {
            HeSoThuc = Convert.ToSingle(inputString.Substring(0));
            HeSoAo = 0;
        }
        else
        {
            if (ViTriDauCong > 0)
            {
                HeSoThuc = Convert.ToSingle(inputString.Substring(0, ViTriDauCong));
                HeSoAo = Convert.ToSingle(inputString.Substring(ViTriDauCong, ViTriPhanAoI - ViTriDauCong));
            }
            else
            {
                if (ViTriDauTru > 0)
                {
                    HeSoThuc = Convert.ToSingle(inputString.Substring(0, ViTriDauTru));
                    HeSoAo = Convert.ToSingle(inputString.Substring(ViTriDauTru, ViTriPhanAoI - ViTriDauTru));
                }
                else
                {
                    HeSoThuc = 0;
                    HeSoAo = Convert.ToSingle(inputString.Substring(0, ViTriPhanAoI));
                }
            }
        }
    }
    public void XuatSoPhuc()
    {
        Console.WriteLine("Số phức đã nhập là: " + ToString());
    }
    public override  string ToString()
    {
        string MyString = "";
        if (HeSoThuc == 0 && HeSoAo == 0)
        {
            MyString += "0";
            return MyString;
        }

        MyString += HeSoThuc;
        if (HeSoAo < 0)
        {
            MyString += HeSoAo + "i";
        }
        else
        {
            MyString += "+" + HeSoAo + "i";
        }
        MyString = "(" + MyString + ")";

        return MyString;
    }
    //căn, lũy thừa, nghịch đảo, số đối. 
    public SoPhuc Can()
    {
        SoPhuc TinhCanMot = new SoPhuc();
        if (HeSoThuc == 0 && HeSoAo == 0)
        {
            TinhCanMot.HeSoThuc = 0;
            TinhCanMot.HeSoAo = 0;
            return TinhCanMot;
        }
        double RSoPhucLT = Math.Sqrt(HeSoThuc * HeSoThuc + HeSoAo * HeSoAo);
        double GocArcCos = 0, GocArcSin = 0;
        if (HeSoThuc >= 0 && HeSoAo >= 0) { GocArcCos = Math.Acos(HeSoThuc / RSoPhucLT); GocArcSin = Math.Asin(HeSoAo / RSoPhucLT); }
        if (HeSoThuc <= 0 && HeSoAo >= 0) { GocArcCos = Math.Acos(HeSoThuc / RSoPhucLT); GocArcSin = Math.PI - Math.Asin(HeSoAo / RSoPhucLT); }
        if (HeSoThuc <= 0 && HeSoAo <= 0) { GocArcCos = -Math.Acos(HeSoThuc / RSoPhucLT); GocArcSin = -Math.PI - Math.Asin(HeSoAo / RSoPhucLT); }
        if (HeSoThuc >= 0 && HeSoAo <= 0) { GocArcCos = -Math.Acos(HeSoThuc / RSoPhucLT); GocArcSin = Math.Asin(HeSoAo / RSoPhucLT); }
        TinhCanMot.HeSoThuc = Math.Sqrt(RSoPhucLT) * Math.Cos(GocArcCos / 2);
        TinhCanMot.HeSoAo = Math.Sqrt(RSoPhucLT) * Math.Sin(GocArcSin / 2);
        return TinhCanMot;
    }
    public SoPhuc LuyThua(int n)
    {
        SoPhuc c = new SoPhuc();
        for (int i = 0; i < n; i++)
        {
            c = this * this;
        }
        return c;
    }
    public SoPhuc NghichDao()
    {
        if (HeSoThuc == 0 && HeSoAo == 0)
        {
            Console.WriteLine("Lỗi do chia cho 0!");
            throw new ArgumentNullException("Lỗi do chia cho 0!");
        }
        else
        {
            SoPhuc a = new SoPhuc(1, 0);
            return a / this;
        }
    }
    public SoPhuc SoDoi()
    {
        SoPhuc c = new SoPhuc();
        c.HeSoThuc = -HeSoThuc;
        c.HeSoAo = -HeSoAo;
        return c;
    }
    //Nạp chồng toán tử
    //+, -, x, /,
    public static SoPhuc operator +(SoPhuc a, SoPhuc b)
    {
        SoPhuc c = new SoPhuc();
        c.HeSoThuc = a.HeSoThuc + b.HeSoThuc;
        c.HeSoAo = a.HeSoAo + b.HeSoAo;
        return c;
    }
    public static SoPhuc operator -(SoPhuc a, SoPhuc b)
    {
        SoPhuc c = new SoPhuc();
        c.HeSoThuc = a.HeSoThuc - b.HeSoThuc;
        c.HeSoAo = a.HeSoAo - b.HeSoAo;
        return c;
    }
    public static SoPhuc operator *(SoPhuc a, SoPhuc b)
    {
        SoPhuc c = new SoPhuc();
        c.HeSoThuc = a.HeSoThuc * b.HeSoThuc - a.HeSoAo * b.HeSoAo;
        c.HeSoAo = a.HeSoThuc * b.HeSoAo + a.HeSoAo * b.HeSoThuc;
        return c;
    }
    public static SoPhuc operator /(SoPhuc a, SoPhuc b)
    {
        if (b.HeSoThuc == 0 && b.HeSoAo == 0)
        {
            Console.WriteLine("Lỗi do chia cho 0!");
            throw new ArgumentNullException("Lỗi do chia cho 0!");
        }
        else
        {
            SoPhuc c = new SoPhuc();
            c.HeSoThuc = (a.HeSoThuc * b.HeSoThuc + a.HeSoAo * b.HeSoAo) / (b.HeSoThuc * b.HeSoThuc + b.HeSoAo * b.HeSoAo);
            c.HeSoAo = (a.HeSoAo * b.HeSoThuc - a.HeSoThuc * b.HeSoAo) / (b.HeSoThuc * b.HeSoThuc + b.HeSoAo * b.HeSoAo);
            return c;
        }
    }
    public static SoPhuc operator >=(SoPhuc a, SoPhuc b)
    {
        if (b.HeSoThuc == 0 && b.HeSoAo == 0)
        {
            Console.WriteLine("Lỗi do chia cho 0!");
            throw new ArgumentNullException("Lỗi do chia cho 0!");
        }
        else
        {
            SoPhuc c = new SoPhuc();
            c.HeSoThuc = (a.HeSoThuc * b.HeSoThuc + a.HeSoAo * b.HeSoAo) / (b.HeSoThuc * b.HeSoThuc + b.HeSoAo * b.HeSoAo);
            c.HeSoAo = (a.HeSoAo * b.HeSoThuc - a.HeSoThuc * b.HeSoAo) / (b.HeSoThuc * b.HeSoThuc + b.HeSoAo * b.HeSoAo);
            return c;
        }
    }
    public static SoPhuc operator <=(SoPhuc a, SoPhuc b)
    {
        if (b.HeSoThuc == 0 && b.HeSoAo == 0)
        {
            Console.WriteLine("Lỗi do chia cho 0!");
            throw new ArgumentNullException("Lỗi do chia cho 0!");
        }
        else
        {
            SoPhuc c = new SoPhuc();
            c.HeSoThuc = (a.HeSoThuc * b.HeSoThuc + a.HeSoAo * b.HeSoAo) / (b.HeSoThuc * b.HeSoThuc + b.HeSoAo * b.HeSoAo);
            c.HeSoAo = (a.HeSoAo * b.HeSoThuc - a.HeSoThuc * b.HeSoAo) / (b.HeSoThuc * b.HeSoThuc + b.HeSoAo * b.HeSoAo);
            return c;
        }
    }
}