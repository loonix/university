IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Obter]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Obter]
GO

CREATE Procedure [dbo].[Obter]
@id varchar(40)
As 
Begin

	Select * From [downloads] Where [id]=@id
End


GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Listar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Listar]
GO

CREATE Procedure [dbo].[Listar]
As 
Begin

	Select * From downloads
End

GO