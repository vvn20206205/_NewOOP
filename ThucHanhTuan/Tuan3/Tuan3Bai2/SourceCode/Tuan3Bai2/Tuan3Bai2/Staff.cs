public class Staff : AEmployee
{
    private string title;

    public string Title { get => title; set => title=value; }

    public Staff(string iName, string iPhoneNumber, string iEmailAddress, string iDepartment, double iSalary, DateTime iDateHire,   string iTitle)
    {
        Name = iName;
        PhoneNumber = iPhoneNumber;
        EmailAddress = iEmailAddress;
        Department = iDepartment;
        Salary = iSalary;
        DateHire = iDateHire;
        Title = iTitle;
    }
    public override int CalculateVacation() {
        TimeSpan _time = DateTime.Now-DateHire;
        if(_time.Days/365>5) {
            return 4;
        } else {
            return 3;
        }
    }
    public override double CalculateBonus() {
        return 0.06*Salary;
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