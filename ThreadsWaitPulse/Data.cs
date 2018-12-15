using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadsWaitPulse
{
    public class Data
    {
        //1 / 2
        private int state = 1;

        public void Tik() {
            Console.Write("Tik-");
            state = 2;
        }

        public void Tac()
        {
            Console.WriteLine("Tac");
            state = 1;
        }

        public int GetState() {
            return state;
        }
    }
}
