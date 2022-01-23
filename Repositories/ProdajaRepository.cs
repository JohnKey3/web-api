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
    public class ProdajaRepository : ProdajaInterface
    {
        private MainContext _context;
        public ProdajaRepository(MainContext context) { _context = context; }
        public IEnumerable<Prodaja> select()
        {
            return _context.Prodajas.FromSqlRaw("prodaja_select");
        }
        public void insert(Prodaja prodaja)
        {
            Microsoft.Data.SqlClient.SqlParameter[] param = new Microsoft.Data.SqlClient.SqlParameter[4];
            param[0] = new Microsoft.Data.SqlClient.SqlParameter("@id_tovar", prodaja.id_tovar);
            param[1] = new Microsoft.Data.SqlClient.SqlParameter("@id_sotrydnik", prodaja.id_sotrydnik);
            param[2] = new Microsoft.Data.SqlClient.SqlParameter("@kolvo", prodaja.kolvo);
            param[3] = new Microsoft.Data.SqlClient.SqlParameter("@price", prodaja.price);
            _context.Database.ExecuteSqlRaw("prodaja_insert @id_tovar, @id_sotrydnik, @kolvo, @price", param);
        }
        public void delete(int id)
        {
            var item = _context.Prodajas.Where(x => x.id == id).FirstOrDefault();
            if (item.Equals(null)) return;
            _context.Prodajas.Remove(item);
        }
        public void update (Prodaja prodaja)
        {
            _context.Prodajas.Update(prodaja);
        }
    }
}
