public class Student : Person
{
    private string nameProgram; 
    public string NameProgram { get => nameProgram; set => nameProgram=value; }
    public Student(string iName,string iPhoneNumber, string iEmailAddress, string iNameProgram)
    {
        Name = iName;
        PhoneNumber = iPhoneNumber;
        EmailAddress = iEmailAddress;
        NameProgram = iNameProgram;
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
