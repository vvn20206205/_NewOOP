using System;
internal class QuadraticEquation {
    private Complex quadraticFactor2;
    private Complex quadraticFactor1;
    private Complex quadraticFactor0;

    protected Complex QuadraticFactor2 { get => quadraticFactor2; set => quadraticFactor2=value; }
    protected Complex QuadraticFactor1 { get => quadraticFactor1; set => quadraticFactor1=value; }
    protected Complex QuadraticFactor0 { get => quadraticFactor0; set => quadraticFactor0=value; }

    public QuadraticEquation() {
    }
    public QuadraticEquation(Complex iQquadraticFactor2,Complex iQquadraticFactor1,Complex iQquadraticFactor0) {
        quadraticFactor2=iQquadraticFactor2;
        quadraticFactor1=iQquadraticFactor1;
        quadraticFactor0=iQquadraticFactor0;
    } 
    public string Display() {
    return("Phương trình đã nhập là: \n"+ToString());
    }
    //Giải phương trình 
    public virtual string SolveQuadraticEquation() {
        // ("Phương trình bậc 2 đã nhập là: \n" + ToString());
        //Tạo số phức 4 của delta =b^2-4ac
        //Tạo số phức 0 và 2 
        Complex _Complex4 = new Complex(4,0);
        Complex _Complex0 = new Complex(0,0);
        Complex _Complex2 = new Complex(2,0);
        if(QuadraticFactor2.Real==_Complex0.Real&&QuadraticFactor2.Imaginary==_Complex0.Imaginary) {
            if(QuadraticFactor1.Real==_Complex0.Real&&QuadraticFactor1.Imaginary==_Complex0.Imaginary) {
                if(QuadraticFactor0.Real==_Complex0.Real&&QuadraticFactor0.Imaginary==_Complex0.Imaginary) {
                    return ("Phương trình vô số nghiệm!");
                } else {
                    return ("Phương trình vô nghiệm!");
                }
            } else {
                return ("Phương trình có 1 nghiệm: x = "+((_Complex0-QuadraticFactor0)/QuadraticFactor1));
            }
        } else {
            //Tính delta
            Complex _Delta = new Complex();
            _Delta=QuadraticFactor1.Exponential(2)-_Complex4*QuadraticFactor2*QuadraticFactor0;
            if(_Delta.Real==0&&_Delta.Imaginary==0) {
                Complex _Result0 = new Complex();
                _Result0=(_Complex0-QuadraticFactor1)/_Complex2*QuadraticFactor2;
                return ("Nghiệm của phương trình đã cho là: x1 = x2 = "+_Result0.ToString()+" ( nghiệm kép )");
            } else {
                //Tính căn delta
                Complex _SqrtDelta1 = new Complex();
                Complex _SqrtDelta2 = new Complex();
                _SqrtDelta1=_Delta.Sqrt();
                _SqrtDelta2=_Complex0-_SqrtDelta1;
                //Tính nghiệm
                Complex _Result1 = new Complex();
                Complex _Result2 = new Complex();
                _Result1=((_Complex0-QuadraticFactor1)+_SqrtDelta1)/(_Complex2*QuadraticFactor2);
                _Result2=((_Complex0-QuadraticFactor1)+_SqrtDelta2)/(_Complex2*QuadraticFactor2);
                return ("Nghiệm của phương trình đã cho là:\n\n\tx1 = "+_Result1.ToString()+"\n\tx2 = "+_Result2.ToString());
            }
        }
    }
    override public string ToString() {
        string _OutputString = "";
        _OutputString+=QuadraticFactor2.ToString()+" x^2 + ";
        _OutputString+=QuadraticFactor1.ToString()+" x + ";
        _OutputString+=QuadraticFactor0.ToString()+" = 0";
        return _OutputString;
    }
}