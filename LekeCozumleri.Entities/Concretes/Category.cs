﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LekeCozumleri.Entities.Concretes
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }


        public List<Stain> Stain { get; set; }
    }
}
