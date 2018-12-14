---
title: SchedulerProvider.FindJobSchedulerInfo Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: FindJobSchedulerInfo Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.SchedulerProvider.FindJobSchedulerInfo(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.schedulerprovider.findjobschedulerinfo(v=VS.90)
ms:contentKeyID: 35520671
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.SchedulerProvider.FindJobSchedulerInfo
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.SchedulerProvider.FindJobSchedulerInfo
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# FindJobSchedulerInfo Method

Finds a [SchedulerInfo](schedulerinfo-class-microsoft-web-media-transformmanager.md) object based on the specified scheduler ID.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicSharedFunctionFindJobSchedulerInfo ( _
    idAsString _
) AsSchedulerInfo
'Usage
DimidAsStringDimreturnValueAsSchedulerInforeturnValue = SchedulerProvider.FindJobSchedulerInfo(id)
```

``` csharp
publicstaticSchedulerInfoFindJobSchedulerInfo(
    stringid
)
```

``` c++
public:
staticSchedulerInfo^ FindJobSchedulerInfo(
    String^ id
)
```

``` fsharp
staticmemberFindJobSchedulerInfo : 
        id:string->SchedulerInfo
```

``` jscript
publicstaticfunctionFindJobSchedulerInfo(
    id : String
) : SchedulerInfo
```

#### Parameters

  - id  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    A scheduler ID value.  

#### Return Value

Type: [Microsoft.Web.Media.TransformManager. . :: . .SchedulerInfo](schedulerinfo-class-microsoft-web-media-transformmanager.md)  
A [SchedulerInfo](schedulerinfo-class-microsoft-web-media-transformmanager.md) object that matches the provided scheduler ID value.  

## See Also

#### Reference

[SchedulerProvider Class](schedulerprovider-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

