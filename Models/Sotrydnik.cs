﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace web_api.Controllers.Models
{
    public class Sotrydnik
    {
        [Key]
        public int id { get; set; }
        public int id_doljnost { get; set; }
        public string surname { get; set; }
        public string name { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string adress { get; set; }
        public string phone { get; set; }
    }
}
