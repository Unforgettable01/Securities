using SecuritiesBusinessLogic.BindingModels;
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
                    .Include(rec => rec.Agent)
                    .Include(rec => rec.Bag)
                    .ThenInclude(rec => rec.Client)
                    .ToList().Select(rec => new RequestViewModel
                    {
                        Id = rec.Id,
                        RequestDate = (DateTime)rec.Date,
                        RequestSum = (decimal)rec.Sum,
                        ClientName = rec.Bag.Client.Fio,
                        AgentName = rec.AgentId.HasValue ? rec.Agent.Fio : string.Empty,
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
                    .Include(rec => rec.Agent)
                    .Include(rec => rec.Bag)
                    .ThenInclude(rec => rec.Client)
                    .Where(rec => rec.Id.Equals(model.Id)).ToList()
                    .Select(rec => new RequestViewModel
                    {
                        Id = rec.Id,
                        RequestDate = (DateTime)rec.Date,
                        RequestSum = (decimal)rec.Sum,
                        ClientName = rec.Bag.Client.Fio,
                        AgentName = rec.AgentId.HasValue ? rec.Agent.Fio : string.Empty,
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
                    .Include(rec => rec.Agent)
                    .Include(rec => rec.Bag)
                    .ThenInclude(rec => rec.Client)
                    .FirstOrDefault(rec => rec.Id == model.Id);
                return request != null ?
                new RequestViewModel
                {
                    Id = request.Id,
                    RequestDate = (DateTime)request.Date,
                    RequestSum = (decimal)request.Sum,
                    ClientName = request.Bag.Client.Fio,
                    AgentName = request.AgentId.HasValue ? request.Agent.Fio : string.Empty,
                    BagId = request.Bag.Id
                } : null;
            }
        }
        public RequestBindingModel GetrequestsForAgents(RequestBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new securitiesdbContext())
            {
                var operation = context.Request
                    .Include(rec => rec.Agent)
                    .Include(rec => rec.Bag)
                .FirstOrDefault(rec => (rec.Id == model.Id) || (rec.AgentId == model.AgentId));
                return operation != null ?
                CreateModele(operation) : null;
            }
        }
        public void Insert(RequestBindingModel model)

        public List<RequestViewModel> GetFilteredRequestClient(int Id)
        {
            using (var context = new securitiesdbContext())
            {
                return context.Request
                    .Include(rec => rec.Agent)
                    .Include(rec => rec.Bag)
                    .ThenInclude(rec => rec.Client)
                    .Where(rec => rec.Bag.ClientId == Id).ToList()
                    .Select(rec => new RequestViewModel
                    {
                        Id = rec.Id,
                        RequestDate = (DateTime)rec.Date,
                        RequestSum = (decimal)rec.Sum,
                        ClientName = rec.Bag.Client.Fio,
                        AgentName = rec.AgentId.HasValue ?
                        rec.Agent.Fio : string.Empty,
                        BagId = rec.Bag.Id
                    }).ToList();
            }
        }

        public void Insert(RequestBindingModel model)
        {
            using (var context = new securitiesdbContext())
            {
                context.Request.Add(CreateModel(model, new Request()));
                context.SaveChanges();
            }
        }

        public void Update(RequestBindingModel model)
        {
            using (var context = new securitiesdbContext())
            {
                Request request = context.Request.FirstOrDefault(rec => rec.Id == model.Id);
                if (request == null)
                {
                    throw new Exception("Элемент не найден");
                }
                CreateModel(model, request);
                context.SaveChanges();
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

        private Request CreateModel(RequestBindingModel model, Request request)
        {
            request.Date = model.RequestDate;
            request.Sum = model.RequestSum;
            request.BagId = model.BagId;

            return request;
        }

        private RequestBindingModel CreateModele(Request request)
        {
            return new RequestBindingModel
            {
                Id = request.Id,
                RequestDate = (DateTime)request.Date,
                RequestSum = (decimal)request.Sum,
                AgentId = (int)request.AgentId,
                BagId = (int)request.BagId
            };
        }
    }
}
