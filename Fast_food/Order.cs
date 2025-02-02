using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
internal class Order
{
    private static int lastOrderNo = 0;
    public int OrderNo { get; private set; }
    private List<OrderItem> itemList;


    public Order()
    {
        OrderNo = ++lastOrderNo;
        itemList = new List<OrderItem>();
    }


    public Order(int orderNo)
    {
        OrderNo = ++lastOrderNo;
        itemList = new List<OrderItem>();
    }


    public void Add(OrderItem item)
    {
        if (item.Quantity == 1)
        {
            itemList.Add(item);
        }
        else if (item.Quantity > 1)
        {
            item.AddQty();
        }

    }

  
    public bool Remove(int index)
    {

        if (index >= 0 && index < itemList.Count)
        {
            itemList.RemoveAt(index);
            return true;

        }
        return false;
    }

    public void ClearAll()
    {
        itemList.Clear();
    }

 
    public double GetTotalAmt()
    {
        return itemList.Sum(item => item.GetItemTotalAmt());
    }
    public void Please()
    {
        OrderNo += 1;
    }

    
    public override string ToString()
    {
        var groupedItems = itemList
            .GroupBy(item => item.Item) 
            .Select(group => new
            {
                Item = group.Key,
                TotalQuantity = group.Sum(item => item.Quantity)
            });  
        var orderItemsDescription = groupedItems.Any()
            ? string.Join(", ", groupedItems.Select(group => $"{group.Item.Name} (x{group.TotalQuantity})"))
            : "No items";

        return $"Order No: {OrderNo}\nItems: [{orderItemsDescription}]\nTotal Amount: ${GetTotalAmt():F2}";
    }
}