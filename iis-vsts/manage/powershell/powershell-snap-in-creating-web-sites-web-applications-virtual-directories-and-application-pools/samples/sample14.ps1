New-Item IIS:\Sites\DemoSite -physicalPath C:\DemoSite -bindings @{protocol="http";bindingInformation=":8080:"}
Set-ItemProperty IIS:\Sites\DemoSite -name applicationPool -value DemoAppPool
New-Item IIS:\Sites\DemoSite\DemoApp -physicalPath C:\DemoSite\DemoApp -type Application
Set-ItemProperty IIS:\sites\DemoSite\DemoApp -name applicationPool -value DemoAppPool
New-Item IIS:\Sites\DemoSite\DemoVirtualDir1 -physicalPath C:\DemoSite\DemoVirtualDir1 -type VirtualDirectory
New-Item IIS:\Sites\DemoSite\DemoApp\DemoVirtualDir2 -physicalPath C:\DemoSite\DemoVirtualDir2 -type VirtualDirectory