---
title: ConfigurationMessage.HelpLinkId Property (Microsoft.Web.Media.TransformManager)
TOCTitle: HelpLinkId Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.ConfigurationMessage.HelpLinkId
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.configurationmessage.helplinkid(v=VS.90)
ms:contentKeyID: 35520580
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.ConfigurationMessage.HelpLinkId
- Microsoft.Web.Media.TransformManager.ConfigurationMessage.set_HelpLinkId
- Microsoft.Web.Media.TransformManager.ConfigurationMessage.get_HelpLinkId
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.ConfigurationMessage.get_HelpLinkId
- Microsoft.Web.Media.TransformManager.ConfigurationMessage.HelpLinkId
- Microsoft.Web.Media.TransformManager.ConfigurationMessage.set_HelpLinkId
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# HelpLinkId Property

Gets or sets a context-sensitive help link ID value.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property HelpLinkId As String
    Get
    Set
'Usage

  Dim instance As ConfigurationMessage
Dim value As String

value = instance.HelpLinkId

instance.HelpLinkId = value
```

```csharp
[DataMemberAttribute]
public string HelpLinkId { get; set; }
```

```cpp
[DataMemberAttribute]
public:
property String^ HelpLinkId {
    String^ get ();
    void set (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
member HelpLinkId : string with get, set
```

```jscript
  function get HelpLinkId () : String
function set HelpLinkId (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The context-sensitive help link ID value.  

## See Also

### Reference

[ConfigurationMessage Class](configurationmessage-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
