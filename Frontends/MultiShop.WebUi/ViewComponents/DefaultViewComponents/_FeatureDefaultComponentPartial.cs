﻿using Microsoft.AspNetCore.Mvc;

namespace MultiShop.WebUi.ViewComponents.DefaultViewComponents
{
    public class _FeatureDefaultComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
