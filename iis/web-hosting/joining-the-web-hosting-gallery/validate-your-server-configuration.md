---
title: "Validate Your Server Configuration | Microsoft Docs"
author: rick-anderson
description: "Introduction ServerValidator is an extensible, plugin-based tool which checks if your server is ready to support WebMatrix. Typically, ServerValidator is run..."
ms.author: aspnetcontent
manager: wpickett
ms.date: 11/02/2010
ms.topic: article
ms.assetid: 
ms.technology: dotnet-webforms
ms.prod: .net-framework
msc.legacyurl: /learn/web-hosting/joining-the-web-hosting-gallery/validate-your-server-configuration
msc.type: authoredcontent
---
Validate Your Server Configuration
====================
by Bilal Aslam

## Server-side validation using ServerValidator

### Introduction

ServerValidator is an extensible, plugin-based tool which checks if your server is ready to support WebMatrix. Typically, ServerValidator is run by a system administrator after they have configured the server. It comes with a command line version (ServerValidatorCommandline.exe) and a user-interface (ServerValidatorUI.exe).

**What ServerValidator does:** 

- Checks if you are running the correct operating system.
- Checks if required software is installed, including products that can be installed using WebPI and otherwise as well as Windows Updates.
- Checks if Web Deploy delegation rules are set up correctly.
- Checks if services are installed and in the correct state.
- It is capable of checking if GAC assemblies and COM objects are installed. While these checks are not required for WebMatrix, shared hosting providers commonly install 3rd party components on their servers.
- Can be extended with your own plug-ins.

**What ServerValidator does not do:** 

- It does not actually do a test publish. This is because a realistic test would be to publish to the server from outside your network so firewalls, etc. are taken into account.
- It does not check firewall settings.
- It does not validate if file system permissions required for certain Web Deploy providers are set up correctly. For example, it does not check that createApp provider has write access to applicationHost.config, or that the identity for setAcl provider has appropriate permissions to the site's folders.

### Installation

Download a version that works with both x86 and x64 server architectures: [ServerValidator](https://go.microsoft.com/fwlink/?LinkId=207733 "ServerValidator Download")

### Example Usage

You can watch a screencast demo of ServerValidator [here](servervalidator-demo.md "ServerValidator Demo Video").

The ServerValidator ZIP file comes with a sample configuration file, WebMatrixValidation.xml, which contains validation checks for WebMatrix support.

1. Open the folder where you unzipped ServerValidator
2. Right-click ServerValidatorUI.exe and click "***Run as Administrator***". This is required for several of the validations to succeed because they require elevated privileges on your server.
3. Inspect the results in the UI

[![](validate-your-server-configuration/_static/image2.png)](validate-your-server-configuration/_static/image1.png)

<a id="_Toc276284068"></a>

### Input File Format

The input file is a well-formatted XML file. It looks like this: 

[!code-xml[Main](validate-your-server-configuration/samples/sample1.xml)]

Comments are allowed in the input XML using standard comment tags.

- Each validation is specified by a &lt;Validation&gt;&lt;/Validation&gt; tag, and is handles by a specific Validator in the ServerValidator.Validators namespace. 

    - *Type* is a required attribute

        - The value for this attribute specifies a .NET type in the ServerValidator.Validators namespace that implements the IValidator interface. For example, let's say type ="MyValidator". ServerValidator ships with a number of built-in Validators – it first searches the ServerValidator.dll assembly for "ServerValidator.Validators.MyValidator". If one is not found, it tries to load the "MyValidator.dll" assembly from disk and looks for the "ServerValidator.Validators.MyValidator" type in it.
    - *description* attribute is required. It should be a simple description of the Validation.
    - *detailsUrlBase* attribute is required. It should be a URI of the documentation.
    - The remaining attributes are optional and are passed as key-value pairs to the Validator itself.

<a id="_Toc276284069"></a>

### Output File Format

The output file is named localhost\_&lt;timestamp&gt;.xml and is placed in the same folder as ServerValidator. A sample report looks like this:

[!code-xml[Main](validate-your-server-configuration/samples/sample2.xml)]

**Important Note:** Not everything that ServerValidator checks for is **required** by WebMatrix or the Spotlight program in the Web Hosting Gallery. The ServerValidator is simply a tool to aid in checking your installed components against the [list of required components](install-server-components.md). It also is useful for verifying that your [Web Deploy settings](configure-site-for-web-deploy-publishing.md) are correct.

<a id="_Toc276284070"></a>

### Included Validators

| Validator | Description |
| --- | --- |
| COMValidator | Checks for the presence of a COM component |
| DelegationRuleValidator | Checks if Web Deploy delegation rules are set up correctly |
| GacAssemblyValidator | Checks if a assembly is GAC'ed |
| OsValidator | Checks if the operating system is in the list of valid operating systems |
| RegistryValidator | Checks if a registry key is present and has a specific value |
| ServiceValidator | Checks if a service is installed and is the expected state |
| WebPIInstalledProductValidator | Checks if a product that can be installed via WebPI is installed. Also checks if all applications in the Application Gallery have dependencies installed. |
| WindowsInstalledComponentValidator | Checks if a product in the Windows Programs Control Panel is installed or not. Use this for programs that are not installed using WebPI. |


#### Example: COMValidator

Check if a specific COM component is installed:

[!code-unknown[Main](validate-your-server-configuration/samples/sample-127503-3.unknown)]

#### Example: DelegationRuleValidator

Checks if the following delegation rules are set up correctly in administration.config: createApp, iisApp, contentPath, dbFullSql, dbMySql, recycleApp, setAcl. This Validator does not take any input:

[!code-unknown[Main](validate-your-server-configuration/samples/sample-127503-4.unknown)]

Note that this Validator does **NOT** check the following:

- createApp: RunAs identity has write access to applicationHost.config
- recycleApp: RunAs identity is a member of the Administrators security group

#### Example: OsValidator

Checks if the current operating system is in the comma-seperated list of valid operating systems specifed in the *validOperatingSystems* attribute:

[!code-unknown[Main](validate-your-server-configuration/samples/sample-127503-5.unknown)]

#### Example: RegistryValidator

Checks the registry for the presence of a key and, optionally, a registry value, kind and data

[!code-unknown[Main](validate-your-server-configuration/samples/sample-127503-6.unknown)]

The regKey attribute is required, all other attributes are optional.

**Valid values for regKey:** HKEY\_LOCAL\_MACHINE\..., HKEY\_CURRENT\_USER\..., HKEY\_CLASSES\_ROOT\..., HKEY\_USERS\..., HKEY\_CURRENT\_CONFIG\...

**Valid values for regValueKind:** String, ExpandString, Binary, DWord, MultiString, QWord.

#### Example: ServiceValidator

Checks if a Windows service is installed and, optionally, in the correct state:

[!code-unknown[Main](validate-your-server-configuration/samples/sample-127503-7.unknown)]

The serviceName attribute is required. serviceState attribute is optional.

**Valid values for serviceState:** Paused, Running, Stopped.

#### Example: WebPiInstalledComponentValidator

This Validator serves two purposes. First, it can be used to check if a product installed using the WebPI 3.0 feed is installed or not. This snippet checks if Microsoft ASP.NET is installed. Valid values for the productId are productIds in the WebPI feed.

[!code-unknown[Main](validate-your-server-configuration/samples/sample-127503-8.unknown)]

 Second, it can be used to check if dependencies for all applications that can be installed using the Web Application Gallery are installed. This is valuable if you want to see if your server supports being a publishing target for Wordpress, Joomla! etc. It will highlight any missing components so you can install them: 

[!code-unknown[Main](validate-your-server-configuration/samples/sample-127503-9.unknown)]

#### Example: WindowsInstalledComponentValidator

This Validator uses WMI to check if a product is in Win32\_Products. It's an alternative to the WebPIInstalledComponentValidator, because it checks the same list as the Programs Control Panel, and can also check for Windows Updates.

**Valid values for *category* attribute:** product and update. 

[!code-unknown[Main](validate-your-server-configuration/samples/sample-127503-10.unknown)]

### Building your own Validator

1. Start Visual Studio
2. Create *.NET 2.0*, C# class library project:  
  
    [![](validate-your-server-configuration/_static/image4.png)](validate-your-server-configuration/_static/image3.png)
3. Add a reference to ServerValidator.dll:  
  
    [![](validate-your-server-configuration/_static/image6.png)](validate-your-server-configuration/_static/image5.png)
4. Paste the following code into MyCustomValidator.cs:


[!code-csharp[Main](validate-your-server-configuration/samples/sample11.cs)]

Each Validator implements the IValidator interface. It *must* be in the ServerValidator.Validators namespace. It overrides two methods:

- *Initialize* method. Called to set up the Validator with input data: 

    - context: set of key-value pairs specified for this Validator in the input XML.
    - server: reserved for future use
    - serverValidationManager: provides access to logging capabilities
- *Validate* method. This method actually does the work of validation. Use the Reporter field on the instance of ServerValidationManager to perform logging.

5. Compile the DLL and place it in the same directory as ServerValidatorCommandLine.exe

6. Add the following snippet to the input file: 

[!code-unknown[Main](validate-your-server-configuration/samples/sample-127503-12.unknown)]

7. Run ServerValidator

<a id="_Toc276284072"></a>

## Client-side validation using WebMatrix

Once ServerValidator shows valid results, the logical next step is to try website publishing from the WebMatrix client. [Learn more about how we do this publish testing](how-webmatrix-verification-works.md "How WebMatrix verification works").

## Next Steps

Now that you have checked to make sure your server is set up correctly, it is time to start provisioning hosting user accounts. To make it easier for end users to consume your server credentials, we suggest giving out user accounts using our Profile XML format. Create a sample test account and [generate a Profile XML for it](generate-a-profile-xml-file.md).
  
  
[Discuss in IIS Forums](https://forums.iis.net/1157.aspx)