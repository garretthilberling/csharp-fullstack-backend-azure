using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TreblleApp.Models;

namespace TreblleApp
{
    public class UserProfileDBContext : IdentityDbContext<UserProfileModel>
    {
        public UserProfileDBContext()
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}