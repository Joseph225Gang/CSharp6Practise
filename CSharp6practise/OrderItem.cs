using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6practise
{
    public class OrderItem
    {
        public int Count { get; set; } = 1;
        public bool ApplyDiscount { get; } = true;
        public string Order { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            string firstName = null;
            if (this.Order != null)
                firstName = this.Order;
            firstName = this?.Order;
            sb.Append($"Total: {firstName}");
            return firstName;
        }

        public void AddItem(OrderItem order)
        {
            try
            {

            }
            catch(Exception e) when(e.Data.Count > 0)
            if (order == null)
                throw new ArgumentException(nameof(order));
        }
    }
}
