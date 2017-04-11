[Options]
RuleList=MyAspRule,MyPhpRule

[MyAspRule]
AppliesTo=.asp, .aspx
DenyDataSection=MyRuleData
ScanURL=0
ScanAllRaw=1
ScanQueryString=1
ScanHeaders=
DenyUnescapedPercent=1

[MyPhpRule]
AppliesTo=.php
DenyDataSection=MyRuleData
ScanURL=1
ScanAllRaw=0
ScanQueryString=1
ScanHeaders=
DenyUnescapedPercent=1

[MyRuleData]
< ; Used by script injection attacks.
> ; Used by script injection attacks.
@ ; Used by script injection attacks.