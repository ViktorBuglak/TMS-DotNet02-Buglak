using System;

namespace TeachMeSkills.Buglak.HomeWork2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Проверка первой датый
            Console.WriteLine("Введите первую дату");
            var dateStartAsString = Console.ReadLine();
            DateTime dateStart; // первая дата
            bool parsesuccessstart = DateTime.TryParse(dateStartAsString, out dateStart);
            if (!parsesuccessstart)
            {
                Console.WriteLine("Некорректной ввод даты");
                return;
            }

            // Проверка второй датый
            Console.WriteLine("Введите вторую дату");
            var dateFinishAsString = Console.ReadLine();
            DateTime dateFinish; // вторая дата
            bool parsesuccessfinish = DateTime.TryParse(dateFinishAsString, out dateFinish);
            if (!parsesuccessfinish)
            {
                Console.WriteLine("Некорректной ввод даты");
                return;
            }

            if (dateStart > dateFinish)
            {
                Console.WriteLine("Первая дата должна быть раньше чем вторая");
                return;
            }

            //Проверка дня недели
            Console.WriteLine("Введите день недели(на англ)");
            var dayAssString = Console.ReadLine();
            DayOfWeek day;
            bool isCorrectDay = DayOfWeek.TryParse(dayAssString, out day);
            if (!isCorrectDay)
            {
                Console.WriteLine("Некорректный ввод дня недели");
                return;
            }
            FindAndShowDays(ref dateStart, ref dateFinish, ref day);

        }

        public static void FindAndShowDays(ref DateTime dateStart, ref DateTime dateFinish, ref DayOfWeek day)
        {
            while (dateStart <= dateFinish)
            {
                if (dateStart.DayOfWeek == day)
                {
                    Console.WriteLine($"{dateStart} - {dateStart.DayOfWeek}");
                }
                dateStart = dateStart.AddDays(1);
            }

        }

    }
}