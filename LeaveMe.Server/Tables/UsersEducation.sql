﻿CREATE TABLE [dbo].[UsersEducation]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
	[UserID] UNIQUEIDENTIFIER NOT NULL, 
	[Institute] NVARCHAR(250) NOT NULL,
	[CourseSpecialization] NVARCHAR(250) NOT NULL,
	[GPA] DECIMAL(4,2) NULL, 
	[StartPeriod] NVARCHAR(10) NOT NULL, 
	[EndPeriod] NVARCHAR(10) NOT NULL, 
	[Comments]  NVARCHAR(800) NULL, 
	[IsActive] BIT NULL DEFAULT 1, 
	[CreatedBy] UNIQUEIDENTIFIER NOT NULL, 
	[UpdatedBy] UNIQUEIDENTIFIER NULL, 
	[CreatedDate] DATETIME NOT NULL DEFAULT (getdate()) , 
	[UpdatedDate] DATETIME NULL, 
	CONSTRAINT [FK_UserEducation_ToUser] FOREIGN KEY ([UserID]) REFERENCES [Users]([UserID]) 
)
