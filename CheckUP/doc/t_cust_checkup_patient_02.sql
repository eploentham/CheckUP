/*
   Sunday, August 12, 20185:30:17 PM
   User: sa
   Server: DESKTOP-M5IUDNE\SQLEXPRESS
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
	ekg nvarchar(255) NULL,
	ekg_result nvarchar(255) NULL,
	ekg_summary nvarchar(255) NULL
GO
ALTER TABLE dbo.t_cust_checkup_patient SET (LOCK_ESCALATION = TABLE)
GO
COMMIT


Warning: The table "t_cust_checkup_patient" has been created, but its maximum row size exceeds the allowed maximum of 8060 bytes. INSERT or UPDATE to this table will fail if the resulting row exceeds the size limit.
