IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Projeto]') AND type in (N'U'))
DROP TABLE [dbo].[Projeto]
GO

CREATE TABLE [dbo].[Projeto](
	[IDProjeto] [nvarchar](10) NOT NULL,
	[Descricao] [nvarchar](100) NULL,
	[DataInicio] [datetime] NULL,
	[DataFim] [datetime] NULL,
	[Valor] [real] NULL,
 CONSTRAINT [PK_Projeto] PRIMARY KEY CLUSTERED 
(
	[IDProjeto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

INSERT INTO [dbo].[Projeto]
           ([IDProjeto]
		   ,[Descricao]
           ,[DataInicio]
		   ,[DataFim]
		   ,[Valor]
           )
     VALUES
           ('A'
		   ,'Projeto A'
		   ,'20100102'
           ,'20121202'
		   ,19.8
		   ),
		   ('B'
		   ,'Projeto B'
		   ,'20200102'
           ,'20211202'
		   ,49.8
		   )
GO


IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProjetoEliminar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ProjetoEliminar]
GO

CREATE Procedure [dbo].[ProjetoEliminar]
@IDProjeto nvarchar(10)
AS
Begin

    Delete from [Projeto]
    Where [IDProjeto]=@IDProjeto

end

GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProjetoObter]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ProjetoObter]
GO

CREATE Procedure [dbo].[ProjetoObter]
@IDProjeto nvarchar(10)
As 
Begin

	Select * From [Projeto] Where [IDProjeto]=@IDProjeto
End


GO


IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProjetoListar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ProjetoListar]
GO

CREATE Procedure [dbo].[ProjetoListar]
As 
Begin

	Select * From Projeto
End

GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProjetoGravar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ProjetoGravar]
GO

CREATE Procedure [dbo].[ProjetoGravar]
@IDProjeto nvarchar(10),
@Descricao nvarchar(100),
@DataInicio datetime,
@DataFim datetime,
@Valor real
As 
Begin

Begin Transaction
   
 IF (Select Count(*) From [Projeto] Where [IDProjeto]=@IDProjeto)=0
      Begin
         Insert Into [Projeto] ([IDProjeto], [Descricao], [DataInicio], [DataFim], [Valor])
         Values (@IDProjeto, @Descricao, @DataInicio, @DataFim, @Valor)
      End
 Else
     Begin
         Update [Projeto]
         Set Descricao=@Descricao,
			 DataInicio=@DataInicio,
			 DataFim=@DataFim,
			 Valor=@Valor
         Where [IDProjeto]=@IDProjeto
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

