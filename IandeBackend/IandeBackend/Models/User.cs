﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IandeBackend.Models
{
    public class User
    {
        public int id { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public int permission { get; set; }
        public bool deleted { get; set; }
    }
}