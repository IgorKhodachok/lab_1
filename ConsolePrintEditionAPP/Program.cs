using System;
using Lab1;

namespace ConsolePrintEditionAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            PrintedEdition printedEdition = new PrintedEdition("Наукове", "966-528-197-6", "пр-т Степана Бандери, 34а, м. Тернопіль", "Богдан", "Будний", "-", "с. Горішня Слобідка, Монастириський район, Тернопільська область", 200, 1/2, "bohdan-books.com/");
            printedEdition.Print();
            Console.WriteLine("================================================");
            Newspaper newspaper = new Newspaper("громадсько-політичне видання", "978-5-91147-039-5", "м.Тернопіль, вул. Крушельницької 1а", "Микола", "Мартинчук", "-", "село Досова, Хмельницька обл.", 1500, 1/30, "nova.te.ua/", "Нова", 15420, "8.05.2022");
            newspaper.Print();
            Console.WriteLine("================================================");
            Journal journal = new Journal("Видання для організації дозвілля", "2708-3268-02", "Адреса вилавництва", "Ім'я редактора", "Прізвище", "По батькові", "Адреса редактора", 6200, 1/2, "forbes.ua/", "forbes", 25000, "Країна Героїв");
            journal.Print();
            Console.WriteLine("================================================");
            Bulletin bulletin = new Bulletin("Наукове", "978-617-7538-64-5", "м. Київ, Україна, вул. Льва Толстого, 14А", "-", "-", "-", "-", 60000, 1/365, "-", "452168", "10.11.2017");
            bulletin.Print();
        }
    }
}