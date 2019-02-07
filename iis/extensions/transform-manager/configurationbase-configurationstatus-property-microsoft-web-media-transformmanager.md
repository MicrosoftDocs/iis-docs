---
title: ConfigurationBase.ConfigurationStatus Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: ConfigurationStatus Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.ConfigurationBase.ConfigurationStatus
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.configurationbase.configurationstatus(v=VS.90)
ms:contentKeyID: 35521039
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.ConfigurationBase.get_ConfigurationStatus
- Microsoft.Web.Media.TransformManager.ConfigurationBase.set_ConfigurationStatus
- Microsoft.Web.Media.TransformManager.ConfigurationBase.ConfigurationStatus
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.ConfigurationBase.ConfigurationStatus
- Microsoft.Web.Media.TransformManager.ConfigurationBase.get_ConfigurationStatus
- Microsoft.Web.Media.TransformManager.ConfigurationBase.set_ConfigurationStatus
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ConfigurationStatus Property

Gets or sets the IIS Transform Manager configuration status.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
<DataMemberAttribute> _
Public Property ConfigurationStatus As ConfigurationMessageSeverity
    Get
    Set
'Usage

  Dim instance As ConfigurationBase
Dim value As ConfigurationMessageSeverity

value = instance.ConfigurationStatus

instance.ConfigurationStatus = value
```

``` csharp
[DataMemberAttribute]
public ConfigurationMessageSeverity ConfigurationStatus { get; set; }
```

``` c++
[DataMemberAttribute]
public:
property ConfigurationMessageSeverity ConfigurationStatus {
    ConfigurationMessageSeverity get ();
    void set (ConfigurationMessageSeverity value);
}
```

``` fsharp
[<DataMemberAttribute>]
member ConfigurationStatus : ConfigurationMessageSeverity with get, set
```

``` jscript
  function get ConfigurationStatus () : ConfigurationMessageSeverity
function set ConfigurationStatus (value : ConfigurationMessageSeverity)
```

#### Property Value

Type: [Microsoft.Web.Media.TransformManager. . :: . .ConfigurationMessageSeverity](configurationmessageseverity-enumeration-microsoft-web-media-transformmanager.md)  
A value that specifies the severity of a configuration message.  

## See Also

#### Reference

[ConfigurationBase Class](configurationbase-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

