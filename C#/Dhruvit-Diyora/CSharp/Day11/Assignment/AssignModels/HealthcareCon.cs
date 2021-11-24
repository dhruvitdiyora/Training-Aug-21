using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Day11.AssignModels
{
    class HealthcareCon: DbContext
    {
        public HealthcareCon()
        {
        }

        public HealthcareCon(DbContextOptions<HealthcareCon> options)
            : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;database=HealthCare;User ID=dd;Password=12345; persist security info=True;");

        }
    }
}
