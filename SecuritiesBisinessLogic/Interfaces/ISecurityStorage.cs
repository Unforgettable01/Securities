using SecuritiesBisinessLogic.BindingModels;
using SecuritiesBisinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SecuritiesBusinessLogic.Interfaces
{
    public interface ISecurityStorage
    {
        List<SecurityViewModel> GetFullList();
        List<SecurityViewModel> GetFilteredList(SecurityBindingModel model);
        SecurityViewModel GetElement(SecurityBindingModel model);
        void Insert(SecurityBindingModel model);
        void Update(SecurityBindingModel model);
        void Delete(SecurityBindingModel model);
    }
}
