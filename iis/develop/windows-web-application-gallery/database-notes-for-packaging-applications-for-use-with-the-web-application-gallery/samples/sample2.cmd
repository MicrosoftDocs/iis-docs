/**********************************************************************/
/* CreateLogin.SQL */
/* Creates a login */
/* This scripts runs on master to create login and requires connection string with DB admin credentials */
/* Supports SQL Server and SQL AZURE */
**********************************************************************/

-- Add here a test to be sure the login does not exist
-- Create login

CREATE LOGIN PlaceHolderForUser WITH PASSWORD = 'PlaceHolderForPassword'