using System;


class Person
{

    public string Name { get; set; }
    public int Weight { get; set; }
    class Program
    {

        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            while (true)
            {
                Console.WriteLine("Enter a name: ");
                string name = Console.ReadLine();

                if (name.ToLower() == "exit")
                {
                    break;
                }

                Console.WriteLine("Enter a weight: ");
                string weightInput = Console.ReadLine();
                int weight;
                if (int.TryParse(weightInput, out weight))
                {
                    Person person = new Person { Name = name, Weight = weight };
                    people.Add(person);
                    Console.WriteLine($"New added name: {name} weight: {weight}");
                }
                else
                {
                    Console.WriteLine("Warning: Invalid Input!");
                   
                }
            }

            Console.WriteLine("*****************************");
            foreach (Person person in people)
            {
                Console.WriteLine($"{person.Name}: {person.Weight}");
            }
        }


    }
}