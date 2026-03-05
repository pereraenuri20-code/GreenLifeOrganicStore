using GreenLifeOrganicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenLifeOrganicStore
{
    internal static class DataStore
    {
        public static List<Product> Products = new List<Product>();
        public static List<Customer> Customers = new List<Customer>();
        public static List<Order> Orders = new List<Order>();

    }
}
