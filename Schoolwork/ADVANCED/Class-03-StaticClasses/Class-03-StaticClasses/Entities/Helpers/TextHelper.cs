using Class_03_StaticClasses.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_03_StaticClasses.Entities.Helpers
{
    public static class TextHelper
    {
        public static int MessagesGenerated = 0;
        public static void GenerateStatusMessage(OrderStatus status)
        {
            string result = string.Empty;
            ConsoleColor color = ConsoleColor.White;
            switch (status)
            {
                case OrderStatus.Processing:
                    ConsoleHelper.WriteInColor("[Processing] Order is gettin proccessed");
                    break;
                case OrderStatus.Delivered:
                    ConsoleHelper.WriteInColor("[Delivered] Successfully delivered!", ConsoleColor.Green);
                    break;
                case OrderStatus.DeliveryInProgress:
                    ConsoleHelper.WriteInColor("[InProgress] Order is gettin delivered");
                    break;
                case OrderStatus.CouldNotDeliver:
                    ConsoleHelper.WriteInColor("[Order Delivery Failure] Could not deliver!");
                    break;
                default:
                    break;
            }
        }
    }
}
