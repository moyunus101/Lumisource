using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LumiSourceApi.Models
{
    public class ActivityDetail
    {
		public int? id { get; set; }
		public string LumisourceItemId { get; set; }
		public int? UnitsInInventory { get; set; }
		public int? UnitsSold { get; set; }
		public double? RevenueByMonth { get; set; }
		public string CustomerNo { get; set; }
		public double? JanToDec { get; set; }
		public double? Total2018 { get; set; }
		public long? Weeksactive { get; set; }
		public bool status { get; set; }
		public string gonogo { get; set; }
		public double? SalesProjections { get; set; }
	}
}

 