using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS.EntityFramework
{
    public class SRSDbContextFactory : IDesignTimeDbContextFactory<SRSDbContext>
    {
        public SRSDbContext CreateDbContext(string[] args = null)
        {
            // ToDo: Add DbContext information for creating and migrating SQL database
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
