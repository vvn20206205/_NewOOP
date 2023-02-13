public class Student : Person {
    #region Fields
    private string nameProgram;
    #endregion
    #region Properties
    public string NameProgram { get => nameProgram; set => nameProgram=value; }
    #endregion
    #region Constructor
    public Student(string iName,string iPhoneNumber,string iEmailAddress,string iNameProgram) {
        Name=iName;
        PhoneNumber=iPhoneNumber;
        EmailAddress=iEmailAddress;
        NameProgram=iNameProgram;
    }
    #endregion
    #region Methods
    public override string ToString() {
        return
            $"- Class Student:"+
            $"\n\tName: {Name}, "+
            $"\n\tPhone Number: {PhoneNumber}, "+
            $"\n\tEmail Address: {EmailAddress}, "+
            $"\n\tName Program: {NameProgram}";
    }
    #endregion
    #region Operator
    #endregion
    #region Events
    #endregion


}
