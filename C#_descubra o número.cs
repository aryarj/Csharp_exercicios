using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.Clear();
        string _Nome;

        Console.WriteLine("Por favor, escolha um número entre 1 e 10 e após sua escolha pressione a tecla 'i' ");
         _Nome = Console.ReadLine();
        if(_Nome == "i"){
            Console.WriteLine("O número escolhido foi o 5? tecle 's' para sim, se foi maior do que 5 tecle 'm' se foi menor do que 5 tecle 'n');
        _Nome = Console.ReadLine();
    }
}