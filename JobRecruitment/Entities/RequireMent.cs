using System;
using System.Collections.Generic;

namespace JobRecruitment.Entities
{
    public partial class RequireMent
    {
        public Guid RequireMentId { get; set; }
        public string Education { get; set; }
        public string Welfare { get; set; }
    }
}
