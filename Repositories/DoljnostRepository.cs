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
    public class DoljnostRepository : DoljnostInterface
    {
        private MainContext _context;
        public DoljnostRepository(MainContext context) { _context = context; }
        public IEnumerable<Doljnost> select()
        {
            return _context.Doljnosts.FromSqlRaw("doljnost_select");
        }
        public void insert(Doljnost doljnost)
        {
            Microsoft.Data.SqlClient.SqlParameter[] param = new Microsoft.Data.SqlClient.SqlParameter[1];
            param[0] = new Microsoft.Data.SqlClient.SqlParameter("@name", doljnost.name);
            _context.Database.ExecuteSqlRaw("doljnost_insert @name", param);
        }
        public void delete(int id)
        {
            var item = _context.Doljnosts.Where(x => x.id == id).FirstOrDefault();
            if (item.Equals(null)) return;
            _context.Doljnosts.Remove(item);
        }
        public void update (Doljnost doljnost)
        {
            _context.Doljnosts.Update(doljnost);
        }
    }
}
