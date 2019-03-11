Csc.exe /noconfig /nowarn:1701,1702 /errorreport:prompt /warn:4 /define:TRACE 
/reference:..\playlistprovder.dll 
/reference:C:\Windows\Microsoft.NET\Framework\v2.0.50727\System.dll 
/debug:pdbonly /filealign:512 /optimize+ 
/out:obj\Release\providersample.dll 
/target:library AssemblyInfo.cs PlaylistProvider.cs