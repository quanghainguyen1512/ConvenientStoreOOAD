﻿using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvenientStore.DAO
{
    [Table("product")]
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public byte[] ImageUrl { get; set; }
        public string Description { get; set; }
        public string Barcode { get; set; }

        [Write(false)]
        public Category Category { get; set; }

        //[Write(false)]
        //public ICollection<ProductDetail> Details { get; set; }

    }
}
