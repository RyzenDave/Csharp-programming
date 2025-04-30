using Class_03_StaticClasses.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_03_StaticClasses.Entities.Models
{
    public class Order : BaseEntity
    {
      public string Title { get; set; }
      public string Description { get; set; }
      public OrderStatus Status { get; set; }

        public Order (int id, string title, string description, OrderStatus status)
        {
            Title = title;
            Description = description;
            Status = status;
        }
        public string PrintOrders()
        {
            for(int i = 0; i < OrderStatus.Count; i++)
            {
                Console.WriteLine($"{i + 1}");
            }
        }
    }
}
