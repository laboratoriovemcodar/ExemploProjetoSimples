// O intuito agora é mostrar o programa totalmente criado em uma classes

using System;

// Namespace é usada para declarar um escopo que contém um conjunto de objetos relacionados
namespace ProjetoSimples
{
    // Class é onde definimos a criação da classe e criamos os seu escopo
    public class Program
    {
        // Metódo inicial, sempre o compilador irá procurar pelo o método Main para iniciar a aplicação, 
        // exceto quando fazemos algumas alterações na inicialização que são tópicos mais avançados 
        public static void Main(string[] args)
        {
            // Variáveis que iremos utilizar durante o código dentro do escopo main
            double numero1;
            double numero2;
            double resultado;
            // Apresentando uma mensagem na tela informando sobre o programa
            Console.WriteLine("Programa simulando as quatro operações básicas");
            Console.WriteLine("Digite um número: ");
            // Lendo a entrada de dados digitada pelo usuário no terminal
            // Após ler a entrada de dados ela virá como tipo String então precimos fazer a conversão
            // Então realizamos um conversão explícita de dados entre String e double
            numero1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite outro número: ");
            // Lendo a entrada de dados digitada pelo usuário no terminal
            // Após ler a entrada de dados ela virá como tipo String então precimos fazer a conversão
            // Então realizamos um conversão explícita de dados entre String e double
            numero2 = Convert.ToDouble(Console.ReadLine());
            // Chamando o método somar
            resultado = Somar(numero1, numero2);
            Console.WriteLine("O resultado da soma entre {0} e {1} é igual à {2}",numero1, numero2, resultado);
            // Chamando o método subtrair
            resultado = Subtrair(numero1, numero2);
            Console.WriteLine("O resultado da subtração entre {0} e {1} é igual à {2}",numero1, numero2, resultado);
            // Chamando o método multiplicar
            resultado = Multiplicar(numero1, numero2);
            Console.WriteLine("O resultado da multiplicação entre {0} e {1} é igual à {2}",numero1, numero2, resultado);
            // Chamando o método dividir
            resultado = Dividir(numero1, numero2);
            Console.WriteLine("O resultado da divisão entre {0} e {1} é igual à {2}",numero1, numero2, resultado);
            // Aguardando a entrada do usuário para finalizar o programa
            Console.ReadKey();
            // Mensagem de fim do programa
            Console.WriteLine("Fim do Programa");

        }

        // Método ou função para somar dois números
        // Aqui nossos métodos tem que ser static porque serão chamados dentro do método main que é static
        // Nosso método ele tem o retorno do tipo double que é um número de ponto flutuante de 8 bits
        // Nosso método tem dois parametros de entrada que são do tipo double
        public static double Somar(double parcela1, double parcela2){
            return parcela1 + parcela2;
        }

        // Método ou função para subtrair dois números
        // Aqui nossos métodos tem que ser static porque serão chamados dentro do método main que é static
        // Nosso método ele tem o retorno do tipo double que é um número de ponto flutuante de 8 bits
        // Nosso método tem dois parametros de entrada que são do tipo double
        public static double Subtrair(double minuendo, double subtraendo){
            return minuendo - subtraendo;
        }

        // Método ou função para multiplicar dois números
        // Aqui nossos métodos tem que ser static porque serão chamados dentro do método main que é static
        // Nosso método ele tem o retorno do tipo double que é um número de ponto flutuante de 8 bits
        // Nosso método tem dois parametros de entrada que são do tipo double
        public static double Multiplicar(double multiplicando, double multiplicador){
            return multiplicando * multiplicador;
        }

        // Método ou função para dividir dois números
        // Aqui nossos métodos tem que ser static porque serão chamados dentro do método main que é static
        // Nosso método ele tem o retorno do tipo double que é um número de ponto flutuante de 8 bits
        // Nosso método tem dois parametros de entrada que são do tipo double
        public static double Dividir(double dividendo, double divisor){
            return dividendo / divisor;
        }




    }
}
