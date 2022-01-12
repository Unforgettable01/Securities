using SecuritiesBusinessLogic.BindingModels;
using SecuritiesBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SecuritiesBusinessLogic.Interfaces
{
    public interface IAgentStorage
    {
        List<AgentViewModel> GetFullList();
        List<AgentViewModel> GetFilteredList(AgentBindingModel model);
        AgentViewModel GetElement(AgentBindingModel model);
        void Insert(AgentBindingModel model);
        void Update(AgentBindingModel model);
        void Delete(AgentBindingModel model);
    }
}
