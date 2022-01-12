﻿using SecuritiesBusinessLogic.BindingModels;
using SecuritiesBusinessLogic.Interfaces;
using SecuritiesBusinessLogic.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SecuritiesDatabase.Implements
{
    public class RequestStorage : IRequestStorage
    {
        public List<RequestViewModel> GetFullList()
        {
            using (var context = new securitiesdbContext())
            {
                return context.Request
                    .Include(rec => rec.Client)
                    .Include(rec => rec.Agent)
                    .Include(rec => rec.Bag)
                    .ToList().Select(rec => new RequestViewModel
                    {
                        Id = rec.Id,
                        RequestDate = (DateTime)rec.Date,
                        RequestSum = (decimal)rec.Sum,
                        ClientName = rec.Client.Fio,
                        AgentName = rec.Agent.Fio,
                        BagId = rec.Bag.Id
                    }).ToList();
            }
        }

        public List<RequestViewModel> GetFilteredList(RequestBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new securitiesdbContext())
            {
                return context.Request
                    .Include(rec => rec.Client)
                    .Include(rec => rec.Agent)
                    .Include(rec => rec.Bag)
                    .Where(rec => rec.Id.Equals(model.Id)).ToList()
                    .Select(rec => new RequestViewModel
                    {
                        Id = rec.Id,
                        RequestDate = (DateTime)rec.Date,
                        RequestSum = (decimal)rec.Sum,
                        ClientName = rec.Client.Fio,
                        AgentName = rec.Agent.Fio,
                        BagId = rec.Bag.Id
                    }).ToList();
            }
        }

        public RequestViewModel GetElement(RequestBindingModel model)
        {
            if (model == null)
            {
                return null;
            }

            using (var context = new securitiesdbContext())
            {
                var request = context.Request
                    .Include(rec => rec.Client)
                    .Include(rec => rec.Agent)
                    .Include(rec => rec.Bag)
                    .FirstOrDefault(rec => rec.Id == model.Id);
                return request != null ?
                new RequestViewModel
                {
                    Id = request.Id,
                    RequestDate = (DateTime)request.Date,
                    RequestSum = (decimal)request.Sum,
                    ClientName = request.Client.Fio,
                    AgentName = request.Agent.Fio,
                    BagId = request.Bag.Id
                } : null;
            }
        }

        public void Insert(RequestBindingModel model)
        {
            using (var context = new securitiesdbContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        CreateModel(model, new Request(), context);
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

        public void Update(RequestBindingModel model)
        {
            using (var context = new securitiesdbContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var element = context.Request.FirstOrDefault(rec => rec.Id == model.Id);

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

        public void Delete(RequestBindingModel model)
        {
            using (var context = new securitiesdbContext())
            {
                Request element = context.Request.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    context.Request.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
        }

        private Request CreateModel(RequestBindingModel model, Request request, securitiesdbContext context)
        {
            request.Date = model.RequestDate;
            request.Sum = model.RequestSum;
            request.ClientId = model.ClientId;
            request.AgentId = model.AgentId;
            request.BagId = model.BagId;

            return request;
        }
    }
}
