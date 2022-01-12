using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text;

namespace SecuritiesBusinessLogic.ViewModels
{
    public class BagViewModel
    {
        public int Id { get; set; }
        [DisplayName("Сумма")]
        public decimal Sum { get; set; }
        [DisplayName("Статус")]
        public string Status { get; set; }
        [DataMember]
        public Dictionary<int?, (string, decimal?)> BagSecurities { get; set; }
    }
}
