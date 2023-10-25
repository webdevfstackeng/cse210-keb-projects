using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");
        Customer customer1 = new Customer("Abel Cole", new Address("King James", "New York", "New York State", "USA"));
        Customer customer2 = new Customer("Kgotla Boabilwe", new Address("Kgale Road", "Gaborone", "South East", "Botswana"));

        Product product1 = new Product("Mango", "product1", 15.08, 8 );
        Product product2 = new Product("Oranges", "product2", 24.05, 60);
        Product product3 = new Product("Bananas", "product3", 18.12, 50 );

        List<Product> _products1 = new List<Product>();
        _products1.Add(product1);
        _products1.Add(product2);
        Order order1 = new Order(_products1, customer2);

        List<Product> _products2 = new List<Product>();
        _products2.Add(product3);
        _products2.Add(product2);
        Order order2 = new Order(_products2, customer1);

        Order order = new Order();
        order._orders.Add(order1);
        order._orders.Add(order2);

        order.Display();

    }
}