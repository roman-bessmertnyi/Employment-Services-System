/*
   10 января 2018 г.10:26:51
   User: 
   Server: (LocalDb)\MSSQLLocalDB
   Database: Employment-Services-System-Alpha
   Application: 
*/

/* To prevent any potential data loss issues, you should review this script in detail before running it outside the context of the database designer.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
EXECUTE sp_rename N'dbo.education_detail.Institute_university_name', N'Tmp_institute_university_name', 'COLUMN' 
GO
EXECUTE sp_rename N'dbo.education_detail.Tmp_institute_university_name', N'institute_university_name', 'COLUMN' 
GO
ALTER TABLE dbo.education_detail SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
