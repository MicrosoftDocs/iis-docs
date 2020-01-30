---
title: IIS Transform Manager
TOCTitle: IIS Transform Manager
ms:assetid: 7b5a31ee-d436-46c3-ad77-86070e434478
ms:mtpsurl: https://msdn.microsoft.com/library/Ff728121(v=VS.90)
ms:contentKeyID: 31469141
ms.date: 06/14/2012
mtps_version: v=VS.90
---

# IIS Transform Manager

IIS Transform Manager provides an extensible platform for scheduling and running tasks in sequence on an IIS server using a local task scheduler. For more information and examples, see the [Transform Manager Knowledge Base](https://go.microsoft.com/fwlink/?linkid=191301).

## Licensing

IIS Transform Manager is designed to work with other programs, such as programs that handle audio or video signals. It's solely your responsibility to ensure your compliance with any terms accompanying such other programs, and that you have obtained any necessary rights for your use of the programs.

## Transform Manager Plug-in Model

The [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md) namespace includes classes that define the plug-in model for IIS Transform Manager. Transform Manager supports a local task scheduler on a single IIS server or on the HPC Task Scheduler in a High Performance Computing (HPC) cluster. For more information about how to use Transform Manager with an HPC cluster, see [High-Performance Transcoding with IIS Transform Manager and Windows HPC Server](https://go.microsoft.com/fwlink/?linkid=217017).

### Task Engine Executable

Transform Manager runs custom tasks by loading them inside the TaskEngine.exe process, which loads custom assemblies and looks for specific interfaces that are implemented in the [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md) assembly. The process uses dependency injection to send required metadata, a status callback, and logging interfaces to the custom task.

### In This section

  - [Custom Task Registration (IIS Transform Manager)](custom-task-registration-iis-transform-manager.md)

  - [Task Definition Schema (IIS Transform Manager)](task-definition-schema-iis-transform-manager.md)

  - [Microsoft.Web.Media.TransformManager Namespace Reference](microsoft-web-media-transformmanager-namespace-reference.md)

## See Also

### Other Resources

[IIS Transform Manager (IIS.net)](https://go.microsoft.com/fwlink/?linkid=194958)

