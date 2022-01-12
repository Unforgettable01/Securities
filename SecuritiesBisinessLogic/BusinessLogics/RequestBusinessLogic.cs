using SecuritiesBusinessLogic.BindingModels;
using SecuritiesBusinessLogic.ViewModels;
using SecuritiesBusinessLogic.Interfaces;
using System;
using System.Collections.Generic;

namespace SecuritiesBusinessLogic.BusinessLogics
{
    public class RequestBusinessLogic
    {
        private readonly IRequestStorage _requestStorage;
        public RequestBusinessLogic(IRequestStorage requestStorage)
        {
            _requestStorage = requestStorage;
        }
        public List<RequestViewModel> Read(RequestBindingModel model)
        {
            if (model == null)
            {
                return _requestStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<RequestViewModel> { _requestStorage.GetElement(model) };
            }
            return _requestStorage.GetFilteredList(model);
        }
        public void Create(RequestBindingModel model)
        {
            var element = _requestStorage.GetElement(new RequestBindingModel
            {
                Id = model.Id
            });
            if (element != null && element.Id != model.Id)
            {
                throw new Exception("Уже есть такая заявка");
            }
            if (model.Id.HasValue)
            {
                _requestStorage.Update(model);
            }
            else
            {
                _requestStorage.Insert(model);
            }

        }
        public void Delete(RequestBindingModel model)
        {
            var element = _requestStorage.GetElement(new RequestBindingModel
            {
                Id = model.Id
            });
            if (element == null)
            {
                throw new Exception("Заявка не найдена");
            }
            _requestStorage.Delete(model);
        }
    }
}
