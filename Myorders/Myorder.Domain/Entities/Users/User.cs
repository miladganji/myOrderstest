using System;
using System.Collections.Generic;
using System.Text;

namespace Myorder.Domain.Entities.Users
{
  public  class User:BaseEntity.Base<Guid>
    {
        public string  UserName { get; set; }
        public string  Password { get; set; }
        public string  PhoneNumber { get; set; }
    }
}
