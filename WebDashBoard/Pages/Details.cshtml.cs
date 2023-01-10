using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ConfigureLib;
using WebDashBoard.Data;

namespace WebDashBoard.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly WebDashBoard.Data.ConfigureItemContext _context;

        public DetailsModel(WebDashBoard.Data.ConfigureItemContext context)
        {
            _context = context;
        }

      public InvokerConfigItem InvokerConfigItem { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.InvokerConfigItem == null)
            {
                return NotFound();
            }

            var invokerconfigitem = await _context.InvokerConfigItem.FirstOrDefaultAsync(m => m.StartupIndex == id);
            if (invokerconfigitem == null)
            {
                return NotFound();
            }
            else 
            {
                InvokerConfigItem = invokerconfigitem;
            }
            return Page();
        }
    }
}
