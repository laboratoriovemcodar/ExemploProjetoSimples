// Dividindo o código = Modularizando
// Atribuindo uma responsabilidade de apenas efetuar as apresentações dos dados

using System;

// Namespace é usada para declarar um escopo que contém um conjunto de objetos relacionados
namespace ProjetoSimplesV3
{
    // Class é onde definimos a criação da classe e criamos os seu escopo
    public class Apresentacao
    {
        // Instanciando a classe de OperacoesBasicas
        private static OperacoesBasicas _operacoesBasicas = new OperacoesBasicas();
        // Variáveis que iremos utilizar durante o código dentro do escopo main
        private double numero1;
        private double numero2;
        private double resultado; 
        public void Apresentar()
        {
            // Apresentando uma mensagem na tela informando sobre o programa
            Console.WriteLine("Programa simulando as quatro operações básicas");
            Console.Write("Digite um número: ");
            // Lendo a entrada de dados digitada pelo usuário no terminal
            // Após ler a entrada de dados ela virá como tipo String então precimos fazer a conversão
            // Então realizamos um conversão explícita de dados entre String e double
            numero1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite outro número: ");
            // Lendo a entrada de dados digitada pelo usuário no terminal
            // Após ler a entrada de dados ela virá como tipo String então precimos fazer a conversão
            // Então realizamos um conversão explícita de dados entre String e double
            numero2 = Convert.ToDouble(Console.ReadLine());
            // Chamando o método somar
            resultado = _operacoesBasicas.Somar(numero1, numero2);
            Console.WriteLine("O resultado da soma entre {0} e {1} é igual à {2}",numero1, numero2, resultado);
            // Chamando o método subtrair
            resultado = _operacoesBasicas.Subtrair(numero1, numero2);
            Console.WriteLine("O resultado da subtração entre {0} e {1} é igual à {2}",numero1, numero2, resultado);
            // Chamando o método multiplicar
            resultado = _operacoesBasicas.Multiplicar(numero1, numero2);
            Console.WriteLine("O resultado da multiplicação entre {0} e {1} é igual à {2}",numero1, numero2, resultado);
            // Chamando o método dividir
            resultado = _operacoesBasicas.Dividir(numero1, numero2);
            Console.WriteLine("O resultado da divisão entre {0} e {1} é igual à {2}",numero1, numero2, resultado);
            // Aguardando a entrada do usuário para finalizar o programa
            Console.ReadKey();
            // Mensagem de fim do programa
            Console.WriteLine("Fim do Programa");
        }
    }
}