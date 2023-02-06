using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan1Bai3 {
    class SumClass {
        #region Fields
        private int begin;
        private int end;
        #endregion
        #region Properties
        public int Begin { get => begin; set => begin=value; }
        public int End { get => end; set => end=value; }
        #endregion
        #region Constructor
        public SumClass(int iBegin,int iEnd) {
            begin=iBegin;
            end=iEnd;
        }
        #endregion
        #region Methods
        public string FindSum() {
            int _sum = (Begin+End)*(End-Begin+1)/2;
            return ($"\tKết quả: Tổng từ {Begin} đến {End} là: {_sum}");
        }
        #endregion
    }
}
