using System;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace LumiSourceApi.Models
{
    public partial class LumisourceContext : DbContext
    {
        public LumisourceContext()
        {
        }

        public LumisourceContext(DbContextOptions<LumisourceContext> options)
            : base(options)
        {
        }

        public virtual DbSet<WorkArSalesByMonth> WorkArSalesByMonths { get; set; }
        public virtual DbSet<WorkCustomer> WorkCustomers { get; set; }
        public virtual DbSet<WorkImAggregate> WorkImAggregates { get; set; }
        public virtual DbSet<WorkItem> WorkItems { get; set; }
        public virtual DbSet<WorkProductFamily> WorkProductFamilies { get; set; }
        public virtual DbSet<WorkProductLine> WorkProductLines { get; set; }
        public virtual DbSet<WorkProductStyle> WorkProductStyles { get; set; }
        public virtual DbSet<WorkVendor> WorkVendors { get; set; }
        public virtual DbSet<Grid1ResultSet> Grid1ResultSets { get; set; }
        public virtual DbSet<ActivityDetail> ActivityDetails { get; set; }
         
         
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //this connection string will be needed if migration etc will be done
                string connString = "";
                optionsBuilder.UseSqlServer(connString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<WorkArSalesByMonth>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Work_AR_SalesByMonth");

                entity.Property(e => e.AggregateIso).HasColumnName("AggregateISO");

                entity.Property(e => e.AggregateSum)
                    .IsRequired()
                    .HasMaxLength(12);

                entity.Property(e => e.AggregateType).HasMaxLength(12);

                entity.Property(e => e.CompanyCode).HasMaxLength(3);

                entity.Property(e => e.CustomerNo).HasMaxLength(12);

                entity.Property(e => e.FamilyCode).HasMaxLength(3);

                entity.Property(e => e.WarehouseCode).HasMaxLength(3);

                entity.Property(e => e._01).HasColumnName("01");

                entity.Property(e => e._02).HasColumnName("02");

                entity.Property(e => e._03).HasColumnName("03");

                entity.Property(e => e._04).HasColumnName("04");

                entity.Property(e => e._05).HasColumnName("05");

                entity.Property(e => e._06).HasColumnName("06");

                entity.Property(e => e._07).HasColumnName("07");

                entity.Property(e => e._08).HasColumnName("08");

                entity.Property(e => e._09).HasColumnName("09");

                entity.Property(e => e._10).HasColumnName("10");

                entity.Property(e => e._11).HasColumnName("11");

                entity.Property(e => e._12).HasColumnName("12");

                entity.Property(e => e._13).HasColumnName("13");
            });

            modelBuilder.Entity<WorkCustomer>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

                entity.ToTable("Work_Customers");

                entity.Property(e => e.CompanyCode)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CustomerAddress1)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerAddress2)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerAddress3)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerCity)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerCountry)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerNoLca)
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("CustomerNoLCA");

                entity.Property(e => e.CustomerNoLdi)
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("CustomerNoLDI");

                entity.Property(e => e.CustomerNoLum)
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("CustomerNoLUM");

                entity.Property(e => e.CustomerState)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerUploadName).HasMaxLength(64);

                entity.Property(e => e.CustomerUrl)
                    .HasMaxLength(256)
                    .HasColumnName("CustomerURL");

                entity.Property(e => e.CustomerZip)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateLastActivity).HasColumnType("date");

                entity.Property(e => e.DateLastPayment).HasColumnType("date");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FaxNo)
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.SalespersonNo)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SalespersonNo2)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SalespersonNo3)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SalespersonNo4)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SalespersonNo5)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.TelephoneExt)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TelephoneNo)
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.TermsCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.UploadInformation).HasMaxLength(4000);
            });

            modelBuilder.Entity<WorkImAggregate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Work_IM_Aggregates");

                entity.Property(e => e.AggregateIso).HasColumnName("AggregateISO");

                entity.Property(e => e.AggregateType)
                    .IsRequired()
                    .HasMaxLength(12);

                entity.Property(e => e.AvgCost).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.AvgPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CompanyCode).HasMaxLength(3);

                entity.Property(e => e.FamilyCode).HasMaxLength(12);

                entity.Property(e => e.TotalCost).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TransactionCode).HasMaxLength(3);

                entity.Property(e => e.WarehouseCode).HasMaxLength(3);
            });

            modelBuilder.Entity<WorkItem>(entity =>
            {
                entity.ToTable("Work_Item");

                entity.Property(e => e.AdCopyText).HasMaxLength(4000);

                entity.Property(e => e.AdFeature).HasMaxLength(1000);

                entity.Property(e => e.AdInfo).HasMaxLength(4000);

                entity.Property(e => e.BulkType).HasMaxLength(4);

                entity.Property(e => e.Color).HasMaxLength(400);

                entity.Property(e => e.CostNotes).HasMaxLength(1000);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CustomerDescription).HasMaxLength(1000);

                entity.Property(e => e.CustomerItemId).HasMaxLength(50);

                entity.Property(e => e.CustomerItemId2).HasMaxLength(50);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateFirstPo)
                    .HasColumnType("datetime")
                    .HasColumnName("DateFirstPO");

                entity.Property(e => e.DateFirstReceipt).HasColumnType("datetime");

                entity.Property(e => e.DatePublished).HasColumnType("datetime");

                entity.Property(e => e.Ds).HasColumnName("DS");

                entity.Property(e => e.FirstCostCurrency).HasMaxLength(3);

                entity.Property(e => e.Hts)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("HTS");

                entity.Property(e => e.ItemType).HasMaxLength(12);

                entity.Property(e => e.LeadTestValidUntil).HasColumnType("date");

                entity.Property(e => e.LumisourceCollection).HasMaxLength(1000);

                entity.Property(e => e.LumisourceDescriptionLong).HasMaxLength(4000);

                entity.Property(e => e.LumisourceItemId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LumisourceUniqueId).HasMaxLength(128);

                entity.Property(e => e.Mas90ExportedOn).HasColumnType("datetime");

                entity.Property(e => e.Notes).HasMaxLength(1000);

                entity.Property(e => e.PkgTestValidUntil).HasColumnType("date");

                entity.Property(e => e.PrimaryBin)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ProductCategoryId).HasMaxLength(12);

                entity.Property(e => e.ProductCategorySubId).HasMaxLength(24);

                entity.Property(e => e.ProductCategorySubId2).HasMaxLength(12);

                entity.Property(e => e.ProductSpecs).HasMaxLength(1000);

                entity.Property(e => e.SalesNotes).HasMaxLength(4000);

                entity.Property(e => e.Srp).HasColumnName("SRP");

                entity.Property(e => e.Status).HasMaxLength(32);

                entity.Property(e => e.UpcId).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.VendorDescription).HasMaxLength(2000);

                entity.Property(e => e.VendorItemId).HasMaxLength(50);

                entity.Property(e => e.WebCategoryId).HasMaxLength(12);

                entity.Property(e => e.WebCategorySubId).HasMaxLength(12);

                entity.Property(e => e.WebDates).HasMaxLength(4000);

                entity.Property(e => e.WebNotes).HasMaxLength(1000);

                entity.Property(e => e.WorkingItemDate).HasColumnType("datetime");

                entity.Property(e => e.WorkingItemDesigner).HasMaxLength(100);

                entity.Property(e => e.WorkingItemId).HasMaxLength(50);

                entity.Property(e => e.WorkingItemName).HasMaxLength(1000);

                entity.Property(e => e.WorkingItemSetupDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<WorkProductFamily>(entity =>
            {
                entity.ToTable("Work_ProductFamilies");

                entity.Property(e => e.Abbr).HasMaxLength(12);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Descr).HasMaxLength(128);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<WorkProductLine>(entity =>
            {
                entity.ToTable("Work_ProductLines");

                entity.Property(e => e.Abbr).HasMaxLength(12);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Descr).HasMaxLength(128);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<WorkProductStyle>(entity =>
            {
                entity.ToTable("Work_ProductStyles");

                entity.Property(e => e.Abbr).HasMaxLength(12);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Descr).HasMaxLength(128);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<WorkVendor>(entity =>
            {
                entity.HasKey(e => e.VendorId);

                entity.ToTable("Work_Vendors");

                entity.Property(e => e.AddressNotes1).HasMaxLength(4000);

                entity.Property(e => e.AddressNotes2).HasMaxLength(4000);

                entity.Property(e => e.BankNotes1).HasMaxLength(4000);

                entity.Property(e => e.BankNotes2).HasMaxLength(4000);

                entity.Property(e => e.Contact1)
                    .HasMaxLength(50)
                    .HasColumnName("Contact_1");

                entity.Property(e => e.Contact2)
                    .HasMaxLength(50)
                    .HasColumnName("Contact_2");

                entity.Property(e => e.Contact3)
                    .HasMaxLength(50)
                    .HasColumnName("Contact_3");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DefaultCurrency)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Email1)
                    .HasMaxLength(100)
                    .HasColumnName("Email_1");

                entity.Property(e => e.Email2)
                    .HasMaxLength(100)
                    .HasColumnName("Email_2");

                entity.Property(e => e.Email3)
                    .HasMaxLength(100)
                    .HasColumnName("Email_3");

                entity.Property(e => e.Fax1)
                    .HasMaxLength(50)
                    .HasColumnName("Fax_1");

                entity.Property(e => e.Fax2)
                    .HasMaxLength(50)
                    .HasColumnName("Fax_2");

                entity.Property(e => e.ImgUrl)
                    .HasMaxLength(100)
                    .HasColumnName("ImgURL");

                entity.Property(e => e.InvitationCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailingAddress)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile1)
                    .HasMaxLength(50)
                    .HasColumnName("Mobile_1");

                entity.Property(e => e.Mobile2)
                    .HasMaxLength(50)
                    .HasColumnName("Mobile_2");

                entity.Property(e => e.Mobile3)
                    .HasMaxLength(50)
                    .HasColumnName("Mobile_3");

                entity.Property(e => e.PaymentTermsText).HasMaxLength(300);

                entity.Property(e => e.Tel1)
                    .HasMaxLength(50)
                    .HasColumnName("Tel_1");

                entity.Property(e => e.Tel2)
                    .HasMaxLength(50)
                    .HasColumnName("Tel_2");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.VendorAddress).HasMaxLength(100);

                entity.Property(e => e.VendorAddress2).HasMaxLength(100);

                entity.Property(e => e.VendorAddress2A).HasMaxLength(100);

                entity.Property(e => e.VendorAddress2B).HasMaxLength(100);

                entity.Property(e => e.VendorAddress3).HasMaxLength(100);

                entity.Property(e => e.VendorBalanceType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VendorCity).HasMaxLength(100);

                entity.Property(e => e.VendorCityProv2).HasMaxLength(100);

                entity.Property(e => e.VendorCountry).HasMaxLength(100);

                entity.Property(e => e.VendorCountry2).HasMaxLength(100);

                entity.Property(e => e.VendorDepositType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VendorIso)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VendorISO");

                entity.Property(e => e.VendorIso2)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VendorISO2");

                entity.Property(e => e.VendorName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.VendorName2).HasMaxLength(100);

                entity.Property(e => e.VendorNickName).HasMaxLength(40);

                entity.Property(e => e.VendorNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VendorState).HasMaxLength(50);

                entity.Property(e => e.VendorType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VendorZip)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.VendorZip2)
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
