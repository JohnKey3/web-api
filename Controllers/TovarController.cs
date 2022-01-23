using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using web_api.Models;
using web_api.Context;
using web_api.Controllers.Models;
using web_api.Repositories;
using web_api.Interfaces;

namespace web_api.Controllers
{
    [ApiController]
    [Route("api/Tovar")]
    public class TovarController : ControllerBase
    {
        private TovarInterface _TovarRepository;
        public TovarController(TovarInterface TovarRepository) { _TovarRepository = TovarRepository; }
        [HttpGet]
        [Route("get")]
        public Tovar get() 
            => _TovarRepository.select().FirstOrDefault();

        [HttpGet]
        [Route("select")]
        public IEnumerable<Tovar> select()
            => _TovarRepository.select();

        [HttpPost]
        [Route("update")]
        public void update(Tovar tovar)
            => _TovarRepository.update(tovar);

        [HttpPost]
        [Route("delete")]
        public void delete(int id)
            => _TovarRepository.delete(id);

        [HttpPost]
        [Route("insert")]
        public void insert(Tovar tovar)
            => _TovarRepository.insert(tovar);
    }
}
