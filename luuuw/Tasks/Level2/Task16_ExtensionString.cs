using luuuw.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using luuuw.Extensions;

namespace luuuw.Tasks.Level2
{
    public class Task16_StringExtensions : ITask
    {
        public string Title => "Методы расширения для string";
        public string Description => "Написать extension-методы для string и продемонстрировать их работу.";

        public string[] Requirements => new[]
        {
            "Реализовать в статическом классе StringExtensions.",
            "Методы: IsPalindrome(), WordCount(), ReverseString().",
            "Методы должны быть public static с this string первым параметром.",
            "Продемонстрировать вызов на 2–3 строках."
        };

        public void Run()
        {
            Console.WriteLine("--- Демонстрация методов расширения ---\n");

            string text1 = "А роза упала на лапу Азора";
            Console.WriteLine($"Строка: \"{text1}\"");
            Console.WriteLine($"Это палиндром? -> {text1.IsPalindrome()}\n");

            string text2 = "Привет, мир!";
            Console.WriteLine($"Строка: \"{text2}\"");
            Console.WriteLine($"Перевернутая: \"{text2.ReverseString()}\"\n");

            string text3 = "Это тестовая строка для проверки подсчета слов.";
            Console.WriteLine($"Строка: \"{text3}\"");
            Console.WriteLine($"Количество слов: {text3.WordCount()}");
        }
    }
}
