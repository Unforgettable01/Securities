using System;
using System.Collections.Generic;
using System.Text;

namespace SecuritiesBisinessLogic.BindingModels
{
    public class AgentBindingModel
    {
        public int? Id { get; set; }
        public string AgentName { get; set; }
        public string AgentLogin { get; set; }
        public string AgentPassword { get; set; }
    }
}
