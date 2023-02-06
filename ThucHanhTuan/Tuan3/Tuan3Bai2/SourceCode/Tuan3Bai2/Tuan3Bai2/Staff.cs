public class Staff : Employee
{
    public string title;
    public string Title
    {
        get
        {
            return title;
        }
        set
        {
            title = value;
        }
    }
    public override double CalculateBonus()
    {
        return 0.06 * Salary;
    }
    public override int CalculateVacation()
    {
        TimeSpan time = DateTime.Now - DateHire;
        if (time.Days / 365 > 5)
        {
            return 4;
        }
        else
        {
            return 3;
        }
    }
    public Staff(string name, string phoneNumber, string emailAddress, string department, double salary, DateTime dateHire,   string title)
    {
        Name = name;
        PhoneNumber = phoneNumber;
        EmailAddress = emailAddress;
        Department = department;
        Salary = salary;
        DateHire = dateHire;
        Title = title;
    }
    public override string ToString()
    {
        return
            $"- Class Staff:" +
            $"\n\tName : {Name}, " +
            $"\n\tPhone Number : {PhoneNumber}, " +
            $"\n\tEmail Address : {EmailAddress}, " +
            $"\n\tDepartment : {Department}, " +
            $"\n\tSalary : {Salary}, " +
            $"\n\tDate Hire : {DateHire}, " +
            $"\n\tTitle : {Title}, " +
            $"\n\tCalculate Bonus : {CalculateBonus()}, " +
            $"\n\tCalculate Vacation : {CalculateVacation()}";
    }
}