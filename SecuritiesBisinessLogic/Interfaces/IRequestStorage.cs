﻿using SecuritiesBisinessLogic.BindingModels;
using SecuritiesBisinessLogic.ViewLogics;
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
        void Insert(RequestBindingModel model);
        void Update(RequestBindingModel model);
        void Delete(RequestBindingModel model);
    }
}
