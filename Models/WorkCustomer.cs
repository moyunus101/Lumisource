using System;
using System.Collections.Generic;

#nullable disable

namespace LumiSourceApi.Models
{
    public partial class WorkCustomer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress1 { get; set; }
        public string CustomerAddress2 { get; set; }
        public string CustomerAddress3 { get; set; }
        public string CustomerCity { get; set; }
        public string CustomerState { get; set; }
        public string CustomerZip { get; set; }
        public string CustomerCountry { get; set; }
        public string CustomerNo { get; set; }
        public string TelephoneNo { get; set; }
        public string TelephoneExt { get; set; }
        public string FaxNo { get; set; }
        public string EmailAddress { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string TermsCode { get; set; }
        public string SalespersonNo { get; set; }
        public string SalespersonNo2 { get; set; }
        public string SalespersonNo3 { get; set; }
        public string SalespersonNo4 { get; set; }
        public string SalespersonNo5 { get; set; }
        public DateTime? DateLastActivity { get; set; }
        public DateTime? DateLastPayment { get; set; }
        public string CustomerNoLum { get; set; }
        public string CustomerNoLdi { get; set; }
        public string CustomerNoLca { get; set; }
        public bool? UsesProductUpload { get; set; }
        public double? EblastAllocationPercent { get; set; }
        public int? UploadFormatId { get; set; }
        public int? UploadRouteId { get; set; }
        public string CustomerUploadName { get; set; }
        public int CompanyId { get; set; }
        public bool? ItemCustomer { get; set; }
        public bool? ViewCustomer { get; set; }
        public string CompanyCode { get; set; }
        public string UploadInformation { get; set; }
        public string CustomerUrl { get; set; }
        public bool? WebCustomer { get; set; }
        public bool? LeadCustomer { get; set; }
    }
}
