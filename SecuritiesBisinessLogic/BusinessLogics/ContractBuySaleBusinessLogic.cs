using SecuritiesBusinessLogic.BindingModels;
using SecuritiesBusinessLogic.Interfaces;
using SecuritiesBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;

namespace SecuritiesBusinessLogic.BusinessLogics
{
    public class ContractBuySaleBusinessLogic
    {
        private readonly IContractBuySaleStorage _contractBuySaleStorage;
        public ContractBuySaleBusinessLogic(IContractBuySaleStorage contractBuySaleStorage)
        {
            _contractBuySaleStorage = contractBuySaleStorage;
        }
        public List<ContractBuySaleViewModel> Read(ContractBuySaleBindingModel model)
        {
            if (model == null)
            {
                return _contractBuySaleStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<ContractBuySaleViewModel> { _contractBuySaleStorage.GetElement(model) };
            }
            return _contractBuySaleStorage.GetFilteredList(model);
        }
        public void Create(ContractBuySaleBindingModel model)
        {
            var element = _contractBuySaleStorage.GetElement(new ContractBuySaleBindingModel
            {
                Id = model.Id
            });
            if (element != null && element.Id != model.Id)
            {
                throw new Exception("Уже есть такой договор купли-прожажи");
            }
            if (model.Id.HasValue)
            {
                _contractBuySaleStorage.Update(model);
            }
            else
            {
                _contractBuySaleStorage.Insert(model);
            }

        }
        public void Delete(ContractBuySaleBindingModel model)
        {
            var element = _contractBuySaleStorage.GetElement(new ContractBuySaleBindingModel
            {
                Id = model.Id
            });
            if (element == null)
            {
                throw new Exception("Договор купли-прожажи не найден");
            }
            _contractBuySaleStorage.Delete(model);
        }
    }
}
