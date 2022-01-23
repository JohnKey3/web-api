using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web_api.Controllers.Models;
using web_api.Models;

namespace web_api.Interfaces
{
    public interface TovarInterface
    {
        IEnumerable<Tovar> select();
        void insert(Tovar tovar);
        void delete(int id);
        void update(Tovar tovar);

    }
}
