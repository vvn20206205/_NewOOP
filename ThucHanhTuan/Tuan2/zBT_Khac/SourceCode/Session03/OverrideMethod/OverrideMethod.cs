using System;
public class B
{
    public virtual void Display()
    {
        Console.WriteLine("Class B's Display Method");
    }
}
public class C : B
{
    public override void Display()
    {
        Console.WriteLine("Class C's Display Method");
    }
}
public class ContainedClass
{
    int MyInt = 0;
}
public class D : C
{
    public ContainedClass MyClass = new ContainedClass();
    public override void Display()
    {
        Console.WriteLine("Class D's Display Method");
    }
}
class ClassDemo1
{
    static void Main(string[] args)
    {
        B MyB = new D(); D MyD = new D();
        //Both result in in D's instance of Display being //called
        MyB.Display(); MyD.Display();
        Console.ReadLine();
    }
}
