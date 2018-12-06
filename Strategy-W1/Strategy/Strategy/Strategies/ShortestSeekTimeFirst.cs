using System;
using System.Collections.Generic;
using System.Linq;

namespace Strategy
{
    public class ShortestSeekTimeFirst: IStrategy
    {
        public ShortestSeekTimeFirst()
        {

        }

        public void Execute(List<DiskProcess> dp)
        {
            Print(dp);
            
            dp = dp.OrderBy(x => x.Time)
           .ToList();

            Print(dp);

            foreach (DiskProcess p in dp)
            {
                if (p.Time != 0)
                {
                    p.Run();

                }
                else
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
