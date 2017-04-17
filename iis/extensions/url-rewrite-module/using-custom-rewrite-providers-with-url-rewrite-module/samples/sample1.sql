USE [master]

CREATE LOGIN [IIS APPPOOL\DefaultAppPool] FROM WINDOWS WITH DEFAULT_DATABASE=[master]

CREATE DATABASE [RewriteDB]
GO

USE [RewriteDB]
GO

CREATE TABLE [dbo].[RewriteTable](
[OriginalUrl] [nvarchar](256) NOT NULL,
[NewUrl] [nvarchar](256) NOT NULL
) ON [PRIMARY]
GO

CREATE PROCEDURE [dbo].[GetRewrittenUrl] 
@input nvarchar(256)
AS
SELECT rt.NewUrl 
FROM dbo.RewriteTable rt 
WHERE rt.OriginalUrl = @input
GO

CREATE USER [IIS APPPOOL\DefaultAppPool] FOR LOGIN [IIS APPPOOL\DefaultAppPool]

GRANT EXECUTE ON dbo.GetRewrittenUrl TO [IIS APPPOOL\DefaultAppPool];
GO

INSERT INTO dbo.RewriteTable VALUES ('old/catalog/product.html', 'new/category/product.html');
INSERT INTO dbo.RewriteTable VALUES ('old/contactus/index.html', 'new/contactus.html');
GO