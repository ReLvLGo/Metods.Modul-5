using System;
using System.Drawing;
using System.Net.Mail;

class Mainclass
{


    static string ShowColor(string UserName, int age)
    {

        return Console.ReadLine();
    }
        static void Main(string[] args)
        {
            var (UserName, age) = (" Дмитрий ", 35);
            Console.WriteLine("Мое имя{0} ", UserName);
            Console.WriteLine("Мой возраст {0} ", age);

            Console.WriteLine("введите имя");
            UserName = Console.ReadLine();

            Console.WriteLine("введите возраст");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("ваше имя{0}", UserName);
            Console.WriteLine("ваш возраст {0}", age);
        Console.WriteLine("{0} Напишите свой любимый цвет", UserName);
        var favcolor = new string[3];

            for (int i = 0; i < favcolor.Length; i++)
            {
                favcolor[i] = ShowColor(UserName, age);

            }
           

            foreach (var color in favcolor)
            {
                Console.WriteLine(color);
            }
        }
    }

