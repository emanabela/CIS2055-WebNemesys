using Microsoft.EntityFrameworkCore;
using Nemesys.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nemesys.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }
        //public DbSet<NemesysUser> NemesysUsers { get; set; }
    }
}
