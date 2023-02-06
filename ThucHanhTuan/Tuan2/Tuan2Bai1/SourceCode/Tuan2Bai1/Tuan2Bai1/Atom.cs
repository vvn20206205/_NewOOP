using System; 
public class Atom { 
    private string atomicNumber;
    private string symbol;
    private string fullName;
    private string atomicWeight;

    public string AtomicNumber { get => atomicNumber; set => atomicNumber=value; }
    public string Symbol { get => symbol; set => symbol=value; }
    public string FullName { get => fullName; set => fullName=value; }
    public string AtomicWeight { get => atomicWeight; set => atomicWeight=value; }

    public Atom() {
    } 
    public bool Accept() {
        int _atomicNumber;
        if(!int.TryParse(AtomicNumber,out _atomicNumber)) { 
            return false;
        } 
        if(string.IsNullOrEmpty(symbol)) { 
            return false;
        }  
        if(string.IsNullOrEmpty(fullName)) { 
            return false;
        }
        float _atomicWeight;
        if(!float.TryParse(atomicWeight,out _atomicWeight)) { 
            return false;
        }
        return true;
    }
    public string Display() {
        return $"{AtomicNumber}\t\t{Symbol}\t{FullName}\t\t{AtomicWeight}";
    }
}