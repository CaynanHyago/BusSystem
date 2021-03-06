USE [master]
GO
/****** Object:  Database [BDTCC]    Script Date: 17/06/2019 22:40:41 ******/
CREATE DATABASE [BDTCC]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BDTCC', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\BDTCC.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BDTCC_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\BDTCC_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [BDTCC] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BDTCC].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BDTCC] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BDTCC] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BDTCC] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BDTCC] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BDTCC] SET ARITHABORT OFF 
GO
ALTER DATABASE [BDTCC] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [BDTCC] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BDTCC] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BDTCC] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BDTCC] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BDTCC] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BDTCC] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BDTCC] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BDTCC] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BDTCC] SET  ENABLE_BROKER 
GO
ALTER DATABASE [BDTCC] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BDTCC] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BDTCC] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BDTCC] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BDTCC] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BDTCC] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BDTCC] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BDTCC] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BDTCC] SET  MULTI_USER 
GO
ALTER DATABASE [BDTCC] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BDTCC] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BDTCC] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BDTCC] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BDTCC] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BDTCC] SET QUERY_STORE = OFF
GO
USE [BDTCC]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [BDTCC]
GO
/****** Object:  Table [dbo].[tblFiscal]    Script Date: 17/06/2019 22:40:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblFiscal](
	[CodFiscal] [int] IDENTITY(1,1) NOT NULL,
	[NomeFiscal] [varchar](100) NOT NULL,
	[Chapa] [int] NOT NULL,
 CONSTRAINT [PK_tblFiscal] PRIMARY KEY CLUSTERED 
(
	[CodFiscal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblMotorista]    Script Date: 17/06/2019 22:40:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblMotorista](
	[CodMotorista] [int] IDENTITY(1,1) NOT NULL,
	[NomeMotorista] [varchar](100) NOT NULL,
	[Chapa] [int] NOT NULL,
	[CodOnibus] [int] NOT NULL,
 CONSTRAINT [PK_tblMotorista] PRIMARY KEY CLUSTERED 
(
	[CodMotorista] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblOnibus]    Script Date: 17/06/2019 22:40:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblOnibus](
	[CodOnibus] [int] IDENTITY(1,1) NOT NULL,
	[Numero] [varchar](15) NOT NULL,
 CONSTRAINT [PK_tblOnibus] PRIMARY KEY CLUSTERED 
(
	[CodOnibus] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblRelatorio]    Script Date: 17/06/2019 22:40:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblRelatorio](
	[CodRelatorio] [int] IDENTITY(1,1) NOT NULL,
	[Dia/Hora] [datetime] NOT NULL,
	[Linha] [varchar](5) NOT NULL,
	[Tabela] [varchar](4) NOT NULL,
	[CodMotorista] [int] NOT NULL,
	[CodFiscal] [int] NOT NULL,
 CONSTRAINT [PK_tblRelatorio] PRIMARY KEY CLUSTERED 
(
	[CodRelatorio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[uspAlterarFiscal]    Script Date: 17/06/2019 22:40:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspAlterarFiscal]
/* parâmetros */	
@CodFiscal INT,
@Nome VARCHAR(100),
@Chapa int

AS
BEGIN
	BEGIN TRY
		BEGIN TRAN	
		
		UPDATE tblFiscal
		set NomeFiscal = @Nome,
	    Chapa = @Chapa
		where CodFiscal = @CodFiscal

		select @CodFiscal AS Retorno
	   
		 
		 
			
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK

		SELECT ERROR_MESSAGE()AS Retorno

	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspAlterarMotorista]    Script Date: 17/06/2019 22:40:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspAlterarMotorista]
/* parâmetros */	
@CodMotorista INT,
@Nome VARCHAR(100),
@Chapa int,
@CodOnibus int 

AS
BEGIN
	BEGIN TRY
		BEGIN TRAN	
		
	    update tblMotorista
		set NomeMotorista = @Nome, Chapa = @Chapa, CodOnibus = @CodOnibus
		where  CodMotorista = @CodMotorista

		select @CodMotorista as Retorno
		 
			
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK

		SELECT ERROR_MESSAGE()AS Retorno

	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspAlterarOnibus]    Script Date: 17/06/2019 22:40:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspAlterarOnibus]
/* parâmetros */	
@CodOnibus INT,
@Numero VARCHAR(15)

AS
BEGIN
	BEGIN TRY
		BEGIN TRAN	
		
	    update tblOnibus
		set Numero = @Numero
		where  CodOnibus = @CodOnibus

		select @CodOnibus as Retorno
		 
			
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK

		SELECT ERROR_MESSAGE()AS Retorno

	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspAlterarRelatorio]    Script Date: 17/06/2019 22:40:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspAlterarRelatorio]
/* parâmetros */	
@CodRelatorio INT,
@Linha VARCHAR(5),
@Tabela VARCHAR(4),
@CodMotorista int,
@CodFiscal int,
@DiaHora datetime

AS
BEGIN
	BEGIN TRY
		BEGIN TRAN	
		
	    update tblRelatorio
		set Linha = @Linha, 
		Tabela = @Tabela, 
		CodMotorista = @CodMotorista, 
		CodFiscal = @CodFiscal,
		[Dia/Hora] = @DiaHora
		where  CodRelatorio = @CodRelatorio

		select @CodRelatorio as Retorno
		 
			
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK

		SELECT ERROR_MESSAGE()AS Retorno

	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspConsultaFiscal]    Script Date: 17/06/2019 22:40:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspConsultaFiscal]

@Nome VARCHAR(100)


AS
BEGIN
	BEGIN TRY
		BEGIN TRAN

		Select CodFiscal, NomeFiscal, Chapa FROM tblFiscal where NomeFiscal like '%' +  @Nome + '%'

		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK
		SELECT ERROR_MESSAGE() AS Retorno
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspConsultaFiscalCodigo]    Script Date: 17/06/2019 22:40:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspConsultaFiscalCodigo]
/* parâmetros */	


AS
BEGIN
	BEGIN TRY
		BEGIN TRAN	
		 
		SELECT * FROM tblFiscal 
			
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK

		SELECT ERROR_MESSAGE()AS Retorno

	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspConsultaFiscalNome]    Script Date: 17/06/2019 22:40:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspConsultaFiscalNome]

AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			
			SELECT NomeFiscal


			FROM tblFiscal

		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK
		SELECT ERROR_MESSAGE() AS Retorno
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspConsultaMotorista]    Script Date: 17/06/2019 22:40:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspConsultaMotorista]

@Nome varchar(100)
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			
			Select CodMotorista, NomeMotorista, Chapa, ONIBUS.Numero FROM tblMotorista 
			JOIN tblOnibus AS ONIBUS ON tblMotorista.CodOnibus = ONIBUS.CodOnibus
			where NomeMotorista like '%' +  @Nome + '%'

		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK
		SELECT ERROR_MESSAGE() AS Retorno
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspConsultaMotoristaCodigo]    Script Date: 17/06/2019 22:40:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[uspConsultaMotoristaCodigo]


AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			
			Select *From tblMotorista

		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK
		SELECT ERROR_MESSAGE() AS Retorno
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspConsultaMotoristaNome]    Script Date: 17/06/2019 22:40:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspConsultaMotoristaNome]

AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			
			SELECT NomeMotorista


			FROM tblMotorista

		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK
		SELECT ERROR_MESSAGE() AS Retorno
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspConsultaOnibus]    Script Date: 17/06/2019 22:40:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspConsultaOnibus]

AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			
			SELECT*
			FROM tblOnibus


		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK
		SELECT ERROR_MESSAGE() AS Retorno
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspConsultarRelatorio]    Script Date: 17/06/2019 22:40:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspConsultarRelatorio]

	
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN

			SELECT MOTO.NomeMotorista, FISCAL.NomeFiscal, Tabela, Linha, [Dia/Hora], CodRelatorio, ONIBUS.Numero			
			
			FROM
			 tblRelatorio AS RL
			INNER JOIN tblMotorista AS MOTO ON RL.CodMotorista = MOTO.CodMotorista
			INNER JOIN tblFiscal AS FISCAL ON RL.CodFiscal = FISCAL.CodFiscal
			LEFT JOIN tblOnibus AS ONIBUS ON MOTO.CodOnibus = ONIBUS.CodOnibus
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK
		SELECT ERROR_MESSAGE() AS Retorno
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspExcluirFiscal]    Script Date: 17/06/2019 22:40:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspExcluirFiscal]
/* parâmetros */	
@CodFiscal INT

AS
BEGIN
	BEGIN TRY
		BEGIN TRAN	
		 
		 delete from tblFiscal
		 where CodFiscal = @CodFiscal

		 SELECT @CodFiscal AS Retorno
		 
		 
			
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK

		SELECT ERROR_MESSAGE()AS Retorno

	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspExcluirMotorista]    Script Date: 17/06/2019 22:40:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspExcluirMotorista]
/* parâmetros */	
@CodMotorista INT

AS
BEGIN
	BEGIN TRY
		BEGIN TRAN	
		 
		 delete from tblMotorista
		 where CodMotorista = @CodMotorista

		 SELECT @CodMotorista AS Retorno
		 
		 
			
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK

		SELECT ERROR_MESSAGE()AS Retorno

	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspExcluirOnibus]    Script Date: 17/06/2019 22:40:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspExcluirOnibus]
/* parâmetros */	
@CodOnibus INT

AS
BEGIN
	BEGIN TRY
		BEGIN TRAN	
		 
		 delete from tblOnibus
		 where CodOnibus = @CodOnibus

		 SELECT @CodOnibus AS Retorno
		 
		 
			
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK

		SELECT ERROR_MESSAGE()AS Retorno

	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspExcluirRelatorio]    Script Date: 17/06/2019 22:40:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspExcluirRelatorio]
/* parâmetros */	
@CodRelatorio int

AS
BEGIN
	BEGIN TRY
		BEGIN TRAN	
		 
		 delete  from tblRelatorio
		 where CodRelatorio  = @CodRelatorio 

		 SELECT @CodRelatorio  AS Retorno
		 
		 
			
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK

		SELECT ERROR_MESSAGE()AS Retorno

	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspInserirFiscal]    Script Date: 17/06/2019 22:40:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspInserirFiscal]
/* parâmetros */	
@Nome VARCHAR(100),
@Chapa VARCHAR(10)
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN	
		
		insert into tblFiscal(NomeFiscal,Chapa)
		values(@Nome,@Chapa)

		Declare @IDNovoFiscal AS INT = @@IDENTITY

		Select @IDNovoFiscal as Retorno
		 
		 
			
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK

		SELECT ERROR_MESSAGE()AS Retorno

	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspInserirMotorista]    Script Date: 17/06/2019 22:40:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspInserirMotorista]
/* parâmetros */	
@Nome VARCHAR(100),
@Chapa int,
@CodOnibus int

AS
BEGIN
	BEGIN TRY
		BEGIN TRAN	
		
		insert into tblMotorista(NomeMotorista, Chapa, CodOnibus)
		values(@Nome, @Chapa, @CodOnibus)

		Declare @IDNovoMotorista AS INT = @@IDENTITY

		Select @IDNovoMotorista as Retorno
		 
		 
			
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK

		SELECT ERROR_MESSAGE()AS Retorno

	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspInserirOnibus]    Script Date: 17/06/2019 22:40:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspInserirOnibus]
/* parâmetros */	
@Numero VARCHAR(15)

AS
BEGIN
	BEGIN TRY
		BEGIN TRAN	
		
		insert into tblOnibus(Numero)
		values(@Numero)

		Declare @IDNovoOnibus AS INT = @@IDENTITY

		Select @IDNovoOnibus  as Retorno
		 
		 
			
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK

		SELECT ERROR_MESSAGE()AS Retorno

	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspInserirRelatorio]    Script Date: 17/06/2019 22:40:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspInserirRelatorio]
/* parâmetros */	
@DiaHora datetime,
@Linha VARCHAR(5),
@Tabela VARCHAR(4),
@CodFiscal int,
@CodMotorista int

AS
BEGIN
	BEGIN TRY
		BEGIN TRAN	
		
		insert into tblRelatorio([Dia/Hora],Linha,Tabela, CodMotorista, CodFiscal)
		values(@DiaHora,@Linha,@Tabela, @CodMotorista,@CodFiscal)

		Declare @IDNovoRelatorio AS INT = @@IDENTITY

		Select @IDNovoRelatorio as Retorno
		 
		 
			
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK

		SELECT ERROR_MESSAGE()AS Retorno

	END CATCH
END
GO
USE [master]
GO
ALTER DATABASE [BDTCC] SET  READ_WRITE 
GO
