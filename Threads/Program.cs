using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1 */

            /*new Thread(() => {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Hello ");
                }
            }).Start();

            new Thread(() => {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("World");
                }
            }).Start();

            Console.WriteLine("Start");*/

            /* 2 */

            /*Thread t1 = new Thread(() => {
                for (int i = 0; i > -1; i++)
                {
                    Console.WriteLine("Hello ");
                }
            });

            Thread t2 = new Thread(() => {
                for (int i = 0; i > -1; i++)
                {
                    Console.WriteLine("World");
                }
            });

            t1.IsBackground = true;
            t2.IsBackground = true;

            t1.Start();
            t2.Start();

            Console.WriteLine("Start--------------------------------");

            t1.Join(50);
            //t2.Join(500);
            
            //Thread.Sleep(1000);*/

            /* 3 */
            /*Thread t1 = new Thread(new Worker().doWork);
            t1.Start();
            Thread.Sleep(10);
            t1.Interrupt();
            Console.WriteLine("The End");*/

            /* 4 */
            /*Worker w1 = new Worker(true);
            Thread t1 = new Thread(w1.doWork);
            t1.Start();
            Thread.Sleep(10);
            w1.isActive = false;
            Console.WriteLine("The End");*/

            /* 5 */
            Worker w1 = new Worker(true);
            Thread t1 = new Thread(w1.doParamWork);
            int number = 3;
            string word1 = "Привет, ";
            string word2 = "Мир";
            string word3 = "!";
            ArrayList list =
                new ArrayList() { number, word1, word2, word3};
            t1.Start(list);
            //Thread.Sleep(10);
            //w1.isActive = false;
            Console.WriteLine("The End");
        }
    }
}
