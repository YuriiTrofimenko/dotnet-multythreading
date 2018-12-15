using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadsWaitPulse
{
    class Program
    {
        static void Main(string[] args)
        {
            Data data = new Data();
            Worker w1 = new Worker(data, 1);
            Worker w2 = new Worker(data, 2);

            new Thread(w1.DoWork).Start();
            new Thread(w2.DoWork).Start();
        }
    }
}
