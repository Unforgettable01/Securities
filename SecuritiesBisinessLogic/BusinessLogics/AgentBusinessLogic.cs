using SecuritiesBusinessLogic.BindingModels;
using SecuritiesBusinessLogic.Interfaces;
using SecuritiesBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;

namespace SecuritiesBusinessLogic.BusinessLogics
{
    public class AgentBusinessLogic
    {
        private readonly IAgentStorage _agentStorage;
        public AgentBusinessLogic(IAgentStorage agentStorage)
        {
            _agentStorage = agentStorage;
        }
        public List<AgentViewModel> Read(AgentBindingModel model)
        {
            if (model == null)
            {
                return _agentStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<AgentViewModel> { _agentStorage.GetElement(model)};
            }
            return _agentStorage.GetFilteredList(model);
        }
        public void Create(AgentBindingModel model)
        {
            var element = _agentStorage.GetElement(new AgentBindingModel
            {
                Id = model.Id
            });
            if (element != null && element.Id != model.Id)
            {
                throw new Exception("Уже есть такой агент");
            }
            if (model.Id.HasValue)
            {
                _agentStorage.Update(model);
            }
            else
            {
                _agentStorage.Insert(model);
            }

        }
        public void Delete(AgentBindingModel model)
        {
            var element = _agentStorage.GetElement(new AgentBindingModel
            {
                Id = model.Id
            });
            if (element == null)
            {
                throw new Exception("Агент не найден");
            }
            _agentStorage.Delete(model);
        }
    }
}
