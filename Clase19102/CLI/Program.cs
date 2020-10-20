using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Ingrese un nombre");
                string nombre = Console.ReadLine();

                PersonHandler.Add(nombre, "");

                foreach (var person in PersonHandler.GetPeople())
                {
                    Console.WriteLine($"Person {person.Name}");
                }
            }

        }
    }
}
