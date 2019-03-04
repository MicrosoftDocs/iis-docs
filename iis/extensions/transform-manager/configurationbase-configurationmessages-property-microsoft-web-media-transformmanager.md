---
title: ConfigurationBase.ConfigurationMessages Property (Microsoft.Web.Media.TransformManager)
TOCTitle: ConfigurationMessages Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.ConfigurationBase.ConfigurationMessages
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.configurationbase.configurationmessages(v=VS.90)
ms:contentKeyID: 35521174
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.ConfigurationBase.get_ConfigurationMessages
- Microsoft.Web.Media.TransformManager.ConfigurationBase.set_ConfigurationMessages
- Microsoft.Web.Media.TransformManager.ConfigurationBase.ConfigurationMessages
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.ConfigurationBase.ConfigurationMessages
- Microsoft.Web.Media.TransformManager.ConfigurationBase.get_ConfigurationMessages
- Microsoft.Web.Media.TransformManager.ConfigurationBase.set_ConfigurationMessages
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ConfigurationMessages Property

Gets or sets a list of IIS Transform Manager configuration messages.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property ConfigurationMessages As Collection(Of ConfigurationMessage)
    Get
    Set
'Usage

  Dim instance As ConfigurationBase
Dim value As Collection(Of ConfigurationMessage)

value = instance.ConfigurationMessages

instance.ConfigurationMessages = value
```

```csharp
[DataMemberAttribute]
public Collection<ConfigurationMessage> ConfigurationMessages { get; set; }
```

```cpp
[DataMemberAttribute]
public:
property Collection<ConfigurationMessage^>^ ConfigurationMessages {
    Collection<ConfigurationMessage^>^ get ();
    void set (Collection<ConfigurationMessage^>^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
member ConfigurationMessages : Collection<ConfigurationMessage> with get, set
```

```jscript
  function get ConfigurationMessages () : Collection<ConfigurationMessage>
function set ConfigurationMessages (value : Collection<ConfigurationMessage>)
```

### Property Value

Type: [System.Collections.ObjectModel.Collection](https://msdn.microsoft.com/library/ms132397)\< (Of \< ( \<'[ConfigurationMessage](configurationmessage-class-microsoft-web-media-transformmanager.md)\> ) \> ) \>  
A list of configuration messages.  

## See Also

### Reference

[ConfigurationBase Class](configurationbase-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

