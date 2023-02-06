// class Polynomial 
using System.Runtime.InteropServices;

public class Polynomial
{
    // Thuộc tính Polynomial
    private List<SoPhuc> heSo = new List<SoPhuc>();
    private int bacDaThuc;
    // Properties Polynomial
    public List<SoPhuc> HeSo
    {
        get { return heSo; }
        set { heSo = value; }
    }
    public int BacDaThuc
    {
        get { return bacDaThuc; }
        set { bacDaThuc = value; }
    }
    // Polynomial constructor
    // Default constructor
    public Polynomial()
    {
        heSo = new List<SoPhuc> { };
        bacDaThuc = heSo.Count();
    }
    public Polynomial(int bacDaThuc, SoPhuc a)
    {
        BacDaThuc = bacDaThuc;
        for (int i = 0; i < BacDaThuc - 1; i++)
        {
            HeSo.Add(new SoPhuc());
        }
        HeSo.Add(a);
    }
    public Polynomial(List<SoPhuc> heSo)
    {
        HeSo = heSo;
        bacDaThuc = HeSo.Count();
    }
    // Polynomial method

    // Các toán tử:  cộng, trừ, nhân
    public static Polynomial operator +(Polynomial a, Polynomial b)
    {
        int bdt1, bdt2, type;
        if (a.BacDaThuc >= b.BacDaThuc)
        {
            bdt1 = a.BacDaThuc;
            bdt2 = b.BacDaThuc;
            type = 0;
        }
        else
        {
            bdt1 = b.BacDaThuc;
            bdt2 = a.BacDaThuc;
            type = 1;
        }
        List<SoPhuc> HeSo2 = new List<SoPhuc>();
        for (int i = 0; i < bdt2; i++)
        {
            SoPhuc KQ = a.heSo[i] + b.heSo[i];
            HeSo2.Add(KQ);

        }
        for (int i = bdt2; i < bdt1; i++)
        {
            switch (type)
            {
                case 0:
                    HeSo2.Add(a.heSo[i]);

                    break;
                case 1:
                    HeSo2.Add(b.heSo[i]);

                    break;

            }


        }
        Polynomial c = new Polynomial(HeSo2);
        return c;
    }
    public static Polynomial operator -(Polynomial a, Polynomial b)
    {
        int bdt1, bdt2, type;
        if (a.BacDaThuc >= b.BacDaThuc)
        {
            bdt1 = a.BacDaThuc;
            bdt2 = b.BacDaThuc;
            type = 0;
        }
        else
        {
            bdt1 = b.BacDaThuc;
            bdt2 = a.BacDaThuc;
            type = 1;
        }
        List<SoPhuc> HeSo2 = new List<SoPhuc>();
        for (int i = 0; i < bdt2; i++)
        {
            SoPhuc KQ = a.heSo[i] - b.heSo[i];
            HeSo2.Add(KQ);

        }
        for (int i = bdt2; i < bdt1; i++)
        {
            switch (type)
            {
                case 0:
                    HeSo2.Add(a.heSo[i]);

                    break;
                case 1:
                    HeSo2.Add(b.heSo[i].SoDoi());

                    break;

            }


        }
        Polynomial c = new Polynomial(HeSo2);
        return c;
    }
    public static Polynomial operator *(Polynomial a, Polynomial b)
    {
        List<SoPhuc> HeSo = new List<SoPhuc>();
        List<SoPhuc> HeSo2 = new List<SoPhuc>();
        int bdt = a.BacDaThuc + b.BacDaThuc - 1;

        SoPhuc SoPhuc0 = new SoPhuc(0, 0);
        for (int i = 0; i < bdt; i++)
        {
            HeSo2.Add(SoPhuc0);

        }
        for (int i = 0; i < a.bacDaThuc; i++)
        {

            for (int j = 0; j < b.bacDaThuc; j++)
            {
                SoPhuc KQ = a.heSo[i] * b.heSo[j];
                HeSo2[i + j] += KQ;
            }
        }
        Polynomial c = new Polynomial(HeSo2);
        return c;
    }
    public SoPhuc LayGiaTri(SoPhuc a)
    {
        SoPhuc c = new SoPhuc(0, 0);
        for (int i = 0; i < BacDaThuc; i++)
        {
            SoPhuc temp = a;
            for (int j = 0; j < i; j++)
            {
                temp = temp * a;
            }
            c += HeSo[BacDaThuc - i - 1] * temp;
        }



        return c;
    }
    public Polynomial BinhPhuong()
    {
        return this * this;
    }
    public Polynomial DaoHam()
    {
        List<SoPhuc> HeSo2 = new List<SoPhuc>();
        for (int i = 1; i < BacDaThuc; i++)
        {

            SoPhuc KQ = new SoPhuc(i, 0);
            KQ *= HeSo[i];
            HeSo2.Add(KQ);
        }


        Polynomial c = new Polynomial(HeSo2);


        return c;
    }
    public Polynomial NguyenHam()
    {
        List<SoPhuc> HeSo2 = new List<SoPhuc>();
        SoPhuc SoPhuc0 = new SoPhuc(0, 0);
        SoPhuc SoPhuc1 = new SoPhuc(1, 0);
        HeSo2.Add(SoPhuc0);

        for (int i = 0; i < BacDaThuc; i++)
        {

            SoPhuc KQ = new SoPhuc(i, 0);
            KQ = HeSo[i] / (KQ + SoPhuc1);
            HeSo2.Add(KQ);
        }


        Polynomial c = new Polynomial(HeSo2);


        return c;
    }
    //public SoPhuc TinhNghiem()
    //{
    //    SoPhuc a = new SoPhuc();
    //    SoPhuc b = new SoPhuc();
    //    SoPhuc SoPhuc2 = new SoPhuc(2, 0);
    //    Console.WriteLine("\nNhập khoảng cách li nghiệm: ");
    //    Console.Write("\ta: ");
    //    a.NhapSoPhuc();
    //    Console.Write("\tb: ");
    //    b.NhapSoPhuc();
    //    double ep = 5;
    //    LayGiaTri(a);
    //    while (true)
    //    {
    //        SoPhuc c = (b + a) / SoPhuc2;
    //        if()
    //    }
    //    for (int i = 0; i < BacDaThuc; i++)
    //    {

    //        SoPhuc KQ = new SoPhuc(i, 0);
    //        Console.WriteLine(KQ);
           
    //    }


    //    SoPhuc KQ = new SoPhuc(2,2);


    //    return KQ;
    //}
    public override string ToString()
    {
        string myString = "";
        if (BacDaThuc == 0)
        {
            return "0";
        }
        else
        {
            for (int i = 0; i < BacDaThuc; i++)
            {
                if (i == 0)
                {

                    myString += "";
                }
                else
                {


                    myString += " + ";
                }
                myString += $"{HeSo[i].ToString()}*x^ {i}";

            }


        }
        return myString;
    }
}