using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ConfigureLib;
using WebDashBoard.Data;

namespace WebDashBoard.Pages
{
    public class CreateModel : PageModel
    {
        private readonly WebDashBoard.Data.ConfigureItemContext _context;

        public CreateModel(WebDashBoard.Data.ConfigureItemContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public InvokerConfigItem InvokerConfigItem { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.InvokerConfigItem.Add(InvokerConfigItem);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
