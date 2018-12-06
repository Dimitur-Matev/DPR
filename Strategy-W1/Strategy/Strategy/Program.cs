using System;
using System.Collections.Generic;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DiskProcess> dp = GenerateData();

            bool exit = false;

            while(!exit){
                Console.WriteLine("Menu: \n" +
                              "0 Exit \n" +
                              "1 First come first serve \n" +
                              "2 Shortest seek time first \n" +
                              "3 Add Process ");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "0":
                        exit = true;
                        break;
                    case "1":
                        DiskMS.Start(new FirstComeFirstServe(), dp);
                        break;
                    case "2":
                        DiskMS.Start(new ShortestSeekTimeFirst(), dp);
                        break;
                    case "3":
                        Console.WriteLine("Enter time for the process:");
                        string input1 = Console.ReadLine();
                        dp.Add(new DiskProcess(Int32.Parse(input1), dp.Count));

                        foreach(DiskProcess element in dp)
                        {
                            element.Info();
                        }
                        break;
                    default:
                        Console.WriteLine("Default case");
                        break;

                }
            }

            List<DiskProcess> GenerateData()
            {
                Random rnd = new Random();

                List<DiskProcess> genData = new List<DiskProcess>();
                for (int i = 0; i <= 8; i++)
                {
                    genData.Add(new DiskProcess(rnd.Next(0, 20), i));
                }

                return genData;
            }

        }
    }
}
