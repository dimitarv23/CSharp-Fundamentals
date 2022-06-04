using System;
using System.Collections.Generic;

namespace P05.ShoppingSpree
{
    class Person
    {
        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            ProductsBought = new List<string>();
        }

        public string Name { get; set; }
        public decimal Money { get; set; }
        public List<string> ProductsBought { get; set; }
    }
    class Product
    {
        public Product(string name, decimal cost)
        {
            this.Name = name;
            this.Cost = cost;
        }

        public string Name { get; set; }
        public decimal Cost { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> allPeople = new List<Person>();
            List<Product> allProducts = new List<Product>();

            //Store all the people with their money ("{name}={money}")
            string[] people = Console.ReadLine()
                    .Split(';', StringSplitOptions.RemoveEmptyEntries);
            //Store all the products with their cost ("{product}={cost}")
            string[] products = Console.ReadLine()
                .Split(';', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < people.Length; i++)
            {
                //Split all the people and their money into two different variables
                string[] personInfo = people[i]
                    .Split('=', StringSplitOptions.RemoveEmptyEntries);
                string personName = personInfo[0];
                decimal personMoney = decimal.Parse(personInfo[1]);

                Person newPerson = new Person(personName, personMoney);
                allPeople.Add(newPerson);
            }

            for (int i = 0; i < products.Length; i++)
            {
                //Split all the products and their cost into two different variables
                string[] productInfo = products[i]
                    .Split('=', StringSplitOptions.RemoveEmptyEntries);
                string productName = productInfo[0];
                decimal productCost = decimal.Parse(productInfo[1]);

                Product newProduct = new Product(productName, productCost);
                allProducts.Add(newProduct);
            }

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] productToBuy = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string person = productToBuy[0];
                string product = productToBuy[1];

                int indexOfPerson = allPeople.FindIndex(x => x.Name == person);
                int indexOfProduct = allProducts.FindIndex(x => x.Name == product);

                if (allPeople[indexOfPerson].Money >= allProducts[indexOfProduct].Cost)
                {
                    //The person has the money to buy the product => subtract the cost of the product from the person's money, add the product to it's bag and print a message
                    allPeople[indexOfPerson].Money -= allProducts[indexOfProduct].Cost;
                    allPeople[indexOfPerson].ProductsBought.Add(allProducts[indexOfProduct].Name);
                    Console.WriteLine($"{person} bought {product}");
                }
                else
                {
                    //The person has less money than the product costs => print a message
                    Console.WriteLine($"{person} can't afford {product}");
                }

                input = Console.ReadLine();
            }

            foreach (Person person in allPeople)
            {
                if (person.ProductsBought.Count > 0)
                {
                    Console.WriteLine($"{person.Name} - {string.Join(", ", person.ProductsBought)}");
                }
                else
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
            }
        }
    }
}
