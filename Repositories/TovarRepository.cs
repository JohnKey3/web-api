using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web_api.Context;
using web_api.Models;
using web_api.Interfaces;
using Microsoft.EntityFrameworkCore;
using web_api.Controllers.Models;

namespace web_api.Repositories
{
    public class TovarRepository : TovarInterface
    {
        private MainContext _context;
        public TovarRepository(MainContext context) { _context = context; }
        public IEnumerable<Tovar> select()
        {
            return _context.Tovars.FromSqlRaw("tovar_select");
        }
        public void insert(Tovar tovar)
        {
            Microsoft.Data.SqlClient.SqlParameter[] param = new Microsoft.Data.SqlClient.SqlParameter[4];
            param[0] = new Microsoft.Data.SqlClient.SqlParameter("@name", tovar.name);
            param[1] = new Microsoft.Data.SqlClient.SqlParameter("@kolvo", tovar.kolvo);
            param[2] = new Microsoft.Data.SqlClient.SqlParameter("@price", tovar.price);
            param[3] = new Microsoft.Data.SqlClient.SqlParameter("@description", tovar.description);
            _context.Database.ExecuteSqlRaw("tovar_insert @name, @kolvo, @price, @description", param);
        }
        public void delete(int id)
        {
            var item = _context.Tovars.Where(x => x.id == id).FirstOrDefault();
            if (item.Equals(null)) return;
            _context.Tovars.Remove(item);
        }
        public void update (Tovar tovar)
        {
            _context.Tovars.Update(tovar);
        }
    }
}
