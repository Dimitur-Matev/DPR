using System;
using System.Collections.Generic;

namespace Strategy
{
    public class FirstComeFirstServe: IStrategy
    {
        public FirstComeFirstServe()
        {
        }

        public void Execute(List<DiskProcess> dp)
        {
            Print(dp);

            foreach(DiskProcess p in dp)
            {
                if (p.Time != 0)
                {
                    p.Run();

                }else
                {
                    p.Info();
                }
            }
        }

        public void Print(List<DiskProcess> dp)
        {
            foreach (DiskProcess p in dp)
            {
                p.Info();
            }
            Console.WriteLine("-----------------------------");
        }
    }
}
