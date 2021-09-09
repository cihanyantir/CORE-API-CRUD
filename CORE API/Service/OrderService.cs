using CORE_API.IService;
using CORE_API.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CORE_API.Service
{
    public class OrderService : IGenericService<Order>
    {
        List<Order> order = new List<Order>();

        public OrderService()
        {
            for (int i = 0; i < 9; i++)
            {
                order.Add(new Order() { Id = i, OrderDate="2021", Quantity=25+i });
            }
        }
        public List<Order> Delete(int id)
        {
            order.RemoveAll(x => x.Id == id);
            return order;

        }

        public List<Order> GetAll()
        {
            return order;

        }

        public Order GetById(int id)
        {
            return order.Where(x => x.Id == id).SingleOrDefault();
        }

        public List<Order> Insert(Order item)
        {
            order.Add(item);
            return order;
        }
    }
}

