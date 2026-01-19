// See https://aka.ms/new-console-template for more information
using System.Data;
using System.Diagnostics;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;
using System.Text;

Console.WriteLine("Привет");

while (true) {
    Console.WriteLine("Что ты хочешь узнать 1 - Фио,2 - Группу,3 - Дату ,4 - выход");
    string? a = Console.ReadLine();
    if (a == "1")
    {
        Console.WriteLine("Тимонин Иван,Козырев Артемий");
    } else if (a == "2")
    {
        Console.WriteLine("ИСП-233");
    } else if(a == "3")
    {
        Console.WriteLine(DateTime.Now);
    }
    else
    {
        break;
    }
    
}