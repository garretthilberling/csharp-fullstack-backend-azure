using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using TreblleApp.Models;

namespace TreblleApp.Controllers
{
    [Authorize]
    [Route("API/UserProfile")]
    public class UserProfileController : ApiController
    {

        // GET: api/UserProfile/userName
        public string Get(string userName)
        {
            using(var context = new UserProfileDBContext())
            {
                var query = context.Users.FirstOrDefault(s => s.UserName == userName);
                return query == null ? "" : query.ProfileImage;
            }
        }

        // POST: api/UserProfile
        // upload profile image
        public IHttpActionResult Post([FromBody] UserProfileModel UserProfile)
        {
            using(var db = new UserProfileDBContext())
            {
                var result = db.Users.SingleOrDefault(b => b.UserName == UserProfile.UserName);
                if(result != null)
                {
                    result.ProfileImage = UserProfile.ProfileImage;
                    db.SaveChanges();
                }

                return Ok(); // will return status 200
            }
        }
    }
}
