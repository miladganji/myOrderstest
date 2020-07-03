using System;
using System.Collections.Generic;
using System.Text;

namespace Myorder.Domain.Entities.Orders
{
  public  class Order:AuditHistory.Audit
    {
        public decimal TotlePrice { get; set; }
        public decimal TotlalAmont { get; set; }
        public double Tax { get; set; }
        public List<OrderItem> OrderItem { get; set; }
    }
}
