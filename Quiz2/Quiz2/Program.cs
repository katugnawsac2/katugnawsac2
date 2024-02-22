using System;

public class program
{

    public static List<string> ListOfStrings = new();
    public static List<int> ListOfInt = new();

    public static void SampleFunction()
    {
        Console.WriteLine($"Hello from {nameof(SampleFunction)}");
    }

    public static void PlaceOrder()
    {
        ListOfStrings.RemoveRange(0, ListOfStrings.Count());
        ListOfInt.RemoveRange(0, ListOfInt.Count());
    }

    public static void AddOrder()
    {

        Console.WriteLine("What is your order: ");
        string order = Console.ReadLine();
        Console.WriteLine("Enter Price: ");
        int OrderPrice = int.Parse(Console.ReadLine());
        ListOfInt.Add(OrderPrice);
        ListOfStrings.Add(order);
    }

    public static void ShowOrder()
    {
        Console.WriteLine("===========ORDER=============");
        int counter = 1;
        foreach (string x in ListOfStrings)
        {
            Console.WriteLine($"{counter}: {x}");
            counter++;
        }

    }


    //MAIN METHOD
    public static void Main(string[] args)
    {


        while (true)
        {
            Console.WriteLine("================");
            Console.WriteLine("[1] Add new order");
            Console.WriteLine("[2] Show Order");
            Console.WriteLine("[3] Place Order");
            Console.WriteLine("[4] Exit");
            Console.WriteLine("=================");
            Console.WriteLine("Select Option: ");

            string option = Console.ReadLine();

            if (option == "4")
            {
                break;
            }




            switch (option)
            {
                case "1":
                    AddOrder();

                    break;

                case "2":
                    ShowOrder();
                    break;

                case "3":
                    PlaceOrder();
                    break;


                default:
                    break;
            }

            Console.WriteLine("ALL ORDER/S AND ITS PRICE: ");

            foreach (string y in ListOfStrings)
            {
                Console.WriteLine($"{y}");

            }

            foreach (int x in ListOfInt)
            {
                Console.WriteLine($"Price: {x}");

            }

        }

    }
}