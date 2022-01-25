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
    [Route("api/Doljnost")]
    public class DoljnostController : ControllerBase
    {
        private DoljnostInterface _DoljnostRepository;
        public DoljnostController(DoljnostInterface DoljnostRepository) { _DoljnostRepository = DoljnostRepository; }
        [HttpGet]
        [Route("get")]
        public Doljnost get() 
            => _DoljnostRepository.select().FirstOrDefault();

        [HttpGet]
        [Route("select")]
        public IEnumerable<Doljnost> select()
            => _DoljnostRepository.select();

        [HttpPost]
        [Route("update")]
        public void update(Doljnost doljnost)
            => _DoljnostRepository.update(doljnost);

        [HttpPost]
        [Route("delete")]
        public void delete(int id)
            => _DoljnostRepository.delete(id);

        [HttpPost]
        [Route("insert")]
        public void insert(Doljnost doljnost)
            => _DoljnostRepository.insert(doljnost);
    }
}
