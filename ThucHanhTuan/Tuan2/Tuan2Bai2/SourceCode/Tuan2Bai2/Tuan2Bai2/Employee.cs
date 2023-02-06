using System;
using static System.Net.Mime.MediaTypeNames;
// declare the Employee class
public class Employee {
    // declare the Employee fields

    private string firstName;
    private string lastName;
    private string address;
    private long sin; 
    private double salary;
    public string FirstName { get { return firstName; } set { firstName=value; } }
    public string LastName { get { return lastName; } set { lastName=value; } }
    public string Address { get { return address; } set { address=value; } }
    public long Sin { get { return sin; } set { sin=value; } }
    public double Salary { get { return salary; } set { salary=value; } }
    // Employee constructor 
    public Employee() {
    }
    public Employee(string ifirstName,string ilastName,string iaddress,long isin,double isalary) {
        FirstName=ifirstName;
        LastName=ilastName;
        Address=iaddress;
        Sin=isin;
        Salary=isalary;
    }
    // define the Employee method
    public double Bonus(double ipercentage) {
        return Salary*ipercentage;
    }
    override public string ToString() {
        double percentage = 5;

        return
                $"\n- Employee Information: "
                +$"\n- FirstName: {FirstName}"
                +$"\n- LastName: {LastName}"
                +$"\n- Address: {Address}"
                +$"\n- Sin: {Sin}"
                +$"\n- Salary: {Salary}"
                +$"\n- Bonus (percentage= {percentage}): {Bonus(percentage)}";
    }
}
