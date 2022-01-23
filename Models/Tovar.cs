using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace web_api.Controllers.Models
{
    public class Tovar
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public int kolvo { get; set; }
        public int price { get; set; }
        public string description { get; set; }
    }
}
