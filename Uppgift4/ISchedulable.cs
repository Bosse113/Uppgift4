using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift4
{
    internal interface ISchedulable
    {
        DateTime NextRun { get; set; }
        void Schedule(DateTime time);
    }
}
