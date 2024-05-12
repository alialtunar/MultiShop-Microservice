using Microsoft.AspNetCore.Mvc;

namespace MultiShop.WebUi.ViewComponents.ProductListViewComponents
{
    public class _ProductListGetPrductCountComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
