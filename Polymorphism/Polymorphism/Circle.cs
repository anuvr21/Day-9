﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Circle : Shape
    {
        public override void DrawShape()
        {
            Console.WriteLine("Drawing Circle");
        }
    }
}
