using System;

class Product
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public double Cost { get; set; }

    public Product(int productId, string name, double cost)
    {
        ProductId = productId;
        Name = name;
        Cost = cost;
    }

    public override bool Equals(object obj)
    {
        if (obj == null || !(obj is Product))
            return false;

        var otherProduct = (Product)obj;
        return ProductId == otherProduct.ProductId && Name == otherProduct.Name;
    }
}

class Inventory
{
    private Product[] products;

    public Inventory()
    {
        products = new Product[]
        {
            new Product(1, "Laptop", 1000),
            new Product(2, "Keyboard", 50),
            new Product(3, "Mouse", 25)
        };
    }

    public void FindProductById()
    {
        int productId;
        Product foundProduct = null;
        double totalCost = 0;
        int quantity = 0;

        Console.Write("Enter the product ID: ");
        while (!int.TryParse(Console.ReadLine(), out productId) || !(productId > 0 && productId <= 3))
        {
            Console.WriteLine("Invalid input. Please enter a valid number for the product ID (1 to 3):");
            Console.Write("Enter the product ID: ");
        }

        foreach (var product in products)
        {
            if (product.ProductId == productId)
            {
                foundProduct = product;

                Console.Write($"Enter quantity for {foundProduct.Name}: ");
                while (!int.TryParse(Console.ReadLine(), out quantity) || quantity <= 0)
                {
                    Console.WriteLine("Invalid quantity. Please enter a valid positive integer:");
                    Console.Write($"Enter quantity for {foundProduct.Name}: ");
                }

                totalCost = foundProduct.Cost * quantity;
                Console.WriteLine($"Product found by ID: {foundProduct.Name}, Quantity: {quantity}, Total Cost: ${totalCost}");
                return;
            }
        }

        Console.WriteLine("Product not found by ID.");
    }

    public void FindProductByName()
    {
        string productName;
        Product foundProduct = null;
        double totalCost = 0;
        int quantity = 0;

        Console.Write("Enter the product name: ");
        productName = Console.ReadLine();

        foreach (var product in products)
        {
            if (product.Name.Equals(productName, StringComparison.OrdinalIgnoreCase))
            {
                foundProduct = product;

                Console.Write($"Enter quantity for {foundProduct.Name}: ");
                while (!int.TryParse(Console.ReadLine(), out quantity) || quantity <= 0)
                {
                    Console.WriteLine("Invalid quantity. Please enter a valid positive integer:");
                    Console.Write($"Enter quantity for {foundProduct.Name}: ");
                }

                totalCost = foundProduct.Cost * quantity;
                Console.WriteLine($"Product found by Name: {foundProduct.Name}, Quantity: {quantity}, Total Cost: ${totalCost}");
                return;
            }
        }

        Console.WriteLine("Product not found by Name.");
    }
}

class Program
{
    static void Main()
    {
        Inventory inventory = new Inventory();
        int choice;

        while (true)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Search by Product ID");
            Console.WriteLine("2. Search by Product Name");
            Console.WriteLine("3. Exit");

            while (!int.TryParse(Console.ReadLine(), out choice) || (choice < 1 || choice > 3))
            {
                Console.WriteLine("Invalid input. Please enter 1, 2, or 3.");
            }

            switch (choice)
            {
                case 1:
                    inventory.FindProductById();
                    break;
                case 2:
                    inventory.FindProductByName();
                    break;
                case 3:
                    Console.WriteLine("Exiting...");
                    return;
            }
        }
    }
}
