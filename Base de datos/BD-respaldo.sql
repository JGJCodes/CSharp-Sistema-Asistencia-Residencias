USE [miempresa]
GO
/****** Object:  StoredProcedure [dbo].[actualizarDia]    Script Date: 15/12/2016 10:49:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Jorge Guzman Juarez
-- Create date: 15/12/2016 10:49:17
-- Description:	Procedimiento para realizar un update a un registro de la tabla DiaLaboral
-- =============================================
CREATE PROCEDURE [dbo].[actualizarDia]( 
	-- Add the parameters for the stored procedure here
	@IdDia int,
	@Asistencia varchar(10)
	)
AS
BEGIN
	UPDATE DiaLaboral SET 
		Asistencia=@Asistencia
	WHERE IdDiaLaboral = @IdDia;
END;


GO
/****** Object:  StoredProcedure [dbo].[actualizarEmpleado]    Script Date: 15/12/2016 10:49:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Jorge Guzman Juarez
-- Create date: 15/12/2016 10:49:17
-- Description:	Procedimiento para realizar un update a un registro de la tabla Empleado
-- =============================================
CREATE PROCEDURE [dbo].[actualizarEmpleado]( 
	-- Add the parameters for the stored procedure here
	@IdEmpleado int,
	@CURP varchar(20),
	@Nombres varchar(20),
	@ApellidoPaterno varchar(20),
	@ApellidoMaterno varchar(20),
	@FechaNacimiento date,
	@Email varchar(20),
	@Celular varchar(20),
	@Fotografia image,
	@IdTarjeta varchar(20),
	@Puesto varchar(20),
	@Departamento varchar(20),
	@HoraEntrada time,
	@HoraSalida time,
	@DiaLibre varchar(20)
	)
AS
BEGIN
	UPDATE Empleado SET 
		CURP=@CURP,
		Nombres=@Nombres,
		ApellidoPaterno=@ApellidoPaterno,
		ApellidoMaterno=@ApellidoMaterno,
		FechaNacimiento=@FechaNacimiento,
		Email=@Email,
		Celular=@Celular,
		Fotografia=@Fotografia,
		IdTarjeta=@IdTarjeta,
		Puesto=@Puesto,
		Departamento=@Departamento,
		HoraEntrada=@HoraEntrada,
		HoraSalida=@HoraSalida,
		DiaLibre=@DiaLibre
	WHERE IdEmpleado = @IdEmpleado
END;

GO
/****** Object:  StoredProcedure [dbo].[borrarDia]    Script Date: 15/12/2016 10:49:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Jorge Guzman Juarez
-- Create date: 15/12/2016 10:49:17
-- Description:	Procedimiento para realizar un delete a un registro de la tabla DiaLaboral
-- =============================================
CREATE PROCEDURE [dbo].[borrarDia](@IdDia int)
	-- Add the parameters for the stored procedure here
AS
BEGIN
	DELETE FROM DiaLaboral WHERE IdDiaLaboral=@IdDia;
END

GO
/****** Object:  StoredProcedure [dbo].[borrarEmpleado]    Script Date: 15/12/2016 10:49:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Jorge Guzman Juarez
-- Create date: 15/12/2016 10:49:17
-- Description:	Procedimiento para realizar un delete a un registro de la tabla Empleado
-- =============================================
CREATE PROCEDURE [dbo].[borrarEmpleado](
	-- Add the parameters for the stored procedure here
	@IdEmpleado int
	)
AS
BEGIN
	DELETE FROM Empleado WHERE IdEmpleado=@IdEmpleado
END;

GO
/****** Object:  StoredProcedure [dbo].[borrarEntrada]    Script Date: 15/12/2016 10:49:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Jorge Guzman Juarez
-- Create date: 15/12/2016 10:49:17
-- Description:	Procedimiento para realizar un delete a un registro de la tabla EntradaLaboral
-- =============================================
CREATE PROCEDURE [dbo].[borrarEntrada](@IdEntrada int)
	-- Add the parameters for the stored procedure here
AS
BEGIN
	DELETE FROM EntradaLaboral WHERE IdHoraEntrada=@IdEntrada;
END

GO
/****** Object:  StoredProcedure [dbo].[borrarSalida]    Script Date: 15/12/2016 10:49:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Jorge Guzman Juarez
-- Create date: 15/12/2016 10:49:17
-- Description:	Procedimiento para realizar un delete a un registro de la tabla SalidaLaboral
-- =============================================
CREATE PROCEDURE [dbo].[borrarSalida](@IdSalida int)
	-- Add the parameters for the stored procedure here
AS
BEGIN
	DELETE FROM SalidaLaboral WHERE IdHoraSalida=@IdSalida;
END

GO
/****** Object:  StoredProcedure [dbo].[insertarDia]    Script Date: 15/12/2016 10:49:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		Jorge Guzman Juarez
-- Create date: 15/12/2016 10:49:17
-- Description:	Procedimiento para realizar un insert a un registro de la tabla DiaLaboral
-- =============================================
CREATE PROCEDURE [dbo].[insertarDia](
	-- Add the parameters for the stored procedure here
	@Empleado int,
	@HoraEntrada int,
	@HoraSalida	int,
	@FechaDia date,
	@Asistencia varchar(10)
	)
AS
BEGIN
	BEGIN TRANSACTION
        DECLARE @IdDia int;
        SELECT @IdDia = coalesce((select max(IdDiaLaboral) + 1 from DiaLaboral), 1)
    COMMIT

	INSERT INTO DiaLaboral(
		IdDiaLaboral,
		Empleado,
		HoraEntrada,
		HoraSalida,
		FechaDia,
		Asistencia
	) Values (
		@IdDia,
		@Empleado,
		@HoraEntrada,
		@HoraSalida,
		@FechaDia,
		@Asistencia
	);
END;



GO
/****** Object:  StoredProcedure [dbo].[insertarEmpleado]    Script Date: 15/12/2016 10:49:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		Jorge Guzman Juarez
-- Create date: 15/12/2016 10:49:17
-- Description:	Procedimiento para realizar un insert a un registro de la tabla Empleado
-- =============================================
CREATE PROCEDURE [dbo].[insertarEmpleado](
	-- Add the parameters for the stored procedure here
	@CURP varchar(20),
	@Nombres varchar(20),
	@ApellidoPaterno varchar(20),
	@ApellidoMaterno varchar(20),
	@FechaNacimiento date,
	@Email varchar(20),
	@Celular varchar(20),
	@Fotografia image,
	@IdTarjeta varchar(20),
	@Puesto varchar(20),
	@Departamento varchar(20),
	@HoraEntrada time,
	@HoraSalida time,
	@DiaLibre varchar(20)	
	)
AS
BEGIN
	BEGIN TRANSACTION
        DECLARE @IdEmpleado int;
        SELECT @IdEmpleado = coalesce((select max(IdEmpleado) + 1 from Empleado), 1)
    COMMIT

	Insert Into Empleado(
		IdEmpleado,
		CURP,
		Nombres,
		ApellidoPaterno,
		ApellidoMaterno,
		FechaNacimiento,
		Email,
		Celular,
		Fotografia,
		IdTarjeta,
		Puesto,
		Departamento,
		HoraEntrada,
		HoraSalida,
		DiaLibre
	) Values (
		@IdEmpleado,
		@CURP,
		@Nombres,
		@ApellidoPaterno,
		@ApellidoMaterno,
		@FechaNacimiento,
		@Email,
		@Celular,
		@Fotografia,
		@IdTarjeta,
		@Puesto,
		@Departamento,
		@HoraEntrada,
		@HoraSalida,
		@DiaLibre
	)
END;



GO
/****** Object:  StoredProcedure [dbo].[insertarEntrada]    Script Date: 15/12/2016 10:49:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		Jorge Guzman Juarez
-- Create date: 15/12/2016 10:49:17
-- Description:	Procedimiento para realizar un insert a un registro de la tabla EntradaLaboral
-- =============================================
CREATE PROCEDURE [dbo].[insertarEntrada](
	-- Add the parameters for the stored procedure here
	@Empleado int,
	@HoraEntrada time,	
	@FechaEntrada date
	)
AS
BEGIN
	BEGIN TRANSACTION
        DECLARE @IdEntrada int;
        SELECT @IdEntrada = coalesce((select max(IdHoraEntrada) + 1 from EntradaLaboral), 1)
    COMMIT

	INSERT INTO EntradaLaboral(
		IdHoraEntrada,
		Empleado,
		HoraEntrada,
		FechaEntrada
	) Values (
		@IdEntrada,
		@Empleado,
		@HoraEntrada,
		@FechaEntrada
	);
END;



GO
/****** Object:  StoredProcedure [dbo].[insertarSalida]    Script Date: 15/12/2016 10:49:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Jorge Guzman Juarez
-- Create date: 15/12/2016 10:49:17
-- Description:	Procedimiento para realizar un insert a un registro de la tabla SalidaLaboral
-- =============================================
CREATE PROCEDURE [dbo].[insertarSalida]( 
	-- Add the parameters for the stored procedure here
	@Empleado int,
	@HoraSalida time,	
	@FechaSalida date
	)
AS
BEGIN
	BEGIN TRANSACTION
        DECLARE @IdSalida int;
        SELECT @IdSalida = coalesce((select max(IdHoraSalida) + 1 from SalidaLaboral), 1)
    COMMIT

	INSERT INTO SalidaLaboral(
		IdHoraSalida,
		Empleado,
		HoraSalida,
		FechaSalida
	) Values (
		@IdSalida,
		@Empleado,
		@HoraSalida,
		@FechaSalida
	);
END;

GO
/****** Object:  StoredProcedure [dbo].[listarDias]    Script Date: 15/12/2016 10:49:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Jorge Guzman Juarez
-- Create date: 15/12/2016 10:49:17
-- Description:	Procedimiento para realizar un listado de los registros de la tabla DiaLaboral
-- =============================================
CREATE PROCEDURE [dbo].[listarDias]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	SELECT * FROM DiaLaboral ORDER BY IdDiaLaboral ASC;
END;


GO
/****** Object:  StoredProcedure [dbo].[listarEmpleados]    Script Date: 15/12/2016 10:49:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Jorge Guzman Juarez
-- Create date: 15/12/2016 10:49:17
-- Description:	Procedimiento para realizar un listado de los registros de la tabla Empleado
-- =============================================
CREATE PROCEDURE [dbo].[listarEmpleados]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	SELECT * FROM Empleado ORDER BY IdEmpleado ASC;
END;

GO
/****** Object:  StoredProcedure [dbo].[listarEntradas]    Script Date: 15/12/2016 10:49:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Jorge Guzman Juarez
-- Create date: 15/12/2016 10:49:17
-- Description:	Procedimiento para realizar un listado de los registros de la tabla EntradaLaboral
-- =============================================
CREATE PROCEDURE [dbo].[listarEntradas]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	SELECT * FROM EntradaLaboral ORDER BY IdHoraEntrada ASC;
END;


GO
/****** Object:  StoredProcedure [dbo].[listarSalidas]    Script Date: 15/12/2016 10:49:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Jorge Guzman Juarez
-- Create date: 15/12/2016 10:49:17
-- Description:	Procedimiento para realizar un listado de los registros de la tabla SalidaLaboral
-- =============================================
CREATE PROCEDURE [dbo].[listarSalidas]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	SELECT * FROM SalidaLaboral ORDER BY IdHoraSalida ASC;
END;


GO
/****** Object:  StoredProcedure [dbo].[reporteAsistencia]    Script Date: 15/12/2016 10:49:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Jorge Guzman Juarez
-- Create date: 15/12/2016 10:49:17
-- Description:	Procedimiento para realizar un reporte segun el tipo de asistencia
-- =============================================
CREATE PROCEDURE [dbo].[reporteAsistencia](
	-- Add the parameters for the stored procedure here
	@FechaInicio date,
	@FechaFinal date,
	@Asistencia varchar(10)
	)
AS
BEGIN
	SELECT * FROM DiaLaboral D WHERE D.Asistencia = @Asistencia 
	AND D.FechaDia BETWEEN @FechaInicio AND @FechaFinal;
END

GO
/****** Object:  StoredProcedure [dbo].[reporteEmpleado]    Script Date: 15/12/2016 10:49:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Jorge Guzman Juarez
-- Create date: 15/12/2016 10:49:17
-- Description:	Procedimiento para realizar un reporte segun el empleado
-- =============================================
CREATE PROCEDURE [dbo].[reporteEmpleado](
	-- Add the parameters for the stored procedure here
	@Empleado int,
	@FechaInicio date,
	@FechaFinal date
	)
AS
BEGIN
	SELECT * FROM DiaLaboral D WHERE D.Empleado = @Empleado 
	AND D.FechaDia BETWEEN @FechaInicio AND @FechaFinal;
END

GO
/****** Object:  StoredProcedure [dbo].[reporteEmpleadoAsistencia]    Script Date: 15/12/2016 10:49:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Jorge Guzman Juarez
-- Create date: 15/12/2016 10:49:17
-- Description:	Procedimiento para realizar un reporte segun el tipo de asistencia por empleado
-- =============================================
CREATE PROCEDURE [dbo].[reporteEmpleadoAsistencia](
	-- Add the parameters for the stored procedure here
	@Empleado int,
	@FechaInicio date,
	@FechaFinal date,
	@Asistencia varchar(10)
	)
AS
BEGIN
	SELECT * FROM DiaLaboral D WHERE D.Empleado = @Empleado 
	AND D.Asistencia = @Asistencia 
	AND D.FechaDia BETWEEN @FechaInicio AND @FechaFinal;
END

GO
/****** Object:  StoredProcedure [dbo].[reporteGeneral]    Script Date: 15/12/2016 10:49:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		Jorge Guzman Juarez
-- Create date: 15/12/2016 10:49:17
-- Description:	Procedimiento para realizar un reporte segun un rango de tiempo determinado
-- =============================================
CREATE PROCEDURE [dbo].[reporteGeneral](
	-- Add the parameters for the stored procedure here
	@FechaInicio date,
	@FechaFinal date
	)
AS
BEGIN
	SELECT * FROM DiaLaboral D WHERE D.FechaDia BETWEEN @FechaInicio AND @FechaFinal
END


GO
/****** Object:  StoredProcedure [dbo].[retornarDia]    Script Date: 15/12/2016 10:49:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Jorge Guzman Juarez
-- Create date: 15/12/2016 10:49:17
-- Description:	Procedimiento para realizar un retorno de un registro de la tabla DiaLaboral
-- =============================================
CREATE PROCEDURE [dbo].[retornarDia](@IdDia int)
	-- Add the parameters for the stored procedure here
AS
BEGIN
	SELECT * FROM DiaLaboral WHERE IdDiaLaboral=@IdDia;
END;


GO
/****** Object:  StoredProcedure [dbo].[retornarEmpleado]    Script Date: 15/12/2016 10:49:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Jorge Guzman Juarez
-- Create date: 15/12/2016 10:49:17
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[retornarEmpleado](@IdEmpleado int)
	-- Add the parameters for the stored procedure here
AS
BEGIN
	SELECT * FROM Empleado WHERE IdEmpleado=@IdEmpleado;
END;

GO
/****** Object:  StoredProcedure [dbo].[retornarEntrada]    Script Date: 15/12/2016 10:49:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Jorge Guzman Juarez
-- Create date: 15/12/2016 10:49:17
-- Description:	Procedimiento para realizar un retorno de un registro de la tabla EntradaLaboral
-- =============================================
CREATE PROCEDURE [dbo].[retornarEntrada](@IdEntrada int)
	-- Add the parameters for the stored procedure here
AS
BEGIN
	SELECT * FROM EntradaLaboral WHERE IdHoraEntrada=@IdEntrada;
END;


GO
/****** Object:  StoredProcedure [dbo].[retornarEntradaporDia]    Script Date: 15/12/2016 10:49:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



-- =============================================
-- Author:		Jorge Guzman Juarez
-- Create date: 15/12/2016 10:49:17
-- Description:	Procedimiento para realizar un retorno de un registro de la tabla EntradaLaboral
-- =============================================
CREATE PROCEDURE [dbo].[retornarEntradaporDia](@IdEmpleado int,@Dia date)
	-- Add the parameters for the stored procedure here
AS
BEGIN
	SELECT * FROM EntradaLaboral WHERE Empleado=@IdEmpleado AND FechaEntrada=@Dia;
END;




GO
/****** Object:  StoredProcedure [dbo].[retornarSalida]    Script Date: 15/12/2016 10:49:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Jorge Guzman Juarez
-- Create date: 15/12/2016 10:49:17
-- Description:	Procedimiento para realizar un retorno de un registro de la tabla SalidaLaboral
-- =============================================
CREATE PROCEDURE [dbo].[retornarSalida](@IdSalida int)
	-- Add the parameters for the stored procedure here
AS
BEGIN
	SELECT * FROM SalidaLaboral WHERE IdHoraSalida=@IdSalida;
END;


GO
/****** Object:  StoredProcedure [dbo].[retornarSalidaporDia]    Script Date: 15/12/2016 10:49:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



-- =============================================
-- Author:		Jorge Guzman Juarez
-- Create date: 15/12/2016 10:49:17
-- Description:	Procedimiento para realizar un retorno de un registro de la tabla SalidaLaboral
-- =============================================
CREATE PROCEDURE [dbo].[retornarSalidaporDia](@IdEmpleado int,@Dia date)
	-- Add the parameters for the stored procedure here
AS
BEGIN
	SELECT * FROM SalidaLaboral WHERE Empleado=@IdEmpleado AND FechaSalida=@Dia;
END;




GO
/****** Object:  Table [dbo].[DiaLaboral]    Script Date: 15/12/2016 10:49:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DiaLaboral](
	[IdDiaLaboral] [int] NOT NULL,
	[Empleado] [int] NULL,
	[HoraEntrada] [int] NULL,
	[HoraSalida] [int] NULL,
	[FechaDia] [date] NULL,
	[Asistencia] [varchar](10) NULL,
 CONSTRAINT [PK_DiaLaboral] PRIMARY KEY CLUSTERED 
(
	[IdDiaLaboral] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 15/12/2016 10:49:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Empleado](
	[IdEmpleado] [int] NOT NULL,
	[CURP] [varchar](20) NULL,
	[Nombres] [varchar](20) NULL,
	[ApellidoPaterno] [varchar](20) NULL,
	[ApellidoMaterno] [varchar](20) NULL,
	[FechaNacimiento] [date] NULL,
	[Email] [varchar](20) NULL,
	[Celular] [varchar](20) NULL,
	[Fotografia] [image] NULL,
	[IdTarjeta] [varchar](20) NULL,
	[Puesto] [varchar](20) NULL,
	[Departamento] [varchar](20) NULL,
	[HoraEntrada] [time](0) NULL,
	[HoraSalida] [time](0) NULL,
	[DiaLibre] [varchar](20) NULL,
 CONSTRAINT [PK_Empleado] PRIMARY KEY CLUSTERED 
(
	[IdEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EntradaLaboral]    Script Date: 15/12/2016 10:49:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EntradaLaboral](
	[IdHoraEntrada] [int] NOT NULL,
	[Empleado] [int] NULL,
	[HoraEntrada] [time](0) NULL,
	[FechaEntrada] [date] NULL,
 CONSTRAINT [PK_EntradaLaboral] PRIMARY KEY CLUSTERED 
(
	[IdHoraEntrada] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SalidaLaboral]    Script Date: 15/12/2016 10:49:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalidaLaboral](
	[IdHoraSalida] [int] NOT NULL,
	[Empleado] [int] NULL,
	[HoraSalida] [time](0) NULL,
	[FechaSalida] [date] NULL,
 CONSTRAINT [PK_SalidaLaboral] PRIMARY KEY CLUSTERED 
(
	[IdHoraSalida] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[DiaLaboral]  WITH CHECK ADD  CONSTRAINT [FK_DiaLaboral_Empleado] FOREIGN KEY([Empleado])
REFERENCES [dbo].[Empleado] ([IdEmpleado])
GO
ALTER TABLE [dbo].[DiaLaboral] CHECK CONSTRAINT [FK_DiaLaboral_Empleado]
GO
ALTER TABLE [dbo].[DiaLaboral]  WITH CHECK ADD  CONSTRAINT [FK_DiaLaboral_EntradaLaboral] FOREIGN KEY([HoraEntrada])
REFERENCES [dbo].[EntradaLaboral] ([IdHoraEntrada])
GO
ALTER TABLE [dbo].[DiaLaboral] CHECK CONSTRAINT [FK_DiaLaboral_EntradaLaboral]
GO
ALTER TABLE [dbo].[DiaLaboral]  WITH CHECK ADD  CONSTRAINT [FK_DiaLaboral_SalidaLaboral] FOREIGN KEY([HoraSalida])
REFERENCES [dbo].[SalidaLaboral] ([IdHoraSalida])
GO
ALTER TABLE [dbo].[DiaLaboral] CHECK CONSTRAINT [FK_DiaLaboral_SalidaLaboral]
GO
ALTER TABLE [dbo].[EntradaLaboral]  WITH CHECK ADD  CONSTRAINT [FK_EntradaLaboral_Empleado] FOREIGN KEY([Empleado])
REFERENCES [dbo].[Empleado] ([IdEmpleado])
GO
ALTER TABLE [dbo].[EntradaLaboral] CHECK CONSTRAINT [FK_EntradaLaboral_Empleado]
GO
ALTER TABLE [dbo].[SalidaLaboral]  WITH CHECK ADD  CONSTRAINT [FK_SalidaLaboral_Empleado] FOREIGN KEY([Empleado])
REFERENCES [dbo].[Empleado] ([IdEmpleado])
GO
ALTER TABLE [dbo].[SalidaLaboral] CHECK CONSTRAINT [FK_SalidaLaboral_Empleado]
GO
