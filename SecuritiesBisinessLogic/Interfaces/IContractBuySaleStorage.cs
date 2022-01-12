using SecuritiesBusinessLogic.BindingModels;
using SecuritiesBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SecuritiesBusinessLogic.Interfaces
{
    public interface IContractBuySaleStorage
    {
        List<ContractBuySaleViewModel> GetFullList();
        List<ContractBuySaleViewModel> GetFilteredList(ContractBuySaleBindingModel model);
        ContractBuySaleViewModel GetElement(ContractBuySaleBindingModel model);
        void Insert(ContractBuySaleBindingModel model);
        void Update(ContractBuySaleBindingModel model);
        void Delete(ContractBuySaleBindingModel model);
    }
}
