using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiManager.Domain.Models;

namespace TaxiManager.DataAccess
{
   public interface IDB<T> where T : BaseEntity
    {
        List<T> GetAll();
        T GetById(int id);
        int Insert(T entity);
        void Update(T entity);
        void Delete(int id);
    
    }
}
