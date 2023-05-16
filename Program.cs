using Objetos.Clases;
using System;

namespace Objetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola guapo");
            //instanciar: crear un nuevo objeto REAL
            Persona persona = new Persona();
            persona.Nombre = "Roberto";
            persona.Apellido = "Fierro";
            persona.Edad = 18;
            persona.Salario = 15000.00;

            persona.ImprimirDatos();

            Console.WriteLine("-----------------------");

            Persona persona2 = new Persona();
            persona2.Nombre = "Axel";
            persona2.Apellido = "Ramón";
            persona2.Edad = 24;
            persona2.Salario = 22000.00;

            persona2.ImprimirDatos();

        }
    }
}
