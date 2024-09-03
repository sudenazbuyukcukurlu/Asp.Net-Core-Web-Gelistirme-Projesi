using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.netcore_projesi.ViewComponents.Feature
{
    public class FeatureList: ViewComponent
    {
        FeatureManager featuremanager = new FeatureManager(new EfFeatureDal());
        public IViewComponentResult Invoke( )
        {
            var values = featuremanager.TGetList();
            return View(values);
        }
    }
}
