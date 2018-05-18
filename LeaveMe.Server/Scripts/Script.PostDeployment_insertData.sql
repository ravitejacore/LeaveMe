/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
			   SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

DECLARE @id as uniqueidentifier 
SELECT @id =  newid()

IF NOT EXISTS ( SELECT 1 FROM [dbo].[Users] WHERE [Email]='admin@srgtech.com')
BEGIN
INSERT INTO [dbo].[Users]
			([UserID],[UserName],[Email],[Password],[IsActive],[CreatedBy],[CreatedDate])
		VALUES     
			(@id, 'raviteja', 'admin@srgtech.com', 'abcd123#', 1, @id ,GETDATE())
END

IF NOT EXISTS ( SELECT 1 FROM [dbo].[Roles] WHERE [RoleName]='System Administrator')
BEGIN
INSERT INTO [dbo].[Roles]
		   ([RoleName],[RoleDescription],[IsActive],[CreatedBy],[CreatedDate])
	 VALUES
		   ('System Administrator' ,'System Administrator',1 ,@id ,GETDATE())

END

IF NOT EXISTS ( SELECT 1 FROM [dbo].[UsersRole] WHERE [UserID]= (SELECT [UserID] FROM [dbo].[Users] WHERE [Email]='admin@srgtech.com')
 AND [RoleID] = ( SELECT RoleID FROM [dbo].[Roles] WHERE [RoleName] ='System Administrator'))
BEGIN
INSERT INTO [dbo].[UsersRole]
		   ([UserID],[RoleID],[IsActive],[CreatedBy],[CreatedDate])
	 VALUES
		   (@id,
			( select RoleID from [dbo].[Roles] where [RoleName] ='System Administrator') ,
			1, @id,GETDATE()
			)

END

IF NOT EXISTS (SELECT 1 FROM [dbo].[UsersProfile] WHERE [UserID]= (SELECT [UserID] FROM [dbo].[Users] WHERE [Email]='admin@srgtech.com'))
BEGIN
INSERT INTO [dbo].[UsersProfile]
		   ([UserID],[FirstName],[MiddleName],[LastName],[DisplayID],[IsActive],[CreatedBy],[CreatedDate])
	 VALUES
		   (@id,'Ravi','Teja','Koneru','ravitejakoneru',1,@id,GETDATE()  )

END



INSERT INTO [dbo].[WorkTitles] ([WorkTitle] ,[WorkDescription] ,[IsActive] ,[CreatedBy] ,[CreatedDate])
     VALUES ('Junior Developer','Junior Developer',1
	       ,(SELECT UserID FROM [dbo].[Users] WHERE [Email]='admin@srgtech.com')
           ,GETDATE() )
GO

INSERT INTO [dbo].[WorkTitles] ([WorkTitle] ,[WorkDescription] ,[IsActive] ,[CreatedBy] ,[CreatedDate])
     VALUES ('Software developer','Software developer',1
	       ,(SELECT UserID FROM [dbo].[Users] WHERE [Email]='admin@srgtech.com')
           ,GETDATE() )
GO

INSERT INTO [dbo].[WorkTitles] ([WorkTitle] ,[WorkDescription] ,[IsActive] ,[CreatedBy] ,[CreatedDate])
     VALUES ('Senior Software Engineer','Senior Software Engineer',1
	       ,(SELECT UserID FROM [dbo].[Users] WHERE [Email]='admin@srgtech.com')
           ,GETDATE() )
GO

INSERT INTO [dbo].[WorkTitles] ([WorkTitle] ,[WorkDescription] ,[IsActive] ,[CreatedBy] ,[CreatedDate])
     VALUES ('Team Leader','Team Leader',1
	       ,(SELECT UserID FROM [dbo].[Users] WHERE [Email]='admin@srgtech.com')
           ,GETDATE() )
GO

INSERT INTO [dbo].[WorkTitles] ([WorkTitle] ,[WorkDescription] ,[IsActive] ,[CreatedBy] ,[CreatedDate])
    VALUES ('Senior Quality Analyst','Senior Quality Analyst',1
	    ,(SELECT UserID FROM [dbo].[Users] WHERE [Email]='admin@srgtech.com')
        ,GETDATE() )
GO

INSERT INTO [dbo].[WorkTitles] ([WorkTitle] ,[WorkDescription] ,[IsActive] ,[CreatedBy] ,[CreatedDate])
    VALUES ('Project leader','Project leader',1
	    ,(SELECT UserID FROM [dbo].[Users] WHERE [Email]='admin@srgtech.com')
        ,GETDATE() )
GO

INSERT INTO [dbo].[WorkTitles] ([WorkTitle] ,[WorkDescription] ,[IsActive] ,[CreatedBy] ,[CreatedDate])
    VALUES ('Project manager','Project manager',1
	    ,(SELECT UserID FROM [dbo].[Users] WHERE [Email]='admin@srgtech.com')
        ,GETDATE() )
GO

INSERT INTO [dbo].[WorkTitles] ([WorkTitle] ,[WorkDescription] ,[IsActive] ,[CreatedBy] ,[CreatedDate])
    VALUES ('Chief Executive Officer','Chief Executive Officer ',1
	    ,(SELECT UserID FROM [dbo].[Users] WHERE [Email]='admin@srgtech.com')
        ,GETDATE() )
GO