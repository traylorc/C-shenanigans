using System;
using System.Collections.Generic;
using System.Text;

namespace sendhelpAMonOwn
{
    class Customers
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public decimal Sales { get; private set; }
        public bool Active { get; set; } = true;
        private static int LastId { get; set; } = 0;

        public void AddSales(decimal amount)
        {
            Sales = Sales + amount;            
        }


       public Customers (string name, string city, string state)
        {
            this.Id = LastId;
            LastId++;
            this.Name = name;
            this.City = city;
            this.State = state;
            
        }
    }
}
