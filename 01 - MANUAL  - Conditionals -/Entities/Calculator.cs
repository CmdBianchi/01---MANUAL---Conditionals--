using System;
using System.Collections.Generic;
using System.Text;
namespace Entities {
    class Calculator {
        public double CoordinateX { get; set; }
        public Calculator(double coordinateX) {
            CoordinateX = coordinateX;
        }
        public double Calculo() {
            if (CoordinateX < 2000.00) {
                return 0;
            }
            else if (CoordinateX >= 2000.00 && CoordinateX < 3000.00) {
                return (CoordinateX - 2000.00)*0.08;
            }
            else if (CoordinateX >= 3000.00 && CoordinateX < 4500.00) {
                return (80) + ((CoordinateX - 3000.00) * 0.18);
            }
            else {
                return (80) + (270) + ((CoordinateX - 4500.00) * 0.28);
            }
       
        }
        public override string ToString() {
            if (Calculo() == 0) {
                return "ISENTO";
            }
            else {
                return "R$ " + Calculo().ToString("F2");
            }
        }
    }
}
