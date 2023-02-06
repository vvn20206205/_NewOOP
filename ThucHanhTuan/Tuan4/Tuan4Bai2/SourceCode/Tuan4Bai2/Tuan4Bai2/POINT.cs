using System.Drawing;

public class Point {
    private double coordinatesX;
    private double coordinatesY;

    public double CoordinatesX { get => coordinatesX; set => coordinatesX=value; }
    public double CoordinatesY { get => coordinatesY; set => coordinatesY=value; }

    public Point() {
        CoordinatesX=0;
        CoordinatesY=0;
    }
    public Point(double iCoordinatesX,double iCoordinatesY) {
        CoordinatesX=iCoordinatesX;
        CoordinatesY=iCoordinatesY;
    }

    public double OriginDistanceO() {
        return Math.Sqrt(CoordinatesX*CoordinatesX+CoordinatesY*CoordinatesY);
    }
    public Point PointSymmetryVerticalAxis() {
        return new Point(-CoordinatesX,CoordinatesY);
    }
    public Point PointSymmetryHorizontalAxis() {
        return new Point(CoordinatesX,-CoordinatesY);
    }
    public Point PointSymmetryOriginDistanceO() {
        
        return new Point(-CoordinatesX,-CoordinatesY);
    }
    public override string ToString() {
        return $"CoordinatesX: {CoordinatesX}, CoordinatesY: {CoordinatesY}";
    }
    // Các toán tử:  cộng, trừ, nhân
    public static Point operator +(Point iPoint1,Point iPoint2) {
        return new Point(iPoint1.CoordinatesX+iPoint2.CoordinatesX,iPoint1.CoordinatesY+iPoint2.CoordinatesY);
    }
    public static Point operator -(Point iPoint1,Point iPoint2) {
        return new Point(iPoint1.CoordinatesX-iPoint2.CoordinatesX,iPoint1.CoordinatesY-iPoint2.CoordinatesY);
    }
    public static Point operator *(Point iPoint1,Point iPoint2) {
        return new Point(iPoint1.CoordinatesX*iPoint2.CoordinatesX,iPoint1.CoordinatesY*iPoint2.CoordinatesY);
    }
}