﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SecuritiesBusinessLogic.BindingModels
{
    public class ContractBuyBindingModel
    {
        public int? Id { get; set; }
        public string Status { get; set; }
        public decimal Sum { get; set; }
        public int RequestId { get; set; }
        public DateTime Date { get; set; }
    }
}
