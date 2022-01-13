using SecuritiesBusinessLogic.BindingModels;
using SecuritiesBusinessLogic.Interfaces;
using SecuritiesBusinessLogic.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SecuritiesDatabase.Implements
{
    public class ClientStorage : IClientStorage
    {
        public List<ClientViewModel> GetFullList()
        {
            using (var context = new securitiesdbContext())
            {
                return context.Client
                .Select(CreateModel).ToList();
            }
        }

        public List<ClientViewModel> GetFilteredList(ClientBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new securitiesdbContext())
            {
                return context.Client
                    .Where(rec => rec.Id == model.Id)
                    .Select(CreateModel).ToList();
            }
        }

        public ClientViewModel GetElement(ClientBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new securitiesdbContext())
            {
                var client = context.Client
                .FirstOrDefault(rec => (rec.Id == model.Id) || (rec.Login == model.ClientLogin && rec.Password == model.ClientPassword));
                return client != null ?
                CreateModel(client) : null;
            }
        }

        public ClientViewModel GetClientLP(ClientBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new securitiesdbContext())
            {
                var client = context.Client
                .FirstOrDefault(rec => rec.Login == model.ClientLogin && rec.Password == model.ClientPassword);
                return client != null ?
                CreateModel(client) : null;
            }
        }

        public void Insert(ClientBindingModel model)
        {
            using (var context = new securitiesdbContext())
            {
                context.Client.Add(CreateModel(model, new Client()));
                context.SaveChanges();
            }
        }

        public void Update(ClientBindingModel model)
        {
            using (var context = new securitiesdbContext())
            {
                Client element = context.Client.FirstOrDefault(rec => rec.Id == model.Id);
                if (element == null)
                {
                    throw new Exception("Элемент не найден");
                }
                CreateModel(model, element);
                context.SaveChanges();
            }
        }

        public void Delete(ClientBindingModel model)
        {
            using (var context = new securitiesdbContext())
            {
                Client element = context.Client.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    context.Client.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
        }

        private Client CreateModel(ClientBindingModel model, Client client)
        {
            client.PassportNumber = model.PassportNumber;
            client.Fio = model.ClientName;
            client.Login = model.ClientLogin;
            client.Password = model.ClientPassword;
            return client;
        }

        private ClientViewModel CreateModel(Client client)
        {
            return new ClientViewModel
            {
                Id = client.Id,
                PassportNumber = client.PassportNumber,
                ClientName = client.Fio,
                ClientLogin = client.Login,
                ClientPassword = client.Password
            };
        }
    }
}
