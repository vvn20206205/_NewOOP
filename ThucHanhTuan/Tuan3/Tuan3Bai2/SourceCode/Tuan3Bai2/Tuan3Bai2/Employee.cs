public abstract class Employee : Person
{
    protected string department;
    protected double salary;
    protected DateTime dateHire;
    public string Department
    {
        get
        {
            return department;
        }
        set
        {
            department = value;
        }
    }
    public double Salary
    {
        get
        {
            return salary;
        }
        set
        {
            salary = value;
        }
    }
    public DateTime DateHire
    {
        get
        {
            return dateHire;
        }
        set
        {
            dateHire = value;
        }
    }
    // Abstract method
    public abstract double CalculateBonus();
    public abstract int CalculateVacation();
}
