using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web_api.Controllers.Models;
using web_api.Models;

namespace web_api.Interfaces
{
    public interface ProdajaInterface
    {
        IEnumerable<Prodaja> select();
        void insert(Prodaja prodaja);
        void delete(int id);
        void update(Prodaja prodaja);

    }
}
