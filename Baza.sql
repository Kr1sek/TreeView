IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'DataDB')
  BEGIN
    CREATE DATABASE [DataDB]


    END
    GO

USE [DataDB]
GO

/****** Object:  Table [dbo].[Data]    Script Date: 16.06.2022 20:28:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Data](
	[DataId] [int] IDENTITY(1,1) NOT NULL,
	[DataName] [varchar](100) NULL,
	[ParentId] [int] NOT NULL,
 CONSTRAINT [PK_Data] PRIMARY KEY CLUSTERED 
(
	[DataId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Data] ADD  CONSTRAINT [DF_Data_ParentId]  DEFAULT ((0)) FOR [ParentId]
GO

insert into Data (DataName, ParentId) values ('Test1', 0)
insert into Data (DataName, ParentId) values ('Test2', 1)
insert into Data (DataName, ParentId) values ('Test3', 2)
insert into Data (DataName, ParentId) values ('Test4', 0)
insert into Data (DataName, ParentId) values ('Test5', 2)
insert into Data (DataName, ParentId) values ('Test6', 1)
insert into Data (DataName, ParentId) values ('Test7', 1)
insert into Data (DataName, ParentId) values ('Test8', 5)
insert into Data (DataName, ParentId) values ('Test9', 3)
insert into Data (DataName, ParentId) values ('Test10', 0)
insert into Data (DataName, ParentId) values ('Test1', 0)


