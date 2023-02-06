using System;
public class CHinhTamGiac : CHinh {
    private double canh1;
    private double canh2;
    private double canh3;

    public double Canh1 { get { return canh1; } set { canh1=value; } }
    public double Canh2 { get { return canh2; } set { canh2=value; } }
    public double Canh3 { get { return canh3; } set { canh3=value; } }
    public CHinhTamGiac() {
    }
    public CHinhTamGiac(double icanh1,double icanh2,double icanh3) {
        Canh1=icanh1;
        Canh2=icanh2;
        Canh3=icanh3;
    }
    public double NuaChuViP() {
        return (Canh1+Canh2+Canh3)/2;
    }
    public override string ToString(){
        return "Hình thang có 3 cạnh lần lượt là: "+Canh1+", "+Canh2+", "+Canh3;
    }
    public override string TinhChuVi() {
        return "Hình tam giác có chu vi: "+(Canh1+Canh2+Canh3);
    }
    public override string TinhDienTich() {
        double p = NuaChuViP();
        return "Hình tam giác có diện tích: "+Math.Sqrt(p*(p-Canh1)*(p-Canh2)*(p-Canh3));
    }
}