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
        static FactoriaAlumnos  fa = null;

        static void Main(string[] args)
        {
            int opcion = 0;
            fa = new FactoriaAlumnos();
            opcion = MostrarMenu();
            EjecutarOpciones(opcion);
            Console.ReadKey();
        }
        private static void EjecutarOpciones(int opcion)
        {
           
            switch (opcion)
            {
                case 1:// Mostrar Alumnos
                    MostrarAlumnos();
                    break;
                case 2: //Añadir Alumnos
                    AddAlumno();
                    break;
            }
        }
        private static void AddAlumno()
        {
            string nombre ="", apellidos ="";
            Console.Clear();

            Console.WriteLine("Introduzca su nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Introduzca sus apellidos: ");
            apellidos = Console.ReadLine();

            Alumno al = new Alumno();
            Alumno al2 = null;
            al.Nombre = nombre;
            al.Apellidos = apellidos;

            al2 = new Alumno(nombre, apellidos);
            fa.AddAlumno(al);
        }
        private static void MostrarAlumnos()
        {
            IList<Alumno> alumnos = fa.MostrarAlumnos();
            Alumno al = null;
            for(int i = 0; i < alumnos.Count; i++)
            {
                al = alumnos.ElementAt(i);
                Console.WriteLine(al.Nombre+" "+al.Apellidos);
            }
        }
        private static int MostrarMenu()
        {
            int opcion = 0;

            Console.WriteLine("1.- Mostrar Alumnos");
            Console.WriteLine("2.- Añadir Alumno");
            
            opcion = Int32.Parse(Console.ReadLine());

            return opcion;
        }
    }
}
