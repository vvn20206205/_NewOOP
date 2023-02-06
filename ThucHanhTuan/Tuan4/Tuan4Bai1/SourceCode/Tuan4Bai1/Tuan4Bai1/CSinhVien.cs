// class SinhVien

public   class CSinhVien
{
    // Thuộc tính SinhVien

    private string hoTen;
    private int tuoi;
    private string gioiTinh;
    private double diemTin;
    private double diemTiengAnh;
    private double diemTrietHoc;
    private double diemTrungBinh;
    private double hocBong;
    // Properties SinhVien
    public string HoTen
    {
        get { return hoTen; }
        set { hoTen = value; }
    }
    public int Tuoi
    {
        get { return tuoi; }
        set { tuoi = value; }
    }
    public string GioiTinh
    {
        get { return gioiTinh; }
        set { gioiTinh = value; }
    }
    public double DiemTin
    {
        get { return diemTin; }
        set { diemTin = value; }
    }
    public double DiemTiengAnh
    {
        get { return diemTiengAnh; }
        set { diemTiengAnh = value; }
    }
    public double DiemTrietHoc
    {
        get { return diemTrietHoc; }
        set { diemTrietHoc = value; }
    }
    public double DiemTrungBinh
    {
        get { return diemTrungBinh; }
        set { diemTrungBinh = value; }
    }
    public double HocBong
    {
        get { return hocBong; }
        set { hocBong = value; }
    }
    // SinhVien constructor
    // Default constructor
    public CSinhVien()
    {
        HocBong = 10000;
        Tuoi = 20;

        TinhDiemTrungBinh();
    }
    public CSinhVien(string hoTen, int tuoi)
    {
        HoTen = hoTen;
        Tuoi = tuoi;
        TinhDiemTrungBinh();
    }
    public CSinhVien(string hoTen, int tuoi, string gioiTinh, double diemTin, double diemTiengAnh, double diemTrietHoc)
    {
        HoTen = hoTen;
        Tuoi = tuoi;
        GioiTinh = gioiTinh;
        DiemTin = diemTin;
        DiemTiengAnh = diemTiengAnh;
        DiemTrietHoc = diemTrietHoc;
        TinhDiemTrungBinh();
    }
    // SinhVien method
    public virtual void TinhDiemTrungBinh()
    {
        DiemTrungBinh = (DiemTin + DiemTiengAnh + DiemTrietHoc) / 3;

        TinhHocBong();
    }
    public void TinhHocBong()
    {
        if (DiemTrungBinh >= 9)
        {
            HocBong = 200000;
        }
        else if (DiemTrungBinh >= 8)
        {
            HocBong = 160000;

        }
        else if (DiemTrungBinh >= 7)
        {
            HocBong = 120000;

        }
        else if (DiemTrungBinh >= 6)
        {
            HocBong = 90000;
        }

    }
    public virtual void InThongTinSinhVien()
    {
        Console.WriteLine("Thông tin sinh viên:\n");
        Console.WriteLine(ToString());
    }
    public override string ToString()
    {
        return
            $"\tHọ tên: {HoTen}, Tuổi: {Tuoi}, Giới tính: {GioiTinh}," +
            $"\n\tĐiểm tin: {DiemTin}, Điểm tiếng anh: {DiemTiengAnh}, Điểm triết học: {DiemTrietHoc}, Điểm trung bình: {DiemTrungBinh}, Học bổng: {HocBong}";
    }
    //Nạp chồng toán tử:
    //So sánh 2 sinh viên: >=/ <= dựa trên điểm trung bình
    public static bool operator >=(CSinhVien a, CSinhVien b)
    {
        return a.DiemTrungBinh >= b.DiemTrungBinh;
    }
    public static bool operator <=(CSinhVien a, CSinhVien b)
    {
        return a.DiemTrungBinh <= b.DiemTrungBinh;
    }
    //Cộng 2 sinh viên: lấy thông tin của sv1; học bổng = tổng học bổng của 2 sv
    public static CSinhVien operator +(CSinhVien a, CSinhVien b)
    {

        CSinhVien c = new CSinhVien();
        c.HoTen = a.HoTen;
        c.Tuoi = a.Tuoi;
        c.GioiTinh = a.GioiTinh;
        c.DiemTin = a.DiemTin;
        c.DiemTiengAnh = a.DiemTiengAnh;
        c.DiemTrietHoc = a.DiemTrietHoc;
        c.DiemTrungBinh = a.DiemTrungBinh;
        c.HocBong = a.HocBong+ b.HocBong;
        return c;
    }

}
