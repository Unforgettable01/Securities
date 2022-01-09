using SecuritiesBisinessLogic.BindingModels;
using SecuritiesBisinessLogic.ViewLogics;
using System;
using System.Collections.Generic;
using System.Text;

namespace SecuritiesBisinessLogic.Interfaces
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
