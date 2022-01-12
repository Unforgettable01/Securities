using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SecuritiesBusinessLogic.ViewModels
{
    public class EmitentViewModel
    {
        public int Id { get; set; }
        [DisplayName("Наименование")]
        public string EmitentName { get; set; }
    }
}
