using SecuritiesBisinessLogic.BindingModels;
using SecuritiesBisinessLogic.ViewModels;
using SecuritiesBusinessLogic.Interfaces;
using System;
using System.Collections.Generic;

namespace SecuritiesBusinessLogic.BisinessLogics
{
    public class SecurityBusinessLogic
    {
        private readonly ISecurityStorage _securityStorage;
        public SecurityBusinessLogic(ISecurityStorage securityStorage)
        {
            _securityStorage = securityStorage;
        }
        public List<SecurityViewModel> Read(SecurityBindingModel model)
        {
            if (model == null)
            {
                return _securityStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<SecurityViewModel> { _securityStorage.GetElement(model) };
            }
            return _securityStorage.GetFilteredList(model);
        }
        public void Create(SecurityBindingModel model)
        {
            var element = _securityStorage.GetElement(new SecurityBindingModel
            {
                Id = model.Id
            });
            if (element != null && element.Id != model.Id)
            {
                throw new Exception("Уже есть такая ценная бумага");
            }
            if (model.Id.HasValue)
            {
                _securityStorage.Update(model);
            }
            else
            {
                _securityStorage.Insert(model);
            }

        }
        public void Delete(SecurityBindingModel model)
        {
            var element = _securityStorage.GetElement(new SecurityBindingModel
            {
                Id = model.Id
            });
            if (element == null)
            {
                throw new Exception("Ценная бумага не найдена");
            }
            _securityStorage.Delete(model);
        }
    }
}
