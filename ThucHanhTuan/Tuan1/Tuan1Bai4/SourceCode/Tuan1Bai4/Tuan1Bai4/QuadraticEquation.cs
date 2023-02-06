using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan1Bai4 {
    class QuadraticEquation {
        private float quadraticFactor2;
        private float quadraticFactor1;
        private float quadraticFactor0;
        public float QuadraticFactor2 { get => quadraticFactor2; set => quadraticFactor2=value; }
        public float QuadraticFactor1 { get => quadraticFactor1; set => quadraticFactor1=value; }
        public float QuadraticFactor0 { get => quadraticFactor0; set => quadraticFactor0=value; }

        public QuadraticEquation(float iQquadraticFactor2,float iQquadraticFactor1,float iQquadraticFactor0) {
            quadraticFactor2=iQquadraticFactor2;
            quadraticFactor1=iQquadraticFactor1;
            quadraticFactor0=iQquadraticFactor0;
        }
        public string SolveQuadraticEquation() {
            if(QuadraticFactor2==0) {
                if(QuadraticFactor1==0) {
                    if(QuadraticFactor0==0) {
                        return ("Phương trình vô số nghiệm!");
                    } else {
                        return ("Phương trình vô nghiệm!");
                    }
                } else {
                    return ($"Phương trình có 1 nghiệm: x = {(-QuadraticFactor0/QuadraticFactor1)}");
                }
            } else {

                float _Delta = QuadraticFactor1*QuadraticFactor1-4*QuadraticFactor2*QuadraticFactor0;
                float _Result1;
                float _Result2;
                if(_Delta>0) {
                    _Result1=(float)((-QuadraticFactor1+Math.Sqrt(_Delta))/(2*QuadraticFactor2));
                    _Result2=(float)((-QuadraticFactor1-Math.Sqrt(_Delta))/(2*QuadraticFactor2));
                    return ($"Phương trình có 2 nghiệm: x1 = {_Result1} và x2 = {_Result2}");
                } else if(_Delta==0) {
                    _Result1=(-QuadraticFactor1/(2*QuadraticFactor2));
                    return ($"Phương trình có nghiệm kép: x1 = x2 = {_Result1}");
                } else {
                    return ("Phương trình vô nghiệm!");
                }
            }
        }

    }
}
