using SecuritiesBusinessLogic.BindingModels;
using SecuritiesBusinessLogic.Interfaces;
using SecuritiesBusinessLogic.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SecuritiesDatabase.Implements
{
    public class PaymentContractBuyStorage : IPaymentContractBuyStorage
    {
        public List<PaymentContractBuyViewModel> GetFullList()
        {
            using (var context = new securitiesdbContext())
            {
                return context.PaymentContractBuy.Select(rec => new PaymentContractBuyViewModel
                {
                    Id = rec.Id,
                    PaymentDate = (DateTime)rec.Date,
                    PaymentSum = (decimal)rec.Sum,
                    ContractBuyId = (int)rec.ContractBuyId
                }).ToList();
            }
        }

        public List<PaymentContractBuyViewModel> GetFilteredList(PaymentContractBuyBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new securitiesdbContext())
            {
                return context.PaymentContractBuy.Where(rec => rec.Id.Equals(model.Id)).Select(rec => new PaymentContractBuyViewModel
                {
                    Id = rec.Id,
                    PaymentDate = (DateTime)rec.Date,
                    PaymentSum = (decimal)rec.Sum,
                    ContractBuyId = (int)rec.ContractBuyId
                }).ToList();
            }
        }

        public PaymentContractBuyViewModel GetElement(PaymentContractBuyBindingModel model)
        {
            if (model == null)
            {
                return null;
            }

            using (var context = new securitiesdbContext())
            {
                var paymentContractBuy = context.PaymentContractBuy.FirstOrDefault(rec => rec.Id == model.Id);
                return paymentContractBuy != null ?
                new PaymentContractBuyViewModel
                {
                    Id = paymentContractBuy.Id,
                    PaymentDate = (DateTime)paymentContractBuy.Date,
                    PaymentSum = (decimal)paymentContractBuy.Sum,
                    ContractBuyId = (int)paymentContractBuy.ContractBuyId
                } : null;
            }
        }

        public void Insert(PaymentContractBuyBindingModel model)
        {
            using (var context = new securitiesdbContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        context.PaymentContractBuy.Add(CreateModel(model, new PaymentContractBuy(), context));
                        context.SaveChanges();
                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public void Update(PaymentContractBuyBindingModel model)
        {
            using (var context = new securitiesdbContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var element = context.PaymentContractBuy.FirstOrDefault(rec => rec.Id == model.Id);
                        if (element == null)
                        {
                            throw new Exception("Элемент не найден");
                        }
                        CreateModel(model, element, context);
                        context.SaveChanges();
                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public void Delete(PaymentContractBuyBindingModel model)
        {
            using (var context = new securitiesdbContext())
            {
                PaymentContractBuy element = context.PaymentContractBuy.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    context.PaymentContractBuy.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
        }

        private PaymentContractBuy CreateModel(PaymentContractBuyBindingModel model, PaymentContractBuy paymentContractBuy, securitiesdbContext context)
        {
            paymentContractBuy.Date = model.PaymentDate;
            paymentContractBuy.Sum = model.PaymentSum;
            paymentContractBuy.ContractBuyId = model.ContractBuyId;
            return paymentContractBuy;
        }
    }
}
