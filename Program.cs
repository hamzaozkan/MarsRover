using System;
using System.Collections.Generic;
using System.Linq;

namespace MarsRoverProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            Startup startup = new Startup(new Service());
            startup.Start();
        }
    }
}
