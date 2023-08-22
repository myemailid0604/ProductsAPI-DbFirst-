﻿using System.ComponentModel.DataAnnotations;

namespace ProductsAPI_DbFirst_.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string? ProductDescription { get; set; }
        public decimal? ProductPrice { get; set; }
    }
}
