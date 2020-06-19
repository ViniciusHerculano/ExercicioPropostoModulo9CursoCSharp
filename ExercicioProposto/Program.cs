using System;
using ExercicioProposto.Entities;
using ExercicioProposto.Entities.Enums;
using System.Globalization;

namespace ExercicioProposto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthdate = DateTime.Parse(Console.ReadLine());

            Client c1 = new Client(name, email, birthdate);

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order? ");
            int quantity = int.Parse(Console.ReadLine());
            Order o1 = new Order(DateTime.Now, status, c1);

            for (int i = 0; i < quantity; i++)
            {
                Console.WriteLine($"Enter #{i + 1} item data:");
                Console.Write("Product name: ");
                string prodname = Console.ReadLine();
                Console.Write("Product price: ");
                double prodprice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int prodqtd = int.Parse(Console.ReadLine());

                Product p1 = new Product(prodname, prodprice);

                OrderItem orderitem = new OrderItem(prodqtd, prodprice, p1);
                o1.AddItem(orderitem);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMARY");
            Console.WriteLine(o1);
               


        }
    }
}
