﻿using System;
namespace Tuan2Bai4 {
    public abstract class AShape {
        #region Fields
        #endregion
        #region Properties
        #endregion
        #region Constructor
        public AShape() {
        }
        #endregion
        #region Methods
        public virtual List<string> Display() {
            List<string> _Output = new List<string>();
            _Output.Add(ToString());
            _Output.Add(GetPerimeter());
            _Output.Add(GetArea());
            return _Output;
        }
        public virtual string GetPerimeter() {
            return "Tính chu vi!";
        }
        public virtual string GetArea() {
            return "Tính diện tích!";
        }
        public override string ToString() {
            return "Hình có các thuộc tính tương ứng!";
        }
        #endregion
        #region Operator
        #endregion
        #region Events
        #endregion
    }
}
