// class KhongGianNChieu
using System;
using System.Drawing;

public class KhongGianNChieu
{
    // Thuộc tính KhongGianNChieu
    private List<double> toaDoNChieu = new List<double>();
    private int soChieu;
    // Properties KhongGianNChieu
    public List<double> ToaDoNChieu
    {
        get { return toaDoNChieu; }
        set { toaDoNChieu = value; }
    }
    public int SoChieu
    {
        get { return soChieu; }
        set { soChieu = value; }
    }
    // KhongGianNChieu constructor
    // Default constructor
    public KhongGianNChieu()
    {
        ToaDoNChieu = new List<double> { };
        SoChieu = ToaDoNChieu.Count();
    }
    public KhongGianNChieu(int SChieu)
    {
        SoChieu = SChieu;
        for (int i = 0; i < SoChieu; i++)
        {
            ToaDoNChieu.Add(0);
        }
    }
    public KhongGianNChieu(List<double> toaDoNChieu)
    {
        ToaDoNChieu = toaDoNChieu;
        SoChieu = ToaDoNChieu.Count();
    }
    // KhongGianNChieu method

    public double KhoangCachGocToaDo()
    {


        double kc = 0;
        for (int i = 0; i < SoChieu; i++)
        {

            kc += ToaDoNChieu[i] * ToaDoNChieu[i];
        }
        return Math.Abs(kc);
    }
    public KhongGianNChieu DiemDoiXungToaDo()
    {

        List<double> ToaDoNChieu2 = new List<double>();

        for (int i = 0; i < SoChieu; i++)
        {
            ToaDoNChieu2.Add(-ToaDoNChieu[i]);
        }
        return new KhongGianNChieu(ToaDoNChieu2);
    }
    // Các toán tử:  cộng, trừ, nhân
    public static KhongGianNChieu operator +(KhongGianNChieu a, KhongGianNChieu b)
    {
        KhongGianNChieu c = new KhongGianNChieu(a.SoChieu);
        for (int i = 0; i < a.SoChieu; i++)
        {
            c.ToaDoNChieu[i] = a.ToaDoNChieu[i] + b.ToaDoNChieu[i];
        }
        return c;
    }
    public static KhongGianNChieu operator -(KhongGianNChieu a, KhongGianNChieu b)
    {
        KhongGianNChieu c = new KhongGianNChieu(a.SoChieu);
        for (int i = 0; i < a.SoChieu; i++)
        {
            c.ToaDoNChieu[i] = a.ToaDoNChieu[i] - b.ToaDoNChieu[i];
        }
        return c;
    }
    public static KhongGianNChieu operator *(KhongGianNChieu a, KhongGianNChieu b)
    {
        KhongGianNChieu c = new KhongGianNChieu(a.SoChieu);
        for (int i = 0; i < a.SoChieu; i++)
        {
            c.ToaDoNChieu[i] = a.ToaDoNChieu[i] * b.ToaDoNChieu[i];
        }
        return c;
    }
    public override string ToString()
    {
        string myString = "[";
        for (int i = 0; i < SoChieu; i++)
        {
            myString += Convert.ToString(ToaDoNChieu[i]);
            if (i == SoChieu - 1)
            {
                myString += "";

            }
            else
            {
                myString += ",";

            }
        }
        myString += "]";
        return myString;
    }
}