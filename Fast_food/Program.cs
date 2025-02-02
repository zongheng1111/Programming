


using System.Reflection.Metadata;

MenuItem bset = new MenuItem("Breakfast Set \nIncludes : Hotcake with Sausage, Hash Brown", 7.90);
MenuItem hcombo = new MenuItem("Hamburger combo \nIncludes : Hamburger, Fries, Cola" , 10.20);
MenuItem hcombo2 = new MenuItem("Hamburger combo\nIncludes : Hamburger, Fries, Tea", 10.20);
MenuItem hcombo3 = new MenuItem("Hamburger combo\nIncludes : Hamburger, Fries, Coffee", 10.20);
MenuItem hcombo4 = new MenuItem("Hamburger combo\nIncludes : Hamburger, Fries, Green Tea", 11.05);
MenuItem hcombo5 = new MenuItem("Hamburger combo\nIncludes : Hamburger, Fries, Tom's Root Beer", 17.05);
MenuItem hcombo6 = new MenuItem("Hamburger combo\nIncludes : Hamburger, Fries, Mocktail", 23.25);

//Value Meals
Product product3 = new ValueMeal("Hotcake with sausage", 6.90, 7, 14);
Product product4 = new ValueMeal("Hamburger", 7.50,0,23);
Product product5 = new ValueMeal("Nasi Lemak", 5.40,0,23);
Product product6 = new ValueMeal("Ribeye steak", 10.20,0,23);

MenuItem hws = new MenuItem("Hotcake with sausage", 6.90);
MenuItem hb = new MenuItem("Hamburger", 7.50);
MenuItem nl = new MenuItem("Nasi Lemak", 5.40);
MenuItem rs = new MenuItem("Ribeye Steak", 10.20);
//Sides
Product product7 = new Side("Hash brown", 2.10);
Product product8 = new Side("Truffle fries", 3.70);
Product product9 = new Side("Calamari", 3.40);
Product product10 = new Side("Caesar salad", 4.30);

MenuItem hashbrown = new MenuItem("Hash brown", 2.10);
MenuItem tf = new MenuItem("Truffle fries", 3.70);
MenuItem cala = new MenuItem("Calamari", 3.40);
MenuItem cs = new MenuItem("Caesar salad", 4.30);


//Beverages
Product product11 = new Beverage("Cola", 2.85,0);
Product product12 = new Beverage("Green Tea", 3.70,0.85);
Product product13 = new Beverage("Coffee", 2.70,0);
Product product14 = new Beverage("Tea", 2.70,0);
Product product15 = new Beverage("Tom’s Root Beer", 9.70,6.85);
Product product16 = new Beverage("Mocktail", 15.90,13.05);

MenuItem cola  = new MenuItem("Cola", 2.85);
MenuItem gt = new MenuItem("Green Tea", 3.70);
MenuItem cof = new MenuItem("Coffee", 2.70);
MenuItem tea = new MenuItem("Tea", 2.70);
MenuItem trb = new MenuItem("Tom’s Root Beer", 9.70);
MenuItem mt = new MenuItem("Mocktail", 15.90);

//Adding components to the Bundle Meals
bset.AddMenu(product3);
bset.AddMenu(product7);

hcombo.AddMenu(product4);
hcombo.AddMenu(product8);
hcombo.AddMenu(product11);

hcombo2.AddMenu(product4);
hcombo2.AddMenu(product8);
hcombo2.AddMenu(product12);

hcombo3.AddMenu(product4);
hcombo3.AddMenu(product8);
hcombo3.AddMenu(product13);

hcombo4.AddMenu(product4);
hcombo4.AddMenu(product8);
hcombo4.AddMenu(product14);

hcombo5.AddMenu(product4);
hcombo5.AddMenu(product8);
hcombo5.AddMenu(product15);

hcombo6.AddMenu(product4);
hcombo6.AddMenu(product8);
hcombo6.AddMenu(product16);

hws.AddMenu(product3);
hb.AddMenu(product4);
nl.AddMenu(product5);
rs.AddMenu(product6);
hashbrown.AddMenu(product7);
tf.AddMenu(product8);
cala.AddMenu(product9);
cs.AddMenu(product10);
cola.AddMenu(product11);
gt.AddMenu(product12);
cof.AddMenu(product13);
tea.AddMenu(product14);
trb.AddMenu(product15);
mt.AddMenu(product16);

//Getting current Date & Time for the Receipt
DateTime now = DateTime.Now;
int day = now.Day;
int month = now.Month;
int year = now.Year;
int hour = now.Hour;
int minute = now.Minute;
int second = now.Second;

string ThamTime = "Current Time : " + hour + "/" + minute + "/" + second;
string ThamDate = "Current Date : " + day + "/" + month + "/" + year;


void DisplayMenu()
{
    Console.WriteLine("Welcome to Tom Cafe!\nCategories\n[1] Bundle Meals \n[2] Value Meals \n[3] Sides \n" +
        "[4] Beverages \n[5] Shopping Cart\n[6] (Admin for 3.2) Adding to Menu\n[7] (Admin for 3.2) Removing from Menu\n[8] (Admin for 3.2) Displaying Menu\n[0] Exit");
    
}
void CartMenu()
{
    Console.WriteLine("Shopping Cart!\n[1] Cancel\n[2]Remove Item\n[3] Confirm Order");
    
}
void UpdateMenu()
{
    Console.WriteLine("Would you like to create/delete a menu item? : ");
    MenuItem skibidi = new MenuItem("WHAT", 33);
}

//For Option 1
void BundleMeals(Order receipt)
{
    int hour = now.Hour;
    int minute = now.Minute;
    OrderItem selecteditem = null;
    
    // Check if the current time is between 7:00 AM and 2:00 PM
    if ((hour > 7 || (hour == 7 && minute >= 0)) && (hour < 14) || (hour == 14 && minute == 0))
    {
        Console.WriteLine("1. " + bset.ToString());
    }
    else
    {
        Console.WriteLine("1. Option not avaliable!");
    }

    // Check if the current time is between 10:00 AM and 7:00 PM
    if ((hour > 10 || (hour == 10 && minute >= 0)) && (hour < 19) || (hour == 19 && minute == 0))
    {
        Console.WriteLine("2. " + hcombo.ToString());
    }
    else
    {
        Console.WriteLine("2. Option not avaliable!");
    }
    Console.WriteLine("0. Back to Menu");
    Console.WriteLine("Select your option : ");
    string bundle = Console.ReadLine();

    int bundleoption = int.Parse(bundle);
    if (bundleoption == 1)
    {
        if ((hour > 7 || (hour == 7 && minute >= 0)) && (hour < 14) || (hour == 14 && minute == 0))
        {
            selecteditem = new OrderItem(bset);
            receipt.Add(selecteditem);
            Console.WriteLine("Tom has added your order in the Shopping Cart!");
        }
        else
        {
            Console.WriteLine("This option is currently unavaliable!");
        }
    }
    if (bundleoption == 2)
    {
        
        if ((hour > 10 || (hour == 10 && minute >= 0)) && (hour < 19) || (hour == 19 && minute == 0))
        {
            Console.WriteLine("Would you like to trade-in your beverage or keep your cola? : ");
            Console.WriteLine("1. Keep Cola \n2. Trade for Tea (+$0.00)\n3. Trade for Coffee (+$0.00)" +
                "\n4. Trade for Green Tea (+$0.85)\n5. Trade for Tom's Root Beer (+$6.85)\n6. Trade for Mocktail (+$13.05)");
            string beverage = Console.ReadLine();
            int beverageopt = int.Parse(beverage);
            if (beverageopt == 1)
            {
                selecteditem = new OrderItem(hcombo);
                receipt.Add(selecteditem);
                Console.WriteLine("Tom has added your order in the Shopping Cart!");
            }
            if (beverageopt == 2)
            {
                selecteditem = new OrderItem(hcombo2);
                receipt.Add(selecteditem);
                Console.WriteLine("Tom has added your order in the Shopping Cart!");
            }
            if (beverageopt == 3)
            {
                selecteditem = new OrderItem(hcombo3);
                receipt.Add(selecteditem);
                Console.WriteLine("Tom has added your order in the Shopping Cart!");
            }
            if (beverageopt == 4)
            {
                selecteditem = new OrderItem(hcombo4);
                receipt.Add(selecteditem);
                Console.WriteLine("Tom has added your order in the Shopping Cart!");
            }
            if (beverageopt == 5)
            {
                selecteditem = new OrderItem(hcombo5);
                receipt.Add(selecteditem);
                Console.WriteLine("Tom has added your order in the Shopping Cart!");
            }
            if (beverageopt == 6)
            {
                selecteditem = new OrderItem(hcombo6);
                receipt.Add(selecteditem);
                Console.WriteLine("Tom has added your order in the Shopping Cart!");
            }
            else if (beverageopt > 6)
            {
                Console.WriteLine("Invalid option!");
            }




            
        }
        else
        {
            Console.WriteLine("This option is currently unavaliable!");
        }
    if (bundleoption == 0)
        {

        }
    else if (bundleoption > 2)
        {
            Console.WriteLine("Invalid option!");
        }

    }

        

}


    
    
    
    //Marc : Add item to orderlist
    //If (menuitem) not in list , add it to the list
    //If (menuitem) in the list , perform AddQty()
    //Then GetTotalQty() will display quantity of display items
    //Multiply price x quantity in the receipt


//For Option 2
void ValueMeals(Order receipt)
{
    int hour = now.Hour;
    int minute = now.Minute;
    OrderItem selecteditem = null;
    // Check if the current time is between 7:00 AM and 2:00 PM
    if ((hour > 7 || (hour == 7 && minute >= 0)) && (hour < 14) || (hour == 14 && minute == 0))
    {
        Console.WriteLine("1. " + hws.ToString());
    }
    else
    {
        Console.WriteLine("1. Option not avaliable!");
    }

    // Check if the current time is between 10:00 AM and 7:00 PM
    if ((hour > 10 || (hour == 10 && minute >= 0)) && (hour < 19) || (hour == 19 && minute == 0))
    {
        Console.WriteLine("2. " + hb.ToString());
    }
    else
    {
        Console.WriteLine("2. Option not avaliable!");
    }
    Console.WriteLine("3. " + nl.ToString());
    Console.WriteLine("4. " + rs.ToString());
    Console.WriteLine("0. Back to Menu");
    Console.WriteLine("Select your option : ");
    string value = Console.ReadLine();
    int valueoption = int.Parse(value);
    if (valueoption == 1)
    {
        if ((hour > 7 || (hour == 7 && minute >= 0)) && (hour < 14) || (hour == 14 && minute == 0))
        {
            selecteditem = new OrderItem(hws);
            receipt.Add(selecteditem);
            Console.WriteLine("Tom has added your order in the Shopping Cart!");
        }
        else
        {
            Console.WriteLine("This option is currently unavaliable!");
        }
    }
    if (valueoption == 2)
    {
        if ((hour > 10 || (hour == 10 && minute >= 0)) && (hour < 19) || (hour == 19 && minute == 0))
        {
            selecteditem = new OrderItem(hb);
            receipt.Add(selecteditem);
            Console.WriteLine("Tom has added your order in the Shopping Cart!");
        }
        else
        {
            Console.WriteLine("This option is currently unavaliable!");
        }
    }
    if (valueoption == 3)
    {
        selecteditem = new OrderItem(nl);
        receipt.Add(selecteditem);
        Console.WriteLine("Tom has added your order in the Shopping Cart!");
    }
    if (valueoption == 4)
    {
        selecteditem = new OrderItem(rs);
        receipt.Add(selecteditem);
        Console.WriteLine("Tom has added your order in the Shopping Cart!");
    }
    if (valueoption == 0)
    {

    }
    else if (valueoption > 4)
    {
        Console.WriteLine("Invalid option!");
    }


}




void Sides(Order receipt)
{
    OrderItem selecteditem = null;
    Console.WriteLine("1. " + product7.ToString());
    Console.WriteLine("2. " + product8.ToString());
    Console.WriteLine("3. " + product9.ToString());
    Console.WriteLine("4. " + product10.ToString());
    Console.WriteLine("0. Back to Menu");
    Console.WriteLine("Select your option : ");
    string side = Console.ReadLine();
    int sideoption = int.Parse(side);
    if (sideoption == 1)
    {
        selecteditem = new OrderItem(hashbrown);
        receipt.Add(selecteditem);
        Console.WriteLine("Tom has added your order in the Shopping Cart!");
    }
    if (sideoption == 2)
    {
        selecteditem = new OrderItem(tf);
        receipt.Add(selecteditem);
        Console.WriteLine("Tom has added your order in the Shopping Cart!");
    }
    if (sideoption == 3)
    {
        selecteditem = new OrderItem(cala);
        receipt.Add(selecteditem);
        Console.WriteLine("Tom has added your order in the Shopping Cart!");
    }
    if (sideoption == 4)
    {
        selecteditem = new OrderItem(cs);
        receipt.Add(selecteditem);
        Console.WriteLine("Tom has added your order in the Shopping Cart!");
    }
    if (sideoption == 0)
    {

    }
    else if (sideoption > 4)
    {
        Console.WriteLine("Invalid option!");
    }

}

//For Option 4
void Beverages(Order receipt)
{
    OrderItem selecteditem = null;
    Console.WriteLine("1. " + product11.ToString());
    Console.WriteLine("2. " + product12.ToString());
    Console.WriteLine("3. " + product13.ToString());
    Console.WriteLine("4. " + product14.ToString());
    Console.WriteLine("5. " + product15.ToString());
    Console.WriteLine("6. " + product16.ToString());
    Console.WriteLine("0. Back to Menu");
    Console.WriteLine("Select your option : ");
    string beverage = Console.ReadLine();
    int beverageoption = int.Parse(beverage);
    if (beverageoption == 1)
    {
        selecteditem = new OrderItem(cola);
        receipt.Add(selecteditem);
        Console.WriteLine("Tom has added your order in the Shopping Cart!");
    }
    if (beverageoption == 2)
    {
        selecteditem = new OrderItem(gt);
        receipt.Add(selecteditem);
        Console.WriteLine("Tom has added your order in the Shopping Cart!");
    }
    if (beverageoption == 3)
    {
        selecteditem = new OrderItem(cof);
        receipt.Add(selecteditem);
        Console.WriteLine("Tom has added your order in the Shopping Cart!");
    }
    if (beverageoption == 4)
    {
        selecteditem = new OrderItem(tea);
        receipt.Add(selecteditem);
        Console.WriteLine("Tom has added your order in the Shopping Cart!");
    }
    if (beverageoption == 5)
    {
        selecteditem = new OrderItem(trb);
        receipt.Add(selecteditem);
        Console.WriteLine("Tom has added your order in the Shopping Cart!");
    }
    if (beverageoption == 6)
    {
        selecteditem = new OrderItem(mt);
        receipt.Add(selecteditem);
        Console.WriteLine("Tom has added your order in the Shopping Cart!");
    }
    if (beverageoption == 0)
    {

    }
    else if (beverageoption > 6)
    {
        Console.WriteLine("Invalid option!");
    }



}

void ShoppingCart(Order receipt)
{
    Console.WriteLine("Shopping Cart");
    Console.WriteLine(receipt.ToString());
    Console.WriteLine("How would you like to proceed?");
    Console.WriteLine("1. Cancel Order\n 2. Remove an Item \n 3. Proceed \n0. Return to Order");
    Console.Write("Select an option : ");
    string cartinput = Console.ReadLine();
    int cartoption = int.Parse(cartinput);
    if (cartoption == 1)
    {
        receipt.ClearAll();
        Console.WriteLine("Tom has cancelled your order!");
    }
    if (cartoption == 2)
    {
        Console.WriteLine("Type the number of the item you would like removed :");
        string removepls = Console.ReadLine();
        int removaltime = int.Parse(removepls);
        int removaltime2 = removaltime - 1;
        bool removed = receipt.Remove(removaltime2);
        


    }
    if (cartoption == 3)
    {
        Console.WriteLine("Thanks for shopping at Tom Diner!");
        Console.WriteLine("Print Date : " + day + "/" + month + "/" + year + "\nPrint time : " + hour + ":" + minute + ":" + second);
        Console.WriteLine(receipt);
        receipt.Please();
        receipt.ClearAll();
        
        
    }
    if (cartoption == 0)
    {

    }
    else if (cartoption > 4)
    {
        Console.WriteLine("Invalid option!");
    }

}

void AddSubsystem(MenuUpdater menusslist)
{
    try
    {
        Console.WriteLine("What category of Tom Cafe's Menu would you like to update? (Sides/Beverages)");
        string creator = Console.ReadLine();
        string creator2 = creator.ToLower();
        Console.WriteLine("What is the name of the Menu Item you wish to create?");
        string menucreator = Console.ReadLine();
        Console.WriteLine("What is the price of the Menu Item you wish to create?");
        string pricecreator = Console.ReadLine();
        double pricing = double.Parse(pricecreator);
        
        menusslist.AddMenuItem(creator2, new MenuItem(menucreator, pricing));

    }
    catch (FormatException)
    {
        Console.WriteLine("Please input an integer/double for the price.");
    }

    
}
void RemoveSubsystem(MenuUpdater menusslist)
{
    Console.WriteLine("What category of Tom Cafe's Menu would you like to remove? (Sides/Beverages)");
    string remover = Console.ReadLine();
    Console.WriteLine("Input the name of the Menu Item you would like to remove");
    string removeritem = Console.ReadLine();
    
    menusslist.RemoveMenuItem(remover, removeritem);

}
void DisplaySubsystem(MenuUpdater menusslist)
{
    Console.WriteLine("Note : Nothing will show up if you have not added any sides/beverages , refer to option 6/7");
    menusslist.DisplayMenuItems();
}

Order receipt = new Order();
MenuUpdater menusslist = new MenuUpdater();
while (true)
{
    

    try
    {
        
        DateTime currentDate = DateTime.Now;
        DisplayMenu();
        Console.Write("Select a category (0-8): ");
        string input = Console.ReadLine();
        int option = int.Parse(input);
        if (int.TryParse(input, out option))
        {
            if (option == 1)
            {
                BundleMeals(receipt);
            }
            if (option == 2)
            {
                ValueMeals(receipt);  
            }

            if (option == 3)
            {
                Sides(receipt);
            }

            if (option == 4)
            {
                Beverages(receipt);
            }
            if (option == 5)
            { 
                ShoppingCart(receipt);
            }
            if (option == 6)
            {
                AddSubsystem(menusslist);
            }
            if (option == 7)
            {
                RemoveSubsystem(menusslist);
            }
            if (option == 8)
            {
                DisplaySubsystem(menusslist);
            }

            if (option == 0)
            {
                Console.WriteLine("Thank you for visiting Tom Cafe!");
                break;
            }
            else if (option > 8 || option < 0)
            {
                Console.WriteLine("Invalid Option! Option must be 1,2,3,4,5,6,7,8 or 0");
            }
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid option. Please choose an integer. \n");
    }
    catch (Exception)
    {
        Console.WriteLine("An unexpected error has occured , please try again.");
    }


    }




//BundleMeals();

