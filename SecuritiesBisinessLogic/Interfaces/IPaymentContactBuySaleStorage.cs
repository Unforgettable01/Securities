using SecuritiesBisinessLogic.BindingModels;
using SecuritiesBisinessLogic.ViewLogics;
using System;
using System.Collections.Generic;
using System.Text;

namespace SecuritiesBisinessLogic.Interfaces
{
    public interface IPaymentContractBuySaleSaleStorage
    {
        List<PaymentContractBuySaleViewModel> GetFullList();
        List<PaymentContractBuySaleViewModel> GetFilteredList(PaymentContractBuySaleBindingModel model);
        PaymentContractBuySaleViewModel GetElement(PaymentContractBuySaleBindingModel model);
        void Insert(PaymentContractBuySaleBindingModel model);
        void Update(PaymentContractBuySaleBindingModel model);
        void Delete(PaymentContractBuySaleBindingModel model);
    }
}
