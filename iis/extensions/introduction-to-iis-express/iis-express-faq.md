---
title: "IIS Express FAQ"
author: vaidy4github
description: "This FAQ contains information about IIS Express support and other common questions. Q: What is IIS Express? A: IIS Express is a lightweight, self-contained v..."
ms.date: 07/06/2010
ms.assetid: a08df534-1da7-4dbe-8392-0d2630116174
msc.legacyurl: /learn/extensions/introduction-to-iis-express/iis-express-faq
msc.type: authoredcontent
---
IIS Express FAQ
====================
by [Vaidy Gopalakrishnan](https://github.com/vaidy4github)

This FAQ contains information about IIS Express support and other common questions.

#### Q: What is IIS Express?

A: IIS Express is a lightweight, self-contained version of IIS optimized for developers. IIS Express provides the power of IIS 7 and above while making it easy to develop and test websites.


#### Q: What is the current release of IIS Express?

A: The current release is IIS 7.5 Express. As the name suggests, this release is derived from the IIS 7.5 server codebase.

#### Q: How does it relate to Microsoft WebMatrix?

A: Microsoft WebMatrix is a simple and integrated suite of tools that streamline ASP.NET and PHP development. IIS Express is the Web server that is included with WebMatrix. You can also install IIS Express all by itself using the following link. See [IIS Express Overview](iis-express-overview.md "IIS Express Overview") for information on the various ways to install the product.

#### Q: Can I use IIS Express with Visual Studio?

A: Yes, Visual Studio 2010 SP1 Beta allows you to build and test web applications using IIS Express instead of the built-in ASP.NET Development Web Server (also known as Cassini). IIS Express is not included with VS 10 SP1 and will need to be installed separately. You can also manually launch IIS Express from the command line and use it with Visual Studio 2008, using the custom web server option.

#### Q: What OS and SKUs are supported?

A: IIS 7.5 Express is supported on the following operating systems:

- Windows XP SP3+
- Windows Vista SP1+
- Windows 7
- Windows Server 2008
- Windows Server 2008 R2
- Windows Server 2003 SP2+

Support is available for all OS SKUs, except Server Core on Windows Server 2008.

#### Q: What .NET Framework versions are supported?

A: Versions 2.0, 3.0, 3.5, and 4.0 are supported.

#### Q: Are 64-bit machines supported?

A: IIS 7.5 Express supports 64-bit architectures using the WoW64 subsystem. Full 64-bit support will be considered for future releases.

#### Q: Does IIS Express support SSL?

A: Yes IIS Express supports SSL. The setup program will install a default, self-signed server certificate in the machine store and configure ports 44300-44399 for use with SSL. You can also set up and configure custom SSL certificates for your websites as an administrator.

#### Q: Does IIS Express support PHP?

A: Yes, IIS Express includes the CGI and FastCGI modules for PHP. The best way to develop PHP applications using IIS Express is to install WebMatrix. This will automatically install and configure PHP and also allow you to download and customize popular gallery applications such as WordPress, Joomla etc.

#### Q: Can IIS Express be redistributed or embedded in other applications?

A: The IIS 7.5 Express license allows the MSI to be redistributed. You can include the MSI in your product or chain your installer to it. You can't distribute IIS Express in any other manner at the moment.

#### Q: Does IIS Express support the IIS "Classic" pipeline mode?

A: IIS Express supports both the "Integrated" and "Classic" managed pipeline modes from IIS.

#### Q: Does IIS Express require administrative privileges?

A: The default IIS Express configuration allows users to run websites without administrative privileges. The setup program also installs a self-signed server certificate that enables standard users to run a site over SSL.

Certain tasks do require elevated user rights. They include:

- Running a website on port 80 or another reserved port
- Installing a custom SSL certificate
- Running network-facing websites

You must also have administrator user rights when using IIS Express on Windows Server 2003 SP2+.

#### Q: Does IIS Express support the command line?

A: Yes, IIS Express can be launched using the command line and supports various runtime options. For information about how to use the command line, see [Use the Command Line to Run a WebMatrix Site or Application](https://go.microsoft.com/fwlink/?LinkId=195514 "Use the Command Line to Run a WebMatrix Site or Application").

#### Q: Is IIS Express xcopy-deployable?

A: The core IIS Express runtime is xcopy-deployable. However, as of this time, xcopy deployment is not an officially supported feature.

#### Q: Does IIS Express support external traffic?

A: By default, only requests over localhost are serviced; however, you can modify the bindings to enable external traffic. For security reasons, you should have Administrator user rights on the machine to set this up.

#### Q: Will UNC/network paths work?

A: Yes. Similar to IIS, you will need to configure the proper UNC credentials to access content from those shares.

#### Q: Does IIS Express support non-HTTP protocols such as net.tcp or MSMQ?

A: No. IIS Express only supports HTTP and HTTPS as its protocol.

#### Q: What about FTP?

A: IIS Express does not include an FTP service. However, note that both WebMatrix and Visual Studio support publishing web applications to production environments using FTP.

#### Q: Are all of the IIS modules supported?

A: IIS Express currently ships with built-in support for URL Rewrite and FastCGI. We will continue to add support for other modules in future releases, based on demand.

#### Q: Does IIS Express support different host headers?

A: Yes, IIS Express supports binding to different host headers. Similar to IIS, you must have Administrator user rights on the machine to complete this operation. You must also do some extra configuration on the OS, such as adding the proper host mappings in the "hosts" file and network configurations.

#### Q: Does IIS Express use the same configuration system as IIS?

A: Yes, IIS Express uses the same *applicationhost.config* and *web.config* files supported by IIS. The key difference is that with IIS Express, the configuration is maintained on a per-user basis. In particular, whereas IIS has a global "applicationhost.config" file, IIS Express maintains a user-specific "applicationhost.config" file in the %userprofile%\documents\IISexpress\config" folder. This lets a standard user run IIS Express and also lets multiple users work on the same machine independently, without conflicting with each other. Some settings require Administrator user rights to set and modify (see question above about running as a standard user).

#### Q: How do I enable verbs like PUT/DELETE for my web application?

A: In the "verb" attribute add PUT and DELETE so the "verb" attribute looks like: You can modify the IIS Express "applicationHost.config" in the %userprofile%\documents\IISExpress\config" folder. For example to enable PUT and DELETE for extensionless Urls scroll down to the bottom of the IIS Express applicationHost.config file and look for a handler entry that starts with: &lt;add name="ExtensionlessUrl-Integrated-4.0" ... . In the "verb" attribute add PUT and DELETE so the "verb" attribute looks like: verb="GET,HEAD,POST,DEBUG,PUT,DELETE"

#### Q: Does IIS Express support more than one application running in the same process?

A: Yes. Similar to IIS, IIS Express supports multiple applications under the same site running in the same process.

#### Q: Are WCF applications supported?

A: Yes, IIS Express support WCF applications. As noted above, WCF is only supported over HTTP or HTTPS. WCF over MSMQ and net.tcp is not supported.

#### Q: Can SharePoint Foundation 2010 run on IIS Express?

A: SharePoint won't run on IIS Express because it uses IIS features that aren't supported. IIS Express won't prevent Sharepoint Foundation 2010 from running if they are both installed on the same machine.

#### Q: Can IIS Express run side-by-side with other Web servers?

A: Yes, IIS Express can run side-by-side with other Web servers as long as there are no conflicting bindings. You can run IIS Express and the operating system version of IIS (IIS 5.1 on Windows XP, IIS 6.0 on Windows Server 2003, IIS 7.0 on Windows Server 2008 or Windows Vista, IIS 7.5 on Windows Server 2008 R2 or Windows 7). IIS Express comes with a default website that runs on port 8080 to avoid conflicts with IIS, which uses port 80 by default. A binding conflict will occur if IIS Express and the other Web server both try to listen on port 80.