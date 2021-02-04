using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork
{
    public class ProductDal
    {
        public List<Product> GetAll()
        {
            using (ETradeContext contex = new ETradeContext())
            {
               return contex.Products.ToList();
            }
        }
        public void Add(Product product)
        {
            using (ETradeContext contex = new ETradeContext())
            {
                var entity = contex.Entry(product);
                entity.State = EntityState.Added;
               // contex.Products.Add(product);
                contex.SaveChanges();

            }
        }
        public void Update(Product product)
        {
            using (ETradeContext contex = new ETradeContext())
            {
                var entity = contex.Entry(product);
                entity.State = EntityState.Modified;
                
                contex.SaveChanges();

            }
        }
        public void Delete(Product product)
        {
            using (ETradeContext contex = new ETradeContext())
            {
                var entity = contex.Entry(product);
                entity.State = EntityState.Deleted;

                contex.SaveChanges();

            }
        }

    }
}
