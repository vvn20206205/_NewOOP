using System;
using System.Drawing;
// Declare an abstract class
abstract class clsBase
{
    // Declare an abstract method.
    abstract public void
    Describe();

    // Declare an abstract property that has only a get accessor.
    abstract public double DoubleProp
    {
        get;
    }
    // Declare an abstract property that has only a set accessor.
    abstract public int IntProp
    {
        set;
    }
    // Declare an abstract propety that has both get and set accessors.
    abstract public string StringProp
    {
        get;
        set;
    }
    // Declare a method that will access the abstract members.
    public void GetAbstract()
    {
        // Get the DoubleProp, which will be in the derived class.
        Console.WriteLine("DoubleProp = " + DoubleProp);
        // You can only set the IntProp value. The storage is in the
        // derived class.
        IntProp = 42;

        // Set the StringProp value
        StringProp = "StringProperty actually is stored in " + "the derived class.";
        // Now show StringProp
        Console.WriteLine(StringProp);

        // Finally, call the abstract method
        Describe();
    }
}
// Derive a class from clsBase. You must implement the abstract members
class clsDerived : clsBase
{
    // Declare a constructor to set the DoubleProp member
    public clsDerived(double val)
    {
        m_Double = val;
    }
    // When you implement an abstract member in a derived class, you may not
    // change the type or access level.
    override public void Describe()
    {
        Console.WriteLine("You called Describe() from the base " + "class but the code body is in the \r\n" +
        "derived class");
        Console.WriteLine("m_Int = " + m_Int);
    }
    // Implement the DoubleProp property. This is where you provide a body
    // for the accessors.
    override public double DoubleProp
    {
        get { return (m_Double); }
    }
    // Implement the set accessor for IntProp.
    override public int IntProp
    {
        set { m_Int = value; }
    }

    // Implement StringProp, providing a body for both the get
    // and set accessors.
    override public string StringProp
    {
        get { return (m_String); }
        set { m_String = value; }
    }
    // Declare fields to support the properties.
    private double m_Double;
    private int m_Int;
    private string m_String;
}

class InterfaceDemo1
{
    static void Main(string[] args)
    {
        // Create an instance of the derived class.
        clsDerived derived = new clsDerived(3.14159);
        // Calling GetAbstract() actually calls the public method in the
        // base class. There is no GetAbstract() in the derived class.
        derived.GetAbstract();
        Console.ReadLine();
    }
}
