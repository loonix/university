IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Projeto]') AND type in (N'U'))
DROP TABLE [dbo].[Projeto]
GO

CREATE TABLE [dbo].[Projeto](
	[IdWow] bigint NOT NULL,
	[Cliente] [nvarchar](50) NULL
	[Servico] [nvarchar](25) NULL
	[Tipo] [nvarchar](25) NULL
	[Origem] [nvarchar](25) NULL
	[Estado] [nvarchar](25) NULL
	[Descricao] [nvarchar](1000) NULL
	[Prioridade] [nvarchar](50) NULL
	[NomePV] [nvarchar](50) NULL
	[DataPedido] [datetime] NULL,
	
	

 CONSTRAINT [PK_Projeto] PRIMARY KEY CLUSTERED 
(
	[CodigoProjeto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

INSERT INTO [dbo].[Projeto]
           ([IdWow],
		   [Cliente],
		   [Servico],
           [Tipo],
		   [Origem],
		   [Estado],
	       [Descricao] ,
	       [Prioridade] ,
	       [NomePV] ,
	       [DataPedido] 	   
           )
     VALUES
           (1
		   ,'EDP'
		   ,'NetPremium'
		   ,'Normal'
		   ,'Diretas'
		   ,'Inprogress'
		   ,
		   ),
		   (2
		   ,49.8
		   ,'20030502'
		   ,'Modelo B'
		   )
GO


IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EliminarProjeto]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[EliminarProjeto]
GO

CREATE Procedure [dbo].[EliminarProjeto]
@CodigoProjeto bigint
AS
Begin

    Delete from [Projeto]
    Where [CodigoProjeto]=@CodigoProjeto

end

GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ObterProjeto]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ObterProjeto]
GO

CREATE Procedure [dbo].[ObterProjeto]
@CodigoProjeto bigint
As 
Begin

	Select * From [Projeto] Where [CodigoProjeto]=@CodigoProjeto
End


GO


IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ListarProjeto]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ListarProjeto]
GO

CREATE Procedure [dbo].[ListarProjeto]
As 
Begin

	Select * From Projeto
End

GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GravarProjeto]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GravarProjeto]
GO

CREATE Procedure [dbo].[GravarProjeto]
@CodigoProjeto bigint,
@NumeroLugares int,
@DataFabrico datetime,
@Modelo real
As 
Begin

Begin Transaction
   
 IF (Select Count(*) From [Projeto] Where [CodigoProjeto]=@CodigoProjeto)=0
      Begin
         Insert Into [Projeto] ([CodigoProjeto], [NumeroLugares], [DataFabrico], [Modelo])
         Values (@CodigoProjeto, @NumeroLugares, @DataFabrico, @Modelo)
      End
 Else
     Begin
         Update [Projeto]
         Set [NumeroLugares]=@NumeroLugares,
			 [DataFabrico]=@DataFabrico,
			 [Modelo]=@Modelo
         Where [CodigoProjeto]=@CodigoProjeto
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

