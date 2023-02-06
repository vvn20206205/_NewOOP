using System;
public class MultidimensionalSpace
{
    private List<double> multidimensionalCoordinates = new List<double>();
    private int dimensionalNumber;

    public List<double> MultidimensionalCoordinates { get => multidimensionalCoordinates; set => multidimensionalCoordinates=value; }
    public int DimensionalNumber { get => dimensionalNumber; set => dimensionalNumber=value; }

    public MultidimensionalSpace()
    {
        MultidimensionalCoordinates= new List<double> { };
        DimensionalNumber=MultidimensionalCoordinates.Count();
    }
    public MultidimensionalSpace(int iDimensionalNumber)
    {
        DimensionalNumber=iDimensionalNumber;
        for (int i = 0; i <DimensionalNumber; i++)
        {
            MultidimensionalCoordinates.Add(0);
        }
    }
    public MultidimensionalSpace(List<double> iMultidimensionalCoordinates)
    {
        MultidimensionalCoordinates = iMultidimensionalCoordinates;
        DimensionalNumber = MultidimensionalCoordinates.Count();
    } 
    public double OriginDistanceO()
    { 
        double _Distance = 0;
        for (int i = 0; i < DimensionalNumber; i++)
        {
            _Distance += MultidimensionalCoordinates[i] * MultidimensionalCoordinates[i];
        }
        return Math.Abs(_Distance);
    }
    public MultidimensionalSpace PointSymmetryOriginDistanceO()
    {
        List<double> _MultidimensionalCoordinates2 = new List<double>();

        for (int i = 0; i < DimensionalNumber; i++)
        {
            _MultidimensionalCoordinates2.Add(-MultidimensionalCoordinates[i]);
        }
        return new MultidimensionalSpace(_MultidimensionalCoordinates2);
    }
    // Các toán tử:  cộng, trừ, nhân
    public static MultidimensionalSpace operator +(MultidimensionalSpace iMultidimensionalSpace1, MultidimensionalSpace iMultidimensionalSpace2)
    {
        MultidimensionalSpace _OutputMultidimensionalSpace = new MultidimensionalSpace(iMultidimensionalSpace1.DimensionalNumber);
        for (int i = 0; i < iMultidimensionalSpace1.DimensionalNumber; i++)
        {
            _OutputMultidimensionalSpace.MultidimensionalCoordinates[i] = iMultidimensionalSpace1.MultidimensionalCoordinates[i] + iMultidimensionalSpace2.MultidimensionalCoordinates[i];
        }
        return _OutputMultidimensionalSpace;
    }
    public static MultidimensionalSpace operator -(MultidimensionalSpace iMultidimensionalSpace1, MultidimensionalSpace iMultidimensionalSpace2)
    {
        MultidimensionalSpace _OutputMultidimensionalSpace = new MultidimensionalSpace(iMultidimensionalSpace1.DimensionalNumber);
        for (int i = 0; i < iMultidimensionalSpace1.DimensionalNumber; i++)
        {
            _OutputMultidimensionalSpace.MultidimensionalCoordinates[i] = iMultidimensionalSpace1.MultidimensionalCoordinates[i] - iMultidimensionalSpace2.MultidimensionalCoordinates[i];
        }
        return _OutputMultidimensionalSpace;
    }
    public static MultidimensionalSpace operator *(MultidimensionalSpace iMultidimensionalSpace1, MultidimensionalSpace iMultidimensionalSpace2)
    {
        MultidimensionalSpace _OutputMultidimensionalSpace = new MultidimensionalSpace(iMultidimensionalSpace1.DimensionalNumber);
        for (int i = 0; i < iMultidimensionalSpace1.DimensionalNumber; i++)
        {
            _OutputMultidimensionalSpace.MultidimensionalCoordinates[i] = iMultidimensionalSpace1.MultidimensionalCoordinates[i] * iMultidimensionalSpace2.MultidimensionalCoordinates[i];
        }
        return _OutputMultidimensionalSpace;
    }
    public override string ToString()
    {
        string _OutputString = "[";
        for (int i = 0; i < DimensionalNumber; i++)
        {
            _OutputString += Convert.ToString(MultidimensionalCoordinates[i]);
            if (i == DimensionalNumber - 1)
            {
                _OutputString += "";

            }
            else
            {
                _OutputString += ",";

            }
        }
        _OutputString += "]";
        return _OutputString;
    }
}