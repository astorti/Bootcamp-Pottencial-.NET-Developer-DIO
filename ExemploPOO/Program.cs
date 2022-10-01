using System;
using ExemploPOO.Models;
using ExemploPOO.Interfaces;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            // INSTANCIANDO UMA PESSOA
            Console.WriteLine("________________________");
            Console.WriteLine("INSTANCIANDO UMA PESSOA");
            Pessoa p1 = new Pessoa();
            p1.Nome = "André";
            p1.Idade = 44;
            p1.Apresentar();


            // INSTANCIANDO UMA CONTA CORRENTE
            Console.WriteLine("________________________");
            Console.WriteLine("INSTANCIANDO UMA CONTA CORRENTE");

            ContaCorrente c1 = new ContaCorrente(123, 1000);

            c1.ExibirSaldo();
            c1.Sacar(1000);
            c1.ExibirSaldo();

            // HERANÇA
            Console.WriteLine("________________________");
            Console.WriteLine("HERANÇA");

            Aluno a1 = new Aluno();
            a1.Nome = "André";
            a1.Idade = 44;
            a1.Nota = 10;
            a1.Apresentar();


            // POLIMORFISMO
            Console.WriteLine("________________________");
            Console.WriteLine("POLIMORFISMO");

            Professor prof1 = new Professor();
            prof1.Nome = "Eduardo";
            prof1.Idade = 30;
            prof1.Salario = 2000M;
            prof1.Apresentar();


            // CLASSE ABSTRATA
            Console.WriteLine("________________________");
            Console.WriteLine("CLASSE ABSTRATA");

            Corrente corrente1 = new Corrente();
            corrente1.Creditar(500);
            corrente1.ExibirSaldo();


            // CONSTRUTOR POR HERANÇA
            Console.WriteLine("________________________");
            Console.WriteLine("CONSTRUTOR POR HERANÇA");

            Pessoa p2 = new Pessoa("André");
            Aluno a2 = new Aluno("Eduardo");
            a2.Apresentar();


            // CLASS OBJECT
            Console.WriteLine("________________________");
            Console.WriteLine("CLASS OBJECT");

            Computador computador = new Computador();
            Console.WriteLine(computador.ToString());


            // INTERFACE
            Console.WriteLine("________________________");
            Console.WriteLine("INTERFACE");

            ICalculadora calculadora = new Calculadora();
            Console.WriteLine("Interface calculadora: " + calculadora.Multiplicar(3, 9));

        }
    }
}
