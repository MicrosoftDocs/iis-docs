---
title: ConfigurationMessage Constructor (String, String, String, String) (Microsoft.Web.Media.TransformManager)
TOCTitle: ConfigurationMessage Constructor (String, String, String, String)
ms:assetid: M:Microsoft.Web.Media.TransformManager.ConfigurationMessage.#ctor(System.String,System.String,System.String,System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.configurationmessage.configurationmessage(v=VS.90)
ms:contentKeyID: 35521075
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
- Microsoft.Web.Media.TransformManager.ConfigurationMessage..ctor
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ConfigurationMessage Constructor (String, String, String, String)

Initializes a new instance of the [ConfigurationMessage](configurationmessage-class-microsoft-web-media-transformmanager.md) class using the specified name, file name, message, and help link ID.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicSubNew ( _
    fileNameAsString, _
    nameAsString, _
    messageAsString, _
    helpLinkIdAsString _
)
'Usage
DimfileNameAsStringDimnameAsStringDimmessageAsStringDimhelpLinkIdAsStringDiminstanceAs NewConfigurationMessage(fileName, _
    name, message, helpLinkId)
```

``` csharp
publicConfigurationMessage(
    stringfileName,
    stringname,
    stringmessage,
    stringhelpLinkId
)
```

``` c++
public:
ConfigurationMessage(
    String^ fileName, 
    String^ name, 
    String^ message, 
    String^ helpLinkId
)
```

``` fsharp
new : 
        fileName:string * 
        name:string * 
        message:string * 
        helpLinkId:string->ConfigurationMessage
```

``` jscript
publicfunctionConfigurationMessage(
    fileName : String, 
    name : String, 
    message : String, 
    helpLinkId : String
)
```

#### Parameters

  - fileName  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The name of the configuration file.  

<!-- end list -->

  - name  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The name of the configuration object.  

<!-- end list -->

  - message  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The configuration message.  

<!-- end list -->

  - helpLinkId  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    A help link ID value.  

## See Also

#### Reference

[ConfigurationMessage Class](configurationmessage-class-microsoft-web-media-transformmanager.md)

[ConfigurationMessage Overload](configurationmessage-constructor-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

