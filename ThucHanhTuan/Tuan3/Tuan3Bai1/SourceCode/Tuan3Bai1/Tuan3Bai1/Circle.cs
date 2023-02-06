public class Circle : GeometricObject
{
    private double radius;
    public double Radius
    {
        get
        { 
            return radius;
        }
        set
        {
            radius = value;
        }
    }

    public Circle()
    {
    }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public Circle(double radius, string color, double weight)
    {
        Radius = radius;
        Color = color;
        Weight = weight;
    }

    public void inputCircle()
    {
        Console.Write("\t\tEnter circle information:\n");
        bool kt = false;
        string input = "";
        double a;
        do
        {
            Console.Write("\t\tradius = ");
            input = Console.ReadLine();
            kt = double.TryParse(input, out a);
        } while (!kt || input == "");
        input = "";
        string b;
        do
        {
            Console.Write("\t\tcolor = ");

            input = Console.ReadLine();
            b = input;
        } while (input == "");
        input = "";
        double c;
        do
        {
            Console.Write("\t\tweight = ");
            input = Console.ReadLine();
            kt = double.TryParse(input, out c);
        } while (!kt || input == "");

        radius = a;
        color = b;
        weight = c;
       
    }
    public override double findArea()
    {
        return Radius * Radius * Math.PI;
    }

    public override double findPerimeter()
    {
        return 2 * Radius * Math.PI;
    }

    public override string ToString()
    {
        return $"=> Circle has radius of {Radius},  color {Color}, weighs {Weight},\n\tand Area: {findArea()}, Perimeter: {findPerimeter()}";
    }
}