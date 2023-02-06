using System;
using System.Xml.Linq;

public class Student : People {
    private double mark;
    public double Mark { get { return mark; } set { mark=value; } }
    // Default construct
    public Student() {
    }

    // Construct a geometric object
    public Student(string name,int age,double mark) {
        Name=name;
        Age=age;
        Mark=mark;
    }
    public override string ToString() {
        return "Name: "+Name+"\t\tAge: "+Age+"\t\tMark: "+Mark;
    }
}