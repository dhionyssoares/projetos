using ExercícioOrder.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioOrder.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }
        public double Total()
        {
            double sum = 0;
            foreach (OrderItem item in Items)
            {
                sum += item.SubTotal();
            }

            return sum;
        }

        public override string ToString()
        {
            StringBuilder sbOrder = new StringBuilder();
            sbOrder.Append("Order moment: " + Moment.ToString("G") + "\n");
            sbOrder.Append("Order status: " + Status + "\n");
            sbOrder.Append("Client: " + Client + "\n");
            sbOrder.Append("Order items: " + "\n");
            foreach (OrderItem item in Items)
            {
                sbOrder.AppendLine(item.ToString());
            }
            sbOrder.AppendLine("Total price: " + Total().ToString("C"));
            return sbOrder.ToString();
        }

        
       
    
    
    
    }
}
