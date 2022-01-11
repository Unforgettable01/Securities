using SecuritiesBisinessLogic.BindingModels;
using SecuritiesBisinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SecuritiesBisinessLogic.Interfaces
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
