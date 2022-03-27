using Secao09.Entities;
using Secao09.Entities.Enums;
using System.Globalization;

namespace Secao09.Exercicios
{
    class ExercicioFixacao
    {
        public ExercicioFixacao()
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth Date: ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Client client = new Client(name, email, birthDate);

            Console.WriteLine();

            Console.WriteLine("Enter order data: ");
            Console.Write("Staus: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine().ToUpper());
            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            Order order = new Order(DateTime.Now, status, client);

            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter #{i + 1} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                order.AddItem(new OrderItem(quantity, productPrice, new Product(productName, productPrice)));

                Console.WriteLine();
            }

            Console.WriteLine("ORDER SUMARY:");
            Console.WriteLine(order);
        }
    }
}