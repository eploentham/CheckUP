/*
   Friday, September 7, 20188:50:19 AM
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
ALTER TABLE dbo.t_cust_checkup ADD
	sticker01_name nvarchar(255) NULL,
	sticker02_name nvarchar(255) NULL,
	sticker03_name nvarchar(255) NULL,
	sticker04_name nvarchar(255) NULL,
	sticker05_name nvarchar(255) NULL,
	sticker06_name nvarchar(255) NULL,
	sticker07_name nvarchar(255) NULL,
	sticker08_name nvarchar(255) NULL,
	sticker09_name nvarchar(255) NULL,
	sticker10_name nvarchar(255) NULL,
	sticker11_name nvarchar(255) NULL,
	sticker12_name nvarchar(255) NULL,
	sticker13_name nvarchar(255) NULL,
	sticker14_name nvarchar(255) NULL,
	sticker15_name nvarchar(255) NULL,
	sticker16_name nvarchar(255) NULL,
	sticker17_name nvarchar(255) NULL,
	sticker18_name nvarchar(255) NULL,
	sticker19_name nvarchar(255) NULL,
	sticker20_name nvarchar(255) NULL
GO
ALTER TABLE dbo.t_cust_checkup SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
