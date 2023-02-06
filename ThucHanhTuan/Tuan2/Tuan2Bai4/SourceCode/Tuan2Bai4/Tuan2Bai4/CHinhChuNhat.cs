using System;
public class CHinhChuNhat : CHinh {
    private double chieuDai;
    private double chieuRong;

    public double ChieuDai { get { return chieuDai; } set { chieuDai=value; } }
    public double ChieuRong { get { return chieuRong; } set { chieuRong=value; } }
    public CHinhChuNhat() {
    }
    public CHinhChuNhat(double chieuDai,double chieuRong) {
        ChieuDai=chieuDai;
        ChieuRong=chieuRong;
    }
    public override string ToString() {
        return "Hình chữ nhật có chiều dài: "+ChieuDai+", có chiều rộng: "+ChieuRong;
    }
    public override string TinhChuVi() {
        return "Hình chữ nhật có chu vi: "+2*(ChieuDai+ChieuRong);
    }
    public override string TinhDienTich() {
        return "Hình chữ nhật có diện tích: "+ChieuDai*ChieuRong;
    }
}