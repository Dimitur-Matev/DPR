using System;
using System.Collections.Generic;

namespace Strategy
{
    public interface IStrategy
    {
        void Execute(List<DiskProcess> dp);
        void Print(List<DiskProcess> dp);
    }
}
