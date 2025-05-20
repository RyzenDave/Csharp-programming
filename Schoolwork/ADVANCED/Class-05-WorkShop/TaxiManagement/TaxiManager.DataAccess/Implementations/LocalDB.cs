using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiManager.Domain.Models;

namespace TaxiManager.DataAccess.Implementations
{
    public class LocalDB<T> : IDB<T> where T : BaseEntity
    {
        public int IdCount { get; set; } = 1;

        private List<T> _db;

        public LocalDB()
        {
            _db = new List<T>();
            IdCount = 1;
        }

        public void Delete(int id)
        {
            var item = _db.SingleOrDefault(x => x.Id == id);
            if (item != null)
            {
                _db.Remove(item);
            }
        }

        public List<T> GetAll()
        {
            return _db;
        }


        public T GetById(int id)
        {
            return _db.SingleOrDefault(x => x.Id == id);
        }


        public int Insert(T entity)
        {
            entity.Id = IdCount;
            _db.Add(entity);

            IdCount++;
            return entity.Id;
        }

        public void Update(T entity)
        {
            var item = _db.SingleOrDefault(x => x.Id == entity.Id);
            if (item != null)
            {
                _db.Remove(item);
                _db.Add(entity);
            }
        }
      
    }
}
