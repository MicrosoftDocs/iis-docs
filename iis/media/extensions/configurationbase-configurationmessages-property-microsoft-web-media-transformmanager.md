---
title: ConfigurationBase.ConfigurationMessages Property  (Microsoft.Web.Media.TransformManager)
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
- CSharp
- JScript
- VB
- FSharp
- c++
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

``` vb
'Declaration
<DataMemberAttribute> _
PublicPropertyConfigurationMessagesAsCollection(OfConfigurationMessage)
    GetSet
'Usage
DiminstanceAsConfigurationBaseDimvalueAsCollection(OfConfigurationMessage)

value = instance.ConfigurationMessages

instance.ConfigurationMessages = value
```

``` csharp
[DataMemberAttribute]
publicCollection<ConfigurationMessage> ConfigurationMessages { get; set; }
```

``` c++
[DataMemberAttribute]
public:
propertyCollection<ConfigurationMessage^>^ ConfigurationMessages {
    Collection<ConfigurationMessage^>^ get ();
    voidset (Collection<ConfigurationMessage^>^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
memberConfigurationMessages : Collection<ConfigurationMessage> withget, set
```

``` jscript
function getConfigurationMessages () : Collection<ConfigurationMessage>
function setConfigurationMessages (value : Collection<ConfigurationMessage>)
```

#### Property Value

Type: [System.Collections.ObjectModel. . :: . .Collection](https://msdn.microsoft.com/en-us/library/ms132397\(v=vs.90\))\< (Of \< ( \<'[ConfigurationMessage](configurationmessage-class-microsoft-web-media-transformmanager.md)\> ) \> ) \>  
A list of configuration messages.  

## See Also

#### Reference

[ConfigurationBase Class](configurationbase-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

