using System;

namespace Lab9
{

    internal class Program
    {
        static double MaxAngle(DialClockArray clocks, out DialClock maxDialClock)
        {
            if (clocks.Length == 0)
                throw new Exception("В массиве нет эл-в");

            double maxAngle = DialClock.GetAngle(clocks[0]);
            maxDialClock = clocks[0];
            for (int i = 1; i<clocks.Length; i++)
            {
                double angle = DialClock.GetAngle(clocks[i]);
                if (angle > maxAngle)
                {
                    maxAngle = angle;
                    maxDialClock = clocks[i];
                }
            }
            return maxAngle;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("ЦИФЕРБЛАТ ЧАСОВ");
            // 1 задание
            Console.WriteLine("Задание 1");
            Console.WriteLine($"(12, -60) = {new DialClock(12, -60)}");
            Console.WriteLine($"(-3, 0) = {new DialClock(-3, 0)}");
            Console.WriteLine($"(0, -5) = {new DialClock(0, -5)}");
            Console.WriteLine($"(0, 123) = {new DialClock(0, 123)}");
            Console.WriteLine($"(123, 0) = {new DialClock(123, 0)}");
            Console.WriteLine($"(100, 10000) = {new DialClock(100, 10000)}");
            Console.WriteLine("\nУглы между стрелками:");
            Console.WriteLine($"(6, 0) = {DialClock.GetAngle(new DialClock(6, 0))}"); //статический метод
            Console.WriteLine($"(3, 0) = {DialClock.GetAngle(new DialClock(3, 0))}");
            Console.WriteLine($"(9, 55) = {new DialClock(9, 55).GetAngle()}"); //нестатический метод
            Console.WriteLine($"(9, 56) = {new DialClock(9, 56).GetAngle()}");
            int count1stTask = DialClock.GetCount;
            Console.WriteLine($"Cформировано объектов = { count1stTask}");
            Console.WriteLine("-----------------------------------------------------------------------------------");

            // 2 задание
            Console.WriteLine("\nЗадание 2");
            DialClock c1 = new DialClock(-3, 0);
            Console.WriteLine($"c1(-3, 0) = {c1.ToString()}");
            c1 = c1 - 60;
            Console.WriteLine($"c1 = c1 - 60 = {c1.ToString()}");
            Console.WriteLine($"c1 = 60 - c1 = {(60 - c1).ToString()}");

            DialClock c2 = new DialClock(5, 59);
            c2++;
            Console.WriteLine($"c2(5, 59)++ = {c2.ToString()}");
            DialClock c3 = new DialClock(6, 0);
            c3--;
            Console.WriteLine($"c3(6, 00)-- = {c3.ToString()}");
            
            Console.WriteLine($"\nbool - делимость угла между стрелками на 2,5:");
            Console.WriteLine($"bool(true) - 9:55 = {(bool)new DialClock(9, 55)}");
            Console.WriteLine($"bool(false) - 9:56 = {(bool)new DialClock(9, 56)}");
            int c4 = new DialClock(6, 30);
            Console.WriteLine($"\nint - количество пройденных часовых делений минутной стрелкой из положения 00:00");
            Console.WriteLine($"int(6:30) = {c4}");
            int count2ndTask = DialClock.GetCount - count1stTask;
            Console.WriteLine($"Cформировано объектов = {count2ndTask}");
            Console.WriteLine("-----------------------------------------------------------------------------------");

            // 3 задание
            try
            {
                Console.WriteLine("\nЗадание 3");
                DialClockArray clocks = new DialClockArray(InputData.NumInput("Сколько часов (шт.) в массиве?"));
                DialClockArray clocks2 = new DialClockArray(clocks);
                clocks2[0] = new DialClock(11, 59);
                Console.WriteLine("1 массив");
                clocks.Show();
                Console.WriteLine("\n2 массив (копия с измененным 1-м эл-м) - подтверждение глубокого копирования");
                clocks2.Show();
                //максимальный угол
                DialClock maxDC;
                double maxAngle = MaxAngle(clocks, out maxDC);
                Console.WriteLine($"\nМаксимальный угол первого массива = {maxAngle}. ({maxDC})");

                Console.WriteLine("\nОбращение к сотому эл-ту:");
                clocks2[100] = new DialClock();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine($"\nCформировано объектов = {DialClock.GetCount - count2ndTask - count1stTask}");
            Console.WriteLine($"Количество массивов = {DialClockArray.GetCount}");
        }
    }
}