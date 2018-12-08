using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads
{
    class Worker
    {
        public bool isActive = false;
        public Worker(bool _isActive) {
            isActive = _isActive;
        }
        public void doWork() {
            for (int i = 0; i < 10; i++)
            {
                if (isActive)
                {
                    Thread.Sleep(1);
                    Console.WriteLine("Hello ");
                    Thread.Sleep(1);
                    Console.WriteLine("World");
                    Thread.Sleep(1);
                    Console.WriteLine("!");
                }
                else {
                    Thread.CurrentThread.Interrupt();
                }
            }
        }

        public void doParamWork(Object args)
        {
            //int number = (int)args;
            //ArrayList list = (ArrayList)args;
            Dictionary<String, Object> dictionary = (Dictionary<String, Object>)args;
            for (int i = 0; i < (int)dictionary["number"]; i++)
            {
                if (isActive)
                {
                    Thread.Sleep(1);
                    Console.WriteLine(dictionary["word1"]);
                    Thread.Sleep(1);
                    Console.WriteLine(dictionary["word2"]);
                    Thread.Sleep(1);
                    Console.WriteLine(dictionary["word3"]);
                }
                else
                {
                    Thread.CurrentThread.Interrupt();
                }
            }
        }
    }
}
