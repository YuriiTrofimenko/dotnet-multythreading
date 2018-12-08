using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sync1
{
    class Program
    {
        static void Main(string[] args)
        {
            Data data = new Data();
            Worker worker = new Worker();
            Flags flags = new Flags();

            worker.data = data;

            new Thread(worker.doWork).Start(new object[] { "1", flags });
            new Thread(worker.doWork).Start(new object[] { "2", flags });

            while (flags.firstDone != true || flags.secondDone != true)
            {
                Thread.Sleep(10);
            }

            Console.WriteLine(data.count);
        }
    }
}
