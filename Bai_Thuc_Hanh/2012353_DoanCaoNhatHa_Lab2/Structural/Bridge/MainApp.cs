using Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class MainApp
{
    public static void Main()
    {
        // Create RefinedAbstraction
        Customers customers = new Customers("Chicago");
        // Set ConcreteImplementor
        customers.Data = new CustomersData();
        // Exercise the bridge
        customers.Show();
        customers.Next();
        customers.Show();
        customers.Next();
        customers.Show();
        customers.Add("Henry Velasquez");
        customers.ShowAll();
        // Wait for user
        Console.ReadKey();
    }
}



