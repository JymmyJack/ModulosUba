using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Uba.Storage.Core
{
    public interface IDbEntity<T> where T : class
    {
        T GetById(T id);
        void Add(T item);
        void Delete(T item);

        void Edit(T item);

        List<T> GetItems();

        List<T> GetItems(params object[] filters);
    }
}
