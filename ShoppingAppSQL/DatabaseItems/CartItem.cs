using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingAppSQL.DataBaseItems
{
    public class CartItem
    {
        [PrimaryKey, AutoIncrement]
        public int CartItemId { get; set; }
        public int ItemQuantity { get; set; }
        public decimal CartPrice { get; set; }
        public string SkincareName { get; set; }
        public string SkincareImage { get; set; }


        [ForeignKey(typeof(SkincareItems))]
        public int SkincareId { get; set; }
        public int skincareQuantity { get; internal set; }
        public int SkincarePrice { get; internal set; }
    }
}
