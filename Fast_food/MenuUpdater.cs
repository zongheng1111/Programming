using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class MenuUpdater
{
    private List<MenuItem> sides = new List<MenuItem>();
    private List<MenuItem> beverages = new List<MenuItem>();

    public void AddMenuItem(string category, MenuItem item)
    {
        string categoryLower = category.ToLower();

        if (categoryLower == "sides")
        {
            sides.Add(item);
        }
        else if (categoryLower == "beverages")
        {
            beverages.Add(item);
        }
        else
        {
            Console.WriteLine("Invalid category.");
        }
    }

    public void RemoveMenuItem(string category, string itemName)
    {
        string categoryLower = category.ToLower();
        bool itemRemoved = false;

        if (categoryLower == "sides")
        {
            int removedCount = sides.RemoveAll(item => item.Name.Equals(itemName));
            itemRemoved = removedCount > 0;
        }
        else if (categoryLower == "beverages")
        {
            int removedCount = beverages.RemoveAll(item => item.Name.Equals(itemName));
            itemRemoved = removedCount > 0;
        }
        else
        {
            Console.WriteLine("Invalid category.");
            return;
        }

        if (itemRemoved)
        {
            Console.WriteLine("Item removed successfully.");
        }
        else
        {
            Console.WriteLine("Item not found in the specified category.");
        }
    }
    public void DisplayMenuItems()
    {
        Console.WriteLine("Sides:");
        foreach (var item in sides)
        {
            Console.WriteLine(item.ToString());
        }

        Console.WriteLine("Beverages:");
        foreach (var item in beverages)
        {
            Console.WriteLine(item.ToString());
        }
    }

}
