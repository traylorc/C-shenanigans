using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp2SQLLibrary
{
    public class RequestLine
    {
        public int Id { get; set; }
        public int RequestId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public Request request { get; set; }
        public Product product { get; set; }

    }
}
