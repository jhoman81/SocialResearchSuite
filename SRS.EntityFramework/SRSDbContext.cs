﻿using Microsoft.EntityFrameworkCore;
using SRS.Domain.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS.EntityFramework
{
    public class SRSDbContext : DbContext
    {
        public SRSDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users {  get; set; }
        public DbSet<Project> Projects {  get; set; }
        public string DbPath { get; set; }

        /* public SRSDbContext()
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string path = Path.Combine(folder, "SocialResearchSuite");

            Directory.CreateDirectory(path); // Create directory if it doesnt exist

            DbPath = $"{path}{System.IO.Path.DirectorySeparatorChar}srsdata.db";
        } 
        

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}"); */
    }
}
