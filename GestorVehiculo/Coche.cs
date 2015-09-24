using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorVehiculo
{
    class Coche
    {
        private static int numero = 0;
        private string nBastidor;
        private string marca;
        private string modelo;
        private int nVelocidad;
        private DateTime fMatriculacion;


        public Coche()
        {
            numero++;
            NBastidor = "";
            Marca = "";
            Modelo = "";
            NVelocidad = 0;
            FMatriculacion = DateTime.Now;
        }

        public string NBastidor
        {
            get
            {
                return nBastidor;
            }

            set
            {
                nBastidor = value;
            }
        }

        public string Marca
        {
            get
            {
                return marca;
            }

            set
            {
                marca = value;
            }
        }

        public string Modelo
        {
            get
            {
                return modelo;
            }

            set
            {
                modelo = value;
            }
        }

        public int NVelocidad
        {
            get
            {
                return nVelocidad;
            }

            set
            {
                nVelocidad = value;
            }
        }

        public DateTime FMatriculacion
        {
            get
            {
                return fMatriculacion;
            }

            set
            {
                fMatriculacion = value;
            }
        }

        public static int Numero
        {
            get
            {
                return numero;
            }
        }
    }
}
