﻿using System;
using Entities;
namespace _01___MANUAL____Conditionals__ {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite o valor do numero: "); int x = int.Parse(Console.ReadLine());
            Console.WriteLine("");         
            Calculator calculator = new Calculator(x);
            Console.WriteLine(calculator);
        }
    }
}
