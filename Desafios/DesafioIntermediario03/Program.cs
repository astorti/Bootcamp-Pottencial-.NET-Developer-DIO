using System;

namespace DesafioIntermediario03
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidadeEntradas = 3;
            var maiorVelocidade = 0;
            string[] tartarugas = new string[0];
      
            while (quantidadeEntradas > 0) 
            {
                var numeroQuantidade = Int32.Parse(Console.ReadLine());
                
                if (numeroQuantidade >= 1 && numeroQuantidade <= 500) 
                {
                    tartarugas = Console.ReadLine().Split(" ");
                    maiorVelocidade = Int32.Parse(tartarugas[0]);
                }

            // TODO: Crie as outras condições necessárias para a resolução do desafio:
                for ( int i = 1; i < tartarugas.Length; i ++ ) 
                {
                    var tartaruga = Int32.Parse(tartarugas[i]);
                        
                    if ( maiorVelocidade < tartaruga ) 
                    {
                        maiorVelocidade = tartaruga;
                    }
                }

                if( maiorVelocidade < 10) 
                {
                    Console.WriteLine(1);
                } 
                else if ( maiorVelocidade >= 10 &&  maiorVelocidade < 20) 
                {
                    Console.WriteLine(2);
                } 
                else if ( maiorVelocidade >= 20) 
                {
                    Console.WriteLine(3);
                }
                else 
                {
                    Console.WriteLine("Insira um número entre 1 e 500");
                }

                quantidadeEntradas--;    
            }           
        }
    }
}
