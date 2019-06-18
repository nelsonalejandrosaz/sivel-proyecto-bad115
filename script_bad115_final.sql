/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     17/06/2019 21:18:33                          */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('IMPORTACIONES') and o.name = 'FK_IMPORTAC_ESTADO_ESTADO_I')
alter table IMPORTACIONES
   drop constraint FK_IMPORTAC_ESTADO_ESTADO_I
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('IMPORTACIONES') and o.name = 'FK_IMPORTAC_PERTENECE_VEHICULO')
alter table IMPORTACIONES
   drop constraint FK_IMPORTAC_PERTENECE_VEHICULO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('IMPORTACIONES') and o.name = 'FK_IMPORTAC_REALIZA_IMPORTAD')
alter table IMPORTACIONES
   drop constraint FK_IMPORTAC_REALIZA_IMPORTAD
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('IMPORTACIONES') and o.name = 'FK_IMPORTAC_TIENE_UNA_UBICACIO')
alter table IMPORTACIONES
   drop constraint FK_IMPORTAC_TIENE_UNA_UBICACIO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('MOVIMIENTOS') and o.name = 'FK_MOVIMIEN_AUTORIZO_USUARIOS')
alter table MOVIMIENTOS
   drop constraint FK_MOVIMIEN_AUTORIZO_USUARIOS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('MOVIMIENTOS') and o.name = 'FK_MOVIMIEN_ES_DE_TIPO_MOV')
alter table MOVIMIENTOS
   drop constraint FK_MOVIMIEN_ES_DE_TIPO_MOV
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('MOVIMIENTOS') and o.name = 'FK_MOVIMIEN_REMOLCADO_TIPO_REM')
alter table MOVIMIENTOS
   drop constraint FK_MOVIMIEN_REMOLCADO_TIPO_REM
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('MOVIMIENTOS') and o.name = 'FK_MOVIMIEN_REPARADO__TALLERES')
alter table MOVIMIENTOS
   drop constraint FK_MOVIMIEN_REPARADO__TALLERES
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('MOVIMIENTOS') and o.name = 'FK_MOVIMIEN_TIENE_IMPORTAC')
alter table MOVIMIENTOS
   drop constraint FK_MOVIMIEN_TIENE_IMPORTAC
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('UBICACIONES') and o.name = 'FK_UBICACIO_PERTENECE_BODEGAS')
alter table UBICACIONES
   drop constraint FK_UBICACIO_PERTENECE_BODEGAS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('USUARIOS') and o.name = 'FK_USUARIOS_TIENE_ROL_ROLES')
alter table USUARIOS
   drop constraint FK_USUARIOS_TIENE_ROL_ROLES
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BODEGAS')
            and   type = 'U')
   drop table BODEGAS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ESTADO_IMPORTACIONES')
            and   type = 'U')
   drop table ESTADO_IMPORTACIONES
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('IMPORTACIONES')
            and   name  = 'ESTADO_FK'
            and   indid > 0
            and   indid < 255)
   drop index IMPORTACIONES.ESTADO_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('IMPORTACIONES')
            and   name  = 'TIENE_UNA_FK'
            and   indid > 0
            and   indid < 255)
   drop index IMPORTACIONES.TIENE_UNA_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('IMPORTACIONES')
            and   name  = 'PERTENECE_FK'
            and   indid > 0
            and   indid < 255)
   drop index IMPORTACIONES.PERTENECE_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('IMPORTACIONES')
            and   name  = 'REALIZA_FK'
            and   indid > 0
            and   indid < 255)
   drop index IMPORTACIONES.REALIZA_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('IMPORTACIONES')
            and   type = 'U')
   drop table IMPORTACIONES
go

if exists (select 1
            from  sysobjects
           where  id = object_id('IMPORTADORES')
            and   type = 'U')
   drop table IMPORTADORES
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('MOVIMIENTOS')
            and   name  = 'REMOLCADO_EN_FK'
            and   indid > 0
            and   indid < 255)
   drop index MOVIMIENTOS.REMOLCADO_EN_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('MOVIMIENTOS')
            and   name  = 'AUTORIZO_FK'
            and   indid > 0
            and   indid < 255)
   drop index MOVIMIENTOS.AUTORIZO_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('MOVIMIENTOS')
            and   name  = 'TIENE_FK'
            and   indid > 0
            and   indid < 255)
   drop index MOVIMIENTOS.TIENE_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('MOVIMIENTOS')
            and   name  = 'ES_DE_FK'
            and   indid > 0
            and   indid < 255)
   drop index MOVIMIENTOS.ES_DE_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('MOVIMIENTOS')
            and   name  = 'REPARADO_EN_FK'
            and   indid > 0
            and   indid < 255)
   drop index MOVIMIENTOS.REPARADO_EN_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('MOVIMIENTOS')
            and   type = 'U')
   drop table MOVIMIENTOS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ROLES')
            and   type = 'U')
   drop table ROLES
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TALLERES')
            and   type = 'U')
   drop table TALLERES
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TIPO_MOVIMIENTOS')
            and   type = 'U')
   drop table TIPO_MOVIMIENTOS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TIPO_REMOLQUES')
            and   type = 'U')
   drop table TIPO_REMOLQUES
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('UBICACIONES')
            and   name  = 'PERTENECE_A_FK'
            and   indid > 0
            and   indid < 255)
   drop index UBICACIONES.PERTENECE_A_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('UBICACIONES')
            and   type = 'U')
   drop table UBICACIONES
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('USUARIOS')
            and   name  = 'TIENE_ROL_FK'
            and   indid > 0
            and   indid < 255)
   drop index USUARIOS.TIENE_ROL_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('USUARIOS')
            and   type = 'U')
   drop table USUARIOS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('VEHICULOS')
            and   type = 'U')
   drop table VEHICULOS
go

/*==============================================================*/
/* Table: BODEGAS                                               */
/*==============================================================*/
create table BODEGAS (
   ID_BODEGA            int                  identity,
   NOMBRE_USER          varchar(50)          not null,
   CAPACIDAD_MAX        int                  not null,
   constraint PK_BODEGAS primary key nonclustered (ID_BODEGA)
)
go

/*==============================================================*/
/* Table: ESTADO_IMPORTACIONES                                  */
/*==============================================================*/
create table ESTADO_IMPORTACIONES (
   _ESTADO_IMPORTACION  int                  identity,
   ESTADO_IMPORTACION   varchar(50)          not null,
   constraint PK_ESTADO_IMPORTACIONES primary key nonclustered (_ESTADO_IMPORTACION)
)
go

/*==============================================================*/
/* Table: IMPORTACIONES                                         */
/*==============================================================*/
create table IMPORTACIONES (
   ATTRIBUTE_15         int                  identity,
   ID_UBICACION         int                  not null,
   _ESTADO_IMPORTACION  int                  not null,
   ID_IMPORTADOR        int                  not null,
   ID_VEHICULO          int                  not null,
   FECHA                datetime             not null,
   DESPERFECTO          varchar(280)         not null,
   PRECIO_VENTA         decimal(14,4)        null,
   constraint PK_IMPORTACIONES primary key nonclustered (ATTRIBUTE_15)
)
go

/*==============================================================*/
/* Index: REALIZA_FK                                            */
/*==============================================================*/
create index REALIZA_FK on IMPORTACIONES (
ID_IMPORTADOR ASC
)
go

/*==============================================================*/
/* Index: PERTENECE_FK                                          */
/*==============================================================*/
create index PERTENECE_FK on IMPORTACIONES (
ID_VEHICULO ASC
)
go

/*==============================================================*/
/* Index: TIENE_UNA_FK                                          */
/*==============================================================*/
create index TIENE_UNA_FK on IMPORTACIONES (
ID_UBICACION ASC
)
go

/*==============================================================*/
/* Index: ESTADO_FK                                             */
/*==============================================================*/
create index ESTADO_FK on IMPORTACIONES (
_ESTADO_IMPORTACION ASC
)
go

/*==============================================================*/
/* Table: IMPORTADORES                                          */
/*==============================================================*/
create table IMPORTADORES (
   ID_IMPORTADOR        int                  identity,
   NIT                  int                  not null,
   NOMBRES              varchar(50)          not null,
   APELLIDOS            varchar(50)          not null,
   APELLIDO_CASADA      varchar(50)          null,
   GENERO               char(1)              not null,
   FECHA_NACIMIENTO     datetime             not null,
   DIRECCION            varchar(280)         not null,
   PERSONA_RESPONSABLE  varchar(100)         not null,
   TELEFONO_RESPONSABLE char(50)             not null,
   EMAIL                varchar(100)         not null,
   constraint PK_IMPORTADORES primary key nonclustered (ID_IMPORTADOR)
)
go

/*==============================================================*/
/* Table: MOVIMIENTOS                                           */
/*==============================================================*/
create table MOVIMIENTOS (
   ID_MOVIMIENTO        int                  identity,
   ID_USUARIOS          int                  not null,
   ID_TALLER            int                  null,
   ATTRIBUTE_15         int                  not null,
   ID_TIPO              int                  not null,
   ID_TIPO_REMOLQUE     int                  null,
   FECHA_MOVIMIENTO     datetime             not null,
   constraint PK_MOVIMIENTOS primary key nonclustered (ID_MOVIMIENTO)
)
go

/*==============================================================*/
/* Index: REPARADO_EN_FK                                        */
/*==============================================================*/
create index REPARADO_EN_FK on MOVIMIENTOS (
ID_TALLER ASC
)
go

/*==============================================================*/
/* Index: ES_DE_FK                                              */
/*==============================================================*/
create index ES_DE_FK on MOVIMIENTOS (
ID_TIPO ASC
)
go

/*==============================================================*/
/* Index: TIENE_FK                                              */
/*==============================================================*/
create index TIENE_FK on MOVIMIENTOS (
ATTRIBUTE_15 ASC
)
go

/*==============================================================*/
/* Index: AUTORIZO_FK                                           */
/*==============================================================*/
create index AUTORIZO_FK on MOVIMIENTOS (
ID_USUARIOS ASC
)
go

/*==============================================================*/
/* Index: REMOLCADO_EN_FK                                       */
/*==============================================================*/
create index REMOLCADO_EN_FK on MOVIMIENTOS (
ID_TIPO_REMOLQUE ASC
)
go

/*==============================================================*/
/* Table: ROLES                                                 */
/*==============================================================*/
create table ROLES (
   ID_ROLES             int                  identity,
   ROL                  varchar(50)          not null,
   constraint PK_ROLES primary key nonclustered (ID_ROLES)
)
go

/*==============================================================*/
/* Table: TALLERES                                              */
/*==============================================================*/
create table TALLERES (
   ID_TALLER            int                  identity,
   NOMBRE_TALLER        varchar(100)         not null,
   constraint PK_TALLERES primary key nonclustered (ID_TALLER)
)
go

/*==============================================================*/
/* Table: TIPO_MOVIMIENTOS                                      */
/*==============================================================*/
create table TIPO_MOVIMIENTOS (
   ID_TIPO              int                  identity,
   TIPO_MOVIMIENTO      varchar(30)          not null,
   constraint PK_TIPO_MOVIMIENTOS primary key nonclustered (ID_TIPO)
)
go

/*==============================================================*/
/* Table: TIPO_REMOLQUES                                        */
/*==============================================================*/
create table TIPO_REMOLQUES (
   ID_TIPO_REMOLQUE     int                  identity,
   TIPO_REMOLQUE        varchar(50)          not null,
   CAPACIDAD_REMOLQUE   int                  not null,
   constraint PK_TIPO_REMOLQUES primary key nonclustered (ID_TIPO_REMOLQUE)
)
go

/*==============================================================*/
/* Table: UBICACIONES                                           */
/*==============================================================*/
create table UBICACIONES (
   ID_UBICACION         int                  identity,
   ID_BODEGA            int                  not null,
   NIVEL                int                  null,
   NUMERO_PARQUEO       int                  null,
   constraint PK_UBICACIONES primary key nonclustered (ID_UBICACION)
)
go

/*==============================================================*/
/* Index: PERTENECE_A_FK                                        */
/*==============================================================*/
create index PERTENECE_A_FK on UBICACIONES (
ID_BODEGA ASC
)
go

/*==============================================================*/
/* Table: USUARIOS                                              */
/*==============================================================*/
create table USUARIOS (
   ID_USUARIOS          int                  identity,
   ID_ROLES             int                  not null,
   EMAIL                varchar(100)         not null,
   PASSWORD             varchar(280)         not null,
   NOMBRE_USER          varchar(50)          not null,
   constraint PK_USUARIOS primary key nonclustered (ID_USUARIOS)
)
go

/*==============================================================*/
/* Index: TIENE_ROL_FK                                          */
/*==============================================================*/
create index TIENE_ROL_FK on USUARIOS (
ID_ROLES ASC
)
go

/*==============================================================*/
/* Table: VEHICULOS                                             */
/*==============================================================*/
create table VEHICULOS (
   ID_VEHICULO          int                  identity,
   MARCA                varchar(50)          not null,
   MODELO               varchar(50)          not null,
   ANO                  int                  not null,
   constraint PK_VEHICULOS primary key nonclustered (ID_VEHICULO)
)
go

alter table IMPORTACIONES
   add constraint FK_IMPORTAC_ESTADO_ESTADO_I foreign key (_ESTADO_IMPORTACION)
      references ESTADO_IMPORTACIONES (_ESTADO_IMPORTACION)
go

alter table IMPORTACIONES
   add constraint FK_IMPORTAC_PERTENECE_VEHICULO foreign key (ID_VEHICULO)
      references VEHICULOS (ID_VEHICULO)
go

alter table IMPORTACIONES
   add constraint FK_IMPORTAC_REALIZA_IMPORTAD foreign key (ID_IMPORTADOR)
      references IMPORTADORES (ID_IMPORTADOR)
go

alter table IMPORTACIONES
   add constraint FK_IMPORTAC_TIENE_UNA_UBICACIO foreign key (ID_UBICACION)
      references UBICACIONES (ID_UBICACION)
go

alter table MOVIMIENTOS
   add constraint FK_MOVIMIEN_AUTORIZO_USUARIOS foreign key (ID_USUARIOS)
      references USUARIOS (ID_USUARIOS)
go

alter table MOVIMIENTOS
   add constraint FK_MOVIMIEN_ES_DE_TIPO_MOV foreign key (ID_TIPO)
      references TIPO_MOVIMIENTOS (ID_TIPO)
go

alter table MOVIMIENTOS
   add constraint FK_MOVIMIEN_REMOLCADO_TIPO_REM foreign key (ID_TIPO_REMOLQUE)
      references TIPO_REMOLQUES (ID_TIPO_REMOLQUE)
go

alter table MOVIMIENTOS
   add constraint FK_MOVIMIEN_REPARADO__TALLERES foreign key (ID_TALLER)
      references TALLERES (ID_TALLER)
go

alter table MOVIMIENTOS
   add constraint FK_MOVIMIEN_TIENE_IMPORTAC foreign key (ATTRIBUTE_15)
      references IMPORTACIONES (ATTRIBUTE_15)
go

alter table UBICACIONES
   add constraint FK_UBICACIO_PERTENECE_BODEGAS foreign key (ID_BODEGA)
      references BODEGAS (ID_BODEGA)
go

alter table USUARIOS
   add constraint FK_USUARIOS_TIENE_ROL_ROLES foreign key (ID_ROLES)
      references ROLES (ID_ROLES)
go

/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 17/06/2019 10:25:21 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 17/06/2019 10:25:21 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](256) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 17/06/2019 10:25:21 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](128) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 17/06/2019 10:25:21 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](128) NOT NULL,
	[ProviderKey] [nvarchar](128) NOT NULL,
	[UserId] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC,
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 17/06/2019 10:25:21 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](128) NOT NULL,
	[RoleId] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 17/06/2019 10:25:21 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](128) NOT NULL,
	[Email] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEndDateUtc] [datetime] NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[UserName] [nvarchar](256) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [RoleNameIndex]    Script Date: 17/06/2019 10:25:21 p.m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_UserId]    Script Date: 17/06/2019 10:25:21 p.m. ******/
CREATE NONCLUSTERED INDEX [IX_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_UserId]    Script Date: 17/06/2019 10:25:21 p.m. ******/
CREATE NONCLUSTERED INDEX [IX_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_RoleId]    Script Date: 17/06/2019 10:25:21 p.m. ******/
CREATE NONCLUSTERED INDEX [IX_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_UserId]    Script Date: 17/06/2019 10:25:21 p.m. ******/
CREATE NONCLUSTERED INDEX [IX_UserId] ON [dbo].[AspNetUserRoles]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UserNameIndex]    Script Date: 17/06/2019 10:25:21 p.m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId]
GO
USE [master]
GO