using SecuritiesBusinessLogic.BindingModels;
using SecuritiesBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SecuritiesBusinessLogic.Interfaces
{
    public interface IPaymentContractBuySaleStorage
    {
        List<PaymentContractBuySaleViewModel> GetFullList();
        List<PaymentContractBuySaleViewModel> GetFilteredList(PaymentContractBuySaleBindingModel model);
        PaymentContractBuySaleViewModel GetElement(PaymentContractBuySaleBindingModel model);
        void Insert(PaymentContractBuySaleBindingModel model);
        void Update(PaymentContractBuySaleBindingModel model);
        void Delete(PaymentContractBuySaleBindingModel model);
    }
}
