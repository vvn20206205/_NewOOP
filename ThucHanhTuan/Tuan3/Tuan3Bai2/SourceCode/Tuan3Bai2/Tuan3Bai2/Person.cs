public abstract class Person
{
    protected string name;
    protected string phoneNumber;
    protected string emailAddress;
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }
    public string PhoneNumber
    {
        get
        {
            return phoneNumber;
        }
        set
        {
            phoneNumber = value;
        }
    }
    public string EmailAddress
    {
        get
        {
            return emailAddress;
        }
        set
        {
            emailAddress = value;
        }
    }
    // Default construct 
    protected Person()
    {
    }
    protected Person(string name, string phoneNumber, string emailAddress)
    {
        Name = name;
        PhoneNumber = phoneNumber;
        EmailAddress = emailAddress;
    }
    public override string ToString()
    {
        return $"Name: {Name}, Phone number: {PhoneNumber}, Email address: {EmailAddress}";
    }
}
