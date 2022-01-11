﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SecuritiesBisinessLogic.BindingModels
{
    public class RequestBindingModel
    {
        public int? Id { get; set; }
        public DateTime RequestDate { get; set; }
        public decimal RequestSum { get; set; }
        public int ClientId { get; set; }
        public int AgentId { get; set; }
        public Dictionary<int, (string, decimal)> RequestSecurity { get; set; }
    }
}