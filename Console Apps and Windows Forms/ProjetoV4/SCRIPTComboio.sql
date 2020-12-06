IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Comboio]') AND type in (N'U'))
DROP TABLE [dbo].[Comboio]
GO

CREATE TABLE [dbo].[Comboio](
	[CodigoComboio] bigint NOT NULL,
	[NumeroLugares] int NULL,
	[DataFabrico] [datetime] NULL,
	[Modelo] [nvarchar](25) NULL
 CONSTRAINT [PK_Comboio] PRIMARY KEY CLUSTERED 
(
	[CodigoComboio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

INSERT INTO [dbo].[Comboio]
           ([CodigoComboio]
		   ,[NumeroLugares]
           ,[DataFabrico]
		   ,[Modelo]
           )
     VALUES
           (1
		   ,198
		   ,'20200105'
		   ,'Modelo A'
		   ),
		   (2
		   ,49.8
		   ,'20030502'
		   ,'Modelo B'
		   )
GO


IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EliminarComboio]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[EliminarComboio]
GO

CREATE Procedure [dbo].[EliminarComboio]
@CodigoComboio bigint
AS
Begin

    Delete from [Comboio]
    Where [CodigoComboio]=@CodigoComboio

end

GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ObterComboio]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ObterComboio]
GO

CREATE Procedure [dbo].[ObterComboio]
@CodigoComboio bigint
As 
Begin

	Select * From [Comboio] Where [CodigoComboio]=@CodigoComboio
End


GO


IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ListarComboio]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ListarComboio]
GO

CREATE Procedure [dbo].[ListarComboio]
As 
Begin

	Select * From Comboio
End

GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GravarComboio]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GravarComboio]
GO

CREATE Procedure [dbo].[GravarComboio]
@CodigoComboio bigint,
@NumeroLugares int,
@DataFabrico datetime,
@Modelo real
As 
Begin

Begin Transaction
   
 IF (Select Count(*) From [Comboio] Where [CodigoComboio]=@CodigoComboio)=0
      Begin
         Insert Into [Comboio] ([CodigoComboio], [NumeroLugares], [DataFabrico], [Modelo])
         Values (@CodigoComboio, @NumeroLugares, @DataFabrico, @Modelo)
      End
 Else
     Begin
         Update [Comboio]
         Set [NumeroLugares]=@NumeroLugares,
			 [DataFabrico]=@DataFabrico,
			 [Modelo]=@Modelo
         Where [CodigoComboio]=@CodigoComboio
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

