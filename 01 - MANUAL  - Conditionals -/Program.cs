using System;
using Entities;
namespace _01___MANUAL____Conditionals__ {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite o valor X do numero p/ informar se é multiplo: "); int x = int.Parse(Console.ReadLine());
            Console.Write("\nDigite o valor Y do numero p/ informar se é multiplo: "); int y = int.Parse(Console.ReadLine());
            Console.WriteLine("");         
            Calculator calculator = new Calculator(x, y);
            Console.WriteLine(calculator);
        }
    }
}
