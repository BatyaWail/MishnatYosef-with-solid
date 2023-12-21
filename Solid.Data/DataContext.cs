using Solid.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Solid.Data
{
    public class DataContext
    {
        public List<Product> products { get; set; }
        public List<Client> clients { get; set; }
        public List<Station> stations { get; set; }
        public DataContext()
        {
            products = new List<Product>() { new Product(1, "oil", "dry", 5), 
                new Product(2, "milk", "milk", 4.5) };
            clients = new List<Client>() { new Client(1, "batya", "0504119712", "breslev"), 
                new Client(2, "yehudit", "0504116143", "chagai 3") };
            stations = new List<Station>() { 
                new Station("breslev", 1, 40, DayOfWeek.Wednesday),
            new Station("ben zacay", 2, 50, DayOfWeek.Monday)};
        }
    }
}
