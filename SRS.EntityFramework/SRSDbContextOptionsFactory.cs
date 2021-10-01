using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS.EntityFramework
{
    class SRSDbContextOptionsFactory : IDesignTimeDbContextFactory<SRSDbContext>
    {
        public SRSDbContext CreateDbContext(string[] args)
        {
            var options = new DbContextOptionsBuilder<SRSDbContext>();
            
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string path = Path.Combine(folder, "SocialResearchSuite");

            Directory.CreateDirectory(path); // Create directory if it doesnt exist

            var DbPath = $"{path}{System.IO.Path.DirectorySeparatorChar}srsdata.db";

            options.UseSqlite($"Data Source={DbPath}");

            return new SRSDbContext(options.Options);
        } 
    }
}
