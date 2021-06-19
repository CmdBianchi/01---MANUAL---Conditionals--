using System;
using System.Collections.Generic;
using System.Text;
namespace Entities {
    class Calculator {
        public int NumberX { get; set; }
        public int NumberY { get; set; }
        public Calculator(int numberX, int numberY) {
            NumberX = numberX;
            NumberY = numberY;
        }
        public bool Verif() {
            if(NumberX % NumberY == 0 || NumberY % NumberX == 0) {
                return true;
            }
            else {
                return false;
            }
        }
        public override string ToString() {
            if (Verif() == true) {
                return "É Multiplo";
            }
            else {
                return "Não é Multiplo";
            }
        }

    }
}
