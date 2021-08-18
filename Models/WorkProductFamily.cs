using System;
using System.Collections.Generic;

#nullable disable

namespace LumiSourceApi.Models
{
    public partial class WorkProductFamily
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Abbr { get; set; }
        public string Descr { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? Sort { get; set; }
    }
}
