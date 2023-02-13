public abstract class AGeometricObject {
    #region Fields
    private string color;
    private double weight;
    #endregion
    #region Properties
    protected string Color { get => color; set => color=value; }
    protected double Weight { get => weight; set => weight=value; }
    #endregion
    #region Constructor

    protected AGeometricObject() {
        Color="white";
        Weight=1.0;
    }
    protected AGeometricObject(string iColor,double iWeight) {
        Color=iColor;
        Weight=iWeight;
    }
    #endregion
    #region Methods
    public abstract double FindArea();
    public abstract double FindPerimeter();
    #endregion
    #region Operator
    #endregion
    #region Events
    #endregion

}

