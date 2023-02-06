using System;
// declare the Atom class
public class CAtom {
    // declare the Atom fields
    private int atomic_number;
    private string symbol;
    private string full_name;
    private float atomic_weight;
    public int AtomicNumber { get { return atomic_number; } set { atomic_number=value; } }
    public string Symbol { get { return symbol; } set { symbol=value; } }
    public string FullName { get { return full_name; } set { full_name=value; } }
    public float AtomicWeight { get { return atomic_weight; } set { atomic_weight=value; } }
    // Atom constructor 
    public CAtom() {
    }
    public CAtom(int iAtomicNumber,string iSymbol,string iFullName,float iAtomicWeight) {
        AtomicNumber=iAtomicNumber;
        Symbol=iSymbol;
        FullName=iFullName;
        AtomicWeight=iAtomicWeight;
    }
    // define the Atom method
    public Boolean Accept(string iAtomicNumber,string iSymbol,string iFullName,string iAtomicWeight) {
        int _temp_AtomicNumber;
        float _temp_iAtomicWeight;

        bool _check = int.TryParse(iAtomicNumber,out _temp_AtomicNumber);
        if(_check==false) { return false; }

        _check=float.TryParse(iAtomicWeight,out _temp_iAtomicWeight);
        if(_check==false) { return false; }

        AtomicNumber=_temp_AtomicNumber;
        Symbol=iSymbol;
        FullName=iFullName;
        AtomicWeight=_temp_iAtomicWeight;
        return true;
    }
    public string Display() {
        return $"{AtomicNumber}\t\t{Symbol}\t{FullName}\t\t{AtomicWeight}";
    }
}
