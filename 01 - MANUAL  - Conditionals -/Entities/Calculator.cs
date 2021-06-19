using System;
using System.Collections.Generic;
using System.Text;
namespace Entities {
    class Calculator {
        public int HourInitial { get; set; }
        public int HourFinal { get; set; }
        public Calculator(int hourInitial, int hourFinal) {
            HourInitial = hourInitial;
            HourFinal = hourFinal;
        }
        public int Calculo() {
            if (HourInitial < HourFinal) {
                return HourFinal - HourInitial;
            }
            else{
                return 24 - HourInitial + HourFinal;
            }
        }
        public override string ToString() {
            return "Duração total do jogo: " + Calculo();
        }
    }
}
