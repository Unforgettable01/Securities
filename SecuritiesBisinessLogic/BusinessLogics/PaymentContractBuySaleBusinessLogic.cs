using SecuritiesBusinessLogic.BindingModels;
using SecuritiesBusinessLogic.Interfaces;
using SecuritiesBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;

namespace SecuritiesBusinessLogic.BusinessLogics
{
    public class PaymentContractBuySaleBusinessLogic
    {
        private readonly IPaymentContractBuySaleStorage _paymentContractBuySaleStorage;
        public PaymentContractBuySaleBusinessLogic(IPaymentContractBuySaleStorage paymentContractBuySaleStorage)
        {
            _paymentContractBuySaleStorage = paymentContractBuySaleStorage;
        }
        public List<PaymentContractBuySaleViewModel> Read(PaymentContractBuySaleBindingModel model)
        {
            if (model == null)
            {
                return _paymentContractBuySaleStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<PaymentContractBuySaleViewModel> { _paymentContractBuySaleStorage.GetElement(model) };
            }
            return _paymentContractBuySaleStorage.GetFilteredList(model);
        }
        public void Create(PaymentContractBuySaleBindingModel model)
        {
            var element = _paymentContractBuySaleStorage.GetElement(new PaymentContractBuySaleBindingModel
            {
                Id = model.Id
            });
            if (element != null && element.Id != model.Id)
            {
                throw new Exception("Уже есть такая оплата");
            }
            if (model.Id.HasValue)
            {
                _paymentContractBuySaleStorage.Update(model);
            }
            else
            {
                _paymentContractBuySaleStorage.Insert(model);
            }

        }
        public void Delete(PaymentContractBuySaleBindingModel model)
        {
            var element = _paymentContractBuySaleStorage.GetElement(new PaymentContractBuySaleBindingModel
            {
                Id = model.Id
            });
            if (element == null)
            {
                throw new Exception("Оплата не найдена");
            }
            _paymentContractBuySaleStorage.Delete(model);
        }
    }
}
