using System;

namespace Lab9
{
    public class DialClockArray
    {
        static Random rnd = new Random();
        DialClock[] dialClockArray;
        static int count = 0;
        public int Length
        {
            get => dialClockArray.Length;
        }
        public DialClockArray()
        {
            dialClockArray = new DialClock[0];
            count++;
        }
        public DialClockArray(int length)
        {
            dialClockArray = new DialClock[length];
            if (InputData.IsRandomInput())
            {
                for (int i = 0; i < length; i++)
                {
                    dialClockArray[i] = new DialClock(rnd.Next(11), rnd.Next(59));
                }
            }
            else
            {
                for (int i = 0; i < length; i++)
                {
                    Console.WriteLine($"{i+1}-й циферблат");
                    int hours = InputData.NumInput("Введите часы");
                    int minutes = InputData.NumInput("Введите минуты");
                    dialClockArray[i] = new DialClock(hours, minutes);
                }
            }
            count++;
        }
        public DialClockArray(DialClockArray other)
        {
            this.dialClockArray = new DialClock[other.Length];
            for (int i = 0; i < other.Length; i++)
            {
                this.dialClockArray[i] = new DialClock(other.dialClockArray[i]);
            }
            count++;
        }

        public DialClockArray(DialClock[] dialClockArray)
        {
            this.dialClockArray=new DialClock[dialClockArray.Length];
            for(int i = 0; i < dialClockArray.Length; i++)
                this.dialClockArray[i] = dialClockArray[i];
        }

        public static int GetCount => count;
        public void Show()
        {
            for (int i = 0; i < this.Length; i++)
            {
                Console.WriteLine($"{i+1}: {dialClockArray[i].ToString()}");
            }
        }
        public DialClock this[int index]
        {
            get
            {
                if (0 <= index && index < dialClockArray.Length)
                    return dialClockArray[index];
                else
                    throw new Exception($"Индекс {index} выходит за пределы массива");
            }
            set
            {
                if (0 <= index && index < dialClockArray.Length)
                    dialClockArray[index] = value;
                else
                    throw new Exception($"Индекс {index} выходит за пределы массива");
            }
        }
    }
}
