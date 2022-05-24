---
title: SchedulerProvider.FindJobSchedulerInfo Method  (Microsoft.Web.Media.TransformManager)
description: Describes the FindJobSchedulerInfo method and provides the method's namespace, assembly, syntax, parameters, and return value.
TOCTitle: FindJobSchedulerInfo Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.SchedulerProvider.FindJobSchedulerInfo(System.String)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.schedulerprovider.findjobschedulerinfo(v=VS.90)
ms:contentKeyID: 35520671
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.SchedulerProvider.FindJobSchedulerInfo
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.SchedulerProvider.FindJobSchedulerInfo
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# FindJobSchedulerInfo Method

Finds a [SchedulerInfo](schedulerinfo-class-microsoft-web-media-transformmanager.md) object based on the specified scheduler ID.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Shared Function FindJobSchedulerInfo ( _
    id As String _
) As SchedulerInfo
'Usage

  Dim id As String
Dim returnValue As SchedulerInfo

returnValue = SchedulerProvider.FindJobSchedulerInfo(id)
```

```csharp
  public static SchedulerInfo FindJobSchedulerInfo(
    string id
)
```

```cpp
  public:
static SchedulerInfo^ FindJobSchedulerInfo(
    String^ id
)
```

``` fsharp
  static member FindJobSchedulerInfo : 
        id:string -> SchedulerInfo 
```

```jscript
  public static function FindJobSchedulerInfo(
    id : String
) : SchedulerInfo
```

### Parameters

  - id  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    A scheduler ID value.  

### Return Value

Type: [Microsoft.Web.Media.TransformManager.SchedulerInfo](schedulerinfo-class-microsoft-web-media-transformmanager.md)  
A [SchedulerInfo](schedulerinfo-class-microsoft-web-media-transformmanager.md) object that matches the provided scheduler ID value.  

## See Also

### Reference

[SchedulerProvider Class](schedulerprovider-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
