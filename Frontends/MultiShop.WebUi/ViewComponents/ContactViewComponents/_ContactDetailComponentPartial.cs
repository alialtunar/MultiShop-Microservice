using Microsoft.AspNetCore.Mvc;

namespace MultiShop.WebUi.ViewComponents.ContactViewComponents
{
    public class _ContactDetailComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();  
        }
    }
}
