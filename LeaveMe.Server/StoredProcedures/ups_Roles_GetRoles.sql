﻿CREATE PROCEDURE [dbo].[ups_Roles_GetRoles]
AS
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;
BEGIN
	SELECT RoleID,RoleName,RoleDescription FROM dbo.Roles
	WHERE IsActive=1
END
