using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ESystem.Models
{
    public class ResidentDetails
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Aadhar { get; set; }
      //  [Remote("IsResidentIdExist", "RWA", ErrorMessage = "Employee name already exist")]
 
        public string ResidentId { get; set; }
        public int VotingMembersId { get; set; }
        public VotingMembers VotingMembers { get; set; }
    }
}