---
title: "Walkthrough: Creating a Request-Level HTTP Module By Using Native Code"
ms.date: "10/07/2016"
ms.assetid: 175190d6-4f32-4813-8ffd-458c79d708e4
---
# Walkthrough: Creating a Request-Level HTTP Module By Using Native Code
This walkthrough demonstrates how to use C++ to create a sample request-level HTTP module that implements the new request-processing architecture in [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)]. This new architecture extends the capabilities of native-code programming when you are writing IIS applications over earlier versions of [!INCLUDE[vstecasp](../../wmi-provider/includes/vstecasp-md.md)] HTTP modules and ISAPI filters or extensions. For more information about designing HTTP modules using the new request-processing architecture, see [Designing Native-Code HTTP Modules](../../web-development-reference/native-code-development-overview/designing-native-code-http-modules.md).  
  
 In this walkthrough, you will create a C++ project for your HTTP module, add the required code for a "Hello World" project, and then compile and test the module.  
  
## Prerequisites  
 The following software is required to complete the steps in the example:  
  
-   [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)].  
  
-   [!INCLUDE[vsprvslong](../../wmi-provider/includes/vsprvslong-md.md)].  
  
-   [!INCLUDE[winsdklong](../../web-development-reference/native-code-development-overview/includes/winsdklong-md.md)].  
  
 **Note** You can use Visual Studio .NET 2003 or earlier, although the walkthrough steps may not be identical.  
  
## Creating the Module  
 In this part of the walkthrough, you will create an empty C++ DLL project for your HTTP module.  
  
#### To create a new C++ DLL project  
  
1.  Open [!INCLUDE[vsprvslong](../../wmi-provider/includes/vsprvslong-md.md)].  
  
2.  Verify that the global options have all the right paths to the SDK include files:  
  
    1.  On the **Tools** menu, click **Options**.  
  
    2.  Expand the **Projects and Solutions** node in the tree view, and then click **VC++ Directories**.  
  
    3.  In the **Show directories for** drop-down box, select **Include files**.  
  
    4.  Verify that the path where you installed the [!INCLUDE[winsdkshort](../../web-development-reference/native-code-development-overview/includes/winsdkshort-md.md)] include files is listed. If the path is not listed, click the **New Line** icon, and then add the path where you installed the SDK include files. The default installation directory is $(VCInstallDir)PlatformSDK\bin.  
  
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
 The next step is to add the required C++ and module-definition files to the project.  
  
#### To add the source files to the project  
  
1.  Create the module-definition file to export the [RegisterModule](../../web-development-reference/native-code-api-reference/pfn-registermodule-function.md) function:  
  
    1.  In Solution Explorer, right-click **Source Files**, point to **Add**, and then click **New Item**.  
  
         The **Add New Item** dialog box opens.  
  
    2.  Expand the **Visual C++** node in the **Categories** pane, and then click **Code**.  
  
    3.  In the **Templates** pane, select the **Module-Definition File** template.  
  
    4.  In the **Name** box, type **HelloWorld**, and leave the default path for the file in the **Location** box.  
  
    5.  Click **Add**.  
  
    6.  Add a line with `EXPORTS` and `RegisterModule`. Your file should look like the code below:  
  
        ```  
        LIBRARY"HelloWorld"  
        EXPORTS  
            RegisterModule  
        ```  
  
        > [!NOTE]
        >  Instead of creating a module-definition file, you can export the [RegisterModule](../../web-development-reference/native-code-api-reference/pfn-registermodule-function.md) function by using the **/EXPORT:RegisterModule** switch.  
  
2.  Create the C++ file:  
  
    1.  In Solution Explorer, right-click **Source Files**, point to **Add**, and then click **New Item**.  
  
         The **Add New Item** dialog box opens.  
  
    2.  Expand the **Visual C++** node in the **Categories** pane, and then click **Code**.  
  
    3.  In the **Templates** pane, select the **C++ File** template.  
  
    4.  In the **Name** box, type **HelloWorld**, and leave the default path for the file in the **Location** box.  
  
    5.  Click **Add**.  
  
    6.  Add the following code:  
  
         [!code-cpp[CHttpModuleHelloWorld#1](~/samples/snippets/cpp/VS_Snippets_IIS/IIS7/CHttpModuleHelloWorld/cpp/CHttpModuleHelloWorld.cpp#1)]  
  
## Compiling and Testing the Module  
  
#### To compile and test the project  
  
1.  Compile the HTTP module:  
  
    1.  On the **Build** menu, click **Build Solution**.  
  
    2.  Verify that Visual Studio did not return any errors or warnings.  
  
    3.  Add the HelloWorld.dll module (with the complete path) to the `globalModules` section of %windir%\system32\inetsrv\config\applicationHost.config file.  
  
2.  Use Internet Explorer to browse to your Web site; you should see "Begin Request sample " with the request count displayed.  
  
> [!NOTE]
>  You will need to stop IIS before you link your project on subsequent builds.  
  
## Troubleshooting Your Settings  
 If your module does not compile or does not work as expected, here are several areas that you can check:  
  
-   Ensure that you have specified `__stdcall` for your exported functions, or that you have configured compilation by using the `__stdcall (/Gz)` calling convention.  
  
-   Ensure that IIS has loaded HelloWorld.dll:  
  
    1.  In [!INCLUDE[iismgr](../../wmi-provider/includes/iismgr-md.md)], click **Default Web Site** in the **Connections** pane.  
  
    2.  In the workspace (the center pane), select **Features View**.  
  
    3.  In the **Group by** box, select **Category**.  
  
    4.  In the **Server Components** category, double-click **Modules**.  
  
    5.  Verify that HelloWorld module is listed.  
  
-   Ensure that you have added the correct `RegisterModule` export to your definition file.  
  
-   Ensure that you have added the definition file to the project settings. To add the file to the project settings, complete the following steps:  
  
    1.  On the **Project** menu, click **Properties**.  
  
    2.  Expand the **Configuration Properties** node in the tree view, expand the **Linker** node, and then click **Input**.  
  
    3.  For the **Module Definition File** settings, ensure that your definition file is listed.  
  
## See Also  
 [Creating Native-Code HTTP Modules](../../web-development-reference/native-code-development-overview/creating-native-code-http-modules.md)   
 [Designing Native-Code HTTP Modules](../../web-development-reference/native-code-development-overview/designing-native-code-http-modules.md)