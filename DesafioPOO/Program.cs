using DesafioPOO.Models;
using System;

namespace DesafioPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TODO: Realizar os testes com as classes Nokia e Iphone
            Console.WriteLine("\nTelefone Nokia");
            Smartphone nokia = new Nokia(numero: "94545-5555", modelo: "C20", IMEI: "561536030195001", memoria: 32);
            nokia.Ligar();
            nokia.InstalarAplicativo("Facebook");
            nokia.ReceberLigacao();

            Console.WriteLine("\nTelefone Iphone");
            Smartphone iphone = new Iphone(numero: "94545-4444", modelo: "13 Pro Max", IMEI: "561536430195011", memoria: 64);
            iphone.Ligar();
            iphone.InstalarAplicativo("Instagram");
            iphone.ReceberLigacao();
        }
    }
}
