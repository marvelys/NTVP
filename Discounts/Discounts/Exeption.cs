﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discounts
{
   public class Exeption : Exception
    {
        public Exeption(string message)
            : base(message)
        {
        }
    }
}
