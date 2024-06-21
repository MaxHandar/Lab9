using System;

namespace Lab9
{
    internal static class InputData
    {
        public static int NumInput(string msg = "", bool notNegative = true)
        {
            bool isConvert;
            int N;
            do
            {
                Console.WriteLine(msg);
                string buf = Console.ReadLine();
                isConvert = int.TryParse(buf, out N);

                if (!isConvert)
                {
                    string msgNotConvert = "Неправильно введено число, попробуй еще раз";
                    Console.WriteLine(msgNotConvert);
                }
            } while (!isConvert);
            return N;
        }
        public static bool IsRandomInput()
        {
            do
            {
                Console.WriteLine("Вводить элементы рандомно?");
                Console.WriteLine("1. Да");
                Console.WriteLine("2. Нет");
                int answer = NumInput();

                switch (answer)
                {
                    case 1:
                        {
                            return true;
                        }
                    case 2:
                        {
                            return false;
                        }
                    default:
                        {
                            Console.WriteLine("Неправильно задан пункт меню");
                            break;
                        }
                }
            } while (true);  
        }
    }
}
