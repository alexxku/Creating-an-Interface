using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creating_an_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Machine1 M1 = new Machine1();
            Machine2 M2 = new Machine2();
            Machine3 M3 = new Machine3();

            M1.Start();
            M1.Stop();
            M2.Start();
            M2.Stop();
            M3.Start();
            M3.Stop();
        }
    }

    public class Machine1 : IControls
    {
        public void Start()
        {
            // Code Here...
        }
        public void Stop()
        {
            // Code Here...
        }
    }

    public class Machine2 : IControls
    {
        public void Start()
        {
            // Code Here ...
        }

        public void Stop()
        {
            // Code Here ...
        }
    }
    
    public class Machine3 : IControls
    {
        public void Start()
        {
            // Code Here ...
        }
        public void Stop()
        {
            // Code Here...
        }
    }

    interface IControls
    {
        void Start();
        void Stop();
    }
}
