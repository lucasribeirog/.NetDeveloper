using EcommerceAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Collections.Generic;
using System.Linq;

namespace EcommerceAPI.Infrastructure.Data
{
    public class EcommerceContext : DbContext
    {
        public EcommerceContext()
        {
        }

        public EcommerceContext(DbContextOptions<EcommerceContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        public override int SaveChanges()
        {
            //Space to business rule
            return base.SaveChanges();
        }
    }
}