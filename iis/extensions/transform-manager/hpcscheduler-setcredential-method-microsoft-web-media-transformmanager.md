---
title: HpcScheduler.SetCredential Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: SetCredential Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.HpcScheduler.SetCredential(Microsoft.Web.Media.TransformManager.Credential)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.hpcscheduler.setcredential(v=VS.90)
ms:contentKeyID: 35520628
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.HpcScheduler.SetCredential
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.HpcScheduler.SetCredential
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SetCredential Method

Sets the [Credential](credential-class-microsoft-web-media-transformmanager.md) object that is required in order to access HPC scheduler resources.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Sub SetCredential ( _
    credential As Credential _
)
'Usage

  Dim instance As HpcScheduler
Dim credential As Credential

instance.SetCredential(credential)
```

```csharp
  public void SetCredential(
    Credential credential
)
```

```cpp
  public:
void SetCredential(
    Credential^ credential
)
```

``` fsharp
  member SetCredential : 
        credential:Credential -> unit 
```

```jscript
  public function SetCredential(
    credential : Credential
)
```

### Parameters

  - credential  
    Type: [Microsoft.Web.Media.TransformManager.Credential](credential-class-microsoft-web-media-transformmanager.md)  
    The [Credential](credential-class-microsoft-web-media-transformmanager.md) object that is required in order to access scheduler resources.  

## See Also

### Reference

[HpcScheduler Class](hpcscheduler-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

