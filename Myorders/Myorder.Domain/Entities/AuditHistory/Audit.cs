using System;
using System.Collections.Generic;
using System.Text;

namespace Myorder.Domain.Entities.AuditHistory
{
   public class Audit:BaseEntity.Base<Guid>
    {
        public string  CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string  ModifyBy { get; set; }
        public DateTime ModifyOn { get; set; }
    }
}
