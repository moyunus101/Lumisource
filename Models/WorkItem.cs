using System;
using System.Collections.Generic;

#nullable disable

namespace LumiSourceApi.Models
{
    public partial class WorkItem
    {
        public int Id { get; set; }
        public string LumisourceItemId { get; set; }
        public string LumisourceUniqueId { get; set; }
        public string LumisourceCollection { get; set; }
        public string LumisourceDescriptionLong { get; set; }
        public int? VendorId { get; set; }
        public string VendorItemId { get; set; }
        public string VendorDescription { get; set; }
        public string UpcId { get; set; }
        public string Status { get; set; }
        public int? ProductTypeId { get; set; }
        public int? ProductLineId { get; set; }
        public int? ProductFamilyId { get; set; }
        public int? ProductStyleId { get; set; }
        public int? ProductStyle2Id { get; set; }
        public int? ProductStyle3Id { get; set; }
        public string ProductCategoryId { get; set; }
        public string ProductCategorySubId { get; set; }
        public string Color { get; set; }
        public double? UnitPrice { get; set; }
        public double? UnitWeight { get; set; }
        public double? StdCost { get; set; }
        public double? DutyPct { get; set; }
        public double? DutyRate { get; set; }
        public double? AvgCost { get; set; }
        public double? FirstCostLocal { get; set; }
        public double? Overhead { get; set; }
        public double? FirstCost { get; set; }
        public double? CntRepackCost { get; set; }
        public string Hts { get; set; }
        public string CostNotes { get; set; }
        public string Notes { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public double? Srp { get; set; }
        public string CustomerItemId { get; set; }
        public double? OverheadPct { get; set; }
        public string ProductSpecs { get; set; }
        public string AdFeature { get; set; }
        public double? Ds { get; set; }
        public double? Trade { get; set; }
        public string WorkingItemId { get; set; }
        public int? CustomerId { get; set; }
        public string CustomerItemId2 { get; set; }
        public string CustomerDescription { get; set; }
        public string WorkingItemName { get; set; }
        public int? Sort { get; set; }
        public bool Replenish { get; set; }
        public int? CompanyId { get; set; }
        public int? WarehouseId { get; set; }
        public bool? ExplodeKit { get; set; }
        public string ProductCategorySubId2 { get; set; }
        public double? RestockPct { get; set; }
        public int? MinimumOrder { get; set; }
        public double? MfrLeadTime { get; set; }
        public double? RetailPrice { get; set; }
        public double? StandardPrice { get; set; }
        public string ItemType { get; set; }
        public int? IncoTermFobId { get; set; }
        public int? OriginPortId { get; set; }
        public int? PackTypeId { get; set; }
        public int? PackCount { get; set; }
        public int? FirstCostCurrencyId { get; set; }
        public double? FirstCostExchangeRate { get; set; }
        public int? NmfcId { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateFirstReceipt { get; set; }
        public int? InventoryCycleId { get; set; }
        public bool IsMas90Exported { get; set; }
        public DateTime? Mas90ExportedOn { get; set; }
        public int? CompanyId2 { get; set; }
        public int? CompanyId3 { get; set; }
        public bool UomChange { get; set; }
        public DateTime? WorkingItemDate { get; set; }
        public string WorkingItemDesigner { get; set; }
        public string PrimaryBin { get; set; }
        public DateTime? LeadTestValidUntil { get; set; }
        public DateTime? PkgTestValidUntil { get; set; }
        public string SalesNotes { get; set; }
        public int? CubicFeetPallet { get; set; }
        public DateTime? WorkingItemSetupDate { get; set; }
        public string AdCopyText { get; set; }
        public string AdInfo { get; set; }
        public string FirstCostCurrency { get; set; }
        public DateTime? DatePublished { get; set; }
        public string WebCategoryId { get; set; }
        public string WebCategorySubId { get; set; }
        public int? WebPublish { get; set; }
        public string WebNotes { get; set; }
        public string WebDates { get; set; }
        public bool WebCheck { get; set; }
        public DateTime? DateFirstPo { get; set; }
        public string BulkType { get; set; }
        public int? HoleMountId { get; set; }
        public int? HoleMount2Id { get; set; }
        public int? HoleMount3Id { get; set; }
    }
}
