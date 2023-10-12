using System;

class Program
{
    public static void Main(string[] args)
    {
        double dTotal = 0, eTotal = 0, fTotal = 0;
        char salesperson;

        Console.WriteLine("Enter person initial (D for Danielle, E for Edward, F for Francis) or Z to terminate:");
        salesperson = Char.ToUpper(Convert.ToChar(Console.ReadLine()));

        while (salesperson != 'Z')
        {
            switch (salesperson)
            {
                case 'D':
                case 'E':
                case 'F':
                    Console.WriteLine("Enter the amount of sale:");
                    double sale = Convert.ToDouble(Console.ReadLine());
                    if (salesperson == 'D')
                    {
                        dTotal += sale;
                    }
                    else if (salesperson == 'E')
                    {
                        eTotal += sale;
                    }
                    else
                    {
                        fTotal += sale;
                    }
                    break;
                default:
                    Console.WriteLine("Error, invalid salesperson selected, please try again.");
                    break;
            }

            Console.WriteLine("Enter another salesperson initial (D for Danielle, E for Edward, F for Francis) or Z to terminate:");
            salesperson = Char.ToUpper(Convert.ToChar(Console.ReadLine()));
        }

        double grandTotal = dTotal + eTotal + fTotal;

        Console.WriteLine($"Danielle's Total: ${dTotal}");
        Console.WriteLine($"Edward's Total: ${eTotal}");
        Console.WriteLine($"Francis's Total: ${fTotal}");
        Console.WriteLine($"Grand Total: ${grandTotal}");

        if (dTotal > eTotal && dTotal > fTotal)
        {
            Console.WriteLine("Highest Sale: Danielle");
        }
        else if (eTotal > dTotal && eTotal > fTotal)
        {
            Console.WriteLine("Highest Sale: Edward");
        }
        else
        {
            Console.WriteLine("Highest Sale: Francis");
        }
    }
}

