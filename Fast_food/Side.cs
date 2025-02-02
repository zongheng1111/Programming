using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
internal class Side : Product
{
    public Side() { }

    public Side(string name, double price)
    {
        Name = name;
        Price = price;
    }


    public override double GetPrice()
    {
        return Price;
    }

    public string ToString()
    {
        return "Name: " + Name + "Price: " + Price;
    }
}