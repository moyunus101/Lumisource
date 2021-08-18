USE [LumiSource]
GO
/****** Object:  StoredProcedure [dbo].[getActivityDetail]    Script Date: 8/13/2021 8:56:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc  [dbo].[getActivityDetail]
as
begin


-- this stored proc needs to be modified show real data
SELECT id=w.id,
	   LumisourceItemId=w.lumisourceItemId,
	   UnitsInInventory=convert(int,floor(1100 * RAND(convert(varbinary, newid())))),
	   UnitsSold=convert(int,floor(1100 * RAND(convert(varbinary, newid())))),
	   RevenueByMonth=floor(1100 * RAND(convert(varbinary, newid()))),
	   
	   CustomerNo=v.VendorNumber,
	   [JanToDec]=floor(1100 * RAND(convert(varbinary, newid()))),
	   [Total2018]=floor(1100 * RAND(convert(varbinary, newid()))),
	   Weeksactive=a.WeeksActive,
	   [status]=case when w.Status='active' then convert(bit,1) else convert(bit,0) end,
	   GONOGO='Go',
	   SalesProjections=floor(1100 * RAND(convert(varbinary, newid())))

  FROM [LumiSource].[dbo].[Work_Item] w 
  inner join Work_AR_SalesByMonth a on w.id=a.ItemId
  left join Work_ProductFamilies f on w.ProductFamilyId=f.Id
  left join Work_ProductStyles s on w.ProductStyleId=s.id
  left join Work_Vendors v on w.VendorId=v.VendorId
 
 
 end