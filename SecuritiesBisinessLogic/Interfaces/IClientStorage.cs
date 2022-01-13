using SecuritiesBusinessLogic.BindingModels;
using SecuritiesBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SecuritiesBusinessLogic.Interfaces
{
    public interface IClientStorage
    {
        List<ClientViewModel> GetFullList();
        List<ClientViewModel> GetFilteredList(ClientBindingModel model);
        ClientViewModel GetElement(ClientBindingModel model);
        ClientViewModel GetClientLP(ClientBindingModel model);
        void Insert(ClientBindingModel model);
        void Update(ClientBindingModel model);
        void Delete(ClientBindingModel model);
    }
}
