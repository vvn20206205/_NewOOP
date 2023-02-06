public class Circle : AGeometricObject {
    private double radius;

    public double Radius { get => radius; set => radius=value; }

    public Circle() {
    }

    public Circle(double iRadius) {
        Radius=iRadius;
    }

    public Circle(double iRadius,string iColor,double iWeight) {
        Radius=iRadius;
        Color=iColor;
        Weight=iWeight;
    }
    public override double FindArea() {
        return Radius*Radius*Math.PI;
    }

    public override double FindPerimeter() {
        return 2*Radius*Math.PI;
    }

    public override string ToString() {
        return $"=> Circle has radius of {Radius},  color {Color}, weighs {Weight},\n\tand Area: {FindArea()}, Perimeter: {FindPerimeter()}";
    }
}