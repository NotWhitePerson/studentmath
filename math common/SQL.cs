using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizsgaCommon
{
    public class SQL : DbContext
    {
        public static string ConnectionString { get; set; }

        public SQL() : base(new DbContextOptionsBuilder().UseSqlServer(ConnectionString).Options) { }

        public DbSet<LogEntry> Logs { get; set; }
    }
}
