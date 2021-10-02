using SRS.Domain.Models;
using SRS.Domain.Services;
using SRS.EntityFramework;
using SRS.EntityFramework.Services;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IDataService<User> userService = new GenericDataService<User>(new SRSDbContextFactory());
            userService.Create(new User { Username = "Test" }).Wait();
        }
    }
}
