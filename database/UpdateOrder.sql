-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE UpdateOrder 
	@InstitutionId int,
	@InventaryId int,
	@MarkUpId int,
	@ExpectedOrderDate datetime,
	@BufferDaysBeforeDelivery int NULL,
	@CreatedBy int NULL,
	@CreatedOn datetime NULL,
	@UpdatedBy int NULL,
	@UpdatedOn datetime NULL,
	@OrderId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	--SET NOCOUNT ON;

   Update [dbo].[Order] SET InstitutionId = @InstitutionId,
							InventaryId = @InventaryId,
							MarkUpId = @MarkUpId,
							ExpectedOrderDate = @ExpectedOrderDate,
							BufferDaysBeforeDelivery = @BufferDaysBeforeDelivery,
							CreatedBy = @CreatedBy,
							CreatedOn = @CreatedOn,
							UpdatedBy = @UpdatedBy,
							UpdatedOn = @UpdatedOn
						WHERE OrderId = @OrderId

	Select InstitutionId,
			InventaryId,
			MarkUpId,
			ExpectedOrderDate,
			BufferDaysBeforeDelivery,
			CreatedBy,
			CreatedOn,
			UpdatedBy,
			UpdatedOn  
			FROM [dbo].[Order]
			WHERE OrderId = @OrderId
END
GO
