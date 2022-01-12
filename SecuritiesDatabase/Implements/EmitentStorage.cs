using SecuritiesBusinessLogic.BindingModels;
using SecuritiesBusinessLogic.Interfaces;
using SecuritiesBusinessLogic.ViewModels;
using SecuritiesDatabase.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SecuritiesDatabase.Implements
{
    public class EmitentStorage : IEmitentStorage
    {
        public List<EmitentViewModel> GetFullList()
        {
            using (var context = new securitiesdbContext())
            {
                return context.Emitent.Select(rec => new EmitentViewModel
                {
                    Id = rec.Id,
                    EmitentName = rec.Name                    
                }).ToList();
            }
        }

        public List<EmitentViewModel> GetFilteredList(EmitentBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new securitiesdbContext())
            {
                return context.Emitent.Where(rec => rec.Id.Equals(model.Id)).Select(rec => new EmitentViewModel
                {
                    Id = rec.Id,
                   EmitentName = rec.Name
                }).ToList();
            }
        }

        public EmitentViewModel GetElement(EmitentBindingModel model)
        {
            if (model == null)
            {
                return null;
            }

            using (var context = new securitiesdbContext())
            {
                var emitent = context.Emitent.FirstOrDefault(rec => rec.Id == model.Id);
                return emitent != null ?
                new EmitentViewModel
                {
                    Id = emitent.Id,
                  EmitentName = emitent.Name
                } : null;
            }
        }

        public void Insert(EmitentBindingModel model)
        {
            using (var context = new securitiesdbContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        context.Emitent.Add(CreateModel(model, new Emitent(), context));
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

        public void Update(EmitentBindingModel model)
        {
            using (var context = new securitiesdbContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var element = context.Emitent.FirstOrDefault(rec => rec.Id == model.Id);
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

        public void Delete(EmitentBindingModel model)
        {
            using (var context = new securitiesdbContext())
            {
                Emitent element = context.Emitent.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    context.Emitent.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
        }

        private Emitent CreateModel(EmitentBindingModel model, Emitent emitent, securitiesdbContext context)
        {
            emitent.Name = model.EmitentName;
            return emitent;
        }
    }
}
