/*
   Thursday, August 30, 20183:20:41 PM
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
CREATE TABLE dbo.b_lab_map
	(
	lab_map_id int NOT NULL,
	lab_map_code nvarchar(255) NULL,
	lab_map_name nvarchar(255) NULL,
	lab_map_code_lis nvarchar(255) NULL,
	active nvarchar(255) NULL,
	date_create nvarchar(255) NULL,
	date_modi nvarchar(255) NULL,
	date_cancel nvarchar(255) NULL,
	user_create nvarchar(255) NULL,
	user_modi nvarchar(255) NULL,
	user_cancel nvarchar(255) NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Table_1 ADD CONSTRAINT
	PK_Table_1 PRIMARY KEY CLUSTERED 
	(
	lab_map_id
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Table_1 SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
