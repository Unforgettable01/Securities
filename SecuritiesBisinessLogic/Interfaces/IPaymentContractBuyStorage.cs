using SecuritiesBisinessLogic.BindingModels;
using SecuritiesBisinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SecuritiesBisinessLogic.Interfaces
{
    public interface IPaymentContractBuyStorage
    {
        List<PaymentContractBuyViewModel> GetFullList();
        List<PaymentContractBuyViewModel> GetFilteredList(PaymentContractBuyBindingModel model);
        PaymentContractBuyViewModel GetElement(PaymentContractBuyBindingModel model);
        void Insert(PaymentContractBuyBindingModel model);
        void Update(PaymentContractBuyBindingModel model);
        void Delete(PaymentContractBuyBindingModel model);
    }
}
