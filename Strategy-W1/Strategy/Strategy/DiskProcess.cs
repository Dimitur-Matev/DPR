using System;
using System.Threading;

namespace Strategy
{
    public class DiskProcess
    {
        private int Id;
        public int Time { get; set; }

        public DiskProcess(int time = 2, int id = 0)
        {
            Id = id;
            Time = time;
        }
        public void Run()
        {
            Console.Write(Id + ": "+Time + " <---->");
            for (int i = Time; i > 0; i--)
            {
                Time--;
                Thread.Sleep(500);
                Console.Write(Time + ",");
            }
            Console.WriteLine();
        }

        public void Info()
        {
            Console.WriteLine(Id + ": " + Time);
        }
    }
}
