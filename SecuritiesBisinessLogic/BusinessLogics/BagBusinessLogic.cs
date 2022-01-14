using SecuritiesBusinessLogic.BindingModels;
using SecuritiesBusinessLogic.Interfaces;
using SecuritiesBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SecuritiesBusinessLogic.BusinessLogics
{
    public class BagBusinessLogic
    {
        private readonly IBagStorage _bagStorage;
        public BagBusinessLogic(IBagStorage bagStorage)
        {
            _bagStorage = bagStorage;
        }
        public List<BagViewModel> Read(BagBindingModel model)
        {
            if (model == null)
            {
                return _bagStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<BagViewModel> { _bagStorage.GetElement(model) };
            }
            return _bagStorage.GetFilteredList(model);
        }
        public List<BagViewModel> GetFiltredBag(BagBindingModel model)
        {
            return _bagStorage.GetFilteredBag(model);
        }
        public void Create(BagBindingModel model)
        {
            var element = _bagStorage.GetElement(new BagBindingModel
            {
                Id = model.Id
            });
            if (element != null && element.Id != model.Id)
            {
                throw new Exception("Уже есть такой агент");
            }
            if (model.Id.HasValue)
            {
                _bagStorage.Update(model);
            }
            else
            {
                _bagStorage.Insert(model);
            }

        }
        public void Delete(BagBindingModel model)
        {
            var element = _bagStorage.GetElement(new BagBindingModel
            {
                Id = model.Id
            });
            if (element == null)
            {
                throw new Exception("Агент не найден");
            }
            _bagStorage.Delete(model);
        }
    }
}
