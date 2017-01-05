using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private AShopDbContext dbContext;

        public AShopDbContext Init()
        {
            return dbContext ?? (dbContext = new AShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
