---
title: "Walkthrough: Creating a Global-Level HTTP Module By Using Native Code"
ms.date: "10/07/2016"
ms.assetid: 2723c69f-eac6-400a-97b9-9517a7d26393
---
# Walkthrough: Creating a Global-Level HTTP Module By Using Native Code
This walkthrough demonstrates how to use C++ to create a sample global-level HTTP module that implements the new request-processing architecture in [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)]. This new architecture extends the capabilities of native-code programming when you are writing IIS applications over earlier versions of [!INCLUDE[vstecasp](../../wmi-provider/includes/vstecasp-md.md)] HTTP modules and ISAPI filters or extensions. For more information about designing HTTP modules using the new request-processing architecture, see [Designing Native-Code HTTP Modules](../../web-development-reference\native-code-development-overview\designing-native-code-http-modules.md).  
  
 In this walkthrough, you will create a C++ project for your HTTP module, add the required code for a "Hello World" project, and then compile and test the module.  
  
## Prerequisites  
 The following software is required to complete the steps in the example:  
  
-   [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)].  
  
-   [!INCLUDE[vsprvslong](../../wmi-provider/includes/vsprvslong-md.md)].  
  
 **Note** You may also use Visual Studio .NET 2003 or earlier, although the walkthrough steps may not be identical.  
  
## Creating the Module  
 In this part of the walkthrough, you will create an empty C++ DLL project for your HTTP module.  
  
#### To create a new C++ DLL project  
  
1.  Start [!INCLUDE[vsprvslong](../../wmi-provider/includes/vsprvslong-md.md)].  
  
2.  Verify that the global options have all the right paths to the SDK include files:  
  
    1.  On the **Tools** menu, click **Options**.  
  
    2.  Expand the **Projects and Solutions** node in the tree view, and then click **VC++ Directories**.  
  
    3.  In the **Show directories for** drop-down box, select **Include files**.  
  
    4.  Verify that the path where you installed the SDK include files is listed. If the path is not listed, click the **New Line** icon, and then add the path where you installed the SDK include files.  
  
    5.  Click **OK**.  
  
3.  Create a new C++ project:  
  
    1.  On the **File** menu, point to **New**, and then click **Project**.  
  
         The **New Project** dialog box opens.  
  
    2.  In the **Project Types** pane, expand the **Visual C++** node, and then click **Win32**.  
  
    3.  In the **Templates** pane, select **Win32 Project**.  
  
    4.  In the **Name** box, type **HelloWorld**.  
  
    5.  In the **Location** box, type the path for the sample.  
  
    6.  Click **OK**.  
  
         The **Win32 Application Wizard** opens.  
  
    7.  Click **Application Settings**.  
  
    8.  Under **Application type**, click **DLL**.  
  
    9. Under **Additional options**, click **Empty project**.  
  
    10. Click **Finish**.  
  
## Adding the Code and Source Files  
 The next step is to add the required C++ and module definition-files to the project.  
  
#### To add the source files to the project  
  
1.  Create the module-definition file to export the [RegisterModule](../../web-development-reference\native-code-api-reference/pfn-registermodule-function.md) function:  
  
    1.  In Solution Explorer, right-click **Source Files**, point to **Add**, and then click **New Item**.  
  
         The **Add New Item** dialog box opens.  
  
    2.  Expand the **Visual C++** node in the **Categories** pane, and then click **Code**.  
  
    3.  In the **Templates** pane, select the **Module-Definition File** template.  
  
    4.  In the **Name** box, type **HelloWorld**, and leave the default path for the file in the **Location** box.  
  
    5.  Click **Add**.  
  
    6.  Add the following code:  
  
        ```  
        LIBRARY HelloWorld  
  
        EXPORTS  
            RegisterModule  
        ```  
  
2.  You can optionally export the [RegisterModule](../../web-development-reference\native-code-api-reference/pfn-registermodule-function.md) function by using the **/EXPORT:RegisterModule** switch:  
  
    1.  On the **Project** menu, click **HelloWorld Properties**.  
  
    2.  Expand the **Configuration Properties** node in the tree view, expand the **Linker** node, and then click **Command Line**.  
  
    3.  In the **Configuration** drop-down box, select **All Configurations**.  
  
    4.  In the **Additional Options** box, type **/EXPORT:RegisterModule**.  
  
    5.  Click **OK**.  
  
3.  Create the C++ file:  
  
    1.  In Solution Explorer, right-click **Source Files**, point to **Add**, and then click **New Item**.  
  
         The **Add New Item** dialog box opens.  
  
    2.  Expand the **Visual C++** node in the **Categories** pane, and then click **Code**.  
  
    3.  In the **Templates** pane, select the **C++ File** template.  
  
    4.  In the **Name** box, type **HelloWorld**, and leave the default path for the file in the **Location** box.  
  
    5.  Click **Add**.  
  
    6.  Add the following code:  
  
<!-- TODO: review snippet reference          [!CODE [CGlobalModuleHelloWorld#1](CGlobalModuleHelloWorld#1)]  -->  
  
4.  You can optionally compile the code by using the `__stdcall (/Gz)` calling convention:  
  
    1.  On the **Project** menu, click **HelloWorld Properties**.  
  
    2.  Expand the **Configuration Properties** node in the tree view, expand the **C/C++** node, and then click **Advanced**.  
  
    3.  In the **Configuration** drop-down box, select **All Configurations**.  
  
    4.  In the **Calling Convention** drop-down box, select **__stdcall (/Gz)**.  
  
    5.  Click **OK**.  
  
## Compiling and Testing the Module  
 Your HTTP module has everything that it needs. All that is required is to compile and test your HTTP module.  
  
#### To compile and test the project  
  
1.  Compile the HTTP module:  
  
    1.  On the **Build** menu, click **Build Solution**.  
  
    2.  Verify that Visual Studio did not return any errors or warnings. If you encounter any errors or warnings, you will need to resolve those issues before testing the project.  
  
2.  Copy the DLL file for the HTTP module to your IIS folder:  
  
    1.  Open Windows Explorer and locate the default folder that was specified when you created the C++ project.  
  
         Depending on your build options, you should see a folder named Debug or Release in the default folder for your project.  
  
    2.  Inside the Debug or Release folder, locate the file named HelloWorld.dll.  
  
    3.  Copy the HelloWorld.dll file to your Inetsrv folder, which is located by default at %WinDir%\System32\Inetsrv.  
  
3.  Add the HelloWorld.dll module to your list of modules (for instructions, see [Designing Native-Code HTTP Modules](../../web-development-reference\native-code-development-overview\designing-native-code-http-modules.md)).  
  
4.  Use Internet Explorer to browse to your Web site; you should see your normal Web site content.  
  
5.  Open the Windows Event Viewer and switch to the global application log; you should see an entry that lists "IISADMIN" as the event source.  
  
6.  Right-click the event, and then click **Properties** to view the event details. You should see a "Hello World!" message displayed in **Description** pane.  
  
## Troubleshooting Your Settings  
 If your module does not compile or does not work as expected, here are several areas that you can check:  
  
-   Ensure that you have specified `__stdcall` for your exported functions, or that you have configured compilation by using the `__stdcall (/Gz)` calling convention.  
  
-   Ensure that you have added the correct `RegisterModule` export to your definition file.  
  
-   Ensure that you have added the definition file to the project settings. To add the file to the project settings, complete the following steps:  
  
    1.  On the **Project** menu, click **Properties**.  
  
    2.  Expand the **Configuration Properties** node in the tree view, expand the **Linker** node, and then click **Input**.  
  
    3.  For the **Module Definition File** settings, ensure that your definition file is listed.  
  
## See Also  
 [Creating Native-Code HTTP Modules](../../web-development-reference\native-code-development-overview\creating-native-code-http-modules.md)   
 [Designing Native-Code HTTP Modules](../../web-development-reference\native-code-development-overview\designing-native-code-http-modules.md)