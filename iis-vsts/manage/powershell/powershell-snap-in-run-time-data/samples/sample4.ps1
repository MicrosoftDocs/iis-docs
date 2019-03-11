PS IIS:\> cd AppPools
PS IIS:\AppPools> Get-WebItemState DemoAppPool
Started
PS IIS:\AppPools> Stop-WebItem DemoAppPool
PS IIS:\AppPools> Get-WebItemState DemoAppPool
Stopped