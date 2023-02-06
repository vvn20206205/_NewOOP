using System;
public class CHinhThang : CHinh {
    private double dayNho;
    private double canhBen1;
    private double dayLon;
    private double canhBen2;
    public double DayNho { get { return dayNho; } set { dayNho=value; } }
    public double CanhBen1 { get { return canhBen1; } set { canhBen1=value; } }
    public double DayLon { get { return dayLon; } set { dayLon=value; } }
    public double CanhBen2 { get { return canhBen2; } set { canhBen2=value; } }
    public CHinhThang() {
    }
    public CHinhThang(double dayNho,double canhBen1,double dayLon,double canhBen2) {
        DayNho=dayNho;
        CanhBen1=canhBen1;
        DayLon=dayLon;
        CanhBen2=canhBen2;
    }

  
    public override string ToString() {
        return "Hình thang có 4 cạnh lần lượt là: "+DayNho+", "+CanhBen1+", "+DayLon+", "+CanhBen2;
    }
    public override string TinhChuVi() {
        return "Hình thang có chu vi: "+(DayNho+CanhBen1+DayLon+CanhBen2);
    }
    public override string TinhDienTich() {
        double s = CanhBen1*CanhBen1*CanhBen2*CanhBen2;
        s+=CanhBen1*CanhBen1*(DayLon-DayNho)*(DayLon-DayNho);
        s+=CanhBen2*CanhBen2*(DayLon-DayNho)*(DayLon-DayNho);
        s*=2;
        s-=CanhBen1*CanhBen1*CanhBen1*CanhBen1+CanhBen2*CanhBen2*CanhBen2*CanhBen2+(DayLon-DayNho)*(DayLon-DayNho)*(DayLon-DayNho)*(DayLon-DayNho);
        s=Math.Sqrt(s);
        s*=(DayNho+DayLon);
        s/=(4*(DayLon-DayNho));
        return "Hình thang có diện tích: "+s;
    }
}