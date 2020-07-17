using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace  Razor.Pages
{
   public class TeslaModel : PageModel
   {
        private readonly ILogger<TeslaModel> _logger;

        public TeslaModel(ILogger<TeslaModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}

