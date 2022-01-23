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
    [Route("api/Sotrydnik")]
    public class SotrydnikController : ControllerBase
    {
        private SotrydnikInterface _SotrydnikRepository;
        public SotrydnikController(SotrydnikInterface SotrydnikRepository) { _SotrydnikRepository = SotrydnikRepository; }
        [HttpGet]
        [Route("get")]
        public Sotrydnik get()
            => _SotrydnikRepository.select().FirstOrDefault();

        [HttpGet]
        [Route("select")]
        public IEnumerable<Sotrydnik> select()
            => _SotrydnikRepository.select();

        [HttpPost]
        [Route("update")]
        public void update(Sotrydnik sotrydnik)
            => _SotrydnikRepository.update(sotrydnik);

        [HttpPost]
        [Route("delete")]
        public void delete(int id)
            => _SotrydnikRepository.delete(id);

        [HttpPost]
        [Route("insert")]
        public void insert(Sotrydnik sotrydnik)
            => _SotrydnikRepository.insert(sotrydnik);
    }
}
