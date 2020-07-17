using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace  Razor.Pages
{
   public class AppleModel : PageModel
   {
        private readonly ILogger<AppleModel> _logger;

        public AppleModel(ILogger<AppleModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}

