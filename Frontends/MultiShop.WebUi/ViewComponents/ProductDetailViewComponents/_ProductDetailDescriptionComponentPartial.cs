using Microsoft.AspNetCore.Mvc;

namespace MultiShop.WebUi.ViewComponents.ProductDetailViewComponents
{
    public class _ProductDetailDescriptionComponentPartial:ViewComponent
    {
      public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
