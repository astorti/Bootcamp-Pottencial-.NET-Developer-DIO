using System;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using System.Globalization;
using ExemploExplorando.Models;
using System.Collections.Generic;


namespace ExemploExplorando
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();

            p1.Nome = "André";
            p1.Sobrenome = "Storti";
            p1.Idade = 44;
            p1.Apresentar();

            // Acessando Classe curso
            Console.WriteLine("_____________________________");
            Console.WriteLine("ACESSO ÀS CLASSES PESSOA E CURSO");

            // Com uso de construtor
            Pessoa p2 = new Pessoa(nome: "André", sobrenome: "Storti");
            
            // Sem uso de construtor
            Pessoa p3 = new Pessoa();
            p3.Nome = "Paulo";
            p3.Sobrenome = "Henrique";

            Curso cursoDeIngles = new Curso();

            cursoDeIngles.Nome = "Ingles";
            cursoDeIngles.Alunos = new List<Pessoa>();

            cursoDeIngles.AdicionarAluno(p2);
            cursoDeIngles.AdicionarAluno(p3);
            cursoDeIngles.ListarAlunos();

            // FORMATANDO VALORES MONETÁRIOS
            Console.WriteLine("------------------------------------");
            Console.WriteLine("FORMATANDO VALORES MONETÁRIOS");

            decimal valorMonetario = 1345.40M;
            Console.WriteLine($"{valorMonetario:c}");

            // ALTERANDO A LOCALIZAÇÃO DO CÓDIGO
            Console.WriteLine("------------------------------------");
            Console.WriteLine("ALTERANDO A LOCALIZAÇÃO DO CÓDIGO");

            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
            Console.WriteLine($"{valorMonetario:c}");

            // ALTERANDO A LOCALIZAÇÃO DA CULTURA
            Console.WriteLine("------------------------------------");
            Console.WriteLine("ALTERANDO A LOCALIZAÇÃO DA CULTURA");

            Console.WriteLine(valorMonetario.ToString("c", CultureInfo.CreateSpecificCulture("en-GB")));

            // FORMATAÇÃO PERSONALIZADA
            Console.WriteLine("------------------------------------");
            Console.WriteLine("FORMATAÇÃO PERSONALIZADA");

            Console.WriteLine(valorMonetario.ToString("c1"));
            Console.WriteLine(valorMonetario.ToString("c2"));
            Console.WriteLine(valorMonetario.ToString("c8"));
            Console.WriteLine(valorMonetario.ToString("n1"));
            Console.WriteLine(valorMonetario.ToString("n8"));

            // REPRESENTAÇÃO EM PORCENTAGEM
            Console.WriteLine("------------------------------------");
            Console.WriteLine("REPRESENTAÇÃO EM PORCENTAGEM");

            double porcentagem = .3421;
            Console.WriteLine(porcentagem.ToString("P"));

            // SEPARADOR DE INTEIRO
            Console.WriteLine("------------------------------------");
            Console.WriteLine("SEPARADOR DE INTEIRO");

            int numero = 25122022;
            Console.WriteLine(numero.ToString("##-##-####"));

            //FORMATANDO O TIPO DATETIME
            Console.WriteLine("___________________________________");
            Console.WriteLine("FORMATANDO O TIPO DATETIME");

            DateTime data = DateTime.Now;
            Console.WriteLine(data);
            Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));
            Console.WriteLine(data.ToString("dd/MM/yyyy hh:mm"));
            Console.WriteLine(data.ToString("dd-MM-yyyy HH:mm"));
            Console.WriteLine(data.ToString("yyyy/MM/dd HH:mm"));
            Console.WriteLine(data.ToString("HH:mm"));


            //FORMATANDO DATA E HORA
            Console.WriteLine("___________________________________");
            Console.WriteLine("FORMATANDO DATA E HORA");

            Console.WriteLine(data.ToShortDateString());
            Console.WriteLine(data.ToShortTimeString());

            //DATETIME COM PARSE E TRYPARSE
            Console.WriteLine("___________________________________");
            Console.WriteLine("DATETIME COM PARSE E TRYPARSE");

            DateTime data1 = DateTime.Parse("2022-09-23 18:00");
            Console.WriteLine(data1);

            string dataString = "2022-09-23 18:00";
            bool sucesso = DateTime.TryParseExact(dataString, 
                                    "yyyy-MM-dd HH:mm",
                                    CultureInfo.InvariantCulture,
                                    DateTimeStyles.None,
                                    out DateTime data2);

            if (sucesso)
            {
                Console.WriteLine($"Conversão com sucesso! Data: {data2}");
            }
            else
            {
                Console.WriteLine($"{dataString} não é uma data válida.");
            }


            //LEITURA DE UM ARQUIVO
            Console.WriteLine("___________________________________");
            Console.WriteLine("LEITURA DE UM ARQUIVO");

            string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");
            foreach (string linha in linhas)
            {
                Console.WriteLine(linha);
            }


            //TRATANDO EXCEÇÕES GENERICAS E ESPECIFICAS
            Console.WriteLine("___________________________________");
            Console.WriteLine("TRATANDO EXCEÇÕES GENERICAS E ESPECIFICAS");

            try
            {
                string[] linhas2 = File.ReadAllLines("Arquivos/arquivosLeitura.txt");
                foreach (string linha in linhas2)
                {
                    Console.WriteLine(linha);
                }

            } 
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado. {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Chegou até aqui.");
            }


            //THROW EXCEPTION
            Console.WriteLine("___________________________________");
            Console.WriteLine("THROW EXCEPTION");

            Console.WriteLine("Descomentar linha 175: //new ExemploExcecao().Metodo1();");

            // QUEUE - FILA
            Console.WriteLine("___________________________________");
            Console.WriteLine("QUEUE - FILA");

            Queue<int> file = new Queue<int>();

            file.Enqueue(2);
            file.Enqueue(4);
            file.Enqueue(6);
            file.Enqueue(8);

            foreach (int item in file)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Removendo o elemento: {file.Dequeue()}");
            file.Enqueue(10);
            
            foreach (int item in file)
            {
                Console.WriteLine(item);
            }


            // STACK - PILHA
            Console.WriteLine("___________________________________");
            Console.WriteLine("STACK - PILHA");

            Stack<int> pilha = new Stack<int>();

            pilha.Push(4);
            pilha.Push(6);
            pilha.Push(8);
            pilha.Push(10);

            foreach (int item in pilha)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Removendo o elemento: {pilha.Pop()}");
            pilha.Push(20);

            foreach (int item in pilha)
            {
                Console.WriteLine(item);
            }

            // DICTIONARY
            Console.WriteLine("___________________________________");
            Console.WriteLine("DICTIONARY");

            Dictionary<string, string> estados = new Dictionary<string, string>();

            estados.Add("SP", "São Paulo");
            estados.Add("BA", "Bahia");
            estados.Add("MG", "Minas Gerais");

            foreach (var item in estados)
            {
                Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
            }

            Console.WriteLine("Após modificação");
            estados.Remove("BA");
            estados["SP"] = "São Paulo - valor alterado";

            foreach (var item in estados)
            {
                Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
            }

            string chave = "BA";
            Console.WriteLine($"Verificando o elemento {chave}");

            if (estados.ContainsKey(chave))
            {
                Console.WriteLine($"Valor existente: {chave}");
            }
            else
            {
                Console.WriteLine($"O valor não existe. É seguro adicionar a chave {chave}.");
            }

            Console.WriteLine(estados["MG"]);


            // TUPLAS
            Console.WriteLine("___________________________________");
            Console.WriteLine("TUPLA");

            (int Id, string Modelo, string Marca, decimal Preco) tupla = (1, "Onix", "Chevrolet", 70200.90M);

            Console.WriteLine($"Id: {tupla.Id}");
            Console.WriteLine($"Modelo: {tupla.Modelo}");
            Console.WriteLine($"Marca: {tupla.Marca}");
            Console.WriteLine($"Preço: {tupla.Preco:c}");

            ValueTuple<int, string, string, decimal> tupla2 = (2, "Cronos", "Fiat", 82900.00M);
            var tupla3 = Tuple.Create(1, "City", "Honda", 89800.00M);

            Console.WriteLine($"Id: {tupla2.Item1}");
            Console.WriteLine($"Modelo: {tupla2.Item2}");
            Console.WriteLine($"Marca: {tupla2.Item3}");
            Console.WriteLine($"Preço: {tupla2.Item4:c}");

            Console.WriteLine($"Id: {tupla3.Item1}");
            Console.WriteLine($"Modelo: {tupla3.Item2}");
            Console.WriteLine($"Marca: {tupla3.Item3}");
            Console.WriteLine($"Preço: {tupla3.Item4:c}");

            // TUPLA EM MÉTODO
            Console.WriteLine("___________________________________");
            Console.WriteLine("TUPLA EM MÉTODO");

            LeituraArquivo arquivo1 = new LeituraArquivo();
            var (sucesso1, linhasArquivo, quantidadeLinhas) = arquivo1.LerArquivo("Arquivos/arquivoLeitura.txt");

            if (sucesso1)
            {
                Console.WriteLine("Quantidade linhas do arquivo: " + quantidadeLinhas);
                foreach (string linhas1 in linhasArquivo)
                {
                    Console.WriteLine(linhas1);
                }
            }
            else
            {
                Console.WriteLine("Não foi possível ler o arquivo.");
            }

            // DESCONSTRUTOR
            Console.WriteLine("___________________________________");
            Console.WriteLine("DESCONSTRUTOR");

            Pessoa p4 = new Pessoa("André", "Storti");

            (string nome, string sobrenome) = p4;
            Console.WriteLine($"{nome} {sobrenome}");


            // IF TERNÁRIO
            Console.WriteLine("___________________________________");
            Console.WriteLine("IF TERNÁRIO");

            int numero2 = 15;
            bool ehPar = false;
            ehPar = numero2 % 2 == 0;
            Console.WriteLine($"O número {numero2} é " + (ehPar ? "par" : "impar"));


            // SERIALIZAÇÃO
            Console.WriteLine("___________________________________");
            Console.WriteLine("SERIALIZAÇÃO");

            Venda v1 = new Venda(1, "Material de escritório", 25.00M);
            
            string serializado = JsonConvert.SerializeObject(v1, Formatting.Indented);
            File.WriteAllText("Arquivos/vendas.json", serializado);
            Console.WriteLine(serializado);

            // SERIALIZAÇÃO DE COLEÇÃO
            Console.WriteLine("___________________________________");
            Console.WriteLine("SERIALIZAÇÃO DE COLEÇÃO");

            DateTime dataAtual = DateTime.Now;
            List<Venda> listaVendas = new List<Venda>();

            Venda v2 = new Venda(1, "Material de escritório", 30.00M, dataAtual);
            Venda v3 = new Venda(2, "Licensa de Software", 110.00M, dataAtual);
            
            listaVendas.Add(v2);
            listaVendas.Add(v3);

            string serializadoColecao = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);
            File.WriteAllText("Arquivos/vendasColecao.json", serializadoColecao);
            Console.WriteLine(serializadoColecao);
            

            // DESERIALIZAÇÃO DE COLEÇÃO COM TIPO NULO PROPRIEDADE
            Console.WriteLine("___________________________________");
            Console.WriteLine("DESERIALIZAÇÃO DE COLEÇÃO COM TIPO NULO EM PROPRIEDADE");

            string conteudoArquivo = File.ReadAllText("Arquivos/vendaDeserializar.json");

            List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

            foreach (Venda ven in listaVenda)
            {
                Console.WriteLine($"Id: {ven.Id}, Produto: {ven.Produto} " +
                                  $"Preço: {ven.Preco}, Data: {ven.DataVenda.ToString("dd/MM/yyy HH:mm")}" +
                                  $" {(ven.Desconto.HasValue ? $"Desconto de: {ven.Desconto}" : "" )}");
            }


            // TIPO NULO
            Console.WriteLine("___________________________________");
            Console.WriteLine("TIPO NULO");

            bool? desejaReceberEmail = null;

            if (desejaReceberEmail.HasValue && desejaReceberEmail.Value)
            {
                Console.WriteLine("O usuário optou por receber e-mail.");
            }
            else
            {
                Console.WriteLine("O usuário não respondeu ou optou por não receber e-mail.");
            }


            // TIPO ANÔNIMO
            Console.WriteLine("___________________________________");
            Console.WriteLine("TIPO ANÔNIMO");

            var tipoAnonimo = new { Nome = "André", Sobrenome = "Storti", Altura = 1.70 };
            
            Console.WriteLine("Nome: " + tipoAnonimo.Nome);
            Console.WriteLine("Sobrenome: " + tipoAnonimo.Sobrenome);
            Console.WriteLine("Altura: " + tipoAnonimo.Altura);


            // TIPO ANÔNIMO EM COLEÇÕES
            Console.WriteLine("___________________________________");
            Console.WriteLine("TIPO ANÔNIMO EM COLEÇÕES");

            string conteudoArquivo2 = File.ReadAllText("Arquivos/vendaDeserializar.json");

            List<Venda> listaVenda2 = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo2);

            var listaAnonimo = listaVenda2.Select(x => new {x.Produto, x.Preco});

            foreach (var venda2 in listaAnonimo)
            {
                Console.WriteLine($"Produto: {venda2.Produto}, Preço: {venda2.Preco}");
            }


            // TIPO DINÂMICO
            Console.WriteLine("___________________________________");
            Console.WriteLine("TIPO DINÂMICO");

            dynamic variavelDinamica = 4;
            Console.WriteLine($"Tipo de variavel: { variavelDinamica.GetType()}, Valor: {variavelDinamica}");
            variavelDinamica = "Texto";
            Console.WriteLine($"Tipo de variavel: { variavelDinamica.GetType()}, Valor: {variavelDinamica}");
            variavelDinamica = true;
            Console.WriteLine($"Tipo de variavel: { variavelDinamica.GetType()}, Valor: {variavelDinamica}");
        
            // CLASSE GENERICA
            Console.WriteLine("___________________________________");
            Console.WriteLine("TIPO DINÂMICO");

            MeuArray<int> arrayInteiro = new MeuArray<int>();
            arrayInteiro.AdicionarElementoArray(30);
            Console.WriteLine(arrayInteiro[0]);

            MeuArray<string> arrayString = new MeuArray<string>();
            arrayString.AdicionarElementoArray("Teste");
            Console.WriteLine(arrayString[0]);


            // MÉTODO DE EXTENSÃO
            Console.WriteLine("___________________________________");
            Console.WriteLine("MÉTODO DE EXTENSÃO");

            int numero3 = 15;
            bool par = false;

            par = numero3.EhPar();
            string mensagem = "O número " + numero3 + " é " + (par ? "par." : "ímpar.");
            Console.WriteLine(mensagem);


            // TIPO DE REFERENCIA
            Console.WriteLine("___________________________________");
            Console.WriteLine("TIPO DE REFERÊNCIA");

            Pessoa p5 = new Pessoa(nome: "André", sobrenome = "Andrade");
            Pessoa p6 = p5;
            p6.Nome = "José";

            Console.WriteLine($"O nome da pessoa p5: {p5.NomeCompleto}");
            Console.WriteLine($"O nome da pessoa p6: {p6.NomeCompleto}");


            // TIPO DE VALOR
            Console.WriteLine("___________________________________");
            Console.WriteLine("TIPO DE VALOR");
            
            int m = 10;
            int n = m;
            n = 60;

            Console.WriteLine($"O valor de M: {m}");
            Console.WriteLine($"O valor de N: {n}");

        }
    }
}
