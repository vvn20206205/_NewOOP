public class Student : Person
{
    private string nameProgram;
    public string NameProgram
    {
        get
        {
            return nameProgram;
        }
        set
        {
            nameProgram = value;
        }
    }
    public Student(string name, string phoneNumber, string emailAddress, string nameProgram)
    {
        Name = name;
        PhoneNumber = phoneNumber;
        EmailAddress = emailAddress;
        NameProgram = nameProgram;
    }

    public override string ToString()
    {
        return 
            $"- Class Student:" +
            $"\n\tName: {Name}, " +
            $"\n\tPhone Number: {PhoneNumber}, " +
            $"\n\tEmail Address: {EmailAddress}, " +
            $"\n\tName Program: {NameProgram}";
    }
}
