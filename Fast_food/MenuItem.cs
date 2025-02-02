using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
internal class MenuItem
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

    public List<Product> ProductList { get; set; } = new List<Product>();
                     

    public MenuItem() { }

    public MenuItem(string name, double price)
    {
        Name = name;
        Price = price;
    }


    public void AddMenu(Product product)
    {
        ProductList.Add(product);
    }

    public double GetTotalPrice()
    {
        double totalprice = 0.0;
       foreach (var product in ProductList)
        {
            totalprice += product.Price;
        }
        return totalprice;
    }

    public string ToString()
    {
        return "Name:" + Name + "\nPrice:" + Price;
    }


}
