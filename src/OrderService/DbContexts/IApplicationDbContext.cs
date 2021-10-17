using System;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

using OrderService.Model;

namespace OrderService.DbContexts
{
    public interface IApplicationDbContext
    {
        DbSet<Order> Orders { get; set; }
        Task<int> SaveChanges();
    }
}