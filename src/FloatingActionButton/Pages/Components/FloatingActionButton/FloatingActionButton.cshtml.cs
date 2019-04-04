using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.AspNetCore.Mvc.ViewComponents
{
    public class FloatingActionButton : ViewComponent
    {
        public FloatingActionButton() { }
        public IViewComponentResult Invoke(FloatingAction model)
        {
            return View("FloatingActionButton", model);
        }
    }
}
