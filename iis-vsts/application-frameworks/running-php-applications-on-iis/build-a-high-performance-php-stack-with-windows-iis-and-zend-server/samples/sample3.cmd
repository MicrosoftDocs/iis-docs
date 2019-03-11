C:\>sqlcmd -S .\SQLEXPRESS

1> USE library
2> GO
Changed database context to 'library'

1> SELECT COUNT(*) FROM books
2> GO
------------
     28