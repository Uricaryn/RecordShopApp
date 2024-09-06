using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using RechordShopApp.Concerete;
using Microsoft.EntityFrameworkCore.Query;

namespace RecordShopAppDAL.Interface
{
    public interface IBaseRepo<T> where T : BaseEntity
    {
        int Create(T entity);

        int Update(T entity);

        int Delete(T entity);

        T GetById(int id);

        bool GetAny(Expression<Func<T, bool>> expression);

        IList<T> GetAll();
    }
}
