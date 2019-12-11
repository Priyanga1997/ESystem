using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ESystem.Models
{
    public class RWAModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string EducationDetails { get; set; }
        public string OccupationDetails { get; set; }
        public bool PreviousRWAMember { get; set; }
        public bool PartOfGovOrNgoOrPolice { get; set; }
        public bool CriminalRecord { get; set; }
        public int PositionForElectionsId { get; set; }
        public PositionForElections PositionForElections { get; set; }
    }
}