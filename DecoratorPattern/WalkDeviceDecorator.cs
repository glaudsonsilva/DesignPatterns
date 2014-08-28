﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    abstract class WalkDeviceDecorator : Human
    {
        public override abstract string Walk();

    }
}