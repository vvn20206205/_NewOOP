using System;
internal class FirstDegreeEquation : QuadraticEquation {
    #region Fields
    #endregion
    #region Properties
    #endregion
    #region Constructor
    public FirstDegreeEquation() {
        Complex _Complex0 = new Complex(0,0);
        QuadraticFactor2=_Complex0;
    }
    public FirstDegreeEquation(Complex iQuadraticFactor1,Complex iQuadraticFactor0) {
        Complex _Complex0 = new Complex(0,0);
        QuadraticFactor2=_Complex0;
        QuadraticFactor1=iQuadraticFactor1;
        QuadraticFactor0=iQuadraticFactor0;
    }
    #endregion
    #region Methods
    public string Display() {
        return ("Phương trình đã nhập là: \n"+ToString());
    }
    public override string SolveQuadraticEquation() {
        Complex _Complex0 = new Complex(0,0);
        if(QuadraticFactor1.Real==_Complex0.Real&&QuadraticFactor1.Imaginary==_Complex0.Imaginary) {
            if(QuadraticFactor0.Real==_Complex0.Real&&QuadraticFactor0.Imaginary==_Complex0.Imaginary) {
                return ("Phương trình vô số nghiệm!");
            } else {
                return ("Phương trình vô nghiệm!");
            }
        } else {
            return ("Phương trình có 1 nghiệm: x = "+((_Complex0-QuadraticFactor0)/QuadraticFactor1));
        }
    }
    public override  string ToString() {
        string MyString = "";
        MyString+=QuadraticFactor1.ToString()+" x + ";
        MyString+=QuadraticFactor0.ToString()+" = 0";
        return MyString;
    }
    #endregion
    #region Operator
    #endregion
    #region Events
    #endregion
}