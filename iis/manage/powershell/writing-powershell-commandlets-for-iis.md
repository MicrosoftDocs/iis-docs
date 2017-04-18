---
title: "Writing PowerShell Commandlets for IIS 7.0 | Microsoft Docs"
author: rick-anderson
description: "With PowerShell shipped, IIS administrators get a new tool to use. The following article concentrates on administration tasks for IIS 7.0 and above; however,..."
ms.author: iiscontent
manager: soshir
ms.date: 11/23/2007
ms.topic: article
ms.assetid: 1191ee63-76d6-4a73-9b56-1f103890cd49
ms.technology: iis-manage
ms.prod: iis
msc.legacyurl: /learn/manage/powershell/writing-powershell-commandlets-for-iis
msc.type: authoredcontent
---
Writing PowerShell Commandlets for IIS 7.0
====================
by Sergei Antonov

## Introduction

With PowerShell shipped, IIS administrators get a new tool to use. The following article concentrates on administration tasks for IIS 7.0 and above; however, PowerShell can be used for existing IIS 6.0 servers.

This article focuses on the administration of the remote IIS server using PowerShell on the client machine. As of this writing, this is possible only if you use the WMI provider that the IIS team shipped with Vista and Windows Server® 2008. In this case, you do not need to have anything related to IIS on your client computer – WMI provides the connection to the actual configuration available on the remote server.

> [!NOTE]
> You may also use Microsoft.Web.Administration within PowerShell to perform administration functions. However, this article does not focus on that technique.


The PowerShell team created a special command to use for access to WMI objects – get-wmiobject. Normally it returns an object, which is created inside of PowerShell that exposes WMI properties and methods, instead of the usual managed code object that is returned for regular classes.

This synthetic object exposes metadata defined in WMI namespace, not metadata from System.Management.ManagementBaseObject which is used as the base. This gives the user the namespace view which was exposed by the WMI provider, and which reflects the administration model of the configured entity.

Unfortunately, this command does not work with IIS namespaces. For PowerShell version 1.0, the get-wmiobject supports only the default authentication level for the remote DCOM connection. This is not enough either for IIS 6.0 or for IIS 7.0 and above. When users configure IIS, it may be necessary to send passwords and other sensitive data over the network connection to edit and store it in the configuration. To support that, IIS providers require an authentication level "Packet Privacy". There is no way to supply this requirement to the get-wmiobject cmdlet.

With this limitation we have two options:

- Use PowerShell as a generic scripting interface to System.Management namespace. Use PowerShell also to do the following: write script code that configures the connection to the remote WMI namespace; and, to retrieve and save administration data using System.Management objects, accessed through PowerShell. It is like C# programming, only in PowerShell language. Usually this works well, but for the WMI case, PowerShell applies a special adapter that automatically converts all System.Management objects into synthetic PowerShell objects that expose WMI namespace as a primary API. For this reason, we must overcome adapter changes and write additional code to access the "native" System.Management substructure, which quickly turns this programming into an unnecessarily complicated exercise.

Therefore, we explore the other option:

- Write PowerShell cmdlets in C# and access the required functionality in C# code. In this case, we choose any suitable APIs to configured entities. We use WMI to access the server. Compared to the same code in PowerShell, C# is much more effective, as it does not need to be parsed and interpreted each time.

This article contains:

- [PowerShell Cmdlet](writing-powershell-commandlets-for-iis.md#01)
- [Adding Configuration Data to the Site](writing-powershell-commandlets-for-iis.md#02)
- [How to Call One cmdlet From Another cmdlet](writing-powershell-commandlets-for-iis.md#03)
- [Extending Cmdlets to work with a Server Farm](writing-powershell-commandlets-for-iis.md#04)

<a id="01"></a>

## PowerShell Cmdlet

To start writing cmdlets, you need a client computer installed with PowerShell. You must also install PowerShell SDK, or simply copy reference DLLs to the working folder using the trick [posted](https://blogs.msdn.com/powershell/archive/2006/09/30/Linking-against-RC2.aspx) by Jeffrey Snover in the PowerShell team blog. Be sure that you have the DCOM connection on your server. The easiest way to confirm this is to start the utility wbemtest, which is available on each Windows platform, and try the connection.

1. Start wbemtest.   
 2. Click Connect.   
 3. Enter connection parameters:

a. Replace "root\default" by \\&lt;computer&gt;\root\webadministration, where "&lt;computer&gt;" has to be name of your server.   
 b. Enter the credentials of the account that has administrator rights on the server .   
 c. Select "Packet Privacy" in Authentication level group.

4. Click Connect. WMI on your client machine connects to the WMI service on your server machine. If it is not accessible, you get an error message dialog box.  
 5. Perform some simple action that engages the WMI provider on the server box, to confirm that it works. Do an enumeration of sites:

a. Click on "Enum Instances" button and enter "site" for class name.   
 b. When it works, the resulting dialog shows a list of all sites available on your server.

PowerShell cmdlet is simply a managed code assembly implemented following formal rules, which are documented in PowerShell SDK. Find them [on-line](http://windowssdk.msdn.microsoft.com/en-us/library/ms714598.aspx).

Before writing any code, it is useful to have a plan.

First, implement a cmdlet that enumerates all IIS sites on the remote server. This cmdlet returns an array of site objects, which represent the IIS configuration element with properties, defined for the site. We will add some extra properties that are useful to have in that object.

We want the cmdlet to look like the following:


[!code-powershell[Main](writing-powershell-commandlets-for-iis/samples/sample1.ps1)]


If we do not pass the credential to the cmdlet programmatically, PowerShell produces a dialog box requesting the user name and password for the remote server.

To get the site object from the remote computer, we must provide the following parameters from our cmdlet:

[!code-csharp[Main](writing-powershell-commandlets-for-iis/samples/sample2.cs)]

All these parameters are public properties in the cmdlet class, decorated by the Parameter attribute.

Implement the first cmdlet. Since get-iissite is not our last command, it is better to do two things: separate code that is responsible for the connection to the server into the parent class RemotingCommand; and, inherit the cmdlet from that class.

[!code-csharp[Main](writing-powershell-commandlets-for-iis/samples/sample3.cs)]

Class RemotingCommand includes parameters and methods required for connection.

- GetScope() returns the System.Management object that has all information required for connection to the remote namespace. Look at the connection.Authentication property. It is initialized to AuthenticationLevel.PacketPrivacy. This is a mandatory requirement. Otherwise, WMI will refuse the connection.
- Method CreateClassObject() is a utility method that uses connection scope to create a specified class based on remote WMI namespace.
- EndProcessing() method is the standard method that each cmdlet class should implement. It is called from PowerShell when our cmdlet is processed. The implementation of EndProcessing() tries to fill the credential property, if it is empty. On the first attempt, it gets the credential from the external variable IISCredential (just for convenience).

When in a PowerShell session, the user may want to place the user name and password into this variable and use it multiple times in multiple commands. If this variable is not defined, or contains an unsuitable object type, the code gets the credentials of the current user or process. It works when the user is running this command locally on the server, using the administrator account. In this case, we do not need to enter any credentials at all. For each loop in this code, there is a known trick to convert the password from string into SecureString.

Now we implement get-iissite.


[!code-csharp[Main](writing-powershell-commandlets-for-iis/samples/sample4.cs)]


In the first cut, the command returns only site names. If the user wants some specific site, they must supply the name of this site to the command; otherwise, all sites on that particular computer will be returned.

To finish the command, you must add the implementation of the class, inherited from PSSnapin. This class is used to register our commands. It has nothing specific to IIS; see the complete code in the source file IISDemoCmd.cs.

Build the cmdlet now and see how it works. You could do it from Visual Studio, but it is simple enough to build it from the command line. Suppose you placed PowerShell reference DLLs into a folder c:\sdk. The following command line builds the cmdlet into IISDemoCmd.dll and places it into the same folder, where the source file is located

[!code-console[Main](writing-powershell-commandlets-for-iis/samples/sample5.cmd)]

Now you must register the command and add it into PowerShell. This procedure is described in PowerShell Programming Reference. Start PowerShell and execute the following commands from the same folder where you built cmdlet DLL.


[!code-powershell[Main](writing-powershell-commandlets-for-iis/samples/sample6.ps1)]


This adds the cmdlet to the running instance of PowerShell. Save those command lines into a script file.You will use them again as you continue working on the cmdlets. You find this script in the file demo\_install.ps1.

See if the command is available:


[!code-powershell[Main](writing-powershell-commandlets-for-iis/samples/sample7.ps1)]


Now try it. Suppose you connect to computer test\_server, using the local administrator account.


[!code-powershell[Main](writing-powershell-commandlets-for-iis/samples/sample8.ps1)]


This command line receives the credential object from get-credential cmdlet, which will interact with user to get the password. It is also possible to produce the credential programmatically, but you must type the password in the script, which is not at all secure.


[!code-powershell[Main](writing-powershell-commandlets-for-iis/samples/sample9.ps1)]


This command stores the credential in the global variable $iiscredential, and the cmdlet will automatically use it. In real sitautions, however, it is better to store the credential into a variable using the get-credential command: $global:iiscredential = get-credential Administrator.

Now that command again.


[!code-powershell[Main](writing-powershell-commandlets-for-iis/samples/sample10.ps1)]


All infrastructure is in place. Now to return to the command and add the rest of the data from the site.

<a id="02"></a>

## Adding Configuration Data to the Site

We have to convert the object from ManagementBaseObject to PSObject and return it to PowerShell. PSObject is a freeform container that can be filled with different kinds of data. We will use PSNoteProperty type. Keep the cmdlet code clean and add a new class that is responsible for the conversion.

[!code-csharp[Main](writing-powershell-commandlets-for-iis/samples/sample11.cs)]

This code recourses for complex properties and adds simple properties such as PSNoteProperty to the resulting PSObject. We also add a dedicated method that will deal with the conversion into out cmdlet. This method converts all WMI data, and adds two more properties: the computer name and the credential that was used to get the connection to this computer. This helps to distinguish each site from other objects in PowerShell session.


[!code-csharp[Main](writing-powershell-commandlets-for-iis/samples/sample12.cs)]


Replace the site name that we returned to PowerShell with a whole object. Method EndProcessing() in the cmdlet now looks like this:


[!code-csharp[Main](writing-powershell-commandlets-for-iis/samples/sample13.cs)]


When we repeat the build and the registration, and run the command again, we see more data about the site:


[!code-powershell[Main](writing-powershell-commandlets-for-iis/samples/sample14.ps1)]


If you compare this with WMI schema for the site, you see that all data are now available; plus, we have additional properties that we added in cmdlet. All properties are accessible from PowerShell through "dot" notation.


[!code-powershell[Main](writing-powershell-commandlets-for-iis/samples/sample15.ps1)]


We have made good progress, but not good enough. The WMI site also has methods, so try to add them as well. This is simple to do in PowerShell – you name the method and tell PowerShell where the code is located. We will add methods of the PSCodeMethod type. To keep the code for the methods, we add the class SiteMethods.


[!code-csharp[Main](writing-powershell-commandlets-for-iis/samples/sample16.cs)]


As you see, this code creates a WMI object for the site and calls WMI methods on this object. This code uses two additional properties that we added to the site. With this class, we can extend the method ConstructPSSite. We must also add a reference to the System.Reflection namespace.

[!code-csharp[Main](writing-powershell-commandlets-for-iis/samples/sample17.cs)]

In addition to the methods added, there is one dynamic property-- "Status". It behaves the same way as properties in C# classes; it is a function that is called when PowerShell needs its value. The code is very simple, because we refer methods from the same assembly as our cmdlet. Nothing prevents loading any other assembly and getting the information about the methods of its classes. If those methods have the right signature, PowerShell uses it the same way.

The object now looks like:


[!code-powershell[Main](writing-powershell-commandlets-for-iis/samples/sample18.ps1)]


With the ability to add methods and dynamic properties to the objects, we can synthesize what we need for any situation. In addition to the methods and properties added in cmdlet, we can add more in the script, without any need to use C# code.

It is also possible to load the definition of the object from XML. A good candidate for additional properties is data exposed from IIS through perf counters related to site-- for example, the total count of processed requests. Those data are easily accessible directly from the managed code-- there is no need to use WMI.

<a id="03"></a>

## How to Call One cmdlet From Another cmdlet

Getting site objects is important, but we need more, like writing a command to add a new site. To create sites, we can use the abstract method Create() defined on the Site class in the WMI WebAdministration namespace. The cmdlet looks like this:


[!code-powershell[Main](writing-powershell-commandlets-for-iis/samples/sample19.ps1)]


We have the same parameters as defined in the Create method. In addition, the command should support –whatif and –passthru switches. The first shows the result of the command execution, but does not make any changes; the second instructs the command to output the result into the pipeline. These two switches are highly recommended to use in "destcructive" commands. To support the –whatif cmdlet, the class must be decorated by the attribute SupportsShouldProcess = true.

Here is part of the code (find the whole code in the iisdemocmd.cs).


[!code-csharp[Main](writing-powershell-commandlets-for-iis/samples/sample20.cs)]


This code uses a new method in the ObjectConverter class to produce a bindings array. The method ToManagementObject() converts input parameters that can be PSObject or Hashtable into the instance of ManagementBaseObject class. Since the call to Create could fail with perfectly correct parameters if the site with those parameters is already available, we call this method in try/cach.

Finally, if the cmdlet checks to see if the user specified –passthru is present, it calls PowerShell to execute a piece of script that returns this new site. In this script, we call our command "get-iissite" and reuse the parameters passed to the current command. InvokeScript puts the result in the pipeline as requested, so there is no need to do anything else. This is an example of how we can do "callback" to PowerShell, passing formatted command lines statically or dynamically. Of course, it is possible to write it as C# code, but it requires either cutting and pasting large parts of GetSiteCommand, or reorganizing and refactoring the namespace.

At the beginning of the method EndProcessing() we see the call to ShouldProcess(). This is how the –whatif switch is supported. When the user passes this switch, this method prints text passed to it as a parameter, and the return is false. All actions that can change the environment must be performed when this call returns true. PowerShell has other switches that can interact with the user and ask confirmation before performing any action. ShouldProcess() returns as a result of this confirmation.

Test the new command with the following:


[!code-powershell[Main](writing-powershell-commandlets-for-iis/samples/sample21.ps1)]


This is how –whatif works. We get a rather cryptic message about what happens when this command executes. To make it more clear, we must format it properly. Parameter Bindings is entered in command line as a hash table, and gets passed into the cmdlet as Hashtable wrapped into PSObject. To produce meaningful text from it, we must add more smart code – the default ToString() simply returns the class name.

Insert this block of text in place of ShouldProcess() line:


[!code-csharp[Main](writing-powershell-commandlets-for-iis/samples/sample22.cs)]


After the cmdlet is built and executed, we see the following output:


[!code-powershell[Main](writing-powershell-commandlets-for-iis/samples/sample23.ps1)]


This is much more understandable. From this new code, it is also clear why we must process Hashtable in the method ToManagementObject() – this is a common type in PowerShell for passing structured parameters.

Now run the command.


[!code-powershell[Main](writing-powershell-commandlets-for-iis/samples/sample24.ps1)]


The first command created the site on the remote server and then retrieved it and passed to the pipeline. To ensure it was done correctly, we got a list of the sites, and indeed, the new site is available. By default, the server will try to start the site, unless we add the parameter –AutoStart false. If there is some problem in the parameters-- for example, the server cannot find the home folder-- then the site will remain stopped.

<a id="04"></a>

## Extending cmdlets to Work With a Server Farm

For now we have two commands: get-iissite and add-iissite. We are missing cmdlets to save the modified site and to delete the site. The deletion command should be remove-iissite, to keep it compatible with the PowerShell naming standards. The Save command will have a name set-iissite. For remove-iissite, we modify the get-iissite code and call the method Delete() on ManagementObject.

[!code-csharp[Main](writing-powershell-commandlets-for-iis/samples/sample25.cs)]

We also added a simple method CreateClassInstance() to the parent cmdlet. This method produces the object instance bound to the object path. Another change is that the Name parameter now cannot be empty – otherwise the user can delete all the sites by mistake. Finally, we added ShouldProcess() call to enable the –whatif and –confirm switches.


[!code-powershell[Main](writing-powershell-commandlets-for-iis/samples/sample26.ps1)]


We can implement the last command set-iissite as an exercise, modifying the add-iissite cmdlet and calling the Put() on ManagementObject.

Now scale the commands out and adapt them to work with multiple servers. This is easy:

Change the property Computer on the parent command to represent an array of strings:


[!code-csharp[Main](writing-powershell-commandlets-for-iis/samples/sample27.cs)]


Then add an extra loop over this array into each cmdlet to perform the same action on each computer. Here is an example from get-iissite:

[!code-console[Main](writing-powershell-commandlets-for-iis/samples/sample28.cmd)]

Now we can manipulate sites on the whole server farm.


[!code-powershell[Main](writing-powershell-commandlets-for-iis/samples/sample29.ps1)]


Save the server names from the farm into text file and use them as a parameter:


[!code-powershell[Main](writing-powershell-commandlets-for-iis/samples/sample30.ps1)]


We can do more advanced things using more PowerShell language. The following code enumerates sites on servers with names. Starting with "iissb", store the list into the variable and then stop all sites that are started.


[!code-powershell[Main](writing-powershell-commandlets-for-iis/samples/sample31.ps1)]


The variable $sitelist keeps the site list, but thanks to the dynamic nature of the property site.Status, we see the actual, not stored, status of each object.


[!code-powershell[Main](writing-powershell-commandlets-for-iis/samples/sample32.ps1)]


We can do the same without using any variables. Start any stopped site on any server on the server farm.


[!code-powershell[Main](writing-powershell-commandlets-for-iis/samples/sample33.ps1)]


In the accompanying source file iisdemocmd.cs, you find more commands for manipulating virtual directories and some properties in the configuration sections.


### Conclusion

As we can see, having only three commands allows us to cover most of the needs in the administration of IIS sites. Combined with the flexibility and richness of the shell language, each command adds a great deal of functionality. At the same time, writing a new command is not much more complicated than implementating similar script in VBScript or Jscript.

The IIS team plans to add full scale support of PowerShell into IIS 7.0 and above. This includes implementing a navigation provider, a property provider and all the other pieces of functionality required to work with all aspects of administration. Follow the progress of these upcoming improvements and look for the announcement on [https://www.iis.net/](https://www.iis.net/) and on the PowerShell site.