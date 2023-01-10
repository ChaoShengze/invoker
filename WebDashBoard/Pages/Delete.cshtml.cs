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
    public class DeleteModel : PageModel
    {
        private readonly WebDashBoard.Data.ConfigureItemContext _context;

        public DeleteModel(WebDashBoard.Data.ConfigureItemContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.InvokerConfigItem == null)
            {
                return NotFound();
            }
            var invokerconfigitem = await _context.InvokerConfigItem.FindAsync(id);

            if (invokerconfigitem != null)
            {
                InvokerConfigItem = invokerconfigitem;
                _context.InvokerConfigItem.Remove(InvokerConfigItem);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
