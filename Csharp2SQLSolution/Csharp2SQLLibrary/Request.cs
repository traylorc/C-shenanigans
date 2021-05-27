using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp2SQLLibrary
{
    public class Request
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; }
        public string Justification { get; set; }
        public string RejectReasoning { get; set; }
        public string DeliveryMode { get; set; }
        public string Status { get; set; }
        public decimal Total { get; set; }
        public User user { get; set; }




    }
}
