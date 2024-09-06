using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using RechordShopApp.Concerete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Query;
using RecordShopAppDAL.Context;
using RecordShopAppDAL.Interface;

namespace RecordShopAppDAL.Concrete
{
    public class BaseRepo<T> : IBaseRepo<T> where T : BaseEntity
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _table;
        
        public BaseRepo(AppDbContext context)
        {
            _context = context;
            _table = _context.Set<T>();
        }

        public int Create(T entity)
        {
            _context.Add(entity);
            return _context.SaveChanges();
        }

        public int Update(T entity)
        {
            _context.Update(entity);
            return _context.SaveChanges();
        }

        public int Delete(T entity)
        {
           _context.Remove(entity);
            return _context.SaveChanges();
        }

        public IList<T> GetAll()
        {
            return _table.ToList();
        }

        public bool GetAny(Expression<Func<T, bool>> expression)
        {
           return _table.Any(expression);
        }

        public T GetById(int id)
        {
           return _table.Find(id);
        }

    }
}
