using System;

namespace ExceptionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Задание1: formatexception
            //// ошибка возникает, когда вместо числа вводят текст
            //try
            //{
            //    console.write("введите число: ");
            //    int a = int.parse(console.readline());
            //    console.writeline($"вы ввели число: {a}");
            //}
            //catch (formatexception)
            //{
            //    console.writeline("ошибка: введён текст вместо числа!");
            //}

            ////Задание2: dividebyzeroexception
            //// ошибка возникает при делении на ноль
            //try
            //{
            //    console.write("введите делимое: ");
            //    int b = int.parse(console.readline());

            //    console.write("введите делитель: ");
            //    int c = int.parse(console.readline());

            //    console.writeline($"результат деления: {b / c}");
            //}
            //catch (dividebyzeroexception)
            //{
            //    console.writeline("ошибка: на ноль делить нельзя!");
            //}

            ////Задание 3 indexoutofrangeexception
            //// ошибка возникает при обращении к несуществующему индексу массива
            //try
            //{
            //    int[] hotels = { 101, 102, 103 }; // индексы только 0, 1, 2

            //    console.write("введите индекс отеля (0-2): ");
            //    int index = int.parse(console.readline());

            //    console.writeline($"вы выбрали отель №{hotels[index]}");
            //}
            //catch (indexoutofrangeexception)
            //{
            //    console.writeline("ошибка: такого индекса нет! индексы: 0, 1, 2.");
            //}

            //// выполняется всегда после всех блоков try
            //finally
            //{
            //    console.writeline("программа завершена. нажмите любую клавишу...");
            //    console.readkey();
            //}
        }
    }
}
