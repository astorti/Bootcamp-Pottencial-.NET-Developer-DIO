## BOOTCAMP POTTENCIAL .NET DEVELOPER
### Plataforma DIO: Digita Inovation One

Repositório para inserção dos códigos e projetos desenvolvidos durante o Bootcamp Pottencial para aprendizado da linguagem C# e .NET.

##### PASTA: EXEMPLO_FUNDAMENTOS
Contém os códigos apresentados em aula sobre os fundamentos da linguagem C#.
 
  __**Tópicos:**__
 > Instanciação de um objeto da classe Pessoa;
 > Declaração de tipos de variaveis;
 > Utilização do tipo DateTime;
 > Sinal de atribuição;
 > Conversão tipos de variaveis;
 > Conversão para string;
 > Casting implicito;
 > Ordem dos operadores;
 > Método TryParse;
 > Operadores condicionais
 > Switch case;
 > Operador OR;
 > Operador AND;
 > Operador NOT;
 > Operadores aritmeticos;
 > Incremento - decremento;
 > Estrutura de repetição FOR;
 > Estrutura de repetição WHILE;
 > Estrutura de repetição DO-WHILE;
 > Menu interativo com WHILE;
 > Array;
 > Foreach;
 > Redimencionar uma array;
 > Copiar uma array;
 > Lista;

##### PASTA: ExemploExplorando
Contém os códigos apresentados em aula sobre os conceitos de nível intermediário da linguagem C#.
 
  __**Tópicos:**__
 > Acessando uma classe com e sem construtor;
 > Formatando valores monetários;
 > Alterando a locallização do código;
 > Alterando a localização da cultura;
 > Formatação personalizada;
 > Representação em porcentagem;
 > Separador de inteiro;
 > Formatação do tipo DateTime;
 > Formatando data e hora;
 > DateTime com Parse e TryParse;
 > Leitura de arquivo;
 > Tratamento de exceções genéricas e específicas;
 > Throw exception;
 > Queue;
 > Stack;
 > Dictionary;
 > Tuplas;
 > Tuplas em métodos;
 > Desconstructor;
 > If ternário;
 > Serialização;
 > Serialização de coleção;
 > Descerialização de coleção;
 > Tipo nulo;
 > Tipo anônimo;
 > Tipo anônimo em coleções;
 > Tipo dinâmico;
 > Classe genérica;
 > Método de extensão;
 > Tipo de referência;
 > Tipo de valor

##### PASTA: ExemploPOO
Contém os códigos apresentados em aula sobre os conceitos de Programação Orientada a Objetos na linguagem C#.
 
  __**Tópicos:**__
 > Instanciação;
 > Herança;
 > Polimorfismo;
 > Classe Abstrata;
 > Construtor por herança;
 > Class Object;
 > Interface.


#### PASTA: Desafios
Contém os códigos dos desafios apresentados durante o bootcamp.
 
 **Desafio Fundamentos 01: Subtraindo o produto e a soma de um número inteiro**
 > **Desafio:** Dado um número inteiro ( n ) , retorne a diferença entre o produto de seus dígitos e a  soma de seus dígitos.
 > **Entrada:** A entrada consiste em um número inteiro ( n );
 > **Saída:** A saída consiste na multiplicação do produto dos dígitos ( n ), a soma de seus dígitos e a  diferenção entre o produto e a soma.

 **Desafio Fundamentos 02: Encaixa ou não?**
 > **Desafio:** Paulinho tem em suas mãos um novo problema. Agora a sua professora lhe pediu que construísse um programa para verificar, à partir de dois valores muito grandes A e B, se B corresponde aos últimos dígitos de A.
 > **Entrada:** A entrada consiste de vários casos de teste. A primeira linha de entrada contém um inteiro N que indica a quantidade de casos de teste. Cada caso de teste consiste de dois valores A e B maiores que zero, cada um deles podendo ter até 1000 dígitos.
 > **Saída:** Para cada caso de entrada imprima uma mensagem indicando se o segundo valor encaixa no primeiro valor.
 
 **Desafio Fundamentos 03: Três divisores**
 > **Desafio:** Dado um inteiro n, retorne true se n tiver exatamente três divisores positivos. Caso contrário, retorne false. O inteiro m é um divisor de n, se existe um inteiro k tal que n = k * m. 
 > **Entrada:** O arquivo de entrada consiste em um inteiro n que será validada caso esteja sob as condições do desafio.
 > **Saída:** A saída consistirá em um tipo booleano: true ou false.

 **Desafio Intermediário 01: Elemento Majoritário**
 > **Desafio:** Dado um array nums de tamanho n, retorne o elemento majoritário, isto é, o elemento que aparece o maior número de vezes no seu array.
 > **Entrada:** A primeira linha da entrada deverá ser o número referente ao tamanho do seu array. As demais linhas nums serão os valores da sua array.
 > **Saída:** A saída deverá retornar o número que aparece o maior número de vezes na sua array, ou seja, o elemento majoritário.

 **Desafio Intermediário 02: Aumento de Salário**
 > **Desafio:** A empresa ABC resolveu conceder um aumento de salários a seus funcionários de acordo com a tabela abaixo:
 
 | Salário | Reajuste (%) |
 | ------  | ------------ |
 | 0 - 400.00 | 15% |
 | 400.01 - 800.00 | 12% |
 | 800.01 - 1200.00 | 10% |
 | 1200.01 - 2000.00 | 7% |
 | Acima de 2000.00 | 4% |
 
 > Leia o salário do funcionário e calcule e mostre o novo salário, bem como o valor de reajuste ganho e o índice reajustado, em percentual.
 > **Entrada:** A entrada contém apenas um valor de ponto flutuante, que pode ser maior ou igual a zero, com duas casas decimais.
 > **Saída:** Imprima 3 linhas na saída: o novo salário, o valor ganho de reajuste e o percentual de reajuste ganho.

 **Desafio Intermediário 03: A Corrida de Tartarugas**
 > **Desafio:** A corrida de tartarugas é um esporte que cresceu muito nos últimos anos, fazendo com que vários competidores se dediquem a capturar tartarugas rápidas, e treina-las para faturar milhões em corridas pelo mundo. Porém a tarefa de capturar tartarugas não é uma tarefa muito fácil, pois quase todos esses répteis são bem lentos. Cada tartaruga é classificada em um nível dependendo de sua velocidade:

 - Nível 1: Se a velocidade é menor que 10 cm/h .
 - Nível 2: Se a velocidade é maior ou igual a 10 cm/h e menor que 20 cm/h .
 - Nível 3: Se a velocidade é maior ou igual a 20 cm/h .

 >Sua tarefa é identificar qual o nível de velocidade da tartaruga mais veloz de um grupo.
 > **Entrada:** A entrada consiste de múltiplos casos de teste, e cada um consiste em duas linhas: A primeira linha contém um inteiro L (1 ≤ L ≤ 500) representando o número de tartarugas do grupo, e a segunda linha contém L inteiros Vi (1 ≤ Vi ≤ 50) representando as velocidades de cada tartaruga do grupo.
 > **Saída:** Para cada caso de teste, imprima uma única linha indicando o nível de velocidade da tartaruga mais veloz do grupo.


 #### Pasta: DesafiosDeProjetos
 Contém os códigos dos desafios de projetos apresentados durante o bootcamp.

 **Desafios de Projeto 01: Construindo um sistema para estacionamento em C#**
  Neste desafio, foi proposto completar partes de um sistema de estacionamento, baseado no [repositório](https://github.com/digitalinnovationone/trilha-net-fundamentos-desafio/) do projeto original da DIO. 
  Este sistema será utilizado para gerenciar veículos estacionados e realizar operações, tais como:

  > **Adicionar** um veículo;
  > **Remover** um veículo e exibir o valor cobrado, a partir das informações de valor e tempo de permanência na vaga, informados no sistema;
  > **Listar** os veículos no estacionamento.

  **Desafios de Projeto 02: Construindo um sistema para hospedagem em hotel em C#**
  Neste desafio foi proposto construir um sistema de hospedagem, que será usado para realizar uma reserva em um hotel. Será necessário usar a classe Pessoa, que representa o hóspede, a classe Suíte, e a classe Reserva, que fará um relacionamento entre ambos. No programa deverá calcular corretamente os valores dos métodos da classe Reserva, que precisará trazer a quantidade de hóspedes e o valor da diária, concedendo um desconto de 10% para caso a reserva seja para um período maior ou igual a 10 dias. O desafio consiste em completar os códigos referente ao métodos da classe Reserva, tais como: **CadastrarHospedes**, **CadastrarSuite**, **ObterQuantidadeHospedes** e **CalcularValorDiaria**. O código base para o desafio se encontra no [repositório](https://github.com/digitalinnovationone/trilha-net-explorando-desafio) da Digital Innovation One.

  **Desafios de Projeto 03: Abstraindo um celular com POO em C#**
  Neste desafio foi proposto a fazer a abstração de um celular usando a programação orientada a objetos, baseado no diagrama de classe do projeto, com o objeto fixar o aprendizado de classes e métodos, classes e metodos abstratos, herança, polimorfismo, construtores e encapsulamento. O projeto consiste na classe abstrata **Smartphone**, com os métodos **Ligar**, **ReceberLigacao** e o método abstrato **InstalarAplicativo** e também as classes **Iphone** e **Nokia**, que herdam os atributos e métodos da classe Smartphone. O código base para o desafio se encontra no [repositório](https://github.com/digitalinnovationone/trilha-net-poo-desafio) da Digital Innovation One.
