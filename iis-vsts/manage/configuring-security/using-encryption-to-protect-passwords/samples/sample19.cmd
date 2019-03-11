cd /d %systemroot%
cd Microsoft.NET\Framework\v2.0.50727
aspnet_regiis.exe -pr App1Key IIS_IUSRS
aspnet_regiis.exe -pa App1Key   AppPoolIdentity1
aspnet_regiis.exe -pr App2Key IIS_IUSRS
aspnet_regiis.exe -pa App2Key   AppPoolIdentity2