public abstract class GeometricObject
{
    protected string color;
    protected double weight;
    // Default construct 
    protected GeometricObject()
    { 
        color = "white";
        weight = 1.0;
    }
    // Construct a geometric object
    protected GeometricObject(string color, double weight)
    {
        this.color = color;
        this.weight = weight;
    }
    public string Color
    {
        get
        {
            return color;
        }
        set
        {
            color = value;
        }
    }
    public double Weight
    {
        get
        {
            return weight;

        }
        set
        {
            weight = value;
        }
    }
    // Abstract method
    public abstract double findArea();
    // Abstract method
    public abstract double findPerimeter();
}

