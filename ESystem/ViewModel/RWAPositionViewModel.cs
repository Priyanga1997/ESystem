using ESystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ESystem.ViewModel
{
    public class RWAPositionViewModel
    {
       public IEnumerable<PositionForElections> PositionForElections { get; set; }
        public Registration Registration { get; set; }
    }
}