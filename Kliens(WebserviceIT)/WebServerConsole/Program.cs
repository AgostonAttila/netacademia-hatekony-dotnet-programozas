﻿using ArfolyamSzolgaltatas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WebServerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(Service1));
            host.Open();

            Console.WriteLine("elindult");
            Console.ReadLine();
        }
    }
}
