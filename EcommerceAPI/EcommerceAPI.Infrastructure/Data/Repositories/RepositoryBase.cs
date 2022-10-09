using EcommerceAPI.Core.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EcommerceAPI.Infrastructure.Data.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly EcommerceContext _ecommerceContext;

        public RepositoryBase(EcommerceContext ecommerceContext)
        {
            this._ecommerceContext = ecommerceContext;
        }

        public void Add(TEntity obj)
        {
            try
            {
                _ecommerceContext.Set<TEntity>().Add(obj);
                _ecommerceContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(TEntity obj)
        {
            try
            {
                _ecommerceContext.Entry(obj).State = EntityState.Modified;
                _ecommerceContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Remove(TEntity obj)
        {
            try
            {
                _ecommerceContext.Set<TEntity>().Remove(obj);
                _ecommerceContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _ecommerceContext.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return _ecommerceContext.Set<TEntity>().Find(id);
        }
    }
}