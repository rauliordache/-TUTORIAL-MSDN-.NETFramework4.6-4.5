using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceProcess;

namespace Control_Another_Service
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceController sc = new ServiceController("WindowsServiceEmail");
            sc.Stop();
            Console.Read();
        }
    }
}
