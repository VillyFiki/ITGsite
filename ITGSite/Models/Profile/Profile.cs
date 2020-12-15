using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ITGSite.Models.Profile
{
    public class UserProfile
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Unknow";
        public int Age { get; set; } = 0;
        public int UsersId { get; set; }
        public virtual User Users { get; set; }
    }
}
