---
title: ConfigurationBase.AddConfigurationMessage Method (String, ConfigurationMessageSeverity) (Microsoft.Web.Media.TransformManager)
TOCTitle: AddConfigurationMessage Method (String, ConfigurationMessageSeverity)
ms:assetid: M:Microsoft.Web.Media.TransformManager.ConfigurationBase.AddConfigurationMessage(System.String,Microsoft.Web.Media.TransformManager.ConfigurationMessageSeverity)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.configurationbase.addconfigurationmessage(v=VS.90)
ms:contentKeyID: 35520673
ms.date: 06/14/2012
mtps_version: v=VS.90
dev_langs:
- vb
- csharp
- c++
- fsharp
- jscript
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.ConfigurationBase.AddConfigurationMessage
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# AddConfigurationMessage Method (String, ConfigurationMessageSeverity)

Adds the specified message to the IIS Transform Manager configuration using the specified severity value.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration

  Public Sub AddConfigurationMessage ( _
    message As String, _
    severity As ConfigurationMessageSeverity _
)
'Usage

  Dim instance As ConfigurationBase
Dim message As String
Dim severity As ConfigurationMessageSeverity

instance.AddConfigurationMessage(message, _
    severity)
```

``` csharp
  public void AddConfigurationMessage(
    string message,
    ConfigurationMessageSeverity severity
)
```

``` c++
  public:
void AddConfigurationMessage(
    String^ message, 
    ConfigurationMessageSeverity severity
)
```

``` fsharp
  member AddConfigurationMessage : 
        message:string * 
        severity:ConfigurationMessageSeverity -> unit 
```

``` jscript
  public function AddConfigurationMessage(
    message : String, 
    severity : ConfigurationMessageSeverity
)
```

#### Parameters

  - message  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The message to add.  

<!-- end list -->

  - severity  
    Type: [Microsoft.Web.Media.TransformManager. . :: . .ConfigurationMessageSeverity](configurationmessageseverity-enumeration-microsoft-web-media-transformmanager.md)  
    A configuration message severity value.  

## See Also

#### Reference

[ConfigurationBase Class](configurationbase-class-microsoft-web-media-transformmanager.md)

[AddConfigurationMessage Overload](configurationbase-addconfigurationmessage-method-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

