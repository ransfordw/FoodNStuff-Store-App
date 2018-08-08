﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FoodNStuff.WebMVC.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionID { get; set; }

        public int CustomerID { get; set; }

        public int ProductID { get; set; }
        //add a property to account for quantity purchased/sold
        //that prop will be related to product.Quantity

        public virtual Product Product { get; set; }
        public virtual Customer Customer { get; set; }

    }
}