using System;
using System.Collections.Generic;

#nullable disable

namespace LumiSourceApi.Models
{
    public partial class WorkImAggregate
    {
        public string AggregateType { get; set; }
        public bool AggregateIso { get; set; }
        public string TransactionCode { get; set; }
        public string CompanyCode { get; set; }
        public string WarehouseCode { get; set; }
        public string FamilyCode { get; set; }
        public int? ItemId { get; set; }
        public int? Year { get; set; }
        public int Month { get; set; }
        public int? Week { get; set; }
        public int? Repeat { get; set; }
        public int Quantity { get; set; }
        public decimal AvgCost { get; set; }
        public decimal AvgPrice { get; set; }
        public decimal TotalCost { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
