using System;
using Entities;
namespace _01___MANUAL____Conditionals__ {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite a hora inicial do jogo: "); int x = int.Parse(Console.ReadLine());
            Console.Write("\nDigite a hora final do jogo: "); int y = int.Parse(Console.ReadLine());
            Console.WriteLine("");         
            Calculator calculator = new Calculator(x, y);
            Console.WriteLine(calculator);
        }
    }
}
