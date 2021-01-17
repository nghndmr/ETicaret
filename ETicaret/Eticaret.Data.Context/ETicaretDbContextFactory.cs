using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eticaret.Data.Context
{
    public class ETicaretDbContextFactory : IDesignTimeDbContextFactory<ETicaretDbContext>
    {
        public ETicaretDbContext CreateDbContext(string[] args)
        {
            var cs = "Server =.; Database = ETicaret; UserId = sa; Password = 1q2w3e4R!";
            var builder = new DbContextOptionsBuilder().UseSqlServer(cs);
            return new ETicaretDbContext(builder.Options);
        }
    }
}
