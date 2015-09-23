using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorAlumnos
{
    class FactoriaAlumnos
    {
        IList<Alumno> alumnos = new List<Alumno>();
        //MostrarAlumnos
        public IList<Alumno> MostrarAlumnos()
        {
            Alumno al = new Alumno();
            al.Nombre = "Jon";
            al.Apellidos = "Perez Gutierrez";

            alumnos.Add(al);

            return alumnos;
        }
        //AñadirAlumnos(Alumno alumno)

    }
}
