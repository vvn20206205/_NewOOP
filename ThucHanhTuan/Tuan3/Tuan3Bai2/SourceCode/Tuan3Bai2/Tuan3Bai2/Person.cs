public abstract class Person
{
    private string name;
    private string phoneNumber;
    private string emailAddress;

    protected string Name { get => name; set => name=value; }
    protected string PhoneNumber { get => phoneNumber; set => phoneNumber=value; }
    protected string EmailAddress { get => emailAddress; set => emailAddress=value; }

    protected Person()
    {
    }
    protected Person(string iName, string iPhoneNumber, string iEmailAddress)
    {
        Name = iName;
        PhoneNumber = iPhoneNumber;
        EmailAddress = iEmailAddress;
    }
    public override string ToString()
    {
        return $"Name: {Name}, Phone number: {PhoneNumber}, Email address: {EmailAddress}";
    }
}
