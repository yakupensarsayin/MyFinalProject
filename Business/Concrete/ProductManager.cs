using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            // Does user has permission to add product?
            // etc. 

            // If user meets all conditions, then finally:
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public List<Product> GetAllByCategoryID(int categoryID)
        {
            return _productDal.GetAllByCategoryID(categoryID);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
