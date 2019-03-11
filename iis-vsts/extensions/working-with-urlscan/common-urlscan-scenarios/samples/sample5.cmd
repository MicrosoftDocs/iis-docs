[SQL Injection Headers]
AppliesTo=.asp,.aspx
DenyDataSection=SQL Injection Headers Strings
ScanUrl=0
ScanAllRaw=0
ScanQueryString=0
ScanHeaders=Cookie:

[SQL Injection Headers Strings]
--
@ ; also catches @@
alter
cast
convert
create
declare
delete
drop
exec ; also catches execute
fetch
insert
kill
select