using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingAppSQL.DataBaseItems
{
    public class SkincareItems
    {
        [PrimaryKey, AutoIncrement]
        public int SkincareItemId { get; set; }
        public string SkincareName { get; set; }
        public int SkincareQuantity { get; set; }
        public string SkincareImage { get; set; }
        public decimal SkincarePrice { get; set; }
        public string SkincareDescription { get; set; }
    }
}