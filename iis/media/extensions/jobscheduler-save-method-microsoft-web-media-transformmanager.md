---
title: JobScheduler.Save Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: Save Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.JobScheduler.Save(System.Boolean)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobscheduler.save(v=VS.90)
ms:contentKeyID: 35520667
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobScheduler.Save
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobScheduler.Save
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Save Method

Saves job scheduler details to a file as XML.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicSubSave ( _
    overwriteAsBoolean _
)
'Usage
DiminstanceAsJobSchedulerDimoverwriteAsBoolean

instance.Save(overwrite)
```

``` csharp
publicvoidSave(
    booloverwrite
)
```

``` c++
public:
voidSave(
    booloverwrite
)
```

``` fsharp
memberSave : 
        overwrite:bool->unit
```

``` jscript
publicfunctionSave(
    overwrite : boolean
)
```

#### Parameters

  - overwrite  
    Type: [System. . :: . .Boolean](https://msdn.microsoft.com/en-us/library/a28wyd50\(v=vs.90\))  
    true to overwrite any existing job template file that has the same name; otherwise, false.  

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
<td><a href="https://msdn.microsoft.com/en-us/library/2asft85a(v=vs.90)">InvalidOperationException</a></td>
<td><p>The file exists and the overwrite parameter is false.</p></td>
</tr>
</tbody>
</table>


## See Also

#### Reference

[JobScheduler Class](jobscheduler-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

