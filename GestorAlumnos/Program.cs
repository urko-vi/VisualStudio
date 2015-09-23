using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorAlumnos
{
    class Program
    {
        //mostrar alumnos
        //añadir alumnos 
        
        static void Main(string[] args)
        {
            
        }
        private int MostrarMenu()
        {
            int opcion = 0;

            Console.WriteLine("1.- Mostrar Alumnos");
            Console.WriteLine("2.- Añadir Alumno");

            opcion = Int32.Parse(Console.ReadLine());

            return opcion;
        }
    }
}
