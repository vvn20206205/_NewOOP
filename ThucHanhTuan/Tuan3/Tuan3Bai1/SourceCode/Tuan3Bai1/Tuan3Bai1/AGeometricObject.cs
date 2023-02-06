public abstract class AGeometricObject {
    private string color;
    private double weight;

    protected string Color { get => color; set => color=value; }
    protected double Weight { get => weight; set => weight=value; }

    protected AGeometricObject() {
        Color="white";
        Weight=1.0;
    }
    protected AGeometricObject(string iColor,double iWeight) {
        Color=iColor;
        Weight=iWeight;
    }
    public abstract double FindArea();
    public abstract double FindPerimeter();
}

