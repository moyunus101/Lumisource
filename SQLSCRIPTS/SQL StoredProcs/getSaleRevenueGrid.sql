USE [LumiSource]
GO
/****** Object:  StoredProcedure [dbo].[getSaleRevenueGrid]    Script Date: 8/13/2021 8:59:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 
ALTER proc  [dbo].[getSaleRevenueGrid]
as
begin
SELECT 
	   w.id
	  ,[LumisourceItemId]
      ,[LumisourceCollection]
      ,[LumisourceDescriptionLong]
	  ,[UpcId]
      ,w.VendorId
	  ,f.Name as Family
	  ,s.Name as Style
	  ,v.VendorNumber
      --,[VendorItemId]
	  ,GrossSales=a.Total*w.UnitPrice
	  ,GrossRevenue=a.Total*w.UnitPrice

  FROM [LumiSource].[dbo].[Work_Item] w 
  inner join Work_AR_SalesByMonth a on w.id=a.ItemId
  left join Work_ProductFamilies f on w.ProductFamilyId=f.Id
  left join Work_ProductStyles s on w.ProductStyleId=s.id
  left join Work_Vendors v on w.VendorId=v.VendorId



 

 end
