public class Student {
    private string fullName;
    private int yearOld;
    private string sex;
    private double informaticsScore;
    private double englishScore;
    private double philosophyScore;
    private double mediumScore;
    private double scholarship;

    public string FullName { get => fullName; set => fullName=value; }
    public int YearOld { get => yearOld; set => yearOld=value; }
    public string Sex { get => sex; set => sex=value; }
    public double InformaticsScore { get => informaticsScore; set => informaticsScore=value; }
    public double EnglishScore { get => englishScore; set => englishScore=value; }
    public double PhilosophyScore { get => philosophyScore; set => philosophyScore=value; }
    public double MediumScore { get => mediumScore; set => mediumScore=value; }
    public double Scholarship { get => scholarship; set => scholarship=value; }

    public Student() {
        Scholarship=10000;
        YearOld=20;

        FindMediumScore();
    }
    public Student(string iFullName,int iYearOld) {
        FullName=iFullName;
        YearOld=iYearOld;
        FindMediumScore();
    }
    public Student(string iFullName,int iYearOld,string iSex,double iInformaticsScore,double iEnglishScore,double iPhilosophyScore) {
        FullName=iFullName;
        YearOld=iYearOld;
        Sex=iSex;
        InformaticsScore=iInformaticsScore;
        EnglishScore=iEnglishScore;
        PhilosophyScore=iPhilosophyScore;
        FindMediumScore();
    }
    public virtual void FindMediumScore() {
        MediumScore=(InformaticsScore+EnglishScore+PhilosophyScore)/3;
        FindScholarship();
    }
    public void FindScholarship() {
        if(MediumScore>=9) {
            Scholarship=200000;
            return;
        }
        if(MediumScore>=8) {
            Scholarship=160000;
            return;
        }
        if(MediumScore>=7) {
            Scholarship=120000;
            return;
        }
        if(MediumScore>=6) {
            Scholarship=90000;
            return;
        }
    }
    public virtual string Display() {
        return ("Thông tin sinh viên:\n"+ToString());
    }
    public override string ToString() {
        return
            $"\tHọ tên: {FullName}, Tuổi: {YearOld}, Giới tính: {Sex},"+
            $"\n\tĐiểm tin: {InformaticsScore}, Điểm tiếng anh: {EnglishScore}, Điểm triết học: {PhilosophyScore}, Điểm trung bình: {MediumScore}, Học bổng: {Scholarship}";
    }
    //Nạp chồng toán tử:
    //So sánh 2 sinh viên: >=/ <= dựa trên điểm trung bình
    public static bool operator >=(Student iStudent1,Student iStudent2) {
        return iStudent1.MediumScore>=iStudent2.MediumScore;
    }
    public static bool operator <=(Student iStudent1,Student iStudent2) {
        return iStudent1.MediumScore<=iStudent2.MediumScore;
    }
    //Cộng 2 sinh viên: lấy thông tin của sv1; học bổng = tổng học bổng của 2 sv
    public static Student operator +(Student iStudent1,Student iStudent2) {

        Student _StudentOutput = new Student();
        _StudentOutput.FullName=iStudent1.FullName;
        _StudentOutput.YearOld=iStudent1.YearOld;
        _StudentOutput.Sex=iStudent1.Sex;
        _StudentOutput.InformaticsScore=iStudent1.InformaticsScore;
        _StudentOutput.EnglishScore=iStudent1.EnglishScore;
        _StudentOutput.PhilosophyScore=iStudent1.PhilosophyScore;
        _StudentOutput.MediumScore=iStudent1.MediumScore;
        _StudentOutput.Scholarship=iStudent1.Scholarship+iStudent2.Scholarship;
        return _StudentOutput;
    }

}
