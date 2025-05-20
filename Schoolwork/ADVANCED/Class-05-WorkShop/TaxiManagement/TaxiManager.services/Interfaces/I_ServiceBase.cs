using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiManager.Domain.Models;

namespace TaxiManager.services.Interfaces
{
    public interface I_ServiceBase<T> where T : BaseEntity
    {
        List<T> GetAll();
        List<T> GetAll(Func<T, bool> whereCondition);
        T GetSingle(int id);
        void Add(T item);
        void Remove(T item);
        void Seed(List<T> items);
    }
}
