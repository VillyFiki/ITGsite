using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITGSite.Models.Profile;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ITGSite.Controllers.Profile
{
    public class ProfileController : Controller
    {
        private UserContext db;
        public ProfileController(UserContext context)
        {
            db = context;
        }

        public IActionResult Index(string username)
        {
            User user = db.Users.Include(u => u.Profiles).FirstOrDefault(p => p.UserName == username);
            if (user != null)
            {
                if (User.Identity.Name == user.UserName)
                {
                    
                    return View("MyProfile", user.Profiles);
                }
                return View("Profile", user.Profiles);
            }
            return View("Profile");
        }
        public IActionResult Edit(UserProfile _profile)
        {
            UserProfile profile = db.Users.Include(u => u.Profiles).FirstOrDefault(u => u.UserName == User.Identity.Name).Profiles;
            if (profile != null)
            {
                profile.Age = _profile.Age;
                profile.Name = _profile.Name;
                db.SaveChanges();
            }
            return View("MyProfile", profile);
        }
    }
}
