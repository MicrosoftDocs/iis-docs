Powerful Admin Tools
--------------------

IIS7 includes a comprehensive set of administration tools, including new administration and command-line tools, new managed code and scripting APIs and Windows Powershell support to simplify day-to-day tasks for developers and administrators.

## IIS Manager

![Enable Remote Connections](powerful-admin-tools/_static/enableremoteconnections-small.png) IIS Manager offers a new, more efficient tool for managing the web server. Built from scratch, the new administration tool provides streamlined access to IIS and ASP.NET configuration settings, membership and user data, and runtime diagnostic information. The new admin tool also enables those who host or administer Web sites to delegate administrative control to developers or content owners, thus reducing cost of ownership and administrative burden for the administrator. Other key features include:

*   [Remote administration](/downloads/microsoft/iis-manager) over HTTP/SSL
*   Support for both Windows and non-Windows credentials for delegated administration
*   A rich [extensibility framework](/learn/develop/extending-the-management-ui) for plugging in new UI features using the .NET Framework
*   Automatic download and install of new UI modules to the client

## .NET Microsoft.Web.Administration

IIS7 includes the Microsoft.Web.Administration API for [programmatically administering](/learn/manage/scripting/how-to-use-microsoftwebadministration) the web server. These managed code API makes it easy to programmatically provision, access important state and diagnostic information, or configure the server.

## Windows PowerShell

The [Windows PowerShell Provider for IIS 7.0](/downloads/microsoft/powershell) allows Web administrators and hosting providers to easily automate routine and complex IIS 7.0 administration tasks such as creating Web sites, and managing configuration and run-time data using Windows PowerShell. Administrators can further increase productivity by leveraging the many cmdlets included with the Windows PowerShell Provider for IIS 7.0.

## Command-line - AppCmd.exe

IIS7 supports a new command line tool [AppCmd.exe](/learn/get-started/getting-started-with-iis/getting-started-with-appcmdexe) \- for administering the server. This powerful utility makes it easy to read and write configuration values, and access site and application pool state information, all from the command prompt.

## WMI / Scripting

IIS7 also includes a new WMI provider which provides access to configuration and server state information to VBScipt and JScript writers. Using WMI, Administrators can easily automate basic configuration tasks like managing Web [sites](/learn/manage/scripting/managing-sites-with-the-iis-wmi-provider) and [applications](/learn/manage/scripting/managing-applications-and-application-pools-on-iis-with-wmi).