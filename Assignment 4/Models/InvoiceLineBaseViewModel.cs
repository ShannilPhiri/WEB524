﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Assignment4.Models
{
    public class InvoiceLineBaseViewModel 
    {
        public int InvoiceLineId { get; set; }
        
        public int InvoiceId { get; set; }
        public int TrackId { get; set; }

        [Column(TypeName = "numeric")]
        public decimal UnitPrice { get; set; }

        public int Quantity { get; set; }
    }
}