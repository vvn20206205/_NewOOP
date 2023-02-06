using System;
public class CHinhTron : CHinh
{
    private double banKinhR;
    
    public double BanKinhR
    {
        get { return banKinhR; }
        set { banKinhR = value; }
    }
    public CHinhTron()
    {
    }
    public CHinhTron(double banKinhR)
    {
        BanKinhR = banKinhR;
    }
 
    public override string ToString()
    {
        return "Hình tròn có bán kính: " + BanKinhR;
    }
    public override string TinhChuVi()
    {
        return "Hình tròn có chu vi: " +2*Math.PI* BanKinhR;
    }
    public override string TinhDienTich()
    {
        return "Hình tròn có diện tích: " +   Math.PI * BanKinhR * BanKinhR;
    }
}