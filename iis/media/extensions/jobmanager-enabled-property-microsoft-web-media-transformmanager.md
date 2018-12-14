---
title: JobManager.Enabled Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: Enabled Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobManager.Enabled
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobmanager.enabled(v=VS.90)
ms:contentKeyID: 35520591
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobManager.get_Enabled
- Microsoft.Web.Media.TransformManager.JobManager.set_Enabled
- Microsoft.Web.Media.TransformManager.JobManager.Enabled
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobManager.Enabled
- Microsoft.Web.Media.TransformManager.JobManager.get_Enabled
- Microsoft.Web.Media.TransformManager.JobManager.set_Enabled
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Enabled Property

Gets a value that indicates whether the job manager that is associated with this job definition can be started.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

``` vb
'Declaration
PublicPropertyEnabledAsBooleanGetPrivateSet
'Usage
DiminstanceAsJobManagerDimvalueAsBooleanvalue = instance.Enabled
```

``` csharp
publicboolEnabled { get; privateset; }
```

``` c++
public:
propertyboolEnabled {
    boolget ();
    private: voidset (boolvalue);
}
```

``` fsharp
memberEnabled : boolwithget, privateset
```

``` jscript
function getEnabled () : booleanprivatefunction setEnabled (value : boolean)
```

#### Property Value

Type: [System. . :: . .Boolean](https://msdn.microsoft.com/en-us/library/a28wyd50\(v=vs.90\))  
A value that indicates whether the job manager that is associated with this job definition can be started.  

## See Also

#### Reference

[JobManager Class](jobmanager-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

