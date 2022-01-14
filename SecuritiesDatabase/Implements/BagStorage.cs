using SecuritiesBusinessLogic.BindingModels;
using SecuritiesBusinessLogic.Interfaces;
using SecuritiesBusinessLogic.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SecuritiesDatabase.Implements
{
    public class BagStorage : IBagStorage
    {
        public List<BagViewModel> GetFullList()
        {
            using (var context = new securitiesdbContext())
            {
                return context.Bag
                    .Include(rec => rec.BagSecurities)
                    .ThenInclude(rec => rec.Securities)
                    .ToList().Select(rec => new BagViewModel
                    {
                        Id = rec.Id,
                        Status = rec.Status,
                        Sum = (decimal)rec.Sum,
                        ClientId = rec.Client.Id,
                        BagSecurities = rec.BagSecurities
                    .ToDictionary(recD => recD.SecuritiesId,
                    recD => (recD.Securities?.Name, recD.Count, recD.Sum))
                    }).ToList();
            }
        }

        public List<BagViewModel> GetFilteredList(BagBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new securitiesdbContext())
            {
                return context.Bag
                    .Include(rec => rec.BagSecurities)
                    .ThenInclude(rec => rec.Securities)
                    .Where(rec => rec.Id.Equals(model.Id)).ToList()
                    .Select(rec => new BagViewModel
                    {
                        Id = rec.Id,
                        Status = rec.Status,
                        Sum = (decimal)rec.Sum,
                        ClientId = rec.Client.Id,
                        BagSecurities = rec.BagSecurities.ToDictionary(recD => recD.SecuritiesId, recD => (recD.Securities?.Name, recD.Count, recD.Sum))
                    }).ToList();
            }
        }

        public BagViewModel GetElement(BagBindingModel model)
        {
            if (model == null)
            {
                return null;
            }

            using (var context = new securitiesdbContext())
            {
                var bag = context.Bag
                    .Include(rec => rec.BagSecurities)
                    .ThenInclude(rec => rec.Securities)
                    .FirstOrDefault(rec => rec.Id == model.Id);
                return bag != null ?
                new BagViewModel
                {
                    Id = bag.Id,
                    Status = bag.Status,
                    Sum = (decimal)bag.Sum,
                    ClientId = bag.Client.Id,
                    BagSecurities = bag.BagSecurities.ToDictionary(recD => recD.SecuritiesId, recD => (recD.Securities?.Name, recD.Count, recD.Sum))
                } : null;
            }
        }

        public void Insert(BagBindingModel model)
        {
            using (var context = new securitiesdbContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        CreateModel(model, new Bag(), context);
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

        public void Update(BagBindingModel model)
        {
            using (var context = new securitiesdbContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var element = context.Bag.FirstOrDefault(rec => rec.Id == model.Id);

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

        public void Delete(BagBindingModel model)
        {
            using (var context = new securitiesdbContext())
            {
                Bag element = context.Bag.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    context.Bag.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
        }

        private Bag CreateModel(BagBindingModel model, Bag bag, securitiesdbContext context)
        {
            bag.Status = model.Status;
            bag.Sum = model.Sum;
            bag.ClientId = model.ClientId;

            if (bag.Id == 0)
            {
                context.Bag.Add(bag);
                context.SaveChanges();
            }

            if (model.Id.HasValue)
            {
                var BagSecurities = context.BagSecurities
                    .Where(rec => rec.BagId == model.Id.Value)
                    .ToList();

                context.BagSecurities
                    .RemoveRange(BagSecurities
                        .Where(rec => !model.BagSecurities
                            .ContainsKey((int)rec.SecuritiesId))
                                .ToList());
                context.SaveChanges();

                foreach (var updateDetail in BagSecurities)
                {
                    updateDetail.Count = model.BagSecurities[(int)updateDetail.SecuritiesId].Item2;
                    updateDetail.Sum = model.BagSecurities[(int)updateDetail.SecuritiesId].Item3;
                    model.BagSecurities.Remove((int)updateDetail.SecuritiesId);
                }

                context.SaveChanges();
            }

            foreach (var ed in model.BagSecurities)
            {
                context.BagSecurities.Add(new BagSecurities
                {
                    BagId = bag.Id,
                    SecuritiesId = ed.Key,
                    Count = ed.Value.Item2,
                    Sum = ed.Value.Item3
                });

                context.SaveChanges();
            }

            return bag;
        }
    }
}
