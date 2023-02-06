
public class Polynomial {
    private List<Complex> coefficient = new List<Complex>();
    private int degree;

    internal List<Complex> Coefficient { get => coefficient; set => coefficient=value; }
    public int Degree { get => degree; set => degree=value; }

    public Polynomial() {
        Coefficient=new List<Complex> { };
        Degree=Coefficient.Count();
    }
    public Polynomial(int iDegree,Complex iComplex) {
        iDegree=iDegree;
        for(int i = 0;i<iDegree-1;i++) {
            Coefficient.Add(new Complex());
        }
        Coefficient.Add(iComplex);
    }
    public Polynomial(List<Complex> iCoefficient) {
        Coefficient=iCoefficient;
        Degree=Coefficient.Count();
    }
    // Polynomial method

    // Các toán tử:  cộng, trừ, nhân
    public static Polynomial operator +(Polynomial iPolynomial1,Polynomial iPolynomial2) {
        int _Degree1, _Degree2, _Type;
        if(iPolynomial1.Degree>=iPolynomial2.Degree) {
            _Degree1=iPolynomial1.Degree;
            _Degree2=iPolynomial2.Degree;
            _Type=0;
        } else {
            _Degree1=iPolynomial2.Degree;
            _Degree2=iPolynomial1.Degree;
            _Type=1;
        }
        List<Complex> _Coefficient2 = new List<Complex>();
        for(int i = 0;i<_Degree2;i++) {
            Complex _ResultComplex = iPolynomial1.Coefficient[i]+iPolynomial2.Coefficient[i];
            _Coefficient2.Add(_ResultComplex);

        }
        for(int i = _Degree2;i<_Degree1;i++) {
            switch(_Type) {
                case 0:
                    _Coefficient2.Add(iPolynomial1.Coefficient[i]);

                    break;
                case 1:
                    _Coefficient2.Add(iPolynomial2.Coefficient[i]);

                    break;

            }


        }
        return   new Polynomial(_Coefficient2);
    }
    public static Polynomial operator -(Polynomial iPolynomial1,Polynomial iPolynomial2) {
        int _Degree1, _Degree2, _Type;
        if(iPolynomial1.Degree>=iPolynomial2.Degree) {
            _Degree1=iPolynomial1.Degree;
            _Degree2=iPolynomial2.Degree;
            _Type=0;
        } else {
            _Degree1=iPolynomial2.Degree;
            _Degree2=iPolynomial1.Degree;
            _Type=1;
        }
        List<Complex> _Coefficient2 = new List<Complex>();
        for(int i = 0;i<_Degree2;i++) {
            Complex _ResultComplex = iPolynomial1.Coefficient[i]-iPolynomial2.Coefficient[i];
            _Coefficient2.Add(_ResultComplex);

        }
        for(int i = _Degree2;i<_Degree1;i++) {
            switch(_Type) {
                case 0:
                    _Coefficient2.Add(iPolynomial1.Coefficient[i]);

                    break;
                case 1:
                    _Coefficient2.Add(iPolynomial2.Coefficient[i].Opposite());

                    break;

            }


        }
        return   new Polynomial(_Coefficient2);
    }
    public static Polynomial operator *(Polynomial iPolynomial1,Polynomial iPolynomial2) {
        List<Complex> _Coefficient2 = new List<Complex>();
        int _Degree = iPolynomial1.Degree+iPolynomial2.Degree-1;

        Complex _Complex0 = new Complex(0,0);
        for(int i = 0;i<_Degree;i++) {
            _Coefficient2.Add(_Complex0);

        }
        for(int i = 0;i<iPolynomial1.Degree;i++) {

            for(int j = 0;j<iPolynomial2.Degree;j++) {
                Complex _ResultComplex = iPolynomial1.Coefficient[i]*iPolynomial2.Coefficient[j];
                _Coefficient2[i+j]+=_ResultComplex;
            }
        }
        return   new Polynomial(_Coefficient2);
    }
    public Complex GetValue(Complex iComplex) {
        Complex _OutputComplex = new Complex(0,0);
        for(int i = 0;i<Degree;i++) {
            Complex _TempComplex = iComplex;
            for(int j = 0;j<i;j++) {
                _TempComplex=_TempComplex*iComplex;
            }
            _OutputComplex+=Coefficient[Degree-i-1]*_TempComplex;
        } 
        return _OutputComplex;
    }
    public Polynomial Square() {
        return this*this;
    }
    public Polynomial Derivative() {
        List<Complex> _Coefficient2 = new List<Complex>();
        for(int i = 1;i<Degree;i++) {

            Complex _ResultComplex = new Complex(i,0);
            _ResultComplex*=Coefficient[i];
            _Coefficient2.Add(_ResultComplex);
        }

        return   new Polynomial(_Coefficient2);


    }
    public Polynomial Primitive() {
        List<Complex> _Coefficient2 = new List<Complex>();
        Complex _Complex0 = new Complex(0,0);
        Complex _Complex1 = new Complex(1,0);
        _Coefficient2.Add(_Complex0);

        for(int i = 0;i<Degree;i++) {
            Complex _ResultComplex = new Complex(i,0);
            _ResultComplex=Coefficient[i]/(_ResultComplex+_Complex1);
            _Coefficient2.Add(_ResultComplex);
        }

        return new Polynomial(_Coefficient2);
    } 
    public override string ToString() {
        string _OutputString = "";
        if(Degree==0) {
            return "0";
        } else {
            for(int i = 0;i<Degree;i++) {
                if(i==0) {

                    _OutputString+="";
                } else {


                    _OutputString+=" + ";
                }
                _OutputString+=$"{Coefficient[i].ToString()}*x^ {i}";

            }


        }
        return _OutputString;
    }
}