
Steps to make this application work,


SQL queries are incomplete because I need some clarifications on columsn and tables. Once I have that then I can correct all sql queries and stroed procs.

1. Create SQL database and create tables. by running script1.sql and then run script2.sql
2. For EF Core primary key is required which shoudl be already handled by script1.sql. If you used original sql script which came with project then
create primary with ID column in each following table.
		select * from Work_Customers
		select * from Work_Item
		select * from Work_ProductFamilies
		select * from Work_ProductLines
		select * from Work_ProductStyles
		select * from Work_Vendors
3.  Change the Connection string in appsetting.json


4. Run built it shoud build with no errors but sometimes it need nuget package downloaded so check that part.

5. Once compiled then launch it in visual studio build IIS. 

Here are two urls port number will be differnt on your machine
https://localhost:44360/swagger   --for API
https://localhost:44360/          -- for web page for grid pannerl
or 
https://localhost:44360/default



