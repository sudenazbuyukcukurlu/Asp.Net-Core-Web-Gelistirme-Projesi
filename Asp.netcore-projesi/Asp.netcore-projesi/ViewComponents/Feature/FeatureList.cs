using Microsoft.AspNetCore.Mvc;

namespace Asp.netcore_projesi.ViewComponents.Feature
{
    public class FeatureList: ViewComponent
    {
        public IViewComponentResult Invoke( )
        {
            return View();
        }
    }
}
