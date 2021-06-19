using System;
using System.Collections.Generic;
using System.Text;
namespace Entities {
    class Calculator {
        public double Coordinate { get; set; }
        public Calculator(double coordinate) {
            Coordinate = coordinate;
        }
        public string Calculo() {
            if (Coordinate >= 0 && Coordinate < 25 ) {
                return "Intervalo (0,25)";
            }
            else if (Coordinate >= 25 && Coordinate < 50) {
                return "Intervalo (25,50)";
            }
            else if (Coordinate >= 50 && Coordinate < 75) {
                return "Intervalo (50,75)";
            }
            else if (Coordinate >= 75 && Coordinate < 100) {
                return "Intervalo (75,100)";
            }
            else{
                return "Fora de intervalo";
            }
        }
        public override string ToString() {
            return "Intervalo do número: " + Calculo();
        }
    }
}
