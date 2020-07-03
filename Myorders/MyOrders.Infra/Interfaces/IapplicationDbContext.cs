using Microsoft.EntityFrameworkCore;
using Myorder.Domain.Entities.Orders;
using Myorder.Domain.Entities.Product;
using Myorder.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyOrders.Infra.Interfaces
{
   public interface IapplicationDbContext
    {
        DbSet<User> Users { get; set; }
        DbSet<Order> Order { get; set; }
        DbSet<OrderItem> OrderItem { get; set; }
        DbSet<Product> Product { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);




    }
}
