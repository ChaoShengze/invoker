using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ConfigureLib;
using WebDashBoard.Data;

namespace WebDashBoard.Pages
{
    public class EditModel : PageModel
    {
        private readonly WebDashBoard.Data.ConfigureItemContext _context;

        public EditModel(WebDashBoard.Data.ConfigureItemContext context)
        {
            _context = context;
        }

        [BindProperty]
        public InvokerConfigItem InvokerConfigItem { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.InvokerConfigItem == null)
            {
                return NotFound();
            }

            var invokerconfigitem =  await _context.InvokerConfigItem.FirstOrDefaultAsync(m => m.StartupIndex == id);
            if (invokerconfigitem == null)
            {
                return NotFound();
            }
            InvokerConfigItem = invokerconfigitem;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(InvokerConfigItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InvokerConfigItemExists(InvokerConfigItem.StartupIndex))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool InvokerConfigItemExists(int id)
        {
          return _context.InvokerConfigItem.Any(e => e.StartupIndex == id);
        }
    }
}
