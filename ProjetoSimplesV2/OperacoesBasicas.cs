// Dividindo o código = Modularizando

using System;

// Namespace é usada para declarar um escopo que contém um conjunto de objetos relacionados
namespace ProjetoSimplesV2
{
    // Class é onde definimos a criação da classe e criamos os seu escopo
    public class OperacoesBasicas
    {
        // Método ou função para somar dois números
        // Aqui nossos métodos tem que ser  porque serão chamados dentro do método main que é 
        // Nosso método ele tem o retorno do tipo double que é um número de ponto flutuante de 8 bits
        // Nosso método tem dois parametros de entrada que são do tipo double
        public double Somar(double parcela1, double parcela2){
            return parcela1 + parcela2;
        }
        // Método ou função para subtrair dois números
        // Aqui nossos métodos tem que ser  porque serão chamados dentro do método main que é 
        // Nosso método ele tem o retorno do tipo double que é um número de ponto flutuante de 8 bits
        // Nosso método tem dois parametros de entrada que são do tipo double
        public double Subtrair(double minuendo, double subtraendo){
            return minuendo - subtraendo;
        }
        // Método ou função para multiplicar dois números
        // Aqui nossos métodos tem que ser  porque serão chamados dentro do método main que é 
        // Nosso método ele tem o retorno do tipo double que é um número de ponto flutuante de 8 bits
        // Nosso método tem dois parametros de entrada que são do tipo double
        public double Multiplicar(double multiplicando, double multiplicador){
            return multiplicando * multiplicador;
        }
        // Método ou função para dividir dois números
        // Aqui nossos métodos tem que ser  porque serão chamados dentro do método main que é 
        // Nosso método ele tem o retorno do tipo double que é um número de ponto flutuante de 8 bits
        // Nosso método tem dois parametros de entrada que são do tipo double
        public double Dividir(double dividendo, double divisor){
            return dividendo / divisor;
        }
    }
}