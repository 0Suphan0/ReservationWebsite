﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T>: IGenericDal<T> where T : class
    {
        public void Insert(T item)
        {
            using var context = new Context();
            context.Add(item);
            context.SaveChanges();
        }

        public void Delete(T item)
        {
            using var context = new Context();
            context.Remove(item);
            context.SaveChanges();
        }

        public void Update(T item)
        {
            using var context = new Context();
            context.Update(item);
            context.SaveChanges();
        }

        public List<T> GetAll()
        {
            using var context = new Context();
            return context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
           using var context = new Context();
            return context.Set<T>().Find(id);
            
        }
    }
}
