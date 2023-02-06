using System;
// declare a Cat class
class Cat
{
    // a private static member to keep
    // track of how many Cat objects have
    // been created
    private static int instances = 0;
    private int weight;
    private String name;
    // cat constructor
    // increments the count of Cats
    public Cat(String name, int weight)
    {
        instances++; this.name = name; this.weight = weight;
    }
    // Static method to retrieve
    // the current number of Cats
    public static void HowManyCats()
    {
        Console.WriteLine("{0} cats adopted", instances);
    }
    public void TellWeight()
    {
        Console.WriteLine("{0} is {1} pounds",
        name, weight);
    }
}
class ClassDemo3
{
    public void Run()
    {
        Cat.HowManyCats();
        Cat frisky = new Cat("Frisky", 5); frisky.TellWeight(); Cat.HowManyCats();
        Cat whiskers = new Cat("Whisky", 7); whiskers.TellWeight(); Cat.HowManyCats();
    }
    public static void Main()
    {
        ClassDemo3 t = new ClassDemo3();
        t.Run();
        Console.ReadLine();
    }
}
