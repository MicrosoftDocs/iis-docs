---
title: ConfigurationMessage Constructor (String, String, String, String, ConfigurationMessageSeverity) (Microsoft.Web.Media.TransformManager)
TOCTitle: ConfigurationMessage Constructor (String, String, String, String, ConfigurationMessageSeverity)
ms:assetid: M:Microsoft.Web.Media.TransformManager.ConfigurationMessage.#ctor(System.String,System.String,System.String,System.String,Microsoft.Web.Media.TransformManager.ConfigurationMessageSeverity)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.configurationmessage.configurationmessage(v=VS.90)
ms:contentKeyID: 35521143
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
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# ConfigurationMessage Constructor (String, String, String, String, ConfigurationMessageSeverity)

Initializes a new instance of the [ConfigurationMessage](configurationmessage-class-microsoft-web-media-transformmanager.md) class using the specified name, file name, message, help link ID, and severity.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Sub New ( _
    fileName As String, _
    name As String, _
    message As String, _
    helpLinkId As String, _
    severity As ConfigurationMessageSeverity _
)
'Usage

  Dim fileName As String
Dim name As String
Dim message As String
Dim helpLinkId As String
Dim severity As ConfigurationMessageSeverity

Dim instance As New ConfigurationMessage(fileName, _
    name, message, helpLinkId, severity)
```

```csharp
  public ConfigurationMessage(
    string fileName,
    string name,
    string message,
    string helpLinkId,
    ConfigurationMessageSeverity severity
)
```

```cpp
  public:
ConfigurationMessage(
    String^ fileName, 
    String^ name, 
    String^ message, 
    String^ helpLinkId, 
    ConfigurationMessageSeverity severity
)
```

``` fsharp
  new : 
        fileName:string * 
        name:string * 
        message:string * 
        helpLinkId:string * 
        severity:ConfigurationMessageSeverity -> ConfigurationMessage
```

```jscript
  public function ConfigurationMessage(
    fileName : String, 
    name : String, 
    message : String, 
    helpLinkId : String, 
    severity : ConfigurationMessageSeverity
)
```

### Parameters

  - fileName  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The name of the configuration file.  

<!-- end list -->

  - name  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The name of the configuration object.  

<!-- end list -->

  - message  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The configuration message.  

<!-- end list -->

  - helpLinkId  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    A help link ID value.  

<!-- end list -->

  - severity  
    Type: [Microsoft.Web.Media.TransformManager.ConfigurationMessageSeverity](configurationmessageseverity-enumeration-microsoft-web-media-transformmanager.md)  
    The error severity.  

## See Also

### Reference

[ConfigurationMessage Class](configurationmessage-class-microsoft-web-media-transformmanager.md)

[ConfigurationMessage Overload](configurationmessage-constructor-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

