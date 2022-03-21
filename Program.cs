using RPG.SRC.Entities;
using System;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {

            Knight arus = new("Arus", 23, "knight");
            Wizard wizard = new Wizard("Jennica", 23, "White Wizard");

            Console.WriteLine(arus.Attack());
            Console.WriteLine(wizard.Attack());
            Console.WriteLine(wizard.Attack(5));
            Console.WriteLine(wizard.Attack(8));
        }
    }
}
