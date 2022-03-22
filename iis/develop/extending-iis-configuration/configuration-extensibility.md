---
title: "Configuration Extensibility"
author: rick-anderson
description: "Introduction The configuration system in IIS 7.0 and above is based on distributed xml files that contain the configuration for IIS, ASP.NET and other compon..."
ms.date: 12/05/2007
ms.assetid: d4d6dc1f-ff81-44b9-ab0b-cf711da8f1e6
msc.legacyurl: /learn/develop/extending-iis-configuration/configuration-extensibility
msc.type: authoredcontent
---
# Configuration Extensibility

The configuration system in IIS 7.0 and above is based on distributed xml files that contain the configuration for IIS, ASP.NET and other components; flexibility in the configuration system also allows for configuration to be set at a number of levels including at the server, the site and the application level. Configuration at the site and application level coexists alongside ASP.NET configuration in web.config files.

One aspect of the new configuration system is the ease with which configuration can be extended. It is possible, with only a few simple changes, to integrate custom configuration sections directly into the configuration system and manipulate these settings using the existing administration APIs. Configuration is extended by simply defining a new configuration section in an XML schema file which is then dropped in the IIS schema directory `%windir%\system32\inetsrv\config\schema`. Finally, the new configuration section has to be registered in the IIS global configuration file.

This article walks through an example which uses basic configuration extensibility and some of the more advanced scenarios. Though the example used is contrived, it should be sufficient to demonstrate the power of configuration extensibility.

## Prerequisites

There are a number of prerequisites for this article. They include:

1. Having a default install of IIS 7.0 or above. If IIS is not installed, install it by opening the Server Manager and adding the Web Server (IIS) role.
2. Making sure that you have the .NET Framework SDK installed. If you do not have the SDK installed, get it from [https://www.microsoft.com/downloads](https://www.microsoft.com/downloads)
3. Using a number of tools in the bin directory of the SDK. Either use the SDK Command Prompt from your start menu or add the bin directory to your path (e.g. `%systemdrive%\Program Files\Microsoft.NET\SDK\v2.0\Bin`)
4. Running all the commands from a command prompt with elevated privileges. Right click on "SDK Command Prompt" (or "Command Prompt") in the start menu and then select "Run as administrator".

## Configuration Extensibility - The Basics

### Overview

In order to demonstrate some of the basic configuration extensibility features, we use the contrived example of a custom logging module. The module itself is not all that special and simply handles a built in IIS logging event *- LogRequest* - and writes a log entry to a file on disk; think of it as a basic version of IIS logging.

Configuration extensibility comes into play because the module needs to know where to log information. The module must have a custom configuration section that stores its configuration - in this case, the logfile location.

### Step 1 - The Schema File

The first step in adding a new configuration section is defining the section. Define the section schema in xml and drop the file into the `%windir%\system32\inetsrv\config\schema` directory.

Create an xml file called **simpleLogging\_Schema.xml** and put the following into it:

[!code-xml[Main](configuration-extensibility/samples/sample1.xml)]

The schema above does two things. First, it defines a new configuration section named "simpleLogging" using the &lt;sectionSchema&gt; element. Second, it defines an attribute of that new configuration section called "logfileDirectory".

You can see from the schema file that the attribute is a string and the configuration system will not encrypt it. The *expanded="true"* tells the configuration system to automatically expand environment variables when used. If you did not create the file in the `%windir%\system32\inetsrv\config\schema` directory, move it there now.

Next, create the default directory specified for "logfileDirectory", as it probably does not exist on your machine. Run the following command from the command line to create the directory:

[!code-console[Main](configuration-extensibility/samples/sample2.cmd)]

The Windows group IIS\_IUSRS must have write permissions to the directory so that the SimpleLogging module we create in Step 4 can write log files to it. Run the following command at the command line:

[!code-console[Main](configuration-extensibility/samples/sample3.cmd)]

### More about the schema

Although Step 1 is complete in terms of our example, it is appropriate to discuss the schema files. In the schema above, we simply created a new configuration section **simpleLogging** that exists under **system.webServer** and specified a custom attribute. However, you can easily create more complex custom configuration with collections, elements and attributes. The following list shows some examples, but the best way to learn is to look at the schema file for the IIS configuration. Find it at `%windir%\system32\inetsrv\config\schema\IIS\_schema.xml`.

* **attribute**

   **Schema information:**

   [!code-xml[Main](configuration-extensibility/samples/sample4.cmd)]

   **Example:**

   [!code-xml[Main](configuration-extensibility/samples/sample5.xml)]

* **element**

   **Schema information:**

   [!code-xml[Main](configuration-extensibility/samples/sample6.xml)]

   **Example:**

   [!code-xml[Main](configuration-extensibility/samples/sample7.xml)]

* **collection**

   **Schema information:**

   [!code-xml[Main](configuration-extensibility/samples/sample8.xml)]

   **Example:**

   [!code-xml[Main](configuration-extensibility/samples/sample9.xml)]

### Step 2 – Registering the New Section

Now that a new section has been defined, tell the configuration system about the section. Register the new section in the `%windir%\system32\inetsrv\config\applicationHost.config` file. Open the file and register the simpleLogging section as below:

[!code-xml[Main](configuration-extensibility/samples/sample10.xml)]

This step is complete. The section is defined and registered.

To check that the section has registered correctly, run the following command from the command line:

[!code-console[Main](configuration-extensibility/samples/sample11.cmd)]

If everything has gone well up to now, then the configuration section displays and you see something like this:

[!code-xml[Main](configuration-extensibility/samples/sample12.xml)]

### Step 3 – Setting the Configuration

Now that the section has been registered, set the configuration as you would any other configuration using a **web.config** file, or set it using the **appcmd.exe** tool in the `%windir%\system32\inetsrv\` directory. You can also set the configuration using any of the configuration APIs. One more option is to set the configuration via the new IIS administration UI by creating a UI module and calling the configuration APIs to set the configuration.

For the time being, set the configuration by adding it to a new **web.config** file for the default IIS website (the one installed at `%systemdrive%\inetpub\wwwroot\` and named "Default Web Site" in the default IIS configuration). Create a file called web.config and add the following:

[!code-xml[Main](configuration-extensibility/samples/sample13.xml)]

You can achieve the same thing from the command line using:

[!code-console[Main](configuration-extensibility/samples/sample14.cmd)]

Run the following command to list the configuration for the "Default Web Site":

[!code-console[Main](configuration-extensibility/samples/sample15.cmd)]

The output is something like this:

[!code-xml[Main](configuration-extensibility/samples/sample16.xml)]

> [!NOTE]
> If the directory specified for "logfileDirectory" does not exist, create it now. The Windows group IIS\_IUSRS must have write permissions to the directory so that the SimpleLogging module we create in the next step can write log files to it. Step 1 above showed the command line command used to set the correct permissions on the default directory. Use a similar command if you have created a different directory.

### Step 4 – The SimpleLogging Module

At this stage, we have extended the configuration system with our customer **simpleLogging** configuration section. We round off the look at basic configuration extensibility by creating the module and showing how to use the custom configuration from it.

We will create a strongly named .NET assembly that all websites in IIS can use. We must use some tools from the .NET SDK for this section; if it is not installed, download it from the [www.microsoft.com/downloads](https://www.microsoft.com/downloads) website.

The required steps include:

1. Create a directory in which to work and open it.
2. Create a **SimpleLoggingModule.cs** file and add the following code to it using a text editor:  

   [!code-csharp[Main](configuration-extensibility/samples/sample17.cs)]

3. We must make this a strongly named module in order for IIS to use it as a global module for all sites. First, create a strong name key file. Open a command prompt and change the directory to the one containing the **SimpleLoggingModule.cs** file. Then, run the following command (make sure that the bin directory of your .NET framework SDK is in your path):  

   [!code-console[Main](configuration-extensibility/samples/sample18.cmd)]

   If this worked correctly, the output of sn.exe says something like "Key pair written to keyFile.snk"

4. Now compile the file and create a DLL. Run the following command from the command prompt:  

   [!code-console[Main](configuration-extensibility/samples/sample19.cmd)]

5. Next, place the compiled assembly (SimpleLoggingModule.dll) into the Global Assembly Cache. Run the following command from the command prompt:  

   [!code-console[Main](configuration-extensibility/samples/sample20.cmd)]

6. Now we must add our module to the list of modules that IIS can use. Before that, however, we must get the full name of the assembly just created. Run the following at the command line:  

   [!code-console[Main](configuration-extensibility/samples/sample21.cmd)]

   This outputs something like this:

   [!code-console[Main](configuration-extensibility/samples/sample22.cmd)]

7. Add the module to the list of modules that IIS can use. Run the command below. However, ensure that you replace the variables with the output of the last command.  

    [!code-console[Main](configuration-extensibility/samples/sample23.cmd)]

    This adds the necessary configuration entry to the applicationHost.config file - IIS's global configuration file.

8. The process is complete. The custom module, which uses custom configuration, has been setup. All that remains is to test it. Initiate the browser and navigate to http://localhost/. You see the following:  

   ![Screenshot of accessing local host in a web browser.](configuration-extensibility/_static/image1.jpg)

If you get an error, make sure that you have given the IIS\_IUSRS group permissions to write to the directory.

Open `%systemdrive%\inetpub\logs\simpleLogs` (or whatever directory you used in the configuration) and you have a .log file named with today's date. Open the file and you see something like this:

![Screenshot of a log file with the time stamps of the accessed directories for the local host website.](configuration-extensibility/_static/image3.jpg)

Experiment with the configuration to ensure that it is working. Try removing the **simpleLogging** section from your web.config file and check to see if the logs go to the default location (just ensure that the ASPNET user has the correct permissions).

> [!NOTE]
> The module we just created is for demonstration purposes only and should not be used in a production environment. It will fail if there are multiple requests trying to write a log entry at the same time.

## Configuration Extensibility - More Advanced Scenarios

### Overview

The previous section examined the basics of configuration extensibility - simply extending the configuration using schema. However, there is more power available when extending configuration.

First, there is the ability to extend configuration to use COM objects for retrieving configuration, allowing you to store the configuration information wherever and however you want without worrying that the configuration APIs cannot read it.

Second, there is the ability to define methods to manipulate and operate on your configuration. These methods can then be called using the existing configuration APIs. Together these two features provide powerful support for building custom configuration extensions.

This section first looks at modifying the simpleLogging custom configuration from the first part of this article to retrieve configuration values using a COM component. Then it looks at adding a configuration method backed by a COM component that performs actions.

### Extending Configuration - An Attribute Backed by COM

This section extends the schema to have an attribute called "logfileCount". This configuration attribute is backed by a .NET assembly (a managed dll - programmed in C#), which counts the number of log files in the log directory; once again, this is a contrived scenario but one that some might find useful.

> [!NOTE]
> You do not have to create a .NET component - any valid COM component will do.

### Step 1 - Creating and Registering the .NET COM Component

First, to create the .NET COM component. Create a directory to store the files we will create and the component we will build and open it.

The component we create must implement some interfaces exposed via COM by the IIS configuration system. In order to use the COM interface from the .NET component, we must create an interop dll - this allows the IIS configuration system to talk to the component when it must get a value for the logfileCount attribute. To create the interop dll, use a tool from the .NET Framework SDK called **tlbimp.exe**. Having Visual Studio or the .NET SDK installed is a prerequisite for this article. If it is not installed, download it from [www.microsoft.com/downloads](https://www.microsoft.com/downloads).

Here are the steps to create the .NET COM component:

1. Open a command line prompt and change to the directory you created to store the files. Make sure that the bin directory of the .NET Framework is in your path and then run the following command at the command line:  

   [!code-console[Main](configuration-extensibility/samples/sample24.cmd)]

   The tlbimp.exe tool will have created a file called AppHostAdminLibrary.dll – this is the interop dll that we need.

2. Create a ConfigurationExtensibility.cs file in the directory you created earlier and copy the following C# code into the file using a text editor:  

   [!code-csharp[Main](configuration-extensibility/samples/sample25.cs)]

   > [!NOTE]
   > We have a class which is implementing the **IAppHostPropertyExtension** interface. The code itself only reads the logfileDirectory attribute to get the logfile directory and then counts all the files that match the filename pattern for the log files that SimpleLoggingModule created.

3. Build the component by running the following command from the commandline:  

   [!code-console[Main](configuration-extensibility/samples/sample26.cmd)]

   You now have your .NET COM component – **ConfigurationExtensibility.dll**.

4. Register the managed COM component you just created. Run the following command at the command prompt:  

   [!code-console[Main](configuration-extensibility/samples/sample27.cmd)]

   This registers the COM component in the registry. You have created and registered a .NET COM component that the configuration system can use.

### Step 2 - Updating the Schema File

Next, modify the **simpleLogging\_Schema.xml** file created earlier. Open the file and change it to look like the following (the new attribute is bolded):

[!code-xml[Main](configuration-extensibility/samples/sample28.xml)]

### Step 3 - Testing

Everything should be working properly now-- all that remains is testing. To test the extension, use a simple script. Create a SimpleLoggingTest.vbs file and enter the following text:

[!code-vb[Main](configuration-extensibility/samples/sample29.vb)]

At this stage, there should be a single log file from testing the SimpleLoggingModule earlier. Run the script from the command line. You see an output of 1.

## Extending Configuration - A Method Backed by COM

Finally, this article examines extending configuration with a method. Configuration methods are operations that the configuration system can call to do work such as modifying a configuration or deleting log files--which is what this method will do. For this example, we add a method to delete all the log files created by the SimpleLoggingModule.

### Step 1 - The Code

1. First,add the necessary code for the method. Open up the ConfigurationExtensibility.cs file created earlier and update it to look as follows (new code bolded):  

   [!code-csharp[Main](configuration-extensibility/samples/sample30.cs)]

   > [!NOTE]
   > We have implemented the **IAppHostMethodExtension** interface. This interface has a single method called **ProvideMethod** which logically provides the method. When someone calls the method (see Step 3 for how to do this), the configuration system calls ProvideMethod and passes parameters, one of which has the name of the method being called; in the code above, we only handle a method called "deleteLogs".

2. Build the project again using:  

   [!code-console[Main](configuration-extensibility/samples/sample31.cmd)]

### Step 2 - Updating the Schema

Next, tell the schema about our new method. At this stage, you should be fairly familiar with your **simpleLogging\_Schema.xml** file, so open it up again and change it to look like the following:

[!code-xml[Main](configuration-extensibility/samples/sample32.xml)]

The change defined a new method called "deleteLogs" and tells the configuration where to look for the method.

### Step 3 - Testing

Finally, check to see if the method is working. A quick and easy way to do this is to write a simple VB script. Below is an example script that outputs the logfileCount, then calls our method and outputs the logfileCount. Simply update the SimpleLoggingTest.vbs file you created earlier and enter the following:

[!code-vb[Main](configuration-extensibility/samples/sample33.vb)]

Run the script from a command line and you get an output of:

[!code-console[Main](configuration-extensibility/samples/sample34.cmd)]

The above was a quick overview of how to provide new configuration and configuration methods backed by COM components. As you probably found, extending configuration using this method is very powerful.

## Configuration Extensibility - Extending Existing Configuration

The final aspect of configuration extensibility is the ability to extend existing configuration sections such as the **system.webServer/sites** section, or to extend the **system.webServer/simpleLogging** section created in the previous two sections.

Extending an existing configuration section is as easy as creating a new one. Simply define the schema as xml and place the schema file in the `%windir%\system32\inetsrv\config\schema\` directory. This should sound familiar, as we have done this previously more than once.

### Extending the "sites" configuration

To better show how to extend an existing configuration section, we extend the **system.applicationHost/sites** section - the configuration section used to define sites. We extend the sites section by adding an "owner" attribute and an "ownerEmail" attribute. Attributes like these are useful when you host multiple sites on a single box and want to keep track of who owns the different sites.

First, create a new schema file. Create a **siteExtension\_schema.xml** file in the `%windir%\system32\inetsrv\config\schema\` directory and enter the text below:

[!code-xml[Main](configuration-extensibility/samples/sample35.xml)]

When extending the schema of an existing section, simply create a `<sectionSchema>` element and set the **name** attribute to be the same as an existing section. In the schema file above, we have defined a &lt;sectionSchema&gt; with a name of "system.applicationHost/sites" - this is the same as the sectionSchema name in the IIS\_Schema.xml file in the Schema directory.

Test our modifications by adding values for the "owner" and "ownerEmail" attributes and then check the configuration file to see the changes. Simply run the following command from the command line:

[!code-console[Main](configuration-extensibility/samples/sample36.cmd)]

To see if the configuration was applied, run the following command and check the output:

[!code-console[Main](configuration-extensibility/samples/sample37.cmd)]

The output should be something like the following:

[!code-xml[Main](configuration-extensibility/samples/sample38.xml)]

> [!NOTE]
> If you now browse to `http://localhost/`, you may receive a server 500.19 error message. This is a known issue and will be resolved in a later build of IIS. To get around this issue, run "iisreset" from the command line.

That concludes the look at configuration extensibility. Hopefully, you can use configuration extensibility in an interesting way after reading through the previous examples.
