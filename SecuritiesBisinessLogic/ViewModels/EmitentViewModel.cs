using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SecuritiesBisinessLogic.ViewLogics
{
    public class EmitentViewModel
    {
        public int Id { get; set; }
        [DisplayName("Наименование")]
        public string EmitentName { get; set; }
    }
}
