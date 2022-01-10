using SecuritiesBisinessLogic.BindingModels;
using SecuritiesBisinessLogic.ViewLogics;
using System;
using System.Collections.Generic;
using System.Text;

namespace SecuritiesBisinessLogic.Interfaces
{
    public interface IContractBuySaleSaleStorage
    {
        List<ContractBuySaleViewModel> GetFullList();
        List<ContractBuySaleViewModel> GetFilteredList(ContractBuySaleBindingModel model);
        ContractBuySaleViewModel GetElement(ContractBuySaleBindingModel model);
        void Insert(ContractBuySaleBindingModel model);
        void Update(ContractBuySaleBindingModel model);
        void Delete(ContractBuySaleBindingModel model);
    }
}
