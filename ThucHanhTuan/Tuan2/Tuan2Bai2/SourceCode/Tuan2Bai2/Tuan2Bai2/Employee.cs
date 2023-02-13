using System;
public class Employee {
    #region Fields
    private string firstName;
    private string lastName;
    private string address;
    private long sin;
    private double salary;
    #endregion
    #region Properties
    public string FirstName { get { return firstName; } set { firstName=value; } }
    public string LastName { get { return lastName; } set { lastName=value; } }
    public string Address { get { return address; } set { address=value; } }
    public long Sin { get { return sin; } set { sin=value; } }
    public double Salary { get { return salary; } set { salary=value; } }
    #endregion
    #region Constructor

    public Employee() {
    }
    public Employee(string iFirstName,string iLastName,string iAddress,long iSin,double iSalary) {
        FirstName=iFirstName;
        LastName=iLastName;
        Address=iAddress;
        Sin=iSin;
        Salary=iSalary;
    }
    #endregion
    #region Methods
    public double Bonus(double iPercentage) {
        return Salary*iPercentage;
    }
    override public string ToString() {
        return
                $"\n- Employee Information: "
                +$"\n- FirstName: {FirstName}"
                +$"\n- LastName: {LastName}"
                +$"\n- Address: {Address}"
                +$"\n- Sin: {Sin}"
                +$"\n- Salary: {Salary}";
    }
    #endregion
    #region Operator
    #endregion
    #region Events
    #endregion
}
