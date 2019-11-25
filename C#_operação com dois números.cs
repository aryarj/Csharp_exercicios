using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.Clear();
            int _Numero1;
            int _Numero2;
            string _Operacao;
            Console.WriteLine("Por favor, digite um numero inteiro");
             _Numero1 = Convert.ToInt16(Console.ReadLine());
            
            Console.WriteLine("Agora, digite o segundo número inteiro");
             _Numero2 = Convert.ToInt16(Console.ReadLine());
            
            Console.WriteLine("Por favor, digite a operação desejada: 's' para soma; 'sub' para subtração; 'm' para multiplicação e 'd' para divisão");
            _Operacao = Console.ReadLine();

            if(_Operacao == "s"){
                Console.WriteLine("O resultado da soma é  " + (_Numero1+_Numero2));
            }
            else if(_Operacao == "sub"){
                Console.WriteLine("O resultado da subtração é  " + (_Numero1 - _Numero2)) ;
             }
             else if(_Operacao == "m"){
                Console.WriteLine("O resultado da multiplicação é  " + _Numero1*_Numero2);}
            else if(_Operacao == "d"){
                Console.WriteLine("O resultado da divisão é   " + _Numero1/_Numero2);}
            else if(_Operacao != "s"){
                Console.WriteLine("Opção invalida. Por favor, reinicie o programa");}
            else if(_Operacao != "sub"){
                Console.WriteLine("Opção invalida. Por favor, reinicie o programa");}
            else if(_Operacao != "m"){
                Console.WriteLine("Opção invalida. Por favor, reinicie o programa");}
            else if(_Operacao != "d"){
                Console.WriteLine("Opção invalida. Por favor, reinicie o programa");}
        }
    }
}