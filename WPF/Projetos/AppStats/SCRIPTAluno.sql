IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Aluno]') AND type in (N'U'))
DROP TABLE [dbo].[Aluno]
GO

CREATE TABLE [dbo].[Aluno](
	[CodigoAluno] int NOT NULL,
	[Nome] [nvarchar](95) NULL,
	[DataNascimento] [datetime] NULL,
	[Telefone] [nvarchar](25) NULL,
 CONSTRAINT [PK_Aluno] PRIMARY KEY CLUSTERED 
(
	[CodigoAluno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

INSERT INTO [dbo].[Aluno]
           ([CodigoAluno]
		   ,[Nome]
           ,[DataNascimento]
		   ,[Telefone]
           )
     VALUES
           (1
		   ,'Aluno A'
		   ,'20200105'
		   ,'931222333'
		   ),
		   (2
		   ,'Aluno B'
		   ,'20030502'
		   ,'915365326'
		   )
GO


IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Eliminar_Aluno]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Eliminar_Aluno]
GO

CREATE Procedure [dbo].[Eliminar_Aluno]
@CodigoAluno int
AS
Begin

    Delete from [Aluno]
    Where [CodigoAluno]=@CodigoAluno

end

GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Obter_Aluno]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Obter_Aluno]
GO

CREATE Procedure [dbo].[Obter_Aluno]
@CodigoAluno int
As 
Begin

	Select * From [Aluno] Where [CodigoAluno]=@CodigoAluno
End


GO


IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Listar_Aluno]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Listar_Aluno]
GO

CREATE Procedure [dbo].[Listar_Aluno]
As 
Begin

	Select * From Aluno
End

GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Gravar_Aluno]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Gravar_Aluno]
GO

CREATE Procedure [dbo].[Gravar_Aluno]
@CodigoAluno int,
@Nome nvarchar(95),
@DataNascimento datetime,
@Telefone nvarchar(25)
As 
Begin

Begin Transaction
   
 IF (Select Count(*) From [Aluno] Where [CodigoAluno]=@CodigoAluno)=0
      Begin
         Insert Into [Aluno] ([CodigoAluno], [Nome], [DataNascimento], [Telefone])
         Values (@CodigoAluno, @Nome, @DataNascimento, @Telefone)
      End
 Else
     Begin
         Update [Aluno]
         Set [Nome]=@Nome,
			 [DataNascimento]=@DataNascimento,
			 [Telefone]=@Telefone
         Where [CodigoAluno]=@CodigoAluno
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

