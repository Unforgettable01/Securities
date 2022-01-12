﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SecuritiesDatabase.Models
{
    public partial class Security
    {
        public Security()
        {
            Bag = new HashSet<Bag>();
        }

        public int Id { get; set; }
        public decimal? BuyPrice { get; set; }
        public decimal? SalePrice { get; set; }
        public int? EmitentId { get; set; }

        public virtual Emitent Emitent { get; set; }
        public virtual ICollection<Bag> Bag { get; set; }
    }
}