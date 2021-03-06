﻿using System.Collections.Generic;
using System.Web.Mvc;

namespace DryIoc.Web.Mvc
{
    public class FilterProvider : IFilterProvider
    {
        public IEnumerable<Filter> GetFilters(ControllerContext controllerContext, ActionDescriptor actionDescriptor)
        {
            return FilterProviders.Providers.GetFilters(controllerContext, actionDescriptor);
        }
    }
}
