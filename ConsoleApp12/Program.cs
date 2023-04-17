using ConsoleApp12.Models;
using LanguageExt.TypeClasses;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Выбирите действие: \r\n1. Управление пассажирами\r\n2. Управление точками назначения\r\n3. Продажа билетов");
        int opper = int.Parse(Console.ReadLine());
        if (opper == 1)
        {
            Console.WriteLine("1. Добавить пользователя\r\n2. Изменить пользователя");
            int cel = int.Parse(Console.ReadLine());
            if (cel == 1)
            {
                    Console.WriteLine("Ввелите Имя, Фамилию, Номер телефона и Дату.(соблюдая именно такой порядок)");
                ApplicationContext ef = new ApplicationContext();
                Passanger pas = new Passanger() { Name = Console.ReadLine(), SurName = Console.ReadLine(), Phone = Console.ReadLine(), Date_reg = Console.ReadLine() };
                ef.Add(pas);
                ef.SaveChanges();
            }
            else
            {

            }
        }
        else if (opper == 2)
        {
            Console.WriteLine("1. Добавить пункт назначения\r\n2. Изменить пункт назначения");
            int punkt = int.Parse(Console.ReadLine());
            if (punkt == 1)
            {
                    Console.WriteLine("Введите город который хотите добавить");
                ApplicationContext ef = new ApplicationContext();
                Point point = new Point() { Num = Console.ReadLine() };
                ef.Add(point);
                ef.SaveChanges();
                
            }
            else
            {

            }
        }
        else if (opper == 3)
        {
            Console.WriteLine("1. Купить билет\r\n2. Изменить билет");
            int bil = int.Parse(Console.ReadLine());
            if (bil == 1)
            {
                Console.WriteLine("Введите номер пассажира, точку отправки, точку прибытия, дату отправки и её стоимость(именно в такойм порядке) ");
                ApplicationContext ef = new ApplicationContext();
                Ticket tick = new Ticket() {Passanger =  Console.ReadLine(), start_point = Console.ReadLine(),end_point =  Console.ReadLine(),departure_details = Console.ReadLine(),cost =  Console.ReadLine() };
                ef.Add(tick);
                ef.SaveChanges();
                
            }
            else
            {

            }
        }
        else
        {
            Console.WriteLine("Возможно вы неверно выбрали действие, выбырайте действие цифрами");
        }
    }
}