using DesafioPOO.Models;
using System;

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implementado: Realizar os testes com as classes Nokia e Iphone
            Console.WriteLine("Smartphone Nokia:");
            Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "111111111", memoria: 64);
            nokia.Ligar();
            nokia.InstalarAplicativo("Whatsapp");

            Console.WriteLine("\n");

            Console.WriteLine("Smartphone iPhone:");
            Smartphone iphone = new Iphone(numero: "4987", modelo: "Modelo 2", imei: "222222222", memoria: 128);
            iphone.Ligar();
            iphone.InstalarAplicativo("Telegram");

            Console.ReadKey();
        }
    }
}
