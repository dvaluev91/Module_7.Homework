﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_7.Models
{
    internal class Order <TDelivery, TStruct> where TDelivery : Delivery
    {
        public TDelivery Delivery;
        public int Number;
        public string Description;
        public void DisplayAddress()
        {
            Console.WriteLine(Delivery.Address);
        }
    }
}
