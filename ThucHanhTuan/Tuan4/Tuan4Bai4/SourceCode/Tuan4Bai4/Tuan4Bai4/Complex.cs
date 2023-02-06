using System;
internal class Complex {
    private double real;
    private double imaginary;

    public double Real { get => real; set => real=value; }
    public double Imaginary { get => imaginary; set => imaginary=value; }

    public Complex() {
        Real=0;
        Imaginary=0;
    }
    public Complex(double iReal,double iImaginary) {
        Real=iReal;
        Imaginary=iImaginary;
    }
    public void SetInputComplex(string iInputString) {
        HandleString(iInputString);
    }
    public void HandleString(string iInputString) {
        //xóa space đầu, cuối
        iInputString=iInputString.Trim();
        //thay thế 1 space bằng "" (nếu có)
        iInputString=iInputString.Replace(" ","");
        //split số phức bằng i..............
        string[] _temp = iInputString.Split("/");
        int _PlusSignPosition = iInputString.LastIndexOf("+");
        int _MinusSignPosition = iInputString.LastIndexOf("-");
        int _VirtualLocation = iInputString.LastIndexOf("i");
        if(_VirtualLocation<0) {
            Real=Convert.ToSingle(iInputString.Substring(0));
            Imaginary=0;
        } else {
            if(_PlusSignPosition>0) {
                Real=Convert.ToSingle(iInputString.Substring(0,_PlusSignPosition));
                Imaginary=Convert.ToSingle(iInputString.Substring(_PlusSignPosition,_VirtualLocation-_PlusSignPosition));
            } else {
                if(_MinusSignPosition>0) {
                    Real=Convert.ToSingle(iInputString.Substring(0,_MinusSignPosition));
                    Imaginary=Convert.ToSingle(iInputString.Substring(_MinusSignPosition,_VirtualLocation-_MinusSignPosition));
                } else {
                    Real=0;
                    Imaginary=Convert.ToSingle(iInputString.Substring(0,_VirtualLocation));
                }
            }
        }
    }
    public string Display() {
        return ("Số phức đã nhập là: "+ToString());
    }
    override public string ToString() {
        string _OutputString = "";
        if(Real==0&&Imaginary==0) {
            _OutputString+="0";
            return _OutputString;
        }

        _OutputString+=Real;
        if(Imaginary<0) {
            _OutputString+=Imaginary+"i";
        } else {
            _OutputString+="+"+Imaginary+"i";
        }
        _OutputString="("+_OutputString+")";

        return _OutputString;
    }
    //căn, lũy thừa, nghịch đảo, số đối. 
    public Complex Sqrt() {
        Complex _SqrtComplex = new Complex();
        if(Real==0&&Imaginary==0) {
            _SqrtComplex.Real=0;
            _SqrtComplex.Imaginary=0;
            return _SqrtComplex;
        }
        double _Module = Math.Sqrt(Real*Real+Imaginary*Imaginary);
        double _ArgumentCos = 0, _ArgumentSin = 0;
        if(Real>=0&&Imaginary>=0) { _ArgumentCos=Math.Acos(Real/_Module); _ArgumentSin=Math.Asin(Imaginary/_Module); }
        if(Real<=0&&Imaginary>=0) { _ArgumentCos=Math.Acos(Real/_Module); _ArgumentSin=Math.PI-Math.Asin(Imaginary/_Module); }
        if(Real<=0&&Imaginary<=0) { _ArgumentCos=-Math.Acos(Real/_Module); _ArgumentSin=-Math.PI-Math.Asin(Imaginary/_Module); }
        if(Real>=0&&Imaginary<=0) { _ArgumentCos=-Math.Acos(Real/_Module); _ArgumentSin=Math.Asin(Imaginary/_Module); }
        _SqrtComplex.Real=Math.Sqrt(_Module)*Math.Cos(_ArgumentCos/2);
        _SqrtComplex.Imaginary=Math.Sqrt(_Module)*Math.Sin(_ArgumentSin/2);
        return _SqrtComplex;
    }
    public Complex Exponential(int n) {
        Complex _ExponentialComplex = new Complex();
        for(int i = 0;i<n;i++) {
            _ExponentialComplex=this*this;
        }
        return _ExponentialComplex;
    }
    public Complex Inverse() {
        if(Real==0&&Imaginary==0) {
            throw new ArgumentNullException("Lỗi do chia cho 0!");
        } else {
            Complex _InverseComplex = new Complex(1,0);
            return _InverseComplex/this;
        }
    }
    public Complex Opposite() {
        Complex _oppositeComplex = new Complex();
        _oppositeComplex.Real=-Real;
        _oppositeComplex.Imaginary=-Imaginary;
        return _oppositeComplex;
    }
    //Nạp chồng toán tử
    //+, -, x, /,
    public static Complex operator +(Complex iComplex1,Complex iComplex2) {
        Complex _OutputComplex = new Complex();
        _OutputComplex.Real=iComplex1.Real+iComplex2.Real;
        _OutputComplex.Imaginary=iComplex1.Imaginary+iComplex2.Imaginary;
        return _OutputComplex;
    }
    public static Complex operator -(Complex iComplex1,Complex iComplex2) {
        Complex _OutputComplex = new Complex();
        _OutputComplex.Real=iComplex1.Real-iComplex2.Real;
        _OutputComplex.Imaginary=iComplex1.Imaginary-iComplex2.Imaginary;
        return _OutputComplex;
    }
    public static Complex operator *(Complex iComplex1,Complex iComplex2) {
        Complex _OutputComplex = new Complex();
        _OutputComplex.Real=iComplex1.Real*iComplex2.Real-iComplex1.Imaginary*iComplex2.Imaginary;
        _OutputComplex.Imaginary=iComplex1.Real*iComplex2.Imaginary+iComplex1.Imaginary*iComplex2.Real;
        return _OutputComplex;
    }
    public static Complex operator /(Complex iComplex1,Complex iComplex2) {
        if(iComplex2.Real==0&&iComplex2.Imaginary==0) {
            throw new ArgumentNullException("Lỗi do chia cho 0!");
        } else {
            Complex _OutputComplex = new Complex();
            _OutputComplex.Real=(iComplex1.Real*iComplex2.Real+iComplex1.Imaginary*iComplex2.Imaginary)/(iComplex2.Real*iComplex2.Real+iComplex2.Imaginary*iComplex2.Imaginary);
            _OutputComplex.Imaginary=(iComplex1.Imaginary*iComplex2.Real-iComplex1.Real*iComplex2.Imaginary)/(iComplex2.Real*iComplex2.Real+iComplex2.Imaginary*iComplex2.Imaginary);
            return _OutputComplex;
        }
    }
}