
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    public class Program
    {
        static void Main(string[] args)
        {

            try
            {
                List<Person> persons = new List<Person>();
                List<Product> products = new List<Product>();

                string[] peopleInput = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
                string[] productsInput = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < peopleInput.Length; i++)
                {
                    string[] currentPerson = peopleInput[i].Split("=");
                    persons.Add(new Person(currentPerson[0], decimal.Parse(currentPerson[1])));
                }

                for (int i = 0; i < productsInput.Length; i++)
                {
                    string[] currentProduct = productsInput[i].Split("=");
                    products.Add(new Product(currentProduct[0], decimal.Parse(currentProduct[1])));
                }

                string command = Console.ReadLine();

                while (command != "END")
                {
                    string[] splitedCommand = command.Split();

                    Person person = persons.FirstOrDefault(p => p.Name == splitedCommand[0]);
                    Product product = products.FirstOrDefault(pr => pr.Name == splitedCommand[1]);

                    if (person.Money < product.Cost)
                    {
                        Console.WriteLine($"{person.Name} can't afford {product.Name}");
                        command = Console.ReadLine();
                        continue;
                    }

                    person.AddProduct(product);
                    Console.WriteLine($"{person.Name} bought {product.Name}");

                    command = Console.ReadLine();
                }

                foreach (var person in persons)
                {
                    string message = person.Bag.Count == 0
                        ? "Nothing bought"
                        : string.Join(", ", person.Bag.Select(p => p.Name));

                    Console.WriteLine($"{person.Name} - {message}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
