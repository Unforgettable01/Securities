using SecuritiesBisinessLogic.BindingModels;
using SecuritiesBisinessLogic.Interfaces;
using SecuritiesBisinessLogic.ViewModels;
using System;
using System.Collections.Generic;

namespace SecuritiesBusinessLogic.BisinessLogics
{
    public class EmitentBusinessLogic
    {
        private readonly IEmitentStorage _EmitentStorage;
        public EmitentBusinessLogic(IEmitentStorage EmitentStorage)
        {
            _EmitentStorage = EmitentStorage;
        }
        public List<EmitentViewModel> Read(EmitentBindingModel model)
        {
            if (model == null)
            {
                return _EmitentStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<EmitentViewModel> { _EmitentStorage.GetElement(model) };
            }
            return _EmitentStorage.GetFilteredList(model);
        }
        public void Create(EmitentBindingModel model)
        {
            var element = _EmitentStorage.GetElement(new EmitentBindingModel
            {
                Id = model.Id
            });
            if (element != null && element.Id != model.Id)
            {
                throw new Exception("Уже есть такой эмитент");
            }
            if (model.Id.HasValue)
            {
                _EmitentStorage.Update(model);
            }
            else
            {
                _EmitentStorage.Insert(model);
            }

        }
        public void Delete(EmitentBindingModel model)
        {
            var element = _EmitentStorage.GetElement(new EmitentBindingModel
            {
                Id = model.Id
            });
            if (element == null)
            {
                throw new Exception("Эмитент не найден");
            }
            _EmitentStorage.Delete(model);
        }
    }
}
