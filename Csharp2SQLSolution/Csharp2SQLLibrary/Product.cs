using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp2SQLLibrary
{
    public class Product
    {
        public int Id { get; set; }
        public int VendorId { get; set; }
        public string Name { get; set; }
        public string PartNbr { get; set; }
        public decimal Price { get; set; }
        public string Unit { get; set; }
        public string PhotoPath { get; set; }
    }
}
