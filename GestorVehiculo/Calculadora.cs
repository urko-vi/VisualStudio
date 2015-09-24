using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorVehiculo
{
    class Calculadora
    {
        public static int Sumar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }
        public static int Multiplicar(int numero1,int numero2)
        {
            return numero1 * numero2;
        }
        public static double Dividir (int numero1,int numero2)
        {
            return (double)numero1 / numero2;
        }
        public static int CalcularFactorial(int numero)
        {
            int resultado=1;
            for(int i= numero; i > 1; i--)
            {
                resultado *= i;
            }

            return resultado;
        }
        public static int CalcularFactorialRecursivo(int numero)
        {
            if (numero == 1 || numero==0)
            {
                return 1;
            }
            else
            {
                return CalcularFactorialRecursivo(numero - 1) * numero;
            }
        }
        public static int CalcularPotencia(int numero,int exp)
        {
            int resultado = 1;
            for(int i = 0; i< exp; i++)
            {
                resultado *= numero;
            }
            Math.Pow(5, 1 / 2);
            return resultado;
        }
    }
}
