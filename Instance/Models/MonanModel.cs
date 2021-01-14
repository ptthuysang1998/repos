using Instance.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instance.Models
{
   public class MonanModel
    {
        private QuananDbContext context = null;
        public MonanModel()
        {
            context = new QuananDbContext();
        }
        public List<Monan> ListAll()
        {
            var list = context.Database.SqlQuery<Monan>(sql: "Sp_GetMonan").ToList();
            return list;
        }
    }
}
