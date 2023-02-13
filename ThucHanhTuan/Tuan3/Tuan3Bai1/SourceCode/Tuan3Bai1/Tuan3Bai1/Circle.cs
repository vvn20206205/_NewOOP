public class Circle : AGeometricObject {
    #region Fields
    private double radius;
    #endregion
    #region Properties
    public double Radius { get => radius; set => radius=value; }
    #endregion
    #region Constructor


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
    #endregion
    #region Methods
    public override double FindArea() {
        return Radius*Radius*Math.PI;
    }

    public override double FindPerimeter() {
        return 2*Radius*Math.PI;
    }

    public override string ToString() {
        return $"=> Circle has radius of {Radius},  color {Color}, weighs {Weight},\n\tand Area: {FindArea()}, Perimeter: {FindPerimeter()}";
    }
    #endregion
    #region Operator
    #endregion
    #region Events
    #endregion
}