using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using TreblleApp.Models;

namespace TreblleApp.App_Start
{
    public class UserProfileConfig : EntityTypeConfiguration<UserProfileModel>
    {
        public UserProfileConfig() : base()
        {
            HasKey(p => p.UserName);
            ToTable("UserProfile");
        }
    }
}