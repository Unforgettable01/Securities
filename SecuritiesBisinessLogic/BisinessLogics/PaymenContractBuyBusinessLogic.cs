using SecuritiesBisinessLogic.BindingModels;
using SecuritiesBisinessLogic.Interfaces;
using SecuritiesBisinessLogic.ViewModels;
using System;
using System.Collections.Generic;

namespace SecuritiesBusinessLogic.BisinessLogics
{
    public class PaymenContractBuyBusinessLogic
    {
        private readonly IPaymentContractBuyStorage _PaymentContractBuyStorage;
        public PaymenContractBuyBusinessLogic(IPaymentContractBuyStorage PaymentContractBuyStorage)
        {
            _PaymentContractBuyStorage = PaymentContractBuyStorage;
        }
        public List<PaymentContractBuyViewModel> Read(PaymentContractBuyBindingModel model)
        {
            if (model == null)
            {
                return _PaymentContractBuyStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<PaymentContractBuyViewModel> { _PaymentContractBuyStorage.GetElement(model) };
            }
            return _PaymentContractBuyStorage.GetFilteredList(model);
        }
        public void Create(PaymentContractBuyBindingModel model)
        {
            var element = _PaymentContractBuyStorage.GetElement(new PaymentContractBuyBindingModel
            {
                Id = model.Id
            });
            if (element != null && element.Id != model.Id)
            {
                throw new Exception("Уже есть такая оплата");
            }
            if (model.Id.HasValue)
            {
                _PaymentContractBuyStorage.Update(model);
            }
            else
            {
                _PaymentContractBuyStorage.Insert(model);
            }

        }
        public void Delete(PaymentContractBuyBindingModel model)
        {
            var element = _PaymentContractBuyStorage.GetElement(new PaymentContractBuyBindingModel
            {
                Id = model.Id
            });
            if (element == null)
            {
                throw new Exception("Оплата не найдена");
            }
            _PaymentContractBuyStorage.Delete(model);
        }
    }
}
