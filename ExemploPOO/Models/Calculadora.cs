using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExemploPOO.Interfaces;

namespace ExemploPOO.Models
{
    public class Calculadora : ICalculadora
    {
        public int Dividir(int numero1, int numero2)
        {
            return numero1 / numero2;
        }

        public int Multiplicar(int numero1, int numero2)
        {
            return numero1 * numero2;
        }

        public int Subtrair(int numero1, int numero2)
        {
            return numero1 - numero2;
        }

        public int Somar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        public int Somar(int numero1, int numero2, int numero3)
        {
            return numero1 + numero2 + numero3;
        }
    }
}