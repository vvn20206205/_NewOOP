public class Faculty : Employee
{
    private string officeHours;
    private string rank;
    public string OfficeHours
    {
        get
        {
            return officeHours;
        }
        set
        {
            officeHours = value;
        }
    }
    public string Rank
    {
        get
        {
            return rank;
        }
        set
        {
            rank = value;
        }
    }
    public Faculty(string name, string phoneNumber, string emailAddress, string department, double salary, DateTime dateHire, string officeHours, string rank)
    {
        Name = name;
        PhoneNumber = phoneNumber;
        EmailAddress = emailAddress;
        Department = department;
        Salary = salary;
        DateHire = dateHire;
        OfficeHours = officeHours;
        Rank = rank;
    }

    public override string ToString()
    {
        return
            $"- Class Faculty:" +
            $"\n\tName : {Name}, " +
            $"\n\tPhone Number : {PhoneNumber}, " +
            $"\n\tEmail Address : {EmailAddress}, " +
            $"\n\tDepartment : {Department}, " +
            $"\n\tSalary : {Salary}, " +
            $"\n\tDate Hire : {DateHire}, " +
            $"\n\tOffice Hours : {OfficeHours}, " +
            $"\n\tRank : {Rank}, " +
            $"\n\tCalculate Bonus : {CalculateBonus()}, " +
            $"\n\tCalculate Vacation : {CalculateVacation()}";
    }
    public override double CalculateBonus()
    {
        return 1000 + 0.05 * Salary;
    }
    public override int CalculateVacation()
    {
        TimeSpan time = DateTime.Now - DateHire;
        if (time.Days / 365 > 3)
        {
            if (Rank.Equals("Senior Lecturer"))
            {
                return 6;
            }
            return 5;
        }
        else
        {
            return 4;
        }
    }
}