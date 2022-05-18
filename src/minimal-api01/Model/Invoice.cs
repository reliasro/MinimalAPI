using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.Model
{
    public class Invoice
    {
        public Guid Id { get; set; }
        public string Date { get; set; }
        public string CustomerName { get; set; }
        public Decimal Value { get; set; }
        public string ProductDescription { get; set; }
        public string Comments { get; set; }
    }
}