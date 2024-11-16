using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Item
    {
        public string name { get; set; }
        public int value { get; set; }

        public Item(string aName, int aValue)
        {
            name = aName;
            value = aValue;
        }

        public override string ToString()
        {
            return $"Name: {name}, Value: {value}";
        }


    }
}
