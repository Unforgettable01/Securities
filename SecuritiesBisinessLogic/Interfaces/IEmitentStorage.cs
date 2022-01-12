using SecuritiesBusinessLogic.BindingModels;
using SecuritiesBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SecuritiesBusinessLogic.Interfaces
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
