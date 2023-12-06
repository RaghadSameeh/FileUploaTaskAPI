using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;

namespace DataAccessLayer.Data
{
    public class Context :DbContext
    {
        public Context()
        {
            
        }

        public Context (DbContextOptions<Context> options) :base(options) { }
        public DbSet<DataFile> Data { get; set; }

    }
}
