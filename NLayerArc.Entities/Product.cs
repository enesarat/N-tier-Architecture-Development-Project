using System;
using System.Collections.Generic;
using System.Text;

namespace NLayerArc.Entities
{
    public class Product: IEntity
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; } //money
        public short UnitsOnOrder { get; set; } //smallint


        /*public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductBrand { get; set; }
        public int ProductCategory { get; set; }
        public int ProductQuantity { get; set; }
        public int ProductPrice { get; set; }*/
    }
}
