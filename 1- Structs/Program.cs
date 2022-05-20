using System;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Product mouse = new Product(1, "mouse gamer", 299.97);// quando executar dotnet run, vou ter esses valores informados
            mouse.Id = 55; //vai imprimir o 55 em vez do 1

            Console.WriteLine(mouse.Id);
            Console.WriteLine(mouse.Name);
            Console.WriteLine(mouse.Price);
        }
    }

    struct Product
    {
        public Product(int id, string name, double price)//Método construtor
        {
            Id = id;
            Name = name;
            Price = price;
        }
        public int Id;
        public string Name;
        public double Price; // Price em maiscúlo é uma propriedade.

        public double PriceInDolar(double dolar) {
            return Price * dolar; // dolar em minusculo é um parâmetro.
        }
    }
}

