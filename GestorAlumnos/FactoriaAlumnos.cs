using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorAlumnos
{
    class FactoriaAlumnos
    {
        IList<Alumno> alumnos = null;
        //MostrarAlumnos
        public IList<Alumno> MostrarAlumnos()
        {
            alumnos = new List<Alumno>();
            return alumnos;
        }
        //AñadirAlumnos

    }
}
