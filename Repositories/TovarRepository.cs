using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web_api.Context;
using web_api.Models;
using web_api.Interfaces;
using Microsoft.EntityFrameworkCore;
using web_api.Controllers.Models;
using Microsoft.Data.SqlClient;

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
        public Tovar getbyid(int id)
        {
            Microsoft.Data.SqlClient.SqlParameter[] param = new Microsoft.Data.SqlClient.SqlParameter[1];
            param[0] = new Microsoft.Data.SqlClient.SqlParameter("@id", id);
            return _context.Tovars.FromSqlRaw("byid @id", param).AsEnumerable().FirstOrDefault();
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
            _context.Database.ExecuteSqlRaw($"DeleteValue {id}" );
                
        }
            
        
        public void update (Tovar tovar)
        {
            Microsoft.Data.SqlClient.SqlParameter[] param = new Microsoft.Data.SqlClient.SqlParameter[5];
            param[0] = new Microsoft.Data.SqlClient.SqlParameter("@id", tovar.id);
            param[1] = new Microsoft.Data.SqlClient.SqlParameter("@name", tovar.name);
            param[2] = new Microsoft.Data.SqlClient.SqlParameter("@kolvo", tovar.kolvo);
            param[3] = new Microsoft.Data.SqlClient.SqlParameter("@price", tovar.price);
            param[4] = new Microsoft.Data.SqlClient.SqlParameter("@description", tovar.description);
            _context.Database.ExecuteSqlRaw("tovar_update @id, @name, @kolvo, @price, @description", param);
        }
    }
}
