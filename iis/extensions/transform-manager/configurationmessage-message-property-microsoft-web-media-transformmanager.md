---
title: ConfigurationMessage.Message Property (Microsoft.Web.Media.TransformManager)
TOCTitle: Message Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.ConfigurationMessage.Message
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.configurationmessage.message(v=VS.90)
ms:contentKeyID: 35520715
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.ConfigurationMessage.Message
- Microsoft.Web.Media.TransformManager.ConfigurationMessage.set_Message
- Microsoft.Web.Media.TransformManager.ConfigurationMessage.get_Message
dev_langs:
- "csharp"
- "jscript"
- "vb"
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.ConfigurationMessage.get_Message
- Microsoft.Web.Media.TransformManager.ConfigurationMessage.Message
- Microsoft.Web.Media.TransformManager.ConfigurationMessage.set_Message
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# Message Property

Gets or sets a configuration message.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property Message As String
    Get
    Set
'Usage

  Dim instance As ConfigurationMessage
Dim value As String

value = instance.Message

instance.Message = value
```

```csharp
[DataMemberAttribute]
public string Message { get; set; }
```

```cpp
[DataMemberAttribute]
public:
property String^ Message {
    String^ get ();
    void set (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
member Message : string with get, set
```

```jscript
  function get Message () : String
function set Message (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The configuration message.  

## See Also

### Reference

[ConfigurationMessage Class](configurationmessage-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

