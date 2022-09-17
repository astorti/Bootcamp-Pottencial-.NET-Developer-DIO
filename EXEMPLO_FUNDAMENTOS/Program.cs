using System;
using System.Collections.Generic;
using EXEMPLO_FUNDAMENTOS.Models;

namespace EXEMPLO_FUNDAMENTOS
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciação de um objeto da classe Pessoa
            Console.WriteLine("Instanciação de um objeto da classe Pessoa");
            Pessoa pessoa1 = new Pessoa();

            pessoa1.Nome = "André";
            pessoa1.Idade = 43;
            pessoa1.Apresentar();


            // Declaração de tipos de variaveis
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Declaração de tipos de variaveis");

            string apresentacao = "Olá amigo!";
            int quantidade = 1;
            Console.WriteLine("Valor da variável quantidade: " + quantidade);
            quantidade = 10;
            double altura = 1.80;
            decimal preco = 1.80M;
            bool condicao = true;

            Console.WriteLine(apresentacao);
            Console.WriteLine("Valor da variável quantidade: " + quantidade);
            Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));
            Console.WriteLine("Valor da variável preço: " + preco);
            Console.WriteLine("Valor da variável condição: " + condicao);

            // Utilização do tipo DateTime
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Utilização do tipo DateTime");

            DateTime dataAtual = DateTime.Now.AddDays(5);
            Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));

            // Sinal de atribuição
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Sinal de atribuição");
            int a = 10;
            int b = 20;
            int c = a + b;
            Console.WriteLine($"O valor de c é {c}");
            c += 5;
            Console.WriteLine($"Novo valor de c é {c}");

            // Conversão tipos de variaveis
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Conversão tipos de variaveis");
            int e = Convert.ToInt32("5");
            int f = int.Parse("5");
            Console.WriteLine(e);
            Console.WriteLine(f);

            // Conversão para string
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Conversão para string");
            int g = 5;
            string h = g.ToString();
            Console.WriteLine(g);

            // Casting implicito
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Casting implicito");
            int i = 10;
            double j = i;
            Console.WriteLine(j);

            // Ordem dos operadores
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Ordem dos operadores");
            double k = 4 / 2 + 2;
            double l = 4 / (2 + 2);
            Console.WriteLine(k);
            Console.WriteLine(l);

            // Método TryParse
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Método TryParse");
            string m = "15-";
            int n = 0;
            int.TryParse(m, out n);
            Console.WriteLine(n);
            Console.WriteLine("Conversão realizada com sucesso");

            //OPERADORES CONDICIONAIS
            Console.WriteLine("----------------------------------");
            Console.WriteLine("OPERADORES CONDICIONAIS");

            int quantidadeEmEstoque = 10;
            int quantidadeCompra = 8;
            bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

            Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
            Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
            Console.WriteLine($"É possível realizar a compra? {possivelVenda}");

            if (quantidadeCompra == 0)
            {
                Console.WriteLine("Venda inválida!");
            }
            else if (possivelVenda) 
            {
                Console.WriteLine("Venda Realizada");
            }
            else
            {
                Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque.");
            }

            // SWITCH CASE
            Console.WriteLine("----------------------------------");
            Console.WriteLine("SWITCH CASE");

            Console.Write("Digite uma vogal: ");
            string letra = Console.ReadLine();

            switch (letra)
            {
                case "a":
                case "e":
                case "i":
                case "o":
                case "u":
                    Console.WriteLine("Vogal");
                    break;

                default:
                    Console.WriteLine("Não é uma vogal");
                    break;
            }


            // OPERADO OR
            Console.WriteLine("----------------------------------");
            Console.WriteLine("OPERADOR OR");

            bool ehMaiorDeIdade = false;
            bool possuiAutorizacaoDoResponsavel = true;

            if (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
            {
                Console.WriteLine("Entrada liberada");
            }
            else
            {
                Console.Write("Entrada não liberada");
            }


            // OPERADO AND
            Console.WriteLine("----------------------------------");
            Console.WriteLine("OPERADOR AND");

            bool possuiPresencaMinima = false;
            double media = 7.5;

            if (possuiPresencaMinima && media >= 7)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }


            // OPERADO NOT
            Console.WriteLine("----------------------------------");
            Console.WriteLine("OPERADOR NOT");

            bool chouve = false;
            bool estaTarde = false;

            if (!chouve && !estaTarde)
            {
                Console.WriteLine("Vou pedalar");
            }
            else
            {
                Console.Write("Vou pedalar um outro dia");
            }


            // OPERADORES ARTMETICOS
            Console.WriteLine("----------------------------------");
            Console.WriteLine("OPERADORES ARITMETICOS - CALCULADORA");

            Calculadora calc = new Calculadora();

            calc.Somar(10, 30);
            calc. Subtrair(10, 50);
            calc.Multiplicar(15, 45);
            calc.Dividir(2, 2);
            calc.Potencia(3, 3);
            calc.Seno(30);
            calc.Coseno(30);
            calc.Tangente(30);
            calc.RaizQuadrada(9);

            // INCREMENTO - DECREMENTO
            Console.WriteLine("----------------------------------");
            Console.WriteLine("INCREMENTO - DECREMENTO");

            int numeroIncremento = 10;
            Console.WriteLine(numeroIncremento);
            Console.WriteLine("Incrementando o 10");
            numeroIncremento++;
            Console.WriteLine(numeroIncremento);

            int numeroDecremento = 20;
            Console.WriteLine(numeroDecremento);
            Console.WriteLine("Decrementando o 20");
            numeroDecremento--;
            Console.WriteLine(numeroDecremento);

            // ESTRUTURA DE REPETIÇÃO FOR
            Console.WriteLine("----------------------------------");
            Console.WriteLine("ESTRUTURA DE REPETIÇÃO FOR");

            int numero = 5;

            for(int contador = 0; contador <= 10; contador++)
            {
                Console.WriteLine($"{numero} x {contador} = {numero * contador}");
            }

            // ESTRUTURA DE REPETIÇÃO WHILE
            Console.WriteLine("----------------------------------");
            Console.WriteLine("ESTRUTURA DE REPETIÇÃO WHILE");

            int num = 6;
            int cont = 0;
            while(cont <= 10)
            {
                Console.WriteLine($"{num} x {cont} = {num * cont}");
                cont++;
            }

            // ESTRUTURA DE REPETIÇÃO DO - WHILE
            Console.WriteLine("----------------------------------");
            Console.WriteLine("ESTRUTURA DE REPETIÇÃO DO - WHILE");

            int soma2 = 0, numero2 = 0;

            do
            {
                Console.WriteLine("Digite um número (0 para parar)");
                numero2 = Convert.ToInt32(Console.ReadLine());

                soma2 += numero2;

            } while(numero2 != 0);

            Console.WriteLine($"O toral dos números digitados é: {soma2}");


            // MENU INTERATIVO COM WHILE
            Console.WriteLine("----------------------------------");
            Console.WriteLine("MENU INTERATIVO COM WHILE");

            string opcao;
            bool exibirMenu = true;

            while(exibirMenu)
            {
                Console.WriteLine("digite a sua opção:");
                Console.WriteLine("1 - Cadastrar cliente");
                Console.WriteLine("2 - Buscar cliente");
                Console.WriteLine("3 - Apagar cliente");
                Console.WriteLine("4 - Encerrar");

                opcao = Console.ReadLine();

                switch(opcao)
                {
                    case "1":
                        Console.WriteLine("Cadastro de cliente");
                        break;
                    
                    case "2":
                        Console.WriteLine("Busca de cliente");
                        break;

                    case "3":
                        Console.WriteLine("Apagar cliente");
                        break;

                    case "4":
                        Console.WriteLine("Encerrar");
                        exibirMenu = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }

            Console.WriteLine("O programa se encerrou.");


            // ARRAY
            Console.WriteLine("----------------------------------");
            Console.WriteLine("ARRAY");

            int[] arrayInteiros = new int[3];
            arrayInteiros[0] = 72;
            arrayInteiros[1] = 64;
            arrayInteiros[2] = 50;

            for (int contador = 0; contador < arrayInteiros.Length; contador++)
            {
                Console.WriteLine($"Posição n´º {contador} = {arrayInteiros[contador]}");
            }


            // FOREACH
            Console.WriteLine("----------------------------------");
            Console.WriteLine("FOREACH");

            int contadorForeach = 0;
            foreach (int valor in arrayInteiros)
            {
                Console.WriteLine($"Posição {contadorForeach} = {valor}");
                contadorForeach++;
            }


            // REDIMENCIONAR UMA ARRAY
            Console.WriteLine("----------------------------------");
            Console.WriteLine("REDIMENCIONAR UMA ARRAY");

            Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);
            contadorForeach = 0;
            foreach (int valor in arrayInteiros)
            {
                Console.WriteLine($"Posição {contadorForeach} = {valor}");
                contadorForeach++;
            }


            // COPIAR UMA ARRAY EM OUTRA ARRAY
            Console.WriteLine("----------------------------------");
            Console.WriteLine("COPIAR UMA ARRAY EM OUTRA ARRAY");

            int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
            Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

            contadorForeach = 0;
            foreach (int valor in arrayInteirosDobrado)
            {
                Console.WriteLine($"Posição {contadorForeach} = {valor}");
                contadorForeach++;
            }


            // LISTA
            Console.WriteLine("----------------------------------");
            Console.WriteLine("LISTA");

            List<string> listaString = new List<string>();

            listaString.Add("SP");
            listaString.Add("BA");
            listaString.Add("MG");

            Console.WriteLine("FOR");
            for (int contador = 0; contador < listaString.Count; contador++)
            {
                Console.WriteLine($"Posição nº {contador} = {listaString[contador]}");
            }

            Console.WriteLine("FOREACH");
            contadorForeach = 0;
            foreach (string item in listaString)
            {
                Console.WriteLine($"Posição nº {contadorForeach} = {item}");
                contadorForeach++;   
            }
        }
    }
}
