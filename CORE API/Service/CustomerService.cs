using CORE_API.IService;
using CORE_API.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CORE_API.Service
{
    public class CustomerService : IGenericService<Customer>
    {
        List<Customer> _customer = new List<Customer>();

        public CustomerService()
        {
            for (int i = 0; i < 9; i++)
            {
                _customer.Add(new Customer() {Id=i,Name="Cihan"+i, Surname="Yantir"+i, PhoneNumber="111111111", RegisterDate="1999"});
            }
        }
        public List<Customer> Delete(int id)
        {
            _customer.RemoveAll(x => x.Id == id);
            return _customer;
         
        }

        public List<Customer> GetAll()
        {
            return _customer;

        }

        public Customer GetById(int id)
        {
            return _customer.Where(x => x.Id == id).SingleOrDefault();
        }

        public List<Customer> Insert(Customer item)
        {
            _customer.Add(item);
            return _customer;
        }
    }
}
