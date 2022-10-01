using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Interfaces
{
    public interface ICalculadora
    {
        int Somar(int numero1, int numero2);
        int Subtrair(int numero1, int numero2);
        int Multiplicar(int numero1, int numero2);
        int Dividir(int numero1, int numero2);
    }
}