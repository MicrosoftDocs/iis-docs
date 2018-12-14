---
title: ConfigurationMessage.HelpLinkId Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: HelpLinkId Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.ConfigurationMessage.HelpLinkId
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.configurationmessage.helplinkid(v=VS.90)
ms:contentKeyID: 35520580
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.ConfigurationMessage.HelpLinkId
- Microsoft.Web.Media.TransformManager.ConfigurationMessage.set_HelpLinkId
- Microsoft.Web.Media.TransformManager.ConfigurationMessage.get_HelpLinkId
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.ConfigurationMessage.get_HelpLinkId
- Microsoft.Web.Media.TransformManager.ConfigurationMessage.HelpLinkId
- Microsoft.Web.Media.TransformManager.ConfigurationMessage.set_HelpLinkId
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# HelpLinkId Property

Gets or sets a context-sensitive help link ID value.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
<DataMemberAttribute> _
PublicPropertyHelpLinkIdAsStringGetSet
'Usage
DiminstanceAsConfigurationMessageDimvalueAsStringvalue = instance.HelpLinkId

instance.HelpLinkId = value
```

``` csharp
[DataMemberAttribute]
publicstringHelpLinkId { get; set; }
```

``` c++
[DataMemberAttribute]
public:
propertyString^ HelpLinkId {
    String^ get ();
    voidset (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
memberHelpLinkId : stringwithget, set
```

``` jscript
function getHelpLinkId () : Stringfunction setHelpLinkId (value : String)
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
The context-sensitive help link ID value.  

## See Also

#### Reference

[ConfigurationMessage Class](configurationmessage-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

