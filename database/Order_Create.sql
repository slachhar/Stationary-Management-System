USE [StationaryManagementSystem]
GO
/****** Object:  StoredProcedure [dbo].[Order_Create]    Script Date: 2/19/2019 11:20:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[Order_Create]
	@InstitutionId int,
	@InventaryId int,
	@MarkUpId int,
	@ExpectedOrderDate datetime,
	@BufferDaysBeforeDelivery int NULL,
	@CreatedBy int NULL,
	@CreatedOn datetime NULL,
	@UpdatedBy int NULL,
	@UpdatedOn datetime NULL
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	--SET NOCOUNT ON;

    -- Insert statements for procedure here
	Insert into [dbo].[Order] Values (
							@InstitutionId,
							@InventaryId,
							@MarkUpId,
							@ExpectedOrderDate,
							@BufferDaysBeforeDelivery,
							@CreatedBy,
							@CreatedOn,
							@UpdatedBy,
							@UpdatedOn)

END
