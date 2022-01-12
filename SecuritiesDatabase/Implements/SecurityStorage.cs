using SecuritiesBusinessLogic.BindingModels;
using SecuritiesBusinessLogic.Interfaces;
using SecuritiesBusinessLogic.ViewModels;
using SecuritiesDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SecuritiesDatabase.Implements
{
    public class SecurityStorage : ISecurityStorage
    {
        public List<SecurityViewModel> GetFullList()
        {
            using (var context = new securitiesdbContext())
            {
                return context.Security.Select(rec => new SecurityViewModel
                {
                    Id = rec.Id,
                    BuyPrice = (decimal)rec.BuyPrice,
                    SalePrice = (decimal)rec.SalePrice,
                    EmitentName = rec.Emitent.Name
                }).ToList();
            }
        }

        public List<SecurityViewModel> GetFilteredList(SecurityBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new securitiesdbContext())
            {
                return context.Security.Where(rec => rec.Id.Equals(model.Id)).Select(rec => new SecurityViewModel
                {
                    Id = rec.Id,
                    BuyPrice = (decimal)rec.BuyPrice,
                    SalePrice = (decimal)rec.SalePrice,
                    EmitentName = rec.Emitent.Name
                }).ToList();
            }
        }

        public SecurityViewModel GetElement(SecurityBindingModel model)
        {
            if (model == null)
            {
                return null;
            }

            using (var context = new securitiesdbContext())
            {
                var security = context.Security.FirstOrDefault(rec => rec.Id == model.Id);
                return security != null ?
                new SecurityViewModel
                {
                    Id = security.Id,
                    BuyPrice = (decimal)security.BuyPrice,
                    SalePrice = (decimal)security.SalePrice,
                    EmitentName = security.Emitent.Name
                } : null;
            }
        }

        public void Insert(SecurityBindingModel model)
        {
            using (var context = new securitiesdbContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        context.Security.Add(CreateModel(model, new Security(), context));
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

        public void Update(SecurityBindingModel model)
        {
            using (var context = new securitiesdbContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var element = context.Security.FirstOrDefault(rec => rec.Id == model.Id);
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

        public void Delete(SecurityBindingModel model)
        {
            using (var context = new securitiesdbContext())
            {
                Security element = context.Security.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    context.Security.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
        }

        private Security CreateModel(SecurityBindingModel model, Security security, securitiesdbContext context)
        {
            security.BuyPrice = model.BuyPrice;
            security.SalePrice = model.SalePrice;
            security.EmitentId = model.EmitentId;
            return security;
        }
    }
}
