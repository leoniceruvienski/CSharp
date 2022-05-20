using System;

namespace Enumeradores
{class Program
    {
        static void Main(string[] args)
        {
            var mouse = new Product(1, "Mouse gamer", 299.97, EProductType.Product);// quando executar dotnet run, vou ter esses valores informados
            var manutencaoEletrica = new Product(2, "Manutenção elétrica residencial", 500, EProductType.Service);
            mouse.Id = 55; //vai imprimir o 55 em vez do 1

            Console.WriteLine(mouse.Id);
            Console.WriteLine(mouse.Name);
            Console.WriteLine(mouse.Price);
            Console.WriteLine(mouse.Type);
            Console.WriteLine((int)mouse.Type);
        }
    }

    struct Product
    {
        public Product(int id, string name, double price, EProductType type)//Método construtor
        {
            Id = id;
            Name = name;
            Price = price;
            Type = type;
        }
        public int Id;
        public string Name;
        public double Price; // Price em maiscúlo é uma propriedade.
        public EProductType Type;

        public double PriceInDolar(double dolar) {
            return Price * dolar; // dolar em minusculo é um parâmetro.
        }
    }

    enum EProductType{ // enumeradores devem ficar no mesmo nível que as classes
        Product = 1,
        Service = 2
    }
}
