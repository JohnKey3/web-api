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
    [Route("api/[controller]")]
    public class ProdajaController : ControllerBase
    {
        private ProdajaInterface _ProdajaRepository;
        public ProdajaController(ProdajaInterface ProdajaRepository) { _ProdajaRepository = ProdajaRepository; }
        [HttpGet]
        [Route("get")]
        public Prodaja get()
            => _ProdajaRepository.select().FirstOrDefault();

        [HttpGet]
        [Route("select")]
        public IEnumerable<Prodaja> select()
            => _ProdajaRepository.select();

        [HttpPost]
        [Route("update")]
        public void update(Prodaja prodaja)
            => _ProdajaRepository.update(prodaja);

        [HttpPost]
        [Route("delete")]
        public void delete(int id)
            => _ProdajaRepository.delete(id);

        [HttpPost]
        [Route("insert")]
        public void insert(Prodaja prodaja)
            => _ProdajaRepository.insert(prodaja);
    }
}
