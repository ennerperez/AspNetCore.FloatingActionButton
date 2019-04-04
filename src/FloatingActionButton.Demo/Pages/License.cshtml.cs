using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FloatingActionButton.Demo.Pages
{
    public class LicenseModel : PageModel
    {
        public void OnGet()
        {

            try
            {
                var path = System.IO.Path.Combine("..", "..", "LICENSE");
                License = System.IO.File.ReadAllText(path);
            }
            catch (Exception ex)
            {
                License = ex.Message;
            }
        }

        public string License { get; private set; }
    }
}