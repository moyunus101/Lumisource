using System;
using System.Collections.Generic;

#nullable disable

namespace LumiSourceApi.Models
{
    public partial class WorkArSalesByMonth
    {
        public string AggregateType { get; set; }
        public bool AggregateIso { get; set; }
        public string AggregateSum { get; set; }
        public string CompanyCode { get; set; }
        public string WarehouseCode { get; set; }
        public string FamilyCode { get; set; }
        public string CustomerNo { get; set; }
        public int? ItemId { get; set; }
        public int Year { get; set; }
        public double? _01 { get; set; }
        public double? _02 { get; set; }
        public double? _03 { get; set; }
        public double? _04 { get; set; }
        public double? _05 { get; set; }
        public double? _06 { get; set; }
        public double? _07 { get; set; }
        public double? _08 { get; set; }
        public double? _09 { get; set; }
        public double? _10 { get; set; }
        public double? _11 { get; set; }
        public double? _12 { get; set; }
        public double? _13 { get; set; }
        public double? Total { get; set; }
        public long? WeeksActive { get; set; }
    }
}
