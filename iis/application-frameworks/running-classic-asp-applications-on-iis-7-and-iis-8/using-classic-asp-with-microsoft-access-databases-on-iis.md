---
title: "Using Classic ASP with Microsoft Access Databases on IIS"
author: rmcmurray
description: "Note : Microsoft Access databases have been popular for many years with developers who use Active Server Pages (ASP) for small-scale applications, but Micros..."
ms.date: 02/19/2009
ms.assetid: 1edd05ef-e45c-4e79-ab3b-e29f668c7483
msc.legacyurl: /learn/application-frameworks/running-classic-asp-applications-on-iis-7-and-iis-8/using-classic-asp-with-microsoft-access-databases-on-iis
msc.type: authoredcontent
---
# Using Classic ASP with Microsoft Access Databases on IIS

by [Robert McMurray](https://github.com/rmcmurray)

> [!NOTE]
> Microsoft Access databases have been popular for many years with developers who use Active Server Pages (ASP) for small-scale applications, but Microsoft Access databases are not designed for scalability, therefore Access databases should only be used where performance is not a factor, and it is best not to host large-scale data-driven applications with Microsoft Access databases.

In IIS 7.0, IIS 7.5, and above, several security changes were made that may affect how classic ASP applications will function. For example, if you were to copy a classic ASP application that uses an Access database that is within the Web site's content area to a server that uses IIS 7.0 or above, you may receive the following error message:

**Microsoft JET Database Engine error '80004005'**
  
**Unspecified error.**
  
**/example.asp, line 100**

This is a generic error triggered by the Access driver that may occur for a variety of reasons, but incorrect permissions is a common cause. More specifically, the ability to work with Microsoft Access databases is implemented through the Microsoft JET Database Engine, which creates various temporary and lock files when it connects to an Access database. The following sections will discuss some of the reasons why this may occur and how to resolve those situations.

## Working with 64-bit Systems

Unfortunately there are no 64-bit ODBC drivers, so on 64-bit systems you will have to run your applications in 32-bit mode. To do so, use the following steps:

1. On the taskbar, click **Start**, point to **Administrative Tools**, and then click **Internet Information Services (IIS) Manager**.
2. In the **Connections** pane, click **Application Pools**.
3. Highlight the application pool for your application, then click **Advanced Settings...** in the **Actions** pane.
4. In the **Advanced Settings** dialog, specify **True** for **Enable 32-Bit Applications**.
5. Click OK to close the **Advanced Settings** dialog.

Note: The 64-bit control panel applet for managing ODBC connections will not display 32-bit ODBC drivers. To work around this issue, you need to open the 32-bit ODBC applet. To do so, use the following steps:

1. Click **Start** and then **Run**, or open a command prompt.
2. Enter the following command:

    [!code-console[Main](using-classic-asp-with-microsoft-access-databases-on-iis/samples/sample1.cmd)]
3. Press the enter key.

## Working with User Access Control

You need to make sure that you follow the steps in this document by using an account that has full administrative permissions. This is best accomplished by using one of two methods:

- Log in to your computer by using the local administrator account.
- If you are logged in using an account that administrative permissions but that is not the local administrator account, open all applications and all command prompt sessions by using the "Run as Administrator" option.

These above conditions are required because the User Account Control (UAC) security component in Windows Vista and Windows Server 2008 will prevent administrative access to the IIS configuration settings. For more information about UAC, see the following documentation:

- [User Account Control](https://go.microsoft.com/fwlink/?LinkId=113664)

## Initial Troubleshooting Investigation

If you have some form of tracing or debugging enabled, the trace or debug information may show the error occurring when the database connection is opened. For example, the following lines of ASP code :

[!code-vb[Main](using-classic-asp-with-microsoft-access-databases-on-iis/samples/sample2.vb)]

### Using Failed Request Tracing in IIS 7.0 and Above

If you have the IIS [Failed Request Tracing](using-failed-request-tracing-to-troubleshoot-classic-asp-errors.md) configured to capture trace logs from HTTP 500 errors, you will see something that resembles the following illustration when you examine a trace log from the failure:

![Screenshot of a browser window showing a portion of a trace log.](using-classic-asp-with-microsoft-access-databases-on-iis/_static/image1.jpg)

Although this error indicates that the failure occurred when opening the database, it does not give any additional information to assist you with narrowing the problem to a specific area.

### Using Process Monitor to gather more information

The Microsoft Windows Sysinternals [Process Monitor](https://technet.microsoft.com/sysinternals/bb896645.aspx) utility is a great resource for tracking permissions-related problems. To use Process Monitor to trace the IIS issues in this topic, configure Process Monitor to filter tracing for only those events that are created by W3wp.exe processes, as shown in the following illustration:

![Screenshot of the Process Monitor Filter dialog.](using-classic-asp-with-microsoft-access-databases-on-iis/_static/image3.jpg)

Once you have configured the Process Monitor filter settings, configure Process Monitor to capture events and then reproduce your error. After you have reproduced your error, look through the Process Monitor capture log for any errors in the **Result** column of logs, as shown in the following illustration:

![Screenshot showing the Process Monitor log.](using-classic-asp-with-microsoft-access-databases-on-iis/_static/image5.jpg)

By analyzing the information in the Process Monitor logs, you can pinpoint any permissions-related issues. This will be illustrated in the following examples.

## Permissions on the Temporary Folders

If you are using the Process Monitor utility on a computer that has a default installation of IIS on Windows Server 2008 and Windows Vista SP1, you may receive an error that resembles the following when ASP connects to an Access database:

**Process Name:** w3wp.exe  
**Operation:** CreateFile  
**Path:** `C:\Windows\Temp\JET5150.tmp`  
**Result:** ACCESS DENIED  
**Detail:**

   | *Desired Access:* | Generic Read/Write, Delete |
   | --- | --- |
   | *Disposition:* | Create |
   | *Options:* | Synchronous IO Non-Alert, Non-Directory File, Random Access, Delete On Close, Open No Recall |
   | *Attributes:* | NT |
   | *ShareMode:* | None |
   | *AllocationSize:* | 0 |
   | *Impersonating:* | NT AUTHORITY\IUSR |

This error shows that the JET database engine cannot create a temporary file as the impersonated Application Pool identity in the default Windows temporary directory. This occurs when you use default settings for the release version of IIS on Windows Server 2008 and Windows Vista SP1, where IIS does not load the user profile for the Application Pool identity's profile by default. To resolve this issue, you could change the permissions on the %*SystemDrive*%\Windows\Temp directory to allow read/write permission for the impersonated user.

If you are using the original release version of Windows Vista you may see an error that resembles the following when ASP connects to an Access database:

**Process Name:** w3wp.exe  
**Operation:** CreateFile  
**Path:** `C:\Windows\ServiceProfiles\NetworkService\AppData\Local\Temp`
**Result:** ACCESS DENIED  
**Detail:**

   | *Desired Access:* | Read Attributes |
   | --- | --- |
   | *Disposition:* | Open |
   | *Options:* | Open Reparse Point |
   | *Attributes:* | n/a |
   | *ShareMode:* | Read, Write, Delete |
   | *AllocationSize:* | n/a |
   | *Impersonating:* | NT AUTHORITY\IUSR |

This error indicates that the JET database engine cannot access the temporary directory for the Network Service user profile that uses the impersonated Application Pool identity. In this particular example, the Application Pool identity is configured to use the Network Service account and IIS is configured to load the user profile for the impersonated Application Pool identity. The error occurs because the impersonated Application Pool identity cannot access the temporary folder for the Network Service account. To resolve this specific issue, you can change the permissions on the %*SystemDrive*%\Windows\ServiceProfiles\NetworkService\AppData\Local\Temp directory to allow read/write permission for the impersonated user, or you can configure IIS to not load the user profile, which will change the temporary folder that the JET database engine will use.

The configuration setting that governs whether the user profile is loaded for the Application Pool identity is **loadUserProfile**, which is set to **false**, by default. You can configure this setting by changing the value of the **Load User Profile** attribute in the **Advanced Settings** dialog box for an application pool.

![Screenshot of the Advanced Settings dialog. Load User profile is highlighted.](using-classic-asp-with-microsoft-access-databases-on-iis/_static/image7.jpg)

You can also configure this setting by using the command-line tool AppCmd.exe with the following syntax:

[!code-console[Main](using-classic-asp-with-microsoft-access-databases-on-iis/samples/sample3.cmd)]

## Permissions on Content Folders

When you are deploying a classic ASP application that uses an Access database you may see this error because the lock file for the Access database cannot be created. To further explain this scenario: Access databases are kept in files that use an .MDB file name extension. When you try to add to the database or update the data, the Microsoft JET database engine attempts to create a lock file with that uses an .LDB file name extension. If the Access database is stored within the content area of your Web site, by default the JET database engine will not have sufficient access permissions to update the database and you will see the following error message displayed in a Web browser:

**Microsoft JET Database Engine error '80004005'  
  
Operation must use an updateable query.  
  
/example.asp, line 100**

If you were using the Process Monitor utility when you reproduced the error, the following information would be logged for the failure:

**Process Name:** w3wp.exe  
**Operation:** CreateFile  
**Path:** `C:\Inetpub\wwwroot\App\_Data\example.ldb`
**Result:** ACCESS DENIED  
**Detail:**

   | *Desired Access:* | Generic Read/Write |
   | --- | --- |
   | *Disposition:* | OpenIf |
   | *Options:* | Synchronous IO Non-Alert, Non-Directory File, Random Access, Open No Recall |
   | *Attributes:* | N |
   | *ShareMode:* | Read, Write |
   | *AllocationSize:* | 0 |
   | *Impersonating:* | NT AUTHORITY\IUSR |

This error clearly lists the lock file as the cause of the failure. To resolve the issue, you can grant the application pool's impersonated identity read/write permission to the folder where the Access database is located, but that poses a security risk for your Web site. A better solution would be to move the Access database out of your Web site's content area to a folder where the application pool's impersonated identity has read/write permission, then create a System Data Source Name (DSN) that points to the database location. Your ASP code would then reference the System DSN in the connection string instead of the physical path of the database, which is also better for security. If you must store the database in the content area, you should always store the database in a folder that is blocked by default by the IIS request-filtering features, such as the App\_Data folder.

## More Information

For additional information about the loadUserProfile and other application pool attributes, see the following pages on the Microsoft Support and [IIS.net](https://www.iis.net/) Web sites:

- [https://www.iis.net/ConfigReference/system.applicationHost/applicationPools/add/processModel](https://www.iis.net/configreference/system.applicationhost/applicationpools/add/processmodel)

- [Error message when you request an ASP page that connects to an Access database in IIS 7.0: "Microsoft JET Database Engine error '80004005'"](https://support.microsoft.com/kb/926939/)
