using System;
using System.Collections.Generic;

namespace Strategy
{
    public static class DiskMS
    {
        public static void Start(IStrategy strategy, List<DiskProcess> procList)
        {
            strategy.Execute(procList);
        }
    }
}
