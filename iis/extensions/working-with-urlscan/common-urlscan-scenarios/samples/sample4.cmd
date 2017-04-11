[SQL Injection]
AppliesTo=.asp,.aspx
DenyDataSection=SQL Injection Strings
ScanUrl=0
ScanAllRaw=0
ScanQueryString=1
ScanHeaders=
DenyUnescapedPercent=1 

[SQL Injection Strings]
--
%3b ; a semicolon
/*
@ ; also catches @@
char ; also catches nchar and varchar
alter
begin
cast
convert
create
cursor
declare
delete
drop
end
exec ; also catches execute
fetch
insert
kill
open
select
sys ; also catches sysobjects and syscolumns
table
update