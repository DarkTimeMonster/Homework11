﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Задача 1. Дано целое число n, указывающее номер дня недели от 1 до 7. По указанному номеру n вывести название соответствующего дня недели.
            Console.WriteLine("Введите номер дня");
            byte numberday = byte.Parse(Console.ReadLine());

            switch (numberday)
            {
            case 1:
            Console.WriteLine("Понедельник");
            break;
            case 2:
            Console.WriteLine("Вторник");
            break;
            case 3:
            Console.WriteLine("Среда");
            break;
            case 4:
            Console.WriteLine("Четверг");
            break;
            case 5:
            Console.WriteLine("Пятница");
            break;
            case 6:
            Console.WriteLine("Суббота");
            break;
            case 7:
            Console.WriteLine("Воскресенье");
            break;
            default:
            Console.WriteLine("Такого номера месяца нет");
            break;
            }*/
            /*
            //Задача 2. В зависимости от порядкового номера месяца (1, 2, ... , 12) вывести на экран его название (январь, февраль, ... , декабрь).
            Console.WriteLine("Введите номер месяца");
            byte numbermonth = byte.Parse(Console.ReadLine());

            switch (numbermonth)
            {
            case 1:
            Console.WriteLine("Январь");
            break;
            case 2:
            Console.WriteLine("Февраль");
            break;
            case 3:
            Console.WriteLine("Март");
            break;
            case 4:
            Console.WriteLine("Апрель");
            break;
            case 5:
            Console.WriteLine("Май");
            break;
            case 6:
            Console.WriteLine("Июнь");
            break;
            case 7:
            Console.WriteLine("Июль");
            break;
            case 8:
            Console.WriteLine("Август");
            break;
            case 9:
            Console.WriteLine("Сентябрь");
            break;
            case 10:
            Console.WriteLine("Октябрь");
            break;
            case 11:
            Console.WriteLine("Ноябрь");
            break;
            case 12:
            Console.WriteLine("Декабрь");
            break;
            default:
            Console.WriteLine("Такого номера месяца нет");
            break;
            }*/
            /*
            //Задача 3. По номеру месяца вывести название времени года.
            Console.WriteLine("Введите номер месяца");
            byte numbermonth = byte.Parse(Console.ReadLine());
            switch(numbermonth)
            {
            case 12:
            case 1:
            case 2:
            Console.WriteLine("Зима");
            break;
            case 3:
            case 4:
            case 5:
            Console.WriteLine("Весна");
            break;
            case 6:
            case 7:
            case 8:
            Console.WriteLine("Лето");
            break;
            case 9:
            case 10:
            case 11:
            Console.WriteLine("Осень");
            break;

            default:
            Console.WriteLine("Такого номера месяца нет");
            break;
            }*/

            /*
            //Задача 4. Вывести название предмета по введенной первой букве: ф – физика, м – математика, и – история, г – география, б – биология.
            Console.WriteLine("Введите первую букву предмета (физика,математика,история,география,биология)");
            char word = Convert.ToChar(Console.ReadLine());
            switch (word)
            {

            case 'Ф':
            case 'ф':
            Console.WriteLine("физика");
            break;
            case 'М':
            case 'м':
            Console.WriteLine("математика");
            break;
            case 'И':
            case 'и':
            Console.WriteLine("история");
            break;
            case 'Б':
            case 'б':
            Console.WriteLine("биология");
            break;
            case 'Г':
            case 'г':
            Console.WriteLine("география");
            break;
            default:
            Console.WriteLine("Такого предмета нет");
            break;
            }*/

            Console.ReadKey();
        }
    }
}
