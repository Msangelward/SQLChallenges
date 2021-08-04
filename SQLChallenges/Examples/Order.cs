using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLChallenges.Examples
{
    public class Order
    {
        public int OrderId { get; set; }

        //This is the Foreign Key
        public Customer CustomerId { get; set; }
        public Customer Customer { get; set; }
        public short OrderStatus { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public int StoreId { get; set; }
        public int Staffid { get; set; }


    }
}
