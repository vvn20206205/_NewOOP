// class Tutors
public class Tutors {
    // Properties Tutors
    private string name;
    private string rank;
    private double salary;
    private double bonus;

    public string Name { get { return name; } set { name=value; } }
    public string Rank { get { return rank; } set { rank=value; } }
    public double Salary { get { return salary; } set { salary=value; } }
    public double Bonus { get { return bonus; } set { bonus=value; } }

    // Tutors constructor
    // Default constructor
    public Tutors() {
        Name="No information";
        Rank="No information";
        Salary=0;
        Bonus=0;
    }
    public Tutors(string iname,string irank,double isalary,double ibonus) {
        Name=iname;
        Rank=irank;
        Salary=isalary;
        Bonus=ibonus;
    }
    // Tutors method
    public override string ToString() {
        if(Salary<Bonus) {
            return $"Tên: {Name}, Cấp bậc: {Rank}, Lỗi Lương < thưởng?(Thể hiện tính đa hình)";
        }
        return $"Tên: {Name}, Cấp bậc: {Rank}, Lương: {Salary}, thưởng: {Bonus}";
    }
}

