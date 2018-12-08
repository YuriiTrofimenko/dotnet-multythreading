using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sync1
{
    class Worker
    {
        //Wait
        //Pulse
        public Data data;
        public void doWork(Object args) {
           
            string name = (string)((object[])args)[0];

            for (int i = 0; i < 10; i++)
            {
                Monitor.Enter(data);

                Thread.Sleep(10);
                int count = data.count;
                Thread.Sleep(10);
                count++;
                Thread.Sleep(10);
                data.count = count;

                Monitor.Exit(data);
            }
            if (name == "1")
            {
                ((Flags)((object[])args)[1]).firstDone = true;
            }
            else {
                ((Flags)((object[])args)[1]).secondDone = true;
            }
        }
    }
}
