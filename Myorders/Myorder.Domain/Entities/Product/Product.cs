using System;
using System.Collections.Generic;
using System.Text;

namespace Myorder.Domain.Entities.Product
{
   public class Product:AuditHistory.Audit
    {
        public string  Name { get; set; }
        public decimal Price { get; set; }
    }
}
