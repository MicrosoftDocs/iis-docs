appcmd.exe set config -section:webFarms
/[name='myServerFarm1'].applicationRequestRouting.affinity.useCookie:"True"
/commit:apphost