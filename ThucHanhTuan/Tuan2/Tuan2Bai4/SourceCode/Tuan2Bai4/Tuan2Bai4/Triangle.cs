using System;
namespace Tuan2Bai4 {
    public class Triangle : AShape {
        #region Fields
        private double edge1;
        private double edge2;
        private double edge3;
        #endregion
        #region Properties
        public double Edge1 { get => edge1; set => edge1=value; }
        public double Edge2 { get => edge2; set => edge2=value; }
        public double Edge3 { get => edge3; set => edge3=value; }
        #endregion
        #region Constructor
        public Triangle() {
        }
        public Triangle(double iEdge1,double iEdge2,double iEdge3) {
            Edge1=iEdge1;
            Edge2=iEdge2;
            Edge3=iEdge3;
        }
        #endregion
        #region Methods
        public double HalfCircumference() {
            return (Edge1+Edge2+Edge3)/2;
        }
        public override string ToString() {
            return "Hình thang có 3 cạnh lần lượt là: "+Edge1+", "+Edge2+", "+Edge3;
        }
        public override string GetPerimeter() {
            return "Hình tam giác có chu vi: "+(Edge1+Edge2+Edge3);
        }
        public override string GetArea() {
            double _HalfCircumference = HalfCircumference();
            return "Hình tam giác có diện tích: "+Math.Sqrt(_HalfCircumference*(_HalfCircumference-Edge1)*(_HalfCircumference-Edge2)*(_HalfCircumference-Edge3));
        }
        #endregion
        #region Operator
        #endregion
        #region Events
        #endregion


    }
}
