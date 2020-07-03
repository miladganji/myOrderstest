using Microsoft.EntityFrameworkCore;
using Myorder.Domain.Entities.AuditHistory;
using Myorder.Domain.Entities.Orders;
using Myorder.Domain.Entities.Product;
using Myorder.Domain.Entities.Users;
using MyOrders.Infra.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//using Microsoft.EntityFrameworkCore;

namespace MyOrders.Infra
{
   public class ApplicationDbcontext : DbContext, IapplicationDbContext
    {
       
        private readonly IGetcurrentUserService getcurrentUserService;

        public ApplicationDbcontext(DbContextOptions option, IGetcurrentUserService getcurrentUserService)
            :base(option)
        {
            this.getcurrentUserService = getcurrentUserService;
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderItem> OrderItem { get; set; }
        public DbSet<Product> Product { get; set; }

        
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken )
        {
            foreach (var item in ChangeTracker.Entries<Audit>())
            {
                switch (item.State)
                {
                   
                    case EntityState.Modified:
                        item.Entity.ModifyBy = getcurrentUserService.GetUser();
                        item.Entity.ModifyOn = DateTime.Now;

                        break;
                    case EntityState.Added:
                        item.Entity.CreatedBy = getcurrentUserService.GetUser();
                        item.Entity.CreatedOn = DateTime.Now;

                        break;
                    default:
                        break;
                }

            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
