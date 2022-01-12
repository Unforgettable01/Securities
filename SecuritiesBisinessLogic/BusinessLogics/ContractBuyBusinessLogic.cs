using SecuritiesBusinessLogic.BindingModels;
using SecuritiesBusinessLogic.Interfaces;
using SecuritiesBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;

namespace SecuritiesBusinessLogic.BusinessLogics
{
    public class ContractBuyBusinessLogic
    {
        private readonly IContractBuyStorage _contractBuyStorage;
        public ContractBuyBusinessLogic(IContractBuyStorage contractBuyStorage)
        {
            _contractBuyStorage = contractBuyStorage;
        }
        public List<ContractBuyViewModel> Read(ContractBuyBindingModel model)
        {
            if (model == null)
            {
                return _contractBuyStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<ContractBuyViewModel> { _contractBuyStorage.GetElement(model) };
            }
            return _contractBuyStorage.GetFilteredList(model);
        }
        public void Create(ContractBuyBindingModel model)
        {
            var element = _contractBuyStorage.GetElement(new ContractBuyBindingModel
            {
                Id = model.Id
            });
            if (element != null && element.Id != model.Id)
            {
                throw new Exception("Уже есть такой договор на покупку");
            }
            if (model.Id.HasValue)
            {
                _contractBuyStorage.Update(model);
            }
            else
            {
                _contractBuyStorage.Insert(model);
            }

        }
        public void Delete(ContractBuyBindingModel model)
        {
            var element = _contractBuyStorage.GetElement(new ContractBuyBindingModel
            {
                Id = model.Id
            });
            if (element == null)
            {
                throw new Exception("Договор на покупку не найден");
            }
            _contractBuyStorage.Delete(model);
        }
    }
}
