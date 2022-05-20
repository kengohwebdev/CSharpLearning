using Day4SampleApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4SampleApp.Repository
{
    internal class ProductRepository : IRepository<Products>
    {
        List<Products> _products;
        public ProductRepository()
        {
            _products = new List<Products>();
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Products> GetAll()
        {
            throw new NotImplementedException();
        }

        public Products GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Products entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Products entity)
        {
            throw new NotImplementedException();
        }
    }
}
