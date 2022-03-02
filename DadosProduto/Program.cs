using DadosProduto.Entities;
using System.Globalization;

List<Product> list = new List<Product>();

Console.Write("Enter the number of products: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Product #{i} data: ");
    Console.Write("Common, used or imported (c/u/i)? ");
    char resp = char.Parse(Console.ReadLine());

    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Price: ");
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    if (resp == 'i')
    {
        Console.Write("Customs fee: ");
        double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        list.Add(new ImportedProduct(name, price, customsFee));
    }
    else if (resp == 'u')
    {
        Console.Write("Manufacture date (DD/MM/YYYY): ");
        DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
        list.Add(new UsedProduct(name, price, manufactureDate));
    }
    else
    {
        list.Add(new Product(name, price));
    }
}

Console.WriteLine();
Console.WriteLine("PRICE TAGS:");
foreach (var prod in list)
{
    Console.WriteLine(prod.PriceTag());
}


