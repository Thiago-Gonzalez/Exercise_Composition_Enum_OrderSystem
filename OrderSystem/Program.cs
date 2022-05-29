// See https://aka.ms/new-console-template for more information
using OrderSystem.Entities.Enums;
using OrderSystem.Entities;
using System.Globalization;

Console.WriteLine("Enter client data:");
Console.Write("Name: ");
string name = Console.ReadLine();
Console.Write("Email: ");
string email = Console.ReadLine();
Console.Write("Birth date (DD/MM/YYYY): ");
DateTime birthDate = DateTime.Parse(Console.ReadLine());


Console.WriteLine("Enter order data:");
Console.Write("Status: ");
OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
Console.Write("How many items to this order? ");
int items = int.Parse(Console.ReadLine());

Order order = new Order(DateTime.Now, status, new Client(name, email, birthDate));

for (int i = 0; i < items; i++)
{
    Console.WriteLine($"Enter #{i+1} item data:");
    Console.Write("Product name: ");
    string productName = Console.ReadLine();
    Console.Write("Product price: ");
    double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Quantity: ");
    int quantity = int.Parse(Console.ReadLine());
    order.AddItem(new OrderItem(quantity, productPrice, new Product(productName, productPrice)));
}

Console.WriteLine();
Console.WriteLine(order);