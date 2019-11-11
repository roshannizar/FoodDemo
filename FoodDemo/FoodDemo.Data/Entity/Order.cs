﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FoodDemo.Data.Entity
{
    public class Order
    {
        public int Id { get; set; }
        public virtual ICollection<OrderLine> OrderLines { get; set; }
        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public virtual Customer Customers { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public StatusType Status { get; set; }
    }
}
