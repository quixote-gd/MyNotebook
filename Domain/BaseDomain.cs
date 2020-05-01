using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class BaseDomain
    {
        public DateTime? ModifiedDate {get; set;}
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string CreatedBy { get; set; }
    }
}
