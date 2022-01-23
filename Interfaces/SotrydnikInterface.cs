using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web_api.Controllers.Models;
using web_api.Models;

namespace web_api.Interfaces
{
    public interface SotrydnikInterface
    {
        IEnumerable<Sotrydnik> select();
        void insert(Sotrydnik sotrydnik);
        void delete(int id);
        void update(Sotrydnik sotrydnik);

    }
}
