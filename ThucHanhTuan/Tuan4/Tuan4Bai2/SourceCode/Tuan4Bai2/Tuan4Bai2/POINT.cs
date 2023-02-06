// class POINT
public class POINT
{
    // Thuộc tính POINT

    private double toaDoX;
    private double toaDoY;
    // Properties POINT
    public double ToaDoX
    {
        get { return toaDoX; }
        set { toaDoX = value; }
    }
    public double ToaDoY
    {
        get { return toaDoY; }
        set { toaDoY = value; }
    }
    // POINT constructor
    // Default constructor
    public POINT()
    {
        ToaDoX = 0;
        ToaDoY = 0;
    }
    public POINT(double toaDoX, double toaDoY)
    {
        ToaDoX = toaDoX;
        ToaDoY = toaDoY;
    }

    // POINT method

    public double KhoangCachGocToaDo()
    {
        return Math.Sqrt(ToaDoX * ToaDoX + ToaDoY * ToaDoY);
    }
    public POINT DiemDoiXungTrucTung()
    {
        return new POINT(-ToaDoX, ToaDoY);
    }
    public POINT DiemDoiXungTrucHoanh()
    {
        return new POINT(ToaDoX, -ToaDoY);
    }
    public POINT DiemDoiXungToaDo()
    {
        return new POINT(-ToaDoX, -ToaDoY);
    }
    public override string ToString()
    {
        return $"ToaDoX: {ToaDoX}, ToaDoY: {ToaDoY}";
    }
    // Các toán tử:  cộng, trừ, nhân
    public static POINT operator +(POINT a, POINT b)
    {
        return new POINT(a.ToaDoX + b.ToaDoX, a.ToaDoY + b.ToaDoY);
    }
    public static POINT operator -(POINT a, POINT b)
    {
        return new POINT(a.ToaDoX - b.ToaDoX, a.ToaDoY - b.ToaDoY);
    }
    public static POINT operator *(POINT a, POINT b)
    {
        return new POINT(a.ToaDoX * b.ToaDoX, a.ToaDoY * b.ToaDoY);
    }
}