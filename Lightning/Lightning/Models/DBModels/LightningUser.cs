using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lightning.Models.DBModels
{
    public class LightningUser : IdentityUser
    {
        public LightningUser()
        {
            this.Requests = new HashSet<Request>();
        }

        public ICollection<Request> Requests { get; set; }
    }
}
