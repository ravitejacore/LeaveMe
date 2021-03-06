﻿CREATE TABLE [dbo].[UsersReporting]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[UserID] UNIQUEIDENTIFIER NOT NULL,
	[RepotingToUserID] UNIQUEIDENTIFIER NOT NULL,
	[IsDirectRepoting] BIT NOT NULL,
	[IsActive] BIT NULL DEFAULT 1, 
	[CreatedBy] UNIQUEIDENTIFIER NOT NULL, 
	[UpdatedBy] UNIQUEIDENTIFIER NULL, 
	[CreatedDate] DATETIME NOT NULL DEFAULT (getdate()) , 
	[UpdatedDate] DATETIME NULL 
	CONSTRAINT [FK_UserReporting_ToUser] FOREIGN KEY ([UserID]) REFERENCES [Users]([UserID])
	CONSTRAINT [FK_UserReporting_RepotingToUserID_ToUser] FOREIGN KEY ([RepotingToUserID]) REFERENCES [Users]([UserID])


)
