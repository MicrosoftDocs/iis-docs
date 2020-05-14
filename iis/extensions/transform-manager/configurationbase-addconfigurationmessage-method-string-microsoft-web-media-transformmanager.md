---
title: ConfigurationBase.AddConfigurationMessage Method (String) (Microsoft.Web.Media.TransformManager)
TOCTitle: AddConfigurationMessage Method (String)
ms:assetid: M:Microsoft.Web.Media.TransformManager.ConfigurationBase.AddConfigurationMessage(System.String)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.configurationbase.addconfigurationmessage(v=VS.90)
ms:contentKeyID: 35521017
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
- Microsoft.Web.Media.TransformManager.ConfigurationBase.AddConfigurationMessage
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# AddConfigurationMessage Method (String)

Adds the specified message to the IIS Transform Manager configuration.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Sub AddConfigurationMessage ( _
    message As String _
)
'Usage

  Dim instance As ConfigurationBase
Dim message As String

instance.AddConfigurationMessage(message)
```

```csharp
  public void AddConfigurationMessage(
    string message
)
```

```cpp
  public:
void AddConfigurationMessage(
    String^ message
)
```

``` fsharp
  member AddConfigurationMessage :
        message:string -> unit
```

```jscript
  public function AddConfigurationMessage(
    message : String
)
```

### Parameters

  - message  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The message to add.  

## See Also

### Reference

[ConfigurationBase Class](configurationbase-class-microsoft-web-media-transformmanager.md)

[AddConfigurationMessage Overload](configurationbase-addconfigurationmessage-method-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
