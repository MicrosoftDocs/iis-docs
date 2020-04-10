---
title: ConfigurationMessage Constructor (XElement, ConfigurationBase) (Microsoft.Web.Media.TransformManager)
TOCTitle: ConfigurationMessage Constructor (XElement, ConfigurationBase)
ms:assetid: M:Microsoft.Web.Media.TransformManager.ConfigurationMessage.#ctor(System.Xml.Linq.XElement,Microsoft.Web.Media.TransformManager.ConfigurationBase)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.configurationmessage.configurationmessage(v=VS.90)
ms:contentKeyID: 35520604
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
- Microsoft.Web.Media.TransformManager.ConfigurationMessage..ctor
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# ConfigurationMessage Constructor (XElement, ConfigurationBase)

Initializes a new instance of the [ConfigurationMessage](configurationmessage-class-microsoft-web-media-transformmanager.md) class using the specified message element and configuration object.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Sub New ( _
    messageElement As XElement, _
    configurationObject As ConfigurationBase _
)
'Usage

  Dim messageElement As XElement
Dim configurationObject As ConfigurationBase

Dim instance As New ConfigurationMessage(messageElement, _
    configurationObject)
```

```csharp
  public ConfigurationMessage(
    XElement messageElement,
    ConfigurationBase configurationObject
)
```

```cpp
  public:
ConfigurationMessage(
    XElement^ messageElement, 
    ConfigurationBase^ configurationObject
)
```

``` fsharp
  new : 
        messageElement:XElement * 
        configurationObject:ConfigurationBase -> ConfigurationMessage
```

```jscript
  public function ConfigurationMessage(
    messageElement : XElement, 
    configurationObject : ConfigurationBase
)
```

### Parameters

  - messageElement  
    Type: [System.Xml.Linq.XElement](https://msdn.microsoft.com/library/bb340098)  
    The XML element that contains the message.  

<!-- end list -->

  - configurationObject  
    Type: [Microsoft.Web.Media.TransformManager.ConfigurationBase](configurationbase-class-microsoft-web-media-transformmanager.md)  
    An object that represents IIS Transform Manager configuration information.  

## See Also

### Reference

[ConfigurationMessage Class](configurationmessage-class-microsoft-web-media-transformmanager.md)

[ConfigurationMessage Overload](configurationmessage-constructor-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
