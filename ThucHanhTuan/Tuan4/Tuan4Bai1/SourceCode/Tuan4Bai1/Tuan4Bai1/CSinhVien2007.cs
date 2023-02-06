public class CSinhVien2007 : CSinhVien
{
    //- Thuộc tính mới: điểm trách nhiệm
    private double diemTrachNhiem;
    public double DiemTrachNhiem
    {
        get { return diemTrachNhiem; }
        set { diemTrachNhiem = value; }
    }
    public CSinhVien2007(string hoTen, int tuoi, string gioiTinh, double diemTin, double diemTiengAnh, double diemTrietHoc, double diemTrachNhiem)
    {
        HoTen = hoTen;
        Tuoi = tuoi;
        GioiTinh = gioiTinh;
        DiemTin = diemTin;
        DiemTiengAnh = diemTiengAnh;
        DiemTrietHoc = diemTrietHoc;
        DiemTrachNhiem = diemTrachNhiem;
        TinhDiemTrungBinh();
    }
    //- Viết lại hàm tính điểm trung bình có cộng thêm điểm trách nhiệm
    public override void TinhDiemTrungBinh()
    {
        DiemTrungBinh = (DiemTin + DiemTiengAnh + DiemTrietHoc) / 3 + DiemTrachNhiem;
        base.TinhHocBong();
    }
    //- Sửa lại hàm in thông tin của lớp CSinhvien thành hàm ảo để nạp chồng trong lớp CSinhvien2007 và in thêm thông tin về điểm trách nhiệm
    public override void InThongTinSinhVien()
    {
        Console.WriteLine("Thông tin sinh viên:\n");
        Console.WriteLine(ToString());
    }
    public override string ToString()
    {
        return
            $"\tHọ tên: {HoTen}, Tuổi: {Tuoi}, Giới tính: {GioiTinh}, Điểm trách nhiệm: {DiemTrachNhiem}," +
            $"\n\tĐiểm tin: {DiemTin}, Điểm tiếng anh: {DiemTiengAnh}, Điểm triết học: {DiemTrietHoc}, Điểm trung bình: {DiemTrungBinh}, Học bổng: {HocBong}";
    }
}
