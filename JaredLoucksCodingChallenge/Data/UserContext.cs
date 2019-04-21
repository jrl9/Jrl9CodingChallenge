using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace JaredLoucksCodingChallenge.Data
{
    public class UserContext : DbContext
    {
        public UserContext() : base("DefaultConnection")
        { }

        public DbSet<JaredLoucksCodingChallenge.Models.User> Users { get; set; }
        public DbSet<JaredLoucksCodingChallenge.Models.Project> Projects { get; set; }
    }
}