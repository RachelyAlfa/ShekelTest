use [TestDB]

select  [dbo].[Products].[ProductID], [ProductDesc],  COALESCE(sum(  [dbo].[Order Details].Quantity ) ,0)   as 'quantity sold' 
from [dbo].[Products] left join [dbo].[Order Details] on  [dbo].[Products].ProductID =  [dbo].[Order Details].ProductID
group by [dbo].[Products].[ProductID], [ProductDesc]

