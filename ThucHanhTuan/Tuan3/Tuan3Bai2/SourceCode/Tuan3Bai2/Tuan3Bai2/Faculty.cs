public class Faculty : AEmployee {
    #region Fields
    private string officeHours;
    private string rank;
    #endregion
    #region Properties
    public string OfficeHours { get => officeHours; set => officeHours=value; }
    public string Rank { get => rank; set => rank=value; }
    #endregion
    #region Constructor

    public Faculty(string iName,string iPhoneNumber,string iEmailAddress,string iDepartment,double iSalary,DateTime iDateHire,string iOfficeHours,string iRank) {
        Name=iName;
        PhoneNumber=iPhoneNumber;
        EmailAddress=iEmailAddress;
        Department=iDepartment;
        Salary=iSalary;
        DateHire=iDateHire;
        OfficeHours=iOfficeHours;
        Rank=iRank;
    }

    #endregion
    #region Methods
    public override string ToString() {
        return
            $"- Class Faculty:"+
            $"\n\tName : {Name}, "+
            $"\n\tPhone Number : {PhoneNumber}, "+
            $"\n\tEmail Address : {EmailAddress}, "+
            $"\n\tDepartment : {Department}, "+
            $"\n\tSalary : {Salary}, "+
            $"\n\tDate Hire : {DateHire}, "+
            $"\n\tOffice Hours : {OfficeHours}, "+
            $"\n\tRank : {Rank}, "+
            $"\n\tCalculate Bonus : {CalculateBonus()}, "+
            $"\n\tCalculate Vacation : {CalculateVacation()}";
    }
    public override double CalculateBonus() {
        return 1000+0.05*Salary;
    }
    public override int CalculateVacation() {
        TimeSpan _time = DateTime.Now-DateHire;
        if(_time.Days/365>3) {
            if(Rank.Equals("Senior Lecturer")) {
                return 6;
            }
            return 5;
        } else {
            return 4;
        }
    }
    #endregion
    #region Operator
    #endregion
    #region Events
    #endregion

}