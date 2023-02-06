using System;
public class CHinh

{
    enum LoaiHinh { HinhTron, HinhChuNhat, HinhThang, HinhTamGiac }
    public CHinh()
    {
    }
    public virtual List<string> Display()
    {
        List<string> str_output = new List<string>();
        str_output.Add(ToString());
        str_output.Add(TinhChuVi());
        str_output.Add(TinhDienTich());
        return str_output;
    }
    public virtual string TinhChuVi()
    {
        return "Tính chu vi!";
    }
    public virtual string TinhDienTich()
    {
       return "Tính diện tích!";
    }
    public override string ToString()
    {
        return "Hình có các thuộc tính tương ứng!";
    }
}