using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
internal class OrderItem
{
    private int quantity;

    public int Quantity
    {
        get { return quantity; }
        set { quantity = value; }
    }


    public MenuItem Item { get; set; }

    public OrderItem() { }

    public OrderItem(MenuItem item)
    {
        Item = item;
        Quantity = 1;
    }

    public void AddQty()
    {
        Quantity++;
    }

    public bool RemoveQty()
    {
        if (quantity > 0)
        {
            quantity -= 1;
            return true;
        }
        return false;
            

        
    }
 

    public double GetItemTotalAmt()
    {
        return Quantity * (Item?.Price ?? 0);
    }
    public string ToString()
    {
        return "Quantity:" + Quantity + "Items:" + Item;
    }



}
