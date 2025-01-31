/*
   Wednesday, 15 January 202511:26:36 am
   User: 
   Server: DESKTOP-TD8UC8F
   Database: dbqueue
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
ALTER TABLE dbo.Clients ADD
	InvoiceNumber nvarchar(50) NULL
GO
ALTER TABLE dbo.Clients SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
