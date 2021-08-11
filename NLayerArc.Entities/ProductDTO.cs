using System;
using System.Collections.Generic;
using System.Text;

namespace NLayerArc.Entities
{
    public class ProductDTO:IEntity    // Bu sınıfı, Joinle birden fazla sınıftan kombine ettiğimiz verileri tek bir objede tutabilmek için kullandık.
    {

        public int ProductId { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; } //money
        public short UnitsOnOrder { get; set; } //smallint

        //public int Id { get; set; }
        //public string ProductName { get; set; }
        //public string ProductBrand { get; set; }
        //public string CategoryName { get; set; }
        //public int ProductQuantity { get; set; }
        //public int ProductPrice { get; set; }
    }
}
