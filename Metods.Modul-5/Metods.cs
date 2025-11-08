using System;
using System.Drawing;


class Mainclass
{

    static void Main(string[] args) { 
   
    static string ShowColor()

    {
        Console.WriteLine("Напишите ваши любимые цвета");
        return Console.ReadLine();
    }

        var favcolor = new string[3];

        for (int i = 0; i < favcolor.Length; i++)
        {
            favcolor[i] = ShowColor();

        }


        Console.WriteLine("Ваши любимые цвета: ");


        foreach (var colors in favcolor)
        {
            switch (colors)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;
                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is yellow!");
                    break;
            }
            Console.WriteLine(colors);

        }
        

    }

}
