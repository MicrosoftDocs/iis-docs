PS IIS:\AppPools> $demoPool = Get-Item IIS:\AppPools\DemoAppPool
PS IIS:\AppPools> $demoPool.processModel.userName = "DemoAppPoolUser"
PS IIS:\AppPools> $demoPool.processModel.password = "Secret!!Pw3009"
PS IIS:\AppPools> $demoPool.processModel.identityType = 3
PS IIS:\AppPools> $demoPool | Set-Item