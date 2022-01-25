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
        public IEnumerable<Tovar> select()
            => _TovarRepository.select();


        [HttpGet("{id}")]
        public Tovar getbyid(int id)
            => _TovarRepository.getbyid(id);

        [HttpPut]
        [Route("update")]
        public void update(int id, [FromBody]Tovar tovar)
            => _TovarRepository.update(tovar);

        [HttpDelete("{id}")]
        public void delete(int id)
            => _TovarRepository.delete(id);
        

        [HttpPost]
        [Route("insert")]
        public void insert([FromBody] Tovar tovar)
            => _TovarRepository.insert(tovar);
    }
}
