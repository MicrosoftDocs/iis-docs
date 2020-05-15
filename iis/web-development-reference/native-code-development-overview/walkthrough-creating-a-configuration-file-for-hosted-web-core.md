---
title: "Walkthrough: Creating a Configuration File for Hosted Web Core"
ms.date: "10/07/2016"
ms.assetid: d7d79047-cb09-4e1d-b7c8-5b48951be121
---
# Walkthrough: Creating a Configuration File for Hosted Web Core

This walkthrough demonstrates how to create a configuration file for use with the Hosted Web Core features that are available in [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)].  
  
 When you create applications that use the Hosted Web Core functionality in [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)], you have to provide a custom configuration file that follows the format of the ApplicationHost.config file. Depending on your configuration settings, your application can host Web pages and applications on the same server where you are hosting Web sites that use [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)]. For example, if your Web server has only one Web site that is serving Web pages on TCP port 80, you could configure your application to serve Web pages on TCP port 8080.  
  
 Because your application requires a custom configuration file, your Web sites and your Hosted Web Core application do not share the same feature settings. For example, you could configure your Web sites to implement dynamic functionality that is not required by your application, or you could configure your application to require a specific authentication method that is not used by your Web sites.  
  
 Even though your ApplicationHost.config file for [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] may contain more than one application pool, the Hosted Web Core functionality in [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] supports only a single application pool.  
  
## Prerequisites  

 The following software is required to complete the steps in the example:  
  
- [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] on [!INCLUDE[windowsver](../../web-development-reference/native-code-development-overview/includes/windowsver-md.md)].  
  
> [!NOTE]
>  While you will have to run your Hosted Web Core application on [!INCLUDE[windowsver](../../web-development-reference/native-code-development-overview/includes/windowsver-md.md)], you do not have to create your configuration file on [!INCLUDE[windowsver](../../web-development-reference/native-code-development-overview/includes/windowsver-md.md)]. You can create your configuration file on a different version of Windows and then copy your configuration file to a computer that has [!INCLUDE[windowsver](../../web-development-reference/native-code-development-overview/includes/windowsver-md.md)] installed.  
  
- [!INCLUDE[vsprvslong](../../wmi-provider/includes/vsprvslong-md.md)].  
  
> [!NOTE]
> You may also use Visual Studio .NET 2003 or earlier, although the walkthrough steps may not be identical.  
  
## Creating a Configuration File  

 The steps in this part of the walkthrough will help you create a new configuration file for use with a Hosted Web Core application that contains the settings that are required to serve static content.  
  
#### To create a configuration file  
  
1. Start [!INCLUDE[vsprvslong](../../wmi-provider/includes/vsprvslong-md.md)].  
  
2. Create a new configuration file:  
  
    1. On the **File** menu, point to **New**, and then click **File**.  
  
         The **New File** dialog box opens.  
  
    2. In the **Categories** pane, click **General**.  
  
    3. In the **Templates** pane, select **XML File**.  
  
    4. Click **Open**.  
  
         A new XML file will open with the following XML code:  
  
        ```  
        <?xml version="1.0" encoding="UTF-8"?>  
        ```  
  
3. To identify this XML file as a configuration file for your application, add the following XML code under the `<?xml?>` element:  
  
    ```  
    <configuration>  
  
    </configuration>  
    ```  
  
## Defining the Configuration Sections  

 When the configuration file has been created, you have to define which configuration sections your configuration file will contain. You do this by adding a `<configSections>` element to your configuration file.  
  
#### To add the \<configSections> section  
  
1. To create the section that defines which sections your configuration file will contain, add the following XML code inside the `<configuration>` element:  
  
    ```  
    <configSections>  
  
    </configSections>  
    ```  
  
2. To define what information will be included in your `<system.applicationHost>` section, add the following XML code inside the `<configSections>` element:  
  
    ```  
    <sectionGroup name="system.applicationHost"  
            type="System.ApplicationHost.Configuration.SystemApplicationHostSectionGroup">  
        <section name="applicationPools"  
                type="System.ApplicationHost.Configuration.ApplicationPoolsSection"  
                allowDefinition="MachineOnly"  
                overrideModeDefault="Deny" />  
        <section name="listenerAdapters"  
                type="System.ApplicationHost.Configuration.ListenerAdaptersSection"  
                allowDefinition="MachineOnly"  
                overrideModeDefault="Deny" />  
        <section name="log"  
                type="System.ApplicationHost.Configuration.LogSection"  
                allowDefinition="MachineOnly"  
                overrideModeDefault="Deny" />  
        <section name="sites"  
                type="System.ApplicationHost.Configuration.SitesSection"  
                allowDefinition="MachineOnly"  
                overrideModeDefault="Deny" />  
    </sectionGroup>  
    ```  
  
3. To define what information will be included in your `<system.applicationHost>` section, add the following code inside the `<configSections>` element:  
  
    ```  
    <sectionGroup name="system.webServer"  
        type="System.WebServer.Configuration.SystemWebServerSectionGroup">  
        <section name="defaultDocument"  
            type="System.WebServer.Configuration.DefaultDocumentSection"  
            overrideModeDefault="Allow" />  
        <section name="directoryBrowse"  
            type="System.WebServer.Configuration.DirectoryBrowseSection"  
            overrideModeDefault="Allow" />  
        <section name="globalModules"  
            type="System.WebServer.Configuration.GlobalModulesSection"  
            allowDefinition="MachineOnly"  
            overrideModeDefault="Deny" />  
        <section name="handlers"  
            type="System.WebServer.Configuration.HandlersSection"  
            overrideModeDefault="Deny" />  
        <section name="httpLogging"  
            type="System.WebServer.Configuration.HttpLoggingSection"  
            overrideModeDefault="Deny" />  
        <section name="modules"  
            type="System.WebServer.Configuration.ModulesSection"  
            allowDefinition="MachineToApplication"  
            overrideModeDefault="Deny" />  
        <sectionGroup name="security"  
            type="System.WebServer.Configuration.SecuritySectionGroup">  
            <section name="access"  
                type="System.WebServer.Configuration.AccessSection"  
                overrideModeDefault="Deny" />  
            <sectionGroup name="authentication"  
                type="System.WebServer.Configuration.AuthenticationSectionGroup">  
                <section name="anonymousAuthentication"  
                    type="System.WebServer.Configuration.AnonymousAuthenticationSection"  
                    overrideModeDefault="Allow" />  
            </sectionGroup>  
        </sectionGroup>  
        <section name="staticContent"  
            type="System.WebServer.Configuration.StaticContentSection"  
            overrideModeDefault="Deny" />  
    </sectionGroup>  
    ```  
  
## Adding the \<system.applicationHost> Settings  

 When you have defined which sections your configuration file will contain, you have to populate the configuration sections with the required settings for your application.  
  
#### To add the \<system.applicationHost> section  
  
1. To add the `<system.applicationHost>` section to your configuration file, add the following XML code inside the `<configuration>` element:  
  
    ```  
    <system.applicationHost>  
  
    </system.applicationHost>  
    ```  
  
2. To create an application pool, add the following XML code inside the `<system.applicationHost>` element:  
  
    ```  
    <applicationPools>  
        <add name="TestAppPool" />  
        <applicationPoolDefaults>  
            <processModel identityType="NetworkService" />  
        </applicationPoolDefaults>  
    </applicationPools>  
    ```  
  
3. To define a listener adapter for HTTP, add the following XML code inside the `<system.applicationHost>` element:  
  
    ```  
    <listenerAdapters>  
        <add name="http" />  
    </listenerAdapters>  
    ```  
  
4. To create a Web site, add the following XML code inside the `<system.applicationHost>` element:  
  
    ```  
    <sites>  
        <site name="Test Web Site" id="1">  
            <application path="/">  
                <virtualDirectory path="/"  
                    physicalPath="D:\inetpub\TestPath\wwwroot" />  
            </application>  
            <bindings>  
                <binding protocol="HTTP" bindingInformation="*:8080:" />  
            </bindings>  
        </site>  
        <siteDefaults>  
            <logFile directory="D:\inetpub\TestPath\Logs" />  
        </siteDefaults>  
        <applicationDefaults applicationPool="TestAppPool" />  
        <virtualDirectoryDefaults allowSubDirConfig="true" />  
    </sites>  
    ```  
  
> [!NOTE]
> You can change the file paths and server bindings in the XML settings as appropriate for your application.  
  
## Adding the \<system.webServer> Settings  
  
#### To add the \<system.webServer> section  
  
1. To add the `<system.webServer>` section to your configuration file, add the following XML code inside the `<configuration>` element:  
  
   ```  
   <system.webServer>  
  
   </system.webServer>  
   ```  
  
2. To define the global modules that your application will use, add the following XML code inside the `<system.webServer>` element:  
  
   ```  
   <globalModules>  
       <add name="DefaultDocumentModule"  
           image="D:\Windows\system32\inetsrv\defdoc.dll" />  
       <add name="DirectoryListingModule"  
           image="D:\Windows\system32\inetsrv\dirlist.dll" />  
       <add name="StaticFileModule"  
           image="D:\Windows\system32\inetsrv\static.dll" />  
       <add name="AnonymousAuthenticationModule"  
           image="D:\Windows\system32\inetsrv\authanon.dll" />  
       <add name="HttpLoggingModule"  
           image="D:\Windows\system32\inetsrv\loghttp.dll" />  
   </globalModules>  
   ```  
  
3. To define the handlers that your application will use, add the following XML code inside the `<system.webServer>` element:  
  
   ```  
   <handlers>  
       <add name="StaticFile" path="*" verb="*"  
           modules="StaticFileModule,DefaultDocumentModule,DirectoryListingModule"  
           resourceType="Either" requireAccess="Read" />  
   </handlers>  
   ```  
  
4. To define the modules that your application will use, add the following XML code inside the `<system.webServer>` element:  
  
   ```  
   <modules>  
       <add name="DefaultDocumentModule" />  
       <add name="DirectoryListingModule" />  
       <add name="StaticFileModule" />  
       <add name="AnonymousAuthenticationModule" />  
       <add name="HttpLoggingModule" />  
   </modules>  
   ```  
  
5. To define your directory browsing and HTTP logging options, add the following XML code inside the `<system.webServer>` element:  
  
   ```  
   <directoryBrowse enabled="true" />  
   <httpLogging dontLog="false" />  
   ```  
  
6. To enable a default document, add the following XML code inside the `<system.webServer>` element:  
  
   ```  
   <defaultDocument enabled="true">  
       <files>  
           <add value="default.htm" />  
       </files>  
   </defaultDocument>  
   ```  
  
7. To define the MIME types that your application will implement, add the following XML code inside the `<system.webServer>` element:  
  
   ```  
   <staticContent>  
       <mimeMap fileExtension=".gif" mimeType="image/gif" />  
       <mimeMap fileExtension=".htm" mimeType="text/html" />  
       <mimeMap fileExtension=".jpg" mimeType="image/jpeg" />  
       <mimeMap fileExtension=".txt" mimeType="text/plain" />  
   </staticContent>  
   ```  
  
   > [!NOTE]
   >  You can add MIME types as appropriate for your application by adding more `<mimeMap>` elements.  
  
8. To define your application's security options, add the following XML code inside the `<system.webServer>` element:  
  
   ```  
   <security>  
       <access flags="Read" sslFlags="None" />  
       <authentication>  
           <anonymousAuthentication enabled="true"  
               userName="IUSR" defaultLogonDomain="" />  
       </authentication>  
   </security>  
   ```  
  
   When you have completed all the preceding steps, you need save your configuration file to a path where your Hosted Web Core application will be able to access it.  
  
   Your application may experience an error if a section of your configuration file has not been correctly defined. Depending on the error, you may be able to retrieve additional information about the problem by examining your server's Event Viewer logs and the IIS log files that are created automatically by your application. For more information about troubleshooting problems with a Hosted Web Core application, see the troubleshooting steps that are listed in [Walkthrough: Creating a Hosted Web Core Application](../../web-development-reference/native-code-development-overview/walkthrough-creating-a-hosted-web-core-application.md).  
  
## See Also  

 [Creating Hosted Web Core Applications](../../web-development-reference/native-code-development-overview/creating-hosted-web-core-applications.md)   
 [Walkthrough: Creating a Hosted Web Core Application](../../web-development-reference/native-code-development-overview/walkthrough-creating-a-hosted-web-core-application.md)
