using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LumiSourceApi.Models
{
    public class Grid1ResultSet
    {
        public int? Id { get; set; }
        public string LumisourceItemId { get; set; }
        public string LumisourceCollection { get; set; }
        public string LumisourceDescriptionLong { get; set; }
        public string UpcId { get; set; }
        public int? VendorId { get; set; }
        public string Family { get; set; }
        public string  Style { get; set; }
        public string  VendorNumber { get; set; }
       // public int? VendorItemId { get; set; }
        public double? GrossSales { get; set; }
        public double? GrossRevenue { get; set; }
        /* w.id
	  ,[LumisourceItemId]
      ,[LumisourceCollection]
      ,[LumisourceDescriptionLong]
	  ,[UpcId]
      ,w.VendorId
	  ,f.Name as Family
	  ,s.Name as Style
	  ,v.VendorNumber
      ,[VendorItemId]
	  ,GrossSales=a.Total*w.UnitPrice
	  ,GrossRevenue=a.Total
*/
    }
}
