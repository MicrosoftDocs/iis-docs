---
title: JobScheduler.ConnectionString Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: ConnectionString Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobScheduler.ConnectionString
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobscheduler.connectionstring(v=VS.90)
ms:contentKeyID: 35520600
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobScheduler.ConnectionString
- Microsoft.Web.Media.TransformManager.JobScheduler.set_ConnectionString
- Microsoft.Web.Media.TransformManager.JobScheduler.get_ConnectionString
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobScheduler.ConnectionString
- Microsoft.Web.Media.TransformManager.JobScheduler.get_ConnectionString
- Microsoft.Web.Media.TransformManager.JobScheduler.set_ConnectionString
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ConnectionString Property

Gets or sets the connection string that is used by this scheduler.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
<DataMemberAttribute> _
PublicPropertyConnectionStringAsStringGetSet
'Usage
DiminstanceAsJobSchedulerDimvalueAsStringvalue = instance.ConnectionString

instance.ConnectionString = value
```

``` csharp
[DataMemberAttribute]
publicstringConnectionString { get; set; }
```

``` c++
[DataMemberAttribute]
public:
propertyString^ ConnectionString {
    String^ get ();
    voidset (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
memberConnectionString : stringwithget, set
```

``` jscript
function getConnectionString () : Stringfunction setConnectionString (value : String)
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
The connection string that is used by this scheduler.  

## See Also

#### Reference

[JobScheduler Class](jobscheduler-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

