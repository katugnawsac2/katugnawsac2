using System;



class Car {
    public string Brand;
    public string Color;
    public int Price;
   
    class program
    {
        static void Main(string[] args)
        {
            List<Car> list = new List<Car>();

            while (true)
            {
                Console.WriteLine("Enter new data? [Y/N]");
                if (Console.ReadLine() == "N")
                {

                    break;

                }

                Car car1 = new Car();

                Console.WriteLine("Enter Car Brand: ");
                car1.Brand = Console.ReadLine();

                Console.WriteLine("Enter Car Color: ");
                car1.Color = Console.ReadLine();

                Console.WriteLine("Enter Car Price: ");
                car1.Price = int.Parse(Console.ReadLine());

                list.Add(car1);

            }

            list.ForEach(x =>
                {

                    Console.WriteLine(x.Brand);
                    Console.WriteLine(x.Color);
                    Console.WriteLine(x.Brand);
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("---------------------------");
                  

                });
        }


    }
}