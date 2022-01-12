//using SecuritiesBusinessLogic.BindingModels;
//using SecuritiesBusinessLogic.Interfaces;
//using SecuritiesBusinessLogic.ViewModels;
//using SecuritiesDatabase.Models;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace SecuritiesDatabase.Implements
//{
//    public class PaymentContractBuySaleStorage : IPaymentContractBuySaleStorage
//    {
//        public List<PaymentContractBuySaleViewModel> GetFullList()
//        {
//            using (var context = new securitiesdbContext())
//            {
//                return context.PaymentContractBuySale.Select(rec => new PaymentContractBuySaleViewModel
//                {
//                    Id = rec.Id,
//                    PaymentDate = (DateTime)rec.Date,
//                    PaymentSum = (decimal)rec.Sum,
//                    ContractBuySaleId = (int)rec.ContractBuySaleId
//                }).ToList();
//            }
//        }

//        public List<PaymentContractBuySaleViewModel> GetFilteredList(PaymentContractBuySaleBindingModel model)
//        {
//            if (model == null)
//            {
//                return null;
//            }
//            using (var context = new securitiesdbContext())
//            {
//                return context.PaymentContractBuySale.Where(rec => rec.Id.Equals(model.Id)).Select(rec => new PaymentContractBuySaleViewModel
//                {
//                    Id = rec.Id,
//                    PaymentDate = (DateTime)rec.Date,
//                    PaymentSum = (decimal)rec.Sum,
//                    ContractBuySaleId = (int)rec.ContractBuySaleId
//                }).ToList();
//            }
//        }

//        public PaymentContractBuySaleViewModel GetElement(PaymentContractBuySaleBindingModel model)
//        {
//            if (model == null)
//            {
//                return null;
//            }

//            using (var context = new securitiesdbContext())
//            {
//                var paymentContractBuySale = context.PaymentContractBuySale.FirstOrDefault(rec => rec.Id == model.Id);
//                return paymentContractBuySale != null ?
//                new PaymentContractBuySaleViewModel
//                {
//                    Id = paymentContractBuySale.Id,
//                    PaymentDate = (DateTime)paymentContractBuySale.Date,
//                    PaymentSum = (decimal)paymentContractBuySale.Sum,
//                    ContractBuySaleId = (int)paymentContractBuySale.ContractBuySaleId
//                } : null;
//            }
//        }

//        public void Insert(PaymentContractBuySaleBindingModel model)
//        {
//            using (var context = new securitiesdbContext())
//            {
//                using (var transaction = context.Database.BeginTransaction())
//                {
//                    try
//                    {
//                        context.PaymentContractBuySale.Add(CreateModel(model, new PaymentContractBuySale(), context));
//                        context.SaveChanges();
//                        transaction.Commit();
//                    }
//                    catch
//                    {
//                        transaction.Rollback();
//                        throw;
//                    }
//                }
//            }
//        }

//        public void Update(PaymentContractBuySaleBindingModel model)
//        {
//            using (var context = new securitiesdbContext())
//            {
//                using (var transaction = context.Database.BeginTransaction())
//                {
//                    try
//                    {
//                        var element = context.PaymentContractBuySale.FirstOrDefault(rec => rec.Id == model.Id);
//                        if (element == null)
//                        {
//                            throw new Exception("Элемент не найден");
//                        }
//                        CreateModel(model, element, context);
//                        context.SaveChanges();
//                        transaction.Commit();
//                    }
//                    catch
//                    {
//                        transaction.Rollback();
//                        throw;
//                    }
//                }
//            }
//        }

//        public void Delete(PaymentContractBuySaleBindingModel model)
//        {
//            using (var context = new securitiesdbContext())
//            {
//                PaymentContractBuySale element = context.PaymentContractBuySale.FirstOrDefault(rec => rec.Id == model.Id);
//                if (element != null)
//                {
//                    context.PaymentContractBuySale.Remove(element);
//                    context.SaveChanges();
//                }
//                else
//                {
//                    throw new Exception("Элемент не найден");
//                }
//            }
//        }

//        private PaymentContractBuySale CreateModel(PaymentContractBuySaleBindingModel model, PaymentContractBuySale paymentContractBuySale, securitiesdbContext context)
//        {
//            paymentContractBuySale.Date = model.PaymentDate;
//            paymentContractBuySale.Sum = model.PaymentSum;
//            paymentContractBuySale.ContractBuySaleId = model.ContractBuySaleId;
//            return paymentContractBuySale;
//        }
//    }
//}
