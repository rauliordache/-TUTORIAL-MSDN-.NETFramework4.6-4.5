using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Windows_Service_Application
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            ServiceBase ServicesToRun;
            ServicesToRun = new Service1();
         /*   {
                new Service1()
            };*/
            ServiceBase.Run(ServicesToRun);
        }
    }
}
