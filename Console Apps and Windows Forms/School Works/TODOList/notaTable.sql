IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Nota]') AND type in (N'U'))
DROP TABLE [dbo].[Nota]
GO

CREATE TABLE [dbo].[Nota](
	[IDNota] [nvarchar](10) NOT NULL,
	[Titulo] [nvarchar](MAX) NOT NULL,
	[DataCriacao] [datetime] NULL,
	[DataExpiracao] [datetime] NULL,
	[Tags] [int] NULL,
	[Conteudo] [nvarchar](MAX) NULL,
	[Destaque] [bit] NULL
 CONSTRAINT [PK_Nota] PRIMARY KEY CLUSTERED 
(
	[IDNota] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

INSERT INTO [dbo].[Nota]
           ([IDNota]
		   ,[Titulo]
		   ,[DataCriacao]
           ,[DataExpiracao]
		   ,[Tags]
		   ,[Conteudo]
		   ,[Destaque])
     VALUES
           ('A'
		   ,'Titulo 1'
		   ,'20100102'
		   ,'20121202'
		   ,2
		   ,'NOTA 1'
		   ,1
		   ),
		   ('B'
		   ,'Titulo 2'
		   ,'20100102'
		   ,'20121202'
		   ,4
		   ,'NOTA 2'
		   ,0)
GO


IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Nota_Eliminar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[NotaEliminar]
GO

CREATE Procedure [dbo].[NotaEliminar]
@IDNota [nvarchar](10)
AS
Begin

    Delete from [Nota]
    Where [IDNota]=@IDNota

end

GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Nota_Obter]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[NotaObter]
GO

CREATE Procedure [dbo].[NotaObter]
@IDNota nvarchar(10)
As 
Begin

	Select * From [Nota] Where [IDNota]=@IDNota
End


GO


IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Nota_Listar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[NotaListar]
GO

CREATE Procedure [dbo].[NotaListar]
As 
Begin

	Select * From Nota
End

GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Nota_Gravar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[NotaGravar]
GO

CREATE Procedure [dbo].[NotaGravar]
@IDNota nvarchar(10),
@Titulo nvarchar(MAX),
@DataCriacao datetime,
@DataExpiracao datetime,
@Tags int,
@Conteudo nvarchar(MAX),
@Destaque bit
As 
Begin

Begin Transaction
   
 IF (Select Count(*) From [Nota] Where [IDNota]=@IDNota)=0
      Begin
         Insert Into [Nota] ([IDNota], [Titulo], [DataCriacao], [DataExpiracao], [Tags], [Conteudo], [Destaque])
         Values (@IDNota, @Titulo, @DataCriacao, @DataExpiracao, @Tags, @Conteudo, @Destaque)
      End
 Else
     Begin
         Update [Nota]
         Set [Titulo]=@Titulo,
			 [DataCriacao]=@DataCriacao,
			 [DataExpiracao]=@DataExpiracao,
			 [Tags]=@Tags,
			 [Conteudo]=@Conteudo,
			 [Destaque]=@Destaque
         Where [IDNota]=@IDNota
      End
 
      If @@error <>0
            Begin
               Rollback transaction
            End
      Else
            Begin
               Commit Transaction
            End
End

GO

