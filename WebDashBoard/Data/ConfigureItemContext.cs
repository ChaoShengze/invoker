using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ConfigureLib;

namespace WebDashBoard.Data
{
    public class ConfigureItemContext : DbContext
    {
        public ConfigureItemContext (DbContextOptions<ConfigureItemContext> options)
            : base(options)
        {
        }

        public DbSet<ConfigureLib.InvokerConfigItem> InvokerConfigItem { get; set; } = default!;
    }
}
