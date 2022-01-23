using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace web_api.Models
{
    public class Prodaja
    {
        [Key]
        public int id { get; set; }
        public int id_tovar { get; set; }
        public int id_sotrydnik { get; set; }
        public int kolvo { get; set; }
        public int price { get; set; } 

    }
}
