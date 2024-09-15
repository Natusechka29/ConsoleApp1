using System;

class MainClass
{
    static void Main(string[] args)
    {
        bool isValid;
        (string firstName, string lastName, int age, string[] pets, string[] colors) personalData;
        do
        {
            personalData = GetData();
            isValid = IsValid(personalData.age, personalData.pets.Length, personalData.colors.Length);
            if (isValid == false)
            {
                Console.WriteLine("Данные неверны, повторите ввод!");
            }
        } while (isValid == false);

        ShowData(personalData);
    }

    static (string firstName, string lastName, int age, string[] pets, string[] colors) GetData()
    {
        Console.Write("Введите имя: ");
        string firstName = Console.ReadLine();
        Console.Write("Ведите фамилию: ");
        string lastName = Console.ReadLine();
        Console.Write("Сколько вам лет? ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Есть ли у вас питомец? ");
        string hasAnimal = Console.ReadLine();
        string[] pets;
        string[] colors;
        if (hasAnimal == "да")
        {
            Console.Write("Сколько у вас питомцев? ");
            byte animalCount = byte.Parse(Console.ReadLine());
            pets = GetPetNames(animalCount);
        }
        else 
        { 
            pets = [];
        }

        Console.Write("Сколько у вас любимых цветов? ");
        int colorCount = int.Parse(Console.ReadLine());
        colors = GetColors(colorCount);

        return (firstName, lastName, age, pets,colors);
    }

    static string[] GetPetNames(byte animalCount)
    {
        string[] petNames = new string[animalCount];

        for (int i = 0; i < petNames.Length; i++)
        {
            Console.Write("Введите имя питомца номер " + (i+1) + ": ");
            petNames[i] = Console.ReadLine();
        } 

        return petNames;
    }

    static string[] GetColors(int colorCount)
    {
        string[] colors = new string[colorCount];

        for (int i = 0; i < colors.Length; i++)
        {
            Console.Write("Введите название цвета номер " + (i + 1) + ": ");
            colors[i] = Console.ReadLine();
        }

        return colors;
    }

    static void ShowData((string firstName, string lastName, int age, string[] pets, string[] colors) personalData)
    {
        Console.WriteLine(personalData.firstName);
        Console.WriteLine(personalData.lastName);
        Console.WriteLine(personalData.age);

        foreach (var pet in personalData.pets) { Console.WriteLine(pet); }
        foreach (var color in personalData.colors) { Console.WriteLine(color); }

    }

    static bool IsValid(int age, int petCount, int colorCount)
    {
        bool isValid = true;

        if (age == 0 || petCount == 0 || colorCount == 0)
        {
            isValid = false;
        }

        return isValid;
    }
}