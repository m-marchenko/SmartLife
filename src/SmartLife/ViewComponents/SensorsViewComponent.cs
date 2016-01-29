using Microsoft.AspNet.Mvc;
using SmartLife.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLife.ViewComponents
{
    [ViewComponent(Name = "Sensors")]
    public class SensorsViewComponent : ViewComponent
    {

        public IViewComponentResult Invoke(ICollection<ISensor> list)
        {
            return View(list);
        }
    }
}
