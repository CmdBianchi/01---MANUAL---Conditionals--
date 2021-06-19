using System;
using System.Collections.Generic;
using System.Text;
namespace Entities {
    class Calculator {
        public int Number { get; set; }
        public Calculator(int number) {
            Number = number;
        }
        public bool Verif() {
            if(Number > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        public override string ToString() {
            if (Verif() == true) {
                return "Positivo";
            }
            else {
                return "Negativo";
            }
        }
    }
}
