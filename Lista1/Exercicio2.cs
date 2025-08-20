using System;
using MinhaBiblioteca;

class Exercicio2
{
    static int contadorImpar(int[] vetor)
    {
        
    }
    static void Main()
    {
        int n;
        Console.WriteLine("Tamanho do vetor:");
        n = int.Parse(Console.ReadLine());
        int[] vetor = new int[n];
        Biblioteca.gerarVetor(vetor);
        Biblioteca.mostrarVetor(vetor);

    }

}