using HomeWork.DL.EFContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HomeWork.DL.DBContext
{
    public class HomeWorkDBFactory : IDesignTimeDbContextFactory<HomeWorkDBContext>
    {
        public HomeWorkDBContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsetting.json")
                .Build();

            var connectionString = configuration.GetConnectionString("HomeWorkDatabase");

            var optionsBuilder = new DbContextOptionsBuilder<HomeWorkDBContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new HomeWorkDBContext(optionsBuilder.Options);
        }
    }
}
