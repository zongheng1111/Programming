using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
internal class ValueMeal : Product
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
    public int StartHour
    {
        get { return startTime.Hour; }
        
    }

    public int EndHour
    {
        get { return endTime.Hour; }
        
    }
    public ValueMeal() { }

    public ValueMeal(string name, double price, int starthour, int endhour)
    {
        Name = name;
        Price = price;
        startTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, starthour, 0, 0);
        endTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, endhour, 0, 0);
    }


    public override double GetPrice()
    {
        return Price;
    }

    public bool IsAvailable()
    {
        DateTime CurrentTime = DateTime.Now;
        
        if (CurrentTime.Hour >= startTime.Hour && CurrentTime.Hour <= endTime.Hour)
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
        return "Name:" + Name + "Price:" + Price;
    }

}