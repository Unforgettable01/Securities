using SecuritiesBusinessLogic.BindingModels;
using SecuritiesBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SecuritiesBusinessLogic.Interfaces
{
    public interface IContractBuyStorage
    {
        List<ContractBuyViewModel> GetFullList();
        List<ContractBuyViewModel> GetFilteredList(ContractBuyBindingModel model);
        ContractBuyViewModel GetElement(ContractBuyBindingModel model);
        void Insert(ContractBuyBindingModel model);
        void Update(ContractBuyBindingModel model);
        void Delete(ContractBuyBindingModel model);
    }
}
