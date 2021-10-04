using Microsoft.EntityFrameworkCore;
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
        public DbSet<User> Users {  get; set; }
        public DbSet<Project> Projects {  get; set; }
        public DbSet<Community> Communities { get; set; }
        public DbSet<Event> Events {  get; set; }   
        public DbSet<Fact> Facts {  get; set; } 
        public DbSet<Family> Families {  get; set; }
        public DbSet<Household> Households { get; set; }
        public DbSet<Media> Media {  get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Place> Places { get; set; }
        public DbSet<Reference> References {  get; set; }   
        public DbSet<Relation> Relations {  get; set; }
        public string DbPath { get; set; }
        public SRSDbContext(DbContextOptions options) : base(options) { }

        // protected override void OnConfiguring(DbContextOptionsBuilder options)
        //    => options.UseSqlite($"Data Source={DbPath}"); 
    }
}
