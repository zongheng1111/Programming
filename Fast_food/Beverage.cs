using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
internal class Beverage : Product
{
    private double tradeIn;

    public double TradeIn
    {
        get { return tradeIn; }
        set { tradeIn = value; }
    }


    public Beverage() { }

    public Beverage(string name, double price, double tradeIn)
    {
        Name = name;
        Price = price;
        TradeIn = tradeIn;
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