using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCSharp
{
    public class EFCoreDemo
    {
        public void Execute()
        {
            using (var context = new MyDataBaseContext())
            {
                
                foreach (var category in context.ProductCategories.Where(x => x.Id == 1))
                {
                    category.Name = "Test";
                }
                context.SaveChanges();// commit
            }
        }
    }
}
