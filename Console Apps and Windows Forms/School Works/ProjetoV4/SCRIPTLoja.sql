IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Loja]') AND type in (N'U'))
DROP TABLE [dbo].[Loja]
GO

CREATE TABLE [dbo].[Loja](
	[CodigoLoja] int NOT NULL,
	[Descricao] [nvarchar](90) NULL,
	[Morada] [nvarchar](100) NULL,
	[Area] [real] NULL,
	[DataInicioAtividade] [datetime] NULL,
 CONSTRAINT [PK_Loja] PRIMARY KEY CLUSTERED 
(
	[CodigoLoja] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

INSERT INTO [dbo].[Loja]
           ([CodigoLoja]
		   ,[Descricao]
           ,[Morada]
		   ,[Area]
		   ,[DataInicioAtividade]
           )
     VALUES
           (1
		   ,'Loja A'
		   ,'Rua X'
		   ,19.8
		   ,'20200105'
		   ),
		   (2
		   ,'Loja B'
		   ,'Rua Y'
		   ,49.8
		   ,'20030502'
		   )
GO


IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Eliminar_Loja]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Eliminar_Loja]
GO

CREATE Procedure [dbo].[Eliminar_Loja]
@CodigoLoja int
AS
Begin

    Delete from [Loja]
    Where [CodigoLoja]=@CodigoLoja

end

GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Obter_Loja]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Obter_Loja]
GO

CREATE Procedure [dbo].[Obter_Loja]
@CodigoLoja int
As 
Begin

	Select * From [Loja] Where [CodigoLoja]=@CodigoLoja
End


GO


IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Listar_Loja]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Listar_Loja]
GO

CREATE Procedure [dbo].[Listar_Loja]
As 
Begin

	Select * From Loja
End

GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Gravar_Loja]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Gravar_Loja]
GO

CREATE Procedure [dbo].[Gravar_Loja]
@CodigoLoja int,
@Descricao nvarchar(90),
@Morada nvarchar(100),
@Area real,
@DataInicioAtividade datetime
As 
Begin

Begin Transaction
   
 IF (Select Count(*) From [Loja] Where [CodigoLoja]=@CodigoLoja)=0
      Begin
         Insert Into [Loja] ([CodigoLoja], [Descricao], [Morada], [Area], [DataInicioAtividade])
         Values (@CodigoLoja, @Descricao, @Morada, @Area, @DataInicioAtividade)
      End
 Else
     Begin
         Update [Loja]
         Set [Descricao]=@Descricao,
			 [Morada]=@Morada,
			 [Area]=@Area,
			 [DataInicioAtividade]=@DataInicioAtividade
         Where [CodigoLoja]=@CodigoLoja
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

