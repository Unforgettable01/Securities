﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SecuritiesBisinessLogic.BindingModels
{
    public class ContractBuySaleBindingModel
    {
        public int? Id { get; set; }
        public string Status { get; set; }
        public decimal ContractSum { get; set; }
        public int RequestId { get; set; }
    }
}