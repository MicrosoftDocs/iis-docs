---
title: SchedulerInfo Class (Microsoft.Web.Media.TransformManager)
TOCTitle: SchedulerInfo Class
ms:assetid: T:Microsoft.Web.Media.TransformManager.SchedulerInfo
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.schedulerinfo(v=VS.90)
ms:contentKeyID: 35520987
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.SchedulerInfo
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.SchedulerInfo
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# SchedulerInfo Class

Provides scheduling information about an IIS Transform Manager job.

## Inheritance Hierarchy

[System.Object](https://msdn.microsoft.com/library/e5kfa45b)  
  Microsoft.Web.Media.TransformManager..::..SchedulerInfo  

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Class SchedulerInfo
'Usage

  Dim instance As SchedulerInfo
```

```csharp
  public class SchedulerInfo
```

```cpp
  public ref class SchedulerInfo
```

``` fsharp
  type SchedulerInfo =  class end
```

```jscript
  public class SchedulerInfo
```

The SchedulerInfo type exposes the following members.

## Constructors

||Name|Description|
|--- |--- |--- |
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[SchedulerInfo(XElement)](schedulerinfo-constructor-xelement-microsoft-web-media-transformmanager.md)|Initializes a new instance of the SchedulerInfo class using the specified RDF scheduler node.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[SchedulerInfo(JobScheduler)](schedulerinfo-constructor-jobscheduler-microsoft-web-media-transformmanager.md)|Initializes a new instance of the SchedulerInfo class using the specified job scheduling information.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[SchedulerInfo(String, String, String, String, Int32)](schedulerinfo-constructor-string-string-string-string-int32-microsoft-web-media-transformmanager.md)|Initializes a new instance of the SchedulerInfo class using the specified job ID, name, type, connection string, and concurrent jobs value.|

## Properties

||Name|Description|
|--- |--- |--- |
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[ConcurrentJobs](schedulerinfo-concurrentjobs-property-microsoft-web-media-transformmanager.md)|Gets or sets the number of concurrent jobs that a job manager can start.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[ConnectionString](schedulerinfo-connectionstring-property-microsoft-web-media-transformmanager.md)|Gets or sets the connection string that is used by this scheduler.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[Id](schedulerinfo-id-property-microsoft-web-media-transformmanager.md)|Gets or sets the ID of the SchedulerInfo object.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[Name](schedulerinfo-name-property-microsoft-web-media-transformmanager.md)|Gets or sets the name of the SchedulerInfo object.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[SchedulerType](schedulerinfo-schedulertype-property-microsoft-web-media-transformmanager.md)|Gets or sets the scheduler type.|

## Methods

||Name|Description|
|--- |--- |--- |
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[CreateInstance() () () ()](schedulerinfo-createinstance-method-microsoft-web-media-transformmanager_1.md)|Creates a new instance of a [Scheduler](scheduler-class-microsoft-web-media-transformmanager.md) object.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[CreateInstance(Logger)](schedulerinfo-createinstance-method-logger-microsoft-web-media-transformmanager.md)|Creates a new instance of a [Scheduler](scheduler-class-microsoft-web-media-transformmanager.md) object by using logger object to log details.|
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

