// O intuito agora é mostrar o programa divido por classes

using System;

// Namespace é usada para declarar um escopo que contém um conjunto de objetos relacionados
namespace ProjetoSimplesV3
{
    // Class é onde definimos a criação da classe e criamos os seu escopo
    public class Program
    {
        // Instanciando a classe de apresentação
        private static Apresentacao _apresentacao = new Apresentacao();
        // Metódo inicial, sempre o compilador irá procurar pelo o método Main para iniciar a aplicação, 
        // exceto quando fazemos algumas alterações na inicialização que são tópicos mais avançados 
        public static void Main(string[] args)
        {
            // Chamando o método Apresentar da classe Apresentacao
            _apresentacao.Apresentar();
        }
    }
}
