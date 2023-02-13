public abstract class AEmployee : Person {
    #region Fields
    private string department;
    private double salary;
    private DateTime dateHire;
    #endregion
    #region Properties
    protected string Department { get => department; set => department=value; }
    protected double Salary { get => salary; set => salary=value; }
    protected DateTime DateHire { get => dateHire; set => dateHire=value; }
    #endregion
    #region Constructor
    #endregion
    #region Methods
    public abstract double CalculateBonus();
    public abstract int CalculateVacation();
    #endregion
    #region Operator
    #endregion
    #region Events
    #endregion


}
