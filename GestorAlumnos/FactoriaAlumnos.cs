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
        private void cargarDatos()
        {
            Alumno al = new Alumno();
            al.Nombre = "Jon";
            al.Apellidos = "Perez Gutierrez";

            alumnos.Add(al);
        }
        //public
        //MostrarAlumnos

        public IList<Alumno> MostrarAlumnos()
        {
            return alumnos;
        }
        //AñadirAlumnos(Alumno alumno)
        public void AddAlumno(Alumno alumno)
        {
            alumnos.Add(alumno);
        }

    }
}
