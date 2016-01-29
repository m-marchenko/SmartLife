using Microsoft.AspNet.Mvc;
using SmartLife.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLife.ViewComponents
{
    [ViewComponent(Name = "CompositeObject")]
    public class CompositeObjectViewComponent : ViewComponent
    {
        public CompositeObjectViewComponent()
        {

        }


        public IViewComponentResult Invoke(ICompositeObject obj)
        {
            return View(obj);
        }
    }
}
