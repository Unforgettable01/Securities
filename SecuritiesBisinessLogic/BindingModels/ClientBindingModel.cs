using System;
using System.Collections.Generic;
using System.Text;

namespace SecuritiesBisinessLogic.BindingModels
{
    public class ClientBindingModel
    {
        public int? Id { get; set; }
        public string PassportNumber { get; set; }
        public string ClientName { get; set; }
        public string ClientPassword { get; set; }
    }
}
