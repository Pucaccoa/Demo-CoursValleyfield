﻿using System.Web;
using System.Web.Mvc;

namespace Application_web_TEst
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
