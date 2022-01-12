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
//    public class ContractBuySaleStorage : IContractBuySaleStorage
//    {
//        public List<ContractBuySaleViewModel> GetFullList()
//        {
//            using (var context = new securitiesdbContext())
//            {
//                return context.ContractBuySale
//                    .Include(rec => rec.Request)
//                .Select(CreateModel).ToList();
//            }
//        }

//        public List<ContractBuySaleViewModel> GetFilteredList(ContractBuySaleBindingModel model)
//        {
//            if (model == null)
//            {
//                return null;
//            }
//            using (var context = new securitiesdbContext())
//            {
//                return context.ContractBuySale
//                    .Include(rec => rec.Request)
//                    .Where(rec => rec.Id == model.Id)
//                    .Select(CreateModel).ToList();
//            }
//        }

//        public ContractBuySaleViewModel GetElement(ContractBuySaleBindingModel model)
//        {
//            if (model == null)
//            {
//                return null;
//            }
//            using (var context = new securitiesdbContext())
//            {
//                var contractBuySale = context.ContractBuySale
//                    .Include(rec => rec.Request)
//                .FirstOrDefault(rec => rec.Id == model.Id);
//                return contractBuySale != null ?
//                CreateModel(contractBuySale) : null;
//            }
//        }

//        public void Insert(ContractBuySaleBindingModel model)
//        {
//            using (var context = new securitiesdbContext())
//            {
//                context.ContractBuySale.Add(CreateModel(model, new ContractBuySale()));
//                context.SaveChanges();
//            }
//        }

//        public void Update(ContractBuySaleBindingModel model)
//        {
//            using (var context = new securitiesdbContext())
//            {
//                ContractBuySale element = context.ContractBuySale.FirstOrDefault(rec => rec.Id == model.Id);
//                if (element == null)
//                {
//                    throw new Exception("Элемент не найден");
//                }
//                CreateModel(model, element);
//                context.SaveChanges();
//            }
//        }

//        public void Delete(ContractBuySaleBindingModel model)
//        {
//            using (var context = new securitiesdbContext())
//            {
//                ContractBuySale element = context.ContractBuySale.FirstOrDefault(rec => rec.Id == model.Id);
//                if (element != null)
//                {
//                    context.ContractBuySale.Remove(element);
//                    context.SaveChanges();
//                }
//                else
//                {
//                    throw new Exception("Элемент не найден");
//                }
//            }
//        }

//        private ContractBuySale CreateModel(ContractBuySaleBindingModel model, ContractBuySale contractBuySale)
//        {
//            contractBuySale.Status = model.Status;
//            contractBuySale.Sum = model.ContractSum;
//            contractBuySale.RequestId = model.RequestId;
//            return contractBuySale;
//        }

//        private ContractBuySaleViewModel CreateModel(ContractBuySale contractBuySale)
//        {
//            return new ContractBuySaleViewModel
//            {
//                Id = contractBuySale.Id,
//                ContractSum = contractBuySale.Sum,
//                Status = contractBuySale.Status,
//                RequestId = contractBuySale.Request.Id
//            };
//        }
//    }
//}
