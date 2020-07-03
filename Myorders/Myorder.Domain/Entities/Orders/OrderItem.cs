using System;
using System.Collections.Generic;
using System.Text;

namespace Myorder.Domain.Entities.Orders
{
   public class OrderItem:AuditHistory.Audit
    {
        public int  Qty { get; set; }
        public Domain.Entities.Product.Product product { get; set; }
    }
}
