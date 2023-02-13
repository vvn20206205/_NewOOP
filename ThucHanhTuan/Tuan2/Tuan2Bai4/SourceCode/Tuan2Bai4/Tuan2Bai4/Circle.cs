using System;
namespace Tuan2Bai4 {
    public class Circle : AShape {
        #region Fields
        private double radius;
        #endregion
        #region Properties
        public double Radius { get => radius; set => radius=value; }
        #endregion
        #region Constructor

        public Circle() {
        }
        public Circle(double iRadius) {
            Radius=iRadius;
        }

        #endregion
        #region Methods
        public override string ToString() {
            return "Hình tròn có bán kính: "+Radius;
        }
        public override string GetPerimeter() {
            return "Hình tròn có chu vi: "+2*Math.PI*Radius;
        }
        public override string GetArea() {
            return "Hình tròn có diện tích: "+Math.PI*Radius*Radius;
        }
        #endregion
        #region Operator
        #endregion
        #region Events
        #endregion

    }
}