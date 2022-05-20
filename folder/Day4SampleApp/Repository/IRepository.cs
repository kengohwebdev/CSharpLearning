﻿using Day4SampleApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4SampleApp.Repository
{
    public interface IRepository<T> where T : class
    {
        public void Insert(T entity);
        public void Update(T entity);
        public void Delete(int id);

        public IEnumerable<T> GetAll();
        public T GetById(int id);
    }
}
