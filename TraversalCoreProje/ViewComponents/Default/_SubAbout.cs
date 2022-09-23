using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProje.ViewComponents.Default
{
    public class _SubAbout:ViewComponent
    {
        SubAboutManager SubAboutManager = new SubAboutManager(new EfSubAboutDal()); //Refactoring yapılacak ve bağımlılıklar ortadan kalkacaktır.
        public IViewComponentResult Invoke()
        {
            var values = SubAboutManager.TGetList();
            return View(values);
        }
    }
}
