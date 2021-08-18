using System;
using System.Collections.Generic;

#nullable disable

namespace LumiSourceApi.Models
{
    public partial class WorkVendor
    {
        public int VendorId { get; set; }
        public string VendorName { get; set; }
        public string VendorAddress { get; set; }
        public string VendorAddress2 { get; set; }
        public string VendorAddress3 { get; set; }
        public string VendorCity { get; set; }
        public string VendorState { get; set; }
        public string VendorZip { get; set; }
        public string VendorCountry { get; set; }
        public string VendorIso { get; set; }
        public string ImgUrl { get; set; }
        public string InvitationCode { get; set; }
        public string VendorNumber { get; set; }
        public string MailingAddress { get; set; }
        public string Tel1 { get; set; }
        public string Tel2 { get; set; }
        public string Fax1 { get; set; }
        public string Fax2 { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public string Mobile1 { get; set; }
        public string Contact1 { get; set; }
        public string Contact2 { get; set; }
        public string VendorName2 { get; set; }
        public string VendorAddress2A { get; set; }
        public string VendorAddress2B { get; set; }
        public string VendorCityProv2 { get; set; }
        public string VendorCountry2 { get; set; }
        public string Email3 { get; set; }
        public string Mobile2 { get; set; }
        public string Mobile3 { get; set; }
        public string Contact3 { get; set; }
        public string VendorType { get; set; }
        public string VendorZip2 { get; set; }
        public string VendorIso2 { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string BankNotes1 { get; set; }
        public string BankNotes2 { get; set; }
        public string AddressNotes1 { get; set; }
        public string AddressNotes2 { get; set; }
        public string VendorNickName { get; set; }
        public double? VendorDeposit { get; set; }
        public short? VendorDepositDays { get; set; }
        public string VendorDepositType { get; set; }
        public double? VendorBalance { get; set; }
        public short? VendorBalanceDays { get; set; }
        public string VendorBalanceType { get; set; }
        public string PaymentTermsText { get; set; }
        public bool IsSycVendor { get; set; }
        public string DefaultCurrency { get; set; }
    }
}
