using System;
namespace Tuan2Bai4 {
public class Trapezoid : AShape {
        #region Fields
        private double baseSmall;
        private double side1;
        private double baseBig;
        private double side2;
        #endregion
        #region Properties
        public double BaseSmall { get => baseSmall; set => baseSmall=value; }
        public double Side1 { get => side1; set => side1=value; }
        public double BaseBig { get => baseBig; set => baseBig=value; }
        public double Side2 { get => side2; set => side2=value; }
        #endregion
        #region Constructor
        public Trapezoid() {
        }
        public Trapezoid(double iBaseSmall,double iSide1,double iBaseBig,double iSide2) {
            BaseSmall=iBaseSmall;
            Side1=iSide1;
            BaseBig=iBaseBig;
            Side2=iSide2;
        }
        #endregion
        #region Methods
        public override string ToString() {
            return "Hình thang có 4 cạnh lần lượt là: "+BaseSmall+", "+Side1+", "+BaseBig+", "+Side2;
        }
        public override string GetPerimeter() {
            return "Hình thang có chu vi: "+(BaseSmall+Side1+BaseBig+Side2);
        }
        public override string GetArea() {
            double _Area = Side1*Side1*Side2*Side2;
            _Area+=Side1*Side1*(BaseBig-BaseSmall)*(BaseBig-BaseSmall);
            _Area+=Side2*Side2*(BaseBig-BaseSmall)*(BaseBig-BaseSmall);
            _Area*=2;
            _Area-=Side1*Side1*Side1*Side1+Side2*Side2*Side2*Side2+(BaseBig-BaseSmall)*(BaseBig-BaseSmall)*(BaseBig-BaseSmall)*(BaseBig-BaseSmall);
            _Area=Math.Sqrt(_Area);
            _Area*=(BaseSmall+BaseBig);
            _Area/=(4*(BaseBig-BaseSmall));
            return "Hình thang có diện tích: "+_Area;
        }
        #endregion
        #region Operator
        #endregion
        #region Events
        #endregion




    }
}