using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            string zodiacSign;
            string works;
            Console.Write("Введите ваше имя: ");
            name = Console.ReadLine();
            Console.Write("Введите ваш возраст: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Какой у вас знак зодиака? ");
            zodiacSign = Console.ReadLine();
            Console.Write("Кем вы работаете? ");
            works = Console.ReadLine();
           
            Console.WriteLine($"Вас зовут: {name}. Ваш возраст - {age}. Ваш знак зодиака - {zodiacSign}. Вы работаете - {works}");
        }
    }
}
