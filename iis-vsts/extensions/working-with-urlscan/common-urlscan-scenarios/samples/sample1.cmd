[Options]
RuleList=Foo

[Foo]
AppliesTo=.htm
DenyDataSection=Foo Strings
ScanUrl=0
ScanAllRaw=0
ScanQueryString=0
ScanHeaders=Foo-Header:
DenyUnescapedPercent=1

[Foo Strings]
--
<
>