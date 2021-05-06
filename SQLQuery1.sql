USE [p2577928]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sproc_tblOrder_FilterByOrderNumber]
		@OrderNumber = NULL

SELECT	@return_value as 'Return Value'

GO
