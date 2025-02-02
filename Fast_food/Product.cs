using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public abstract class Product
{
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    private double price;

    public double Price
    {
        get { return price; }
        set { price = value; }
    }

    //private double balance;

    public Product() { }

    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public virtual double GetPrice()
    {
        return Price;
    }


    public override string ToString()
    {
        return "Name: " + Name + "\n" + "Price: " + Price;
    }
}
