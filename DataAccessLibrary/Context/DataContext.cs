using DataAccessLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Context
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<PageGroup> PageGroups { get; set; }
        public DbSet<Page> Pages { get; set; }

        public DbSet<PageComment> PageComments { get; set; }

        public DbSet<InformationForm> InformationForms { get; set; }
    }
}
