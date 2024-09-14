using System;

class MainClass
{
    static void Main(string[] args)
    {
        Console.WriteLine("Напишите что-то");
        var str = Console.ReadLine();

        Console.WriteLine("Укажите глубину эха");
        var deep = int.Parse(Console.ReadLine());

        Echo(str, deep);

        Console.ReadKey();
    }

    static void Echo(string phrase, int deep)
    {
        
        if (phrase.Length > 2)
        {
            phrase = phrase.Remove(0, 2);
        }

        Console.WriteLine("..." + phrase);

        if (deep > 1)
        {
            Echo(phrase, deep - 1);
        }
    }
}