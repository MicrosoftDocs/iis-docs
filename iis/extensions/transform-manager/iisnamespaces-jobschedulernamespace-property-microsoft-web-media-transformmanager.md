---
title: IisNamespaces.JobSchedulerNamespace Property (Microsoft.Web.Media.TransformManager)
TOCTitle: JobSchedulerNamespace Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.IisNamespaces.JobSchedulerNamespace
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.iisnamespaces.jobschedulernamespace(v=VS.90)
ms:contentKeyID: 35520815
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IisNamespaces.get_JobSchedulerNamespace
- Microsoft.Web.Media.TransformManager.IisNamespaces.JobSchedulerNamespace
dev_langs:
- "csharp"
- "jscript"
- "vb"
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.TransformManager.Sdk.dll
api_name:
- Microsoft.Web.Media.TransformManager.IisNamespaces.get_JobSchedulerNamespace
- Microsoft.Web.Media.TransformManager.IisNamespaces.JobSchedulerNamespace
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# JobSchedulerNamespace Property

Gets the URI of a media services schema document that is related to job schedulers.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Sdk (in Microsoft.Web.Media.TransformManager.Sdk.dll)

## Syntax

```vb
'Declaration

  Public Shared ReadOnly Property JobSchedulerNamespace As XNamespace
    Get
'Usage

  Dim value As XNamespace

value = IisNamespaces.JobSchedulerNamespace
```

```csharp
  public static XNamespace JobSchedulerNamespace { get; }
```

```cpp
  public:
static property XNamespace^ JobSchedulerNamespace {
    XNamespace^ get ();
}
```

``` fsharp
  static member JobSchedulerNamespace : XNamespace
```

```jscript
  static function get JobSchedulerNamespace () : XNamespace
```

### Property Value

Type: [System.Xml.Linq.XNamespace](https://msdn.microsoft.com/library/bb291898)  
The XML namespace value "http://schemas.microsoft.com/iis/media/v4/TM/JobScheduler\#".  

## See Also

### Reference

[IisNamespaces Class](iisnamespaces-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

