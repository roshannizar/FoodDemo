﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FoodDemo.Data.Entity
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [Display(Name="Product Name")]
        [StringLength(50,ErrorMessage ="Name cannot be too long")]
        public string Name { get; set; }

        [Display(Name="Product Description")]
        public string Description { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public double UnitPrice { get; set; }

        [Required]
        public int Quantity { get; set; }
    }
}
