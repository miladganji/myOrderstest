using System;
using System.Collections.Generic;
using System.Text;

namespace Myorder.Domain.Entities.BaseEntity
{
   public class Base<T>
    {
        public T Id { get; set; }
    }
}
