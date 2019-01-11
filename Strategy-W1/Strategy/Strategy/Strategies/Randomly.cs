using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Strategy.Strategies
{
    class Randomly: IStrategy
    {
        public Randomly() { }
        public void Execute(List<DiskProcess> dp)
        {
            Print(dp);

            RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
            int n = dp.Count;
            while (n > 1)
            {
                byte[] box = new byte[1];
                do provider.GetBytes(box);
                while (!(box[0] < n * (Byte.MaxValue / n)));
                int k = (box[0] % n);
                n--;
                DiskProcess value = dp[k];
                dp[k] = dp[n];
                dp[n] = value;
            }

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
