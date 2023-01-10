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
    public class IndexModel : PageModel
    {
        private readonly WebDashBoard.Data.ConfigureItemContext _context;

        public IndexModel(WebDashBoard.Data.ConfigureItemContext context)
        {
            _context = context;
        }

        public IList<InvokerConfigItem> InvokerConfigItem { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.InvokerConfigItem != null)
            {
                InvokerConfigItem = await _context.InvokerConfigItem.ToListAsync();
            }
        }
    }
}
