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
ALTER TABLE dbo.b_cust_checkup_patient_value_normal ADD
	uric_acid_value_normal nvarchar(255) NULL,
	uric_acid_value_lower nvarchar(255) NULL,
	uric_acid_value_upper nvarchar(255) NULL,
	uric_acid_value_lower_suggess nvarchar(255) NULL,
	uric_acid_value_upper_suggess nvarchar(255) NULL
GO
ALTER TABLE dbo.b_cust_checkup_patient_value_normal SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
