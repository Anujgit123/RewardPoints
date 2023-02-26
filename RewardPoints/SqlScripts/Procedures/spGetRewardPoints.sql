USE [RewardPoints]

-- =============================================
-- Author:		Anuj Yadav
-- Create date: 25th Feb 2023
-- Description:	procedure to Get Reward Points based on CustomerID
-- =============================================
CREATE PROCEDURE [dbo].[spGetRewardPoints] 
	@CustomerID INT
AS
BEGIN
SELECT [CustomerID]
      ,[CustomerName]
      ,[Month]
      ,SUM([Transaction]) AS 'Transaction'
	  
      
  FROM [dbo].[RewardPoints] GROUP BY Month,CustomerID, CustomerName HAVING CustomerID = @CustomerID
  
END
GO


