﻿using Microsoft.AspNetCore.Mvc;

namespace MultiShop.WebUi.ViewComponents.DefaultViewComponents
{
    public class _SpecialOfferComponentPartial:ViewComponent
    {
         public IViewComponentResult Invoke()
        {
            return View();  
        }
    }
}
