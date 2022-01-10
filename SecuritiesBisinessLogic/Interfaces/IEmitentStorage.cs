using SecuritiesBisinessLogic.BindingModels;
using SecuritiesBisinessLogic.ViewLogics;
using System;
using System.Collections.Generic;
using System.Text;

namespace SecuritiesBisinessLogic.Interfaces
{
    public interface IEmitentStorage
    {
        List<EmitentViewModel> GetFullList();
        List<EmitentViewModel> GetFilteredList(EmitentBindingModel model);
        EmitentViewModel GetElement(EmitentBindingModel model);
        void Insert(EmitentBindingModel model);
        void Update(EmitentBindingModel model);
        void Delete(EmitentBindingModel model);
    }
}
