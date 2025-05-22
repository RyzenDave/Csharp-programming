using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiManager.Domain.Models;
using TaxiManager.services.Interfaces;

namespace TaxiManager.services.Services
{
    public class ServiceBase<T> : I_ServiceBase<T> where T : BaseEntity
    {
        private readonly IDB<T> _db;

        public ServiceBase()
        {
           _db = new IDB<T>();
        }
        public void Add(T item)
        {

        }
        public void Remove(T item)
        {

        }
        public List<T> GetAll()
        {

        }
        public List<T> GetAll(Func<T, bool> whereCondition)
        {

        }
        public T GetSingle(int id)
        {

        }
        public void Seed(List<T> items)
        {

        }
    }
}
