using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eticaret.Data.Context.Extensions
{
    public static class SeviceCollectionExtensions
    {
        public static void AddDataBaseContext(IServiceCollection services,string connectionString)
        {
            services.AddDbContext<ETicaretDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });
            services.AddScoped<DbContext, ETicaretDbContext>();
        }
    }
}
