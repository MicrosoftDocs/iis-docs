PS IIS:\Sites\DemoSite\DemoApp>Add-WebConfiguration /system.webServer/defaultDocument/files  "IIS:\sites\Default Web Site" -at 0 -value
@{value="new-index.html"}