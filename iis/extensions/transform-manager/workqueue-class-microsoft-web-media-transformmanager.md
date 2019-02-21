---
title: WorkQueue Class (Microsoft.Web.Media.TransformManager)
TOCTitle: WorkQueue Class
ms:assetid: T:Microsoft.Web.Media.TransformManager.WorkQueue
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.workqueue(v=VS.90)
ms:contentKeyID: 35521126
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.WorkQueue
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.WorkQueue
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# WorkQueue Class

Provides status details for jobs.

## Inheritance Hierarchy

[System.Object](https://msdn.microsoft.com/library/e5kfa45b)  
  Microsoft.Web.Media.TransformManager..::..WorkQueue  

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

```vb
'Declaration

  Public Class WorkQueue
'Usage

  Dim instance As WorkQueue
```

```csharp
  public class WorkQueue
```

```cpp
  public ref class WorkQueue
```

``` fsharp
  type WorkQueue =  class end
```

```jscript
  public class WorkQueue
```

The WorkQueue type exposes the following members.

## Properties

||Name|Description|
|--- |--- |--- |
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[ConfiguringJobs](workqueue-configuringjobs-property-microsoft-web-media-transformmanager.md)|Gets a collection of job details that specify jobs that are being configured.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[FailedJobs](workqueue-failedjobs-property-microsoft-web-media-transformmanager.md)|Gets a collection of job details that specify jobs that have failed.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[FinishedJobs](workqueue-finishedjobs-property-microsoft-web-media-transformmanager.md)|Gets a collection of job details that specify jobs that have finished.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[RunningJobs](workqueue-runningjobs-property-microsoft-web-media-transformmanager.md)|Gets a collection of job details that specify jobs that are running.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[SubmittedJobs](workqueue-submittedjobs-property-microsoft-web-media-transformmanager.md)|Gets a collection of job details that specify jobs that have been submitted.|

## Methods

||Name|Description|
|--- |--- |--- |
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[Equals](https://msdn.microsoft.com/library/bsc2ak47)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Protected method](images/Hh125771.protmethod(en-us,VS.90).gif "Protected method")|[Finalize](https://msdn.microsoft.com/library/4k87zsw7)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetHashCode](https://msdn.microsoft.com/library/zdee4b3y)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetType](https://msdn.microsoft.com/library/dfwy45w9)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Protected method](images/Hh125771.protmethod(en-us,VS.90).gif "Protected method")|[MemberwiseClone](https://msdn.microsoft.com/library/57ctke0a)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[ToString](https://msdn.microsoft.com/library/7bxwbwt2)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

### Reference

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

