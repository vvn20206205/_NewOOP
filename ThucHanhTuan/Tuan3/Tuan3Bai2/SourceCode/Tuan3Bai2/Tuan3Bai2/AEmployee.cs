public abstract class AEmployee : Person
{
    private string department;
    private double salary;
    private DateTime dateHire;

    protected string Department { get => department; set => department=value; }
    protected double Salary { get => salary; set => salary=value; }
    protected DateTime DateHire { get => dateHire; set => dateHire=value; }

    public abstract double CalculateBonus();
    public abstract int CalculateVacation();
}
