/*
   Saturday, August 11, 20187:28:21 PM
   User: sa
   Server: DESKTOP-N9H5I8B\SQLEXPRESS
   Database: checkup
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
ALTER TABLE dbo.t_cust_checkup_patient ADD
	test01 nvarchar(255) NULL,
	test02 nvarchar(255) NULL,
	test03 nvarchar(255) NULL,
	test04 nvarchar(255) NULL,
	test05 nvarchar(255) NULL,
	test06 nvarchar(255) NULL,
	test07 nvarchar(255) NULL,
	test08 nvarchar(255) NULL,
	test09 nvarchar(255) NULL,
	test10 nvarchar(255) NULL,
	test11 nvarchar(255) NULL,
	test12 nvarchar(255) NULL,
	test13 nvarchar(255) NULL,
	test14 nvarchar(255) NULL,
	test15 nvarchar(255) NULL,
	test16 nvarchar(255) NULL,
	test17 nvarchar(255) NULL,
	test18 nvarchar(255) NULL,
	test19 nvarchar(255) NULL,
	test20 nvarchar(255) NULL
GO
ALTER TABLE dbo.t_cust_checkup_patient SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
