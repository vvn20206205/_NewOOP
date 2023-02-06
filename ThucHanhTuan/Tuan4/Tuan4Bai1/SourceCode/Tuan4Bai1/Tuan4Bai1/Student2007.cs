public class Student2007 : Student
{ 
    private double responsibilityScore;  
    public double ResponsibilityScore { get => responsibilityScore; set => responsibilityScore=value; }

    public Student2007(string iFullName, int iYearOld, string iSex, double iInformaticsScore, double iEnglishScore, double iPhilosophyScore, double iResponsibilityScore)
    {
        FullName = iFullName;
        YearOld = iYearOld;
        Sex = iSex;
        InformaticsScore = iInformaticsScore;
        EnglishScore = iEnglishScore;
        PhilosophyScore = iPhilosophyScore;
        ResponsibilityScore = iResponsibilityScore;
        FindMediumScore();
    }
    //- Viết lại hàm tính điểm trung bình có cộng thêm điểm trách nhiệm
    public override void FindMediumScore()
    {
        MediumScore = (InformaticsScore + EnglishScore + PhilosophyScore) / 3 + ResponsibilityScore;
        base.FindScholarship();
    }
    public override string  Display()
    {
        return    ("Thông tin sinh viên:\n"+ToString());
    }
    public override string ToString()
    {
        return
            $"\tHọ tên: {FullName}, Tuổi: {YearOld}, Giới tính: {Sex}, Điểm trách nhiệm: {ResponsibilityScore}," +
            $"\n\tĐiểm tin: {InformaticsScore}, Điểm tiếng anh: {EnglishScore}, Điểm triết học: {PhilosophyScore}, Điểm trung bình: {MediumScore}, Học bổng: {Scholarship}";
    }
}
