using SecuritiesBusinessLogic.BindingModels;
using SecuritiesBusinessLogic.Interfaces;
using SecuritiesBusinessLogic.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SecuritiesDatabase.Implements
{
    public class AgentStorage : IAgentStorage
    {
        public List<AgentViewModel> GetFullList()
        {
            using (var context = new securitiesdbContext())
            {
                return context.Agent
                .Select(CreateModel).ToList();
            }
        }

        public List<AgentViewModel> GetFilteredList(AgentBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new securitiesdbContext())
            {
                return context.Agent
                    .Where(rec => rec.Id == model.Id)
                    .Select(CreateModel).ToList();
            }
        }

        public AgentViewModel GetElement(AgentBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new securitiesdbContext())
            {
                var agent = context.Agent
                .FirstOrDefault(rec => (rec.Id == model.Id) || (rec.Login == model.AgentLogin && rec.Password == model.AgentPassword));
                return agent != null ?
                CreateModel(agent) : null;
            }
        }

        public AgentViewModel GetAgentLP(AgentBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new securitiesdbContext())
            {
                var agent = context.Agent
                .FirstOrDefault(rec => rec.Login == model.AgentLogin && rec.Password == model.AgentPassword);
                return agent != null ?
                CreateModel(agent) : null;
            }
        }

        public void Insert(AgentBindingModel model)
        {
            using (var context = new securitiesdbContext())
            {
                context.Agent.Add(CreateModel(model, new Agent()));
                context.SaveChanges();
            }
        }

        public void Update(AgentBindingModel model)
        {
            using (var context = new securitiesdbContext())
            {
                Agent element = context.Agent.FirstOrDefault(rec => rec.Id == model.Id);
                if (element == null)
                {
                    throw new Exception("Элемент не найден");
                }
                CreateModel(model, element);
                context.SaveChanges();
            }
        }

        public void Delete(AgentBindingModel model)
        {
            using (var context = new securitiesdbContext())
            {
                Agent element = context.Agent.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    context.Agent.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
        }

        private Agent CreateModel(AgentBindingModel model, Agent agent)
        {
            agent.Fio = model.AgentName;
            agent.Login = model.AgentLogin;
            agent.Password = model.AgentPassword;
            return agent;
        }

        private AgentViewModel CreateModel(Agent agent)
        {
            return new AgentViewModel
            {
                Id = agent.Id,
                AgentName = agent.Fio,
                AgentLogin = agent.Login,
                AgentPassword = agent.Password
            };
        }
    }
}
