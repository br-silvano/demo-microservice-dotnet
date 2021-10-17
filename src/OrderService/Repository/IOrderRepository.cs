using System;
using System.Threading.Tasks;

using OrderService.Model;

namespace OrderService.Repository
{
    public interface IOrderRepository
    {
        Task<string> Add(Order order);
        Task<Order> GetById(string id);
        Task<string> Cancel(string id);
        Task<Order> GetByCustomerId(string custid);
    }
}