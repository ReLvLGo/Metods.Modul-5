using System;
using System.Drawing;


class Mainclass
{
    static string ShowColor()

    {

        
        var favcolor = new string[3];

        for (int i = 0; i < favcolor.Length; i++)
        {
            favcolor[i] = ShowColor();
        }
       
        
            Console.WriteLine("Ваши любимые цвета: ");
        var temp = Console.ReadLine();

        switch (temp)
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



        foreach (var color in favcolor)
            {

                Console.WriteLine(color);

            }
        return ShowColor();

    }

    }
        
    

