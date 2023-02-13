public abstract class Person {
    #region Fields
    private string name;
    private string phoneNumber;
    private string emailAddress;
    #endregion
    #region Properties
    protected string Name { get => name; set => name=value; }
    protected string PhoneNumber { get => phoneNumber; set => phoneNumber=value; }
    protected string EmailAddress { get => emailAddress; set => emailAddress=value; }
    #endregion
    #region Constructor
    protected Person() {
    }
    protected Person(string iName,string iPhoneNumber,string iEmailAddress) {
        Name=iName;
        PhoneNumber=iPhoneNumber;
        EmailAddress=iEmailAddress;
    }
    #endregion
    #region Methods
    public override string ToString() {
        return $"Name: {Name}, Phone number: {PhoneNumber}, Email address: {EmailAddress}";
    }
    #endregion
    #region Operator
    #endregion
    #region Events
    #endregion


}
