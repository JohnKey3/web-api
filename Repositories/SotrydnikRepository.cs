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
    public class SotrydnikRepository : SotrydnikInterface
    {
        private MainContext _context;
        public SotrydnikRepository(MainContext context) { _context = context; }
        public IEnumerable<Sotrydnik> select()
        {
            return _context.Sotrydniks.FromSqlRaw("sotrydnik_select");
        }
        public void insert(Sotrydnik sotrydnik)
        {
            Microsoft.Data.SqlClient.SqlParameter[] param = new Microsoft.Data.SqlClient.SqlParameter[7];
            param[0] = new Microsoft.Data.SqlClient.SqlParameter("@id_doljnost", sotrydnik.id_doljnost);
            param[1] = new Microsoft.Data.SqlClient.SqlParameter("@surname", sotrydnik.surname);
            param[2] = new Microsoft.Data.SqlClient.SqlParameter("@name", sotrydnik.name);
            param[3] = new Microsoft.Data.SqlClient.SqlParameter("@login", sotrydnik.login);
            param[4] = new Microsoft.Data.SqlClient.SqlParameter("@password", sotrydnik.password);
            param[5] = new Microsoft.Data.SqlClient.SqlParameter("@adress", sotrydnik.adress);
            param[6] = new Microsoft.Data.SqlClient.SqlParameter("@phone", sotrydnik.phone);
            _context.Database.ExecuteSqlRaw("sotrydnik_insert @id_doljnost, @surname, @name, @login, @password, @adress, @phone", param);
        }
        public void delete(int id)
        {
            var item = _context.Sotrydniks.Where(x => x.id == id).FirstOrDefault();
            if (item.Equals(null)) return;
            _context.Sotrydniks.Remove(item);
        }
        public void update (Sotrydnik sotrydnik)
        {
            _context.Sotrydniks.Update(sotrydnik);
        }
    }
}
