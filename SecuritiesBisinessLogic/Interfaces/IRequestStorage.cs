using SecuritiesBusinessLogic.BindingModels;
using SecuritiesBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SecuritiesBusinessLogic.Interfaces
{
    public interface IRequestStorage
    {
        List<RequestViewModel> GetFullList();
        List<RequestViewModel> GetFilteredList(RequestBindingModel model);
        RequestViewModel GetElement(RequestBindingModel model);
        List<RequestViewModel> GetFilteredRequestClient(int Id);
        RequestBindingModel GetrequestsForAgents(RequestBindingModel model);
        void Insert(RequestBindingModel model);
        void Update(RequestBindingModel model);
        void Delete(RequestBindingModel model);
    }
}
