using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace web_api.Controllers.Models
{
    public class Doljnost
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
    }
}
