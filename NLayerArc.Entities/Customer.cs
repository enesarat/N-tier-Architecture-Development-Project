using System;
using System.Collections.Generic;
using System.Text;

namespace NLayerArc.Entities
{
    public class Customer: IEntity
    {

        public string CustomerID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }


        //public int CustomerId { get; set; }
        //public string UserName { get; set; }

    }
}
