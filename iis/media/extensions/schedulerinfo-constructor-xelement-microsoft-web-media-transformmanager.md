---
title: SchedulerInfo Constructor (XElement) (Microsoft.Web.Media.TransformManager)
TOCTitle: SchedulerInfo Constructor (XElement)
ms:assetid: M:Microsoft.Web.Media.TransformManager.SchedulerInfo.#ctor(System.Xml.Linq.XElement)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.schedulerinfo.schedulerinfo(v=VS.90)
ms:contentKeyID: 35521169
ms.date: 06/14/2012
mtps_version: v=VS.90
dev_langs:
- vb
- csharp
- c++
- fsharp
- jscript
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.SchedulerInfo..ctor
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SchedulerInfo Constructor (XElement)

Initializes a new instance of the [SchedulerInfo](schedulerinfo-class-microsoft-web-media-transformmanager.md) class using the specified RDF scheduler node.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicSubNew ( _
    hasSchedulerAsXElement _
)
'Usage
DimhasSchedulerAsXElementDiminstanceAs NewSchedulerInfo(hasScheduler)
```

``` csharp
publicSchedulerInfo(
    XElementhasScheduler
)
```

``` c++
public:
SchedulerInfo(
    XElement^ hasScheduler
)
```

``` fsharp
new : 
        hasScheduler:XElement->SchedulerInfo
```

``` jscript
publicfunctionSchedulerInfo(
    hasScheduler : XElement
)
```

#### Parameters

  - hasScheduler  
    Type: [System.Xml.Linq. . :: . .XElement](https://msdn.microsoft.com/en-us/library/bb340098\(v=vs.90\))  
    An XML element that contains the scheduler node. The node is defined using the RDF specification.  

## Exceptions

<table>
<colgroup>
<col style="width: 50%" />
<col style="width: 50%" />
</colgroup>
<thead>
<tr class="header">
<th>Exception</th>
<th>Condition</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><a href="https://msdn.microsoft.com/en-us/library/27426hcy(v=vs.90)">ArgumentNullException</a></td>
<td><p>hasScheduler is null Nothing nullptr unit a null reference (Nothing in Visual Basic)</p></td>
</tr>
</tbody>
</table>


## See Also

#### Reference

[SchedulerInfo Class](schedulerinfo-class-microsoft-web-media-transformmanager.md)

[SchedulerInfo Overload](schedulerinfo-constructor-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

