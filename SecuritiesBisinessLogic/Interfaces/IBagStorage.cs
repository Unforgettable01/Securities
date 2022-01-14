using SecuritiesBusinessLogic.BindingModels;
using SecuritiesBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SecuritiesBusinessLogic.Interfaces
{
    public interface IBagStorage
    {
        List<BagViewModel> GetFullList();
        List<BagViewModel> GetFilteredList(BagBindingModel model);
        List<BagViewModel> GetFilteredBag(BagBindingModel model);
        BagViewModel GetElement(BagBindingModel model);
        void Insert(BagBindingModel model);
        void Update(BagBindingModel model);
        void Delete(BagBindingModel model);
    }
}
