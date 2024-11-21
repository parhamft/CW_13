﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_13.Entityes
{
    public class Category
    {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }
        public string? CategoryDescription { get; set; }
        public Byte[]? Picture { get; set; }
        public List<Product> Products { get; set; }
    }
}
