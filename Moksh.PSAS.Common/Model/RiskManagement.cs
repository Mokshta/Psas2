using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Moksh.PSAS.Common.Model
{
    public class RiskManagement
    {
        public int OrgID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int SourceType { get; set; }
        public string SourceDetail { get; set; }
        public string Background { get; set; }
       // public varbinary Attachment { get; set; } // Attachment data type?
        public string Remarks { get; set; }
        public int OpportunityOrThreat { get; set; }
        public int Stage { get; set; }
        public int Status { get; set; }
        public int RevealIdentity { get; set; }
        public string Notes { get; set; }
        public int Category { get; set; }
        public int SubCategory { get; set; }
        public int InternalOrExternal { get; set; }
        public int ImpactedOrganization { get; set; }
        public int Level { get; set; }
        public int RiskOwnerId { get; set; }
        public string RiskOwnderName { get; set; }
        public string RiskOwnderEmailID { get; set; }
        public int SMEID { get; set; }
        public string SMEName { get; set; }
        public string SMEEmailID { get; set; }
        public int Probability { get; set; }
        public int Impact { get; set; }
        public int Priority { get; set; }
        public int InherentRikScore { get; set; }
        public string InherentRiskGrading { get; set; }






    }
}
