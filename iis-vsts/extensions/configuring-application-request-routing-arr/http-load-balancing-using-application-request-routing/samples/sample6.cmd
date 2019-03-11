appcmd.exe set config -section:webFarms
/[name='myServerFarm1'].applicationRequestRouting.healthCheck.url:"http://(server
name or FQDN of ARR server)/healthCheck.txt "
/[name='myServerFarm1'].applicationRequestRouting.healthCheck.responseMatch:"I am
healthy." /commit:apphost