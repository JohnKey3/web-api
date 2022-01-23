using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web_api.Controllers.Models;
using web_api.Models;

namespace web_api.Interfaces
{
    public interface DoljnostInterface
    {
        IEnumerable<Doljnost> select();
        void insert(Doljnost doljnost);
        void delete(int id);
        void update(Doljnost doljnost);

    }
}
