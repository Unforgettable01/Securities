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
//    public class ContractBuyStorage : IContractBuyStorage
//    {
//        public List<ContractBuyViewModel> GetFullList()
//        {
//            using (var context = new securitiesdbContext())
//            {
//                return context.ContractBuy
//                    .Include(rec => rec.Request)
//                .Select(CreateModel).ToList();
//            }
//        }

//        public List<ContractBuyViewModel> GetFilteredList(ContractBuyBindingModel model)
//        {
//            if (model == null)
//            {
//                return null;
//            }
//            using (var context = new securitiesdbContext())
//            {
//                return context.ContractBuy
//                    .Include(rec => rec.Request)
//                    .Where(rec => rec.Id == model.Id)
//                    .Select(CreateModel).ToList();
//            }
//        }

//        public ContractBuyViewModel GetElement(ContractBuyBindingModel model)
//        {
//            if (model == null)
//            {
//                return null;
//            }
//            using (var context = new securitiesdbContext())
//            {
//                var contractBuy = context.ContractBuy
//                    .Include(rec => rec.Request)
//                .FirstOrDefault(rec => rec.Id == model.Id);
//                return contractBuy != null ?
//                CreateModel(contractBuy) : null;
//            }
//        }

//        public void Insert(ContractBuyBindingModel model)
//        {
//            using (var context = new securitiesdbContext())
//            {
//                context.ContractBuy.Add(CreateModel(model, new ContractBuy()));
//                context.SaveChanges();
//            }
//        }

//        public void Update(ContractBuyBindingModel model)
//        {
//            using (var context = new securitiesdbContext())
//            {
//                ContractBuy element = context.ContractBuy.FirstOrDefault(rec => rec.Id == model.Id);
//                if (element == null)
//                {
//                    throw new Exception("Элемент не найден");
//                }
//                CreateModel(model, element);
//                context.SaveChanges();
//            }
//        }

//        public void Delete(ContractBuyBindingModel model)
//        {
//            using (var context = new securitiesdbContext())
//            {
//                ContractBuy element = context.ContractBuy.FirstOrDefault(rec => rec.Id == model.Id);
//                if (element != null)
//                {
//                    context.ContractBuy.Remove(element);
//                    context.SaveChanges();
//                }
//                else
//                {
//                    throw new Exception("Элемент не найден");
//                }
//            }
//        }

//        private ContractBuy CreateModel(ContractBuyBindingModel model, ContractBuy contractBuy)
//        {
//            contractBuy.Status = model.Status;
//            contractBuy.Sum = model.Sum;
//            contractBuy.RequestId = model.RequestId;
//            return contractBuy;
//        }

//        private ContractBuyViewModel CreateModel(ContractBuy contractBuy)
//        {
//            return new ContractBuyViewModel
//            {
//                Id = contractBuy.Id,
//                Sum = contractBuy.Sum,
//                Status = contractBuy.Status,
//                RequestId = contractBuy.Request.Id
//            };
//        }
//    }
//}
