using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_proyecto_final
{
    internal class Program
    {      
        static void Main(string[] args)
        {
            string[] nombres = { "Matias", "Rocio", "Tincho"};
            mostrarArreglo(nombres);
            modificarReserva(nombres, 1, "Rocio2");
            Console.WriteLine();
            mostrarArreglo(nombres);
            Console.ReadKey();
        }
   
        static void mostrarArreglo(string[] nombres) 
        {
            foreach (string nombre in nombres)
            {
                Console.Write(" " + nombre);
            }
        }
        static void modificarReserva(string[] nombres, int indice, string nuevoNombre) 
        {   
            if (indice >= 0 && indice < nombres.Length) 
            {
                nombres[indice] = nuevoNombre;
            }
            else
            {
                Console.WriteLine("Indice invalido");
            }
        }


    }
}
