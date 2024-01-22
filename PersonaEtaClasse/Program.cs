using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaEtaClasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona();
            p.DataN = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("La tua età è: {0}", p.Calcoloe());
            Console.ReadLine();
        }
    }
}
