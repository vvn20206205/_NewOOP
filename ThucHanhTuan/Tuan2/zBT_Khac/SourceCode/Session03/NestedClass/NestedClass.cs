using System;
class Car
{
    // declare the Engine class
    public class Engine
    {
        // declare the Engine fields
        public int cylinders;
        public int horsepower;
        // define the Engine method
        public void Start()
        {
            System.Console.WriteLine("Engine started");
        }
    }
    // declare the Car fields
    public string make;
    public Engine engine;
    // Car has an Engine
    // define the Car method
    public void Start()
    {
        engine.Start();
    }
}
class ClassDemo2
{
    public static void Main()
    {
        // declare a Car object reference named myCar
        System.Console.WriteLine("Creating  a Car object");
        Car myCar = new Car();
        myCar.make = "Toyota";
        // Car objects have an Engine object
        System.Console.WriteLine("Creating  an Engine object");
        myCar.engine = new Car.Engine();
        myCar.engine.cylinders = 4;
        myCar.engine.horsepower = 180;
        // display the values for the Car and Engine object fields
        System.Console.WriteLine("myCar.make  = " + myCar.make); System.Console.WriteLine("myCar.engine.cylinders = " +
        myCar.engine.cylinders); System.Console.WriteLine("myCar.engine.horsepower = " +
        myCar.engine.horsepower);
        // call the Car object's Start() method
        myCar.Start();
        Console.ReadLine();
    }
}
