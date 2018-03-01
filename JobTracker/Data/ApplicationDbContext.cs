// Chris Miller - DB Connection

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using JobTracker.Models;

namespace JobTracker.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //References to DB models
        public DbSet<Company> Company { get; set; }
        public DbSet<CompanyContact> CompanyContact { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Job> Job { get; set; }
        public DbSet<JobContact> JobContact { get; set; }
        public DbSet<Status> Status { get; set; }
    }
}


