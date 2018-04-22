using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Moksh.PSAS.WebApp.Models
{
    public class RiskIdentified
    {

        public int OrgID { get; set; }
        [Required(ErrorMessage = "Please enter a title")]
        public string Title { get; set; }
        public string Description { get; set; }
        [Required(ErrorMessage = "Please select a source type")]
        public int SourceType { get; set; }
        public string SourceDetail { get; set; }
        public bool OpportunityOrThreat { get; set; }


    }
}