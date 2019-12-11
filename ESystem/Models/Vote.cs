using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ESystem.Models
{
    public class Vote
    {
        public int Id { get; set; }
        public int RegistrationId { get; set; }
        public Registration Registration { get; set; }
    }
}