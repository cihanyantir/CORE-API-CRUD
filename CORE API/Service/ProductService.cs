using CORE_API.IService;
using CORE_API.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CORE_API.Service
{
    public class ProductService : IGenericService<Product>
    {
        List<Product> _product = new List<Product>();

        public ProductService()
        {
            for (int i = 0; i < 9; i++)
            {
                _product.Add(new Product() { Id = i, Name = "Urun" + i, Stock=60+i});
            }
        }
        public List<Product> Delete(int id)
        {
            _product.RemoveAll(x => x.Id == id);
            return _product;

        }

        public List<Product> GetAll()
        {
            return _product;

        }

        public Product GetById(int id)
        {
            return _product.Where(x => x.Id == id).SingleOrDefault();
        }

        public List<Product> Insert(Product item)
        {
            _product.Add(item);
            return _product;
        }
    }
}
