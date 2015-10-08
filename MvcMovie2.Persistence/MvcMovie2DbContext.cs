using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using MvcMovie2.Domain;

namespace MvcMovie2.Persistence
{
    public class MvcMovie2DbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        public MvcMovie2DbContext()
        {
            Configuration.LazyLoadingEnabled = false;
        }  
    }
}
