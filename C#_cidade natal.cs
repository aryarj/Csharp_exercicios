using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.Clear();
            string _Nome;
            string _Cidade;
            Console.WriteLine("Por favor, escreva o seu nome");
            _Nome = Console.ReadLine();
            Console.WriteLine("Agora, escreva o nome de sua cidade natal");
            _Cidade = Console.ReadLine();
            if(_Cidade == "Campinas"){
                Console.WriteLine("A pessoa " + _Nome + " é campineira");
            }
            else if(_Cidade == "São Paulo"){
                Console.WriteLine("A pessoa " + _Nome + " é paulista");
             }
             else if(_Cidade == "Maringá"){
                Console.WriteLine("A pessoa " + _Nome + " é Maringaense");}
            else {Console.WriteLine("Não sei a sua designação natal, sinto muito");}
        }
    }
}