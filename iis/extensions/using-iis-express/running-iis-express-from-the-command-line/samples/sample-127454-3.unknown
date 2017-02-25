iisexpress /?

IIS Express Usage:
------------------
iisexpress [/config:config-file] [/site:site-name] [/siteid:site-id] [/systray:boolean] 
iisexpress /path:app-path [/port:port-number] [/clr:clr-version] [/systray:boolean] 

/config:config-file 
The full path to the applicationhost.config file. The default value is the IISExpress8\config\applicationhost.config file that is located in the user's Documents folder.

/site:site-name 
The name of the site to launch, as described in the applicationhost.config file. 

/siteid:site-id 
The ID of the site to launch, as described in the applicationhost.config file.

/path:app-path 
The full physical path of the application to run. You cannot combine this option with the /config and related options. 

/port:port-number 
The port to which the application will bind. The default value is 8080. You must also specify the /path option. 

/clr:clr-version The .NET Framework version (e.g. v2.0) to use to run the application. The default value is v4.0. You must also specify the /path option. 

/systray:boolean 
Enables or disables the system tray application. The default value is true. 

/trace:debug-trace-level 
Valid values are info or i,warning or w,error or e. 

Examples: 
iisexpress /site:WebSite1 
This command runs WebSite1 site from the user profile configuration file.

iisexpress /config:c:\myconfig\applicationhost.config 
This command runs the first site in the specified configuration file. 

iisexpress /path:c:\myapp\ /port:80 
This command runs the site from c:\myapp folder over port 80.