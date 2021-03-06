﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternDotNet
{
    class WindowsMonitor:IObserver<int>
    {
        public void OnCompleted()
        {
            Console.WriteLine("Server is down. Messages wont come.");
        }

        public void OnError(Exception error)
        {
            Console.WriteLine(error.Message);
        }

        public void OnNext(int value)
        {
            Console.WriteLine("Windows APP ::: Current CPU temperature: {0}", value);
        }
    }
}
