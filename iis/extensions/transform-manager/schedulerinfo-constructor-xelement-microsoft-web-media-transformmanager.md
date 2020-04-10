---
title: SchedulerInfo Constructor (XElement) (Microsoft.Web.Media.TransformManager)
TOCTitle: SchedulerInfo Constructor (XElement)
ms:assetid: M:Microsoft.Web.Media.TransformManager.SchedulerInfo.#ctor(System.Xml.Linq.XElement)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.schedulerinfo.schedulerinfo(v=VS.90)
ms:contentKeyID: 35521169
ms.date: 06/14/2012
mtps_version: v=VS.90
dev_langs:
- vb
- csharp
- cpp
- fsharp
- jscript
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.SchedulerInfo..ctor
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SchedulerInfo Constructor (XElement)

Initializes a new instance of the [SchedulerInfo](schedulerinfo-class-microsoft-web-media-transformmanager.md) class using the specified RDF scheduler node.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Sub New ( _
    hasScheduler As XElement _
)
'Usage

  Dim hasScheduler As XElement

Dim instance As New SchedulerInfo(hasScheduler)
```

```csharp
  public SchedulerInfo(
    XElement hasScheduler
)
```

```cpp
  public:
SchedulerInfo(
    XElement^ hasScheduler
)
```

``` fsharp
  new : 
        hasScheduler:XElement -> SchedulerInfo
```

```jscript
  public function SchedulerInfo(
    hasScheduler : XElement
)
```

### Parameters

  - hasScheduler  
    Type: [System.Xml.Linq.XElement](https://msdn.microsoft.com/library/bb340098)  
    An XML element that contains the scheduler node. The node is defined using the RDF specification.  

## Exceptions

|Exception|Condition|
|--- |--- |
|[ArgumentNullException](https://msdn.microsoft.com/library/27426hcy)|hasScheduler is null Nothing nullptr unit a null reference (Nothing in Visual Basic)|

## See Also

### Reference

[SchedulerInfo Class](schedulerinfo-class-microsoft-web-media-transformmanager.md)

[SchedulerInfo Overload](schedulerinfo-constructor-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
