using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
internal class BundleMeal : Product
{
    private DateTime startTime;

    public DateTime StartTime
    {
        get { return startTime; }
        set { startTime = value; }
    }

    private DateTime endTime;

    public DateTime EndTime
    {
        get { return endTime; }
        set { endTime = value; }
    }

    public BundleMeal() { }

    public BundleMeal(string name, double price, DateTime startTime, DateTime endTime)
    {
        Name = name;
        Price = price;
        StartTime = startTime;
        EndTime = endTime;
    }


    public override double GetPrice()
    {
        return Price;
    }

    public bool IsAvailable()
    { 
        DateTime CurrentTime = DateTime.Now;
        
        if (CurrentTime >= startTime && CurrentTime <= endTime)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public string ToString()
    {
        return "Name:" + Name + "Price:" + Price + "StartTime:" + StartTime + "EndTime:" + EndTime;
    }

}

