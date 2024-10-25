using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCSharp
{
    public class MyDataBaseContext : DbContext
    {
        public MyDataBaseContext() : base("name=MyDataBaseContext")
        {
        }

        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }
    }

}
