---
title: ConfigurationMessage Class (Microsoft.Web.Media.TransformManager)
TOCTitle: ConfigurationMessage Class
ms:assetid: T:Microsoft.Web.Media.TransformManager.ConfigurationMessage
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.configurationmessage(v=VS.90)
ms:contentKeyID: 35520555
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.ConfigurationMessage
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.ConfigurationMessage
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# ConfigurationMessage Class

Represents messages that are initialized during IIS Transform Manager service initialization.

## Inheritance Hierarchy

[System.Object](https://msdn.microsoft.com/library/e5kfa45b)  
  Microsoft.Web.Media.TransformManager..::..ConfigurationMessage  

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataContractAttribute> _
Public Class ConfigurationMessage
'Usage

  Dim instance As ConfigurationMessage
```

```csharp
[DataContractAttribute]
public class ConfigurationMessage
```

```cpp
[DataContractAttribute]
public ref class ConfigurationMessage
```

``` fsharp
[<DataContractAttribute>]
type ConfigurationMessage =  class end
```

```jscript
  public class ConfigurationMessage
```

The ConfigurationMessage type exposes the following members.

## Constructors

||Name|Description|
|--- |--- |--- |
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[ConfigurationMessage(String)](configurationmessage-constructor-string-microsoft-web-media-transformmanager.md)|Initializes a new instance of the ConfigurationMessage class using the specified message.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[ConfigurationMessage(XElement, ConfigurationBase)](configurationmessage-constructor-xelement-configurationbase-microsoft-web-media-transformmanager.md)|Initializes a new instance of the ConfigurationMessage class using the specified message element and configuration object.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[ConfigurationMessage(String, String, String, String)](configurationmessage-constructor-string-string-string-string-microsoft-web-media-transformmanager.md)|Initializes a new instance of the ConfigurationMessage class using the specified name, file name, message, and help link ID.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[ConfigurationMessage(String, String, String, String, ConfigurationMessageSeverity)](configurationmessage-constructor-string-string-string-string-configurationmessageseverity-microsoft-web-media-transformmanager.md)|Initializes a new instance of the ConfigurationMessage class using the specified name, file name, message, help link ID, and severity.|

## Properties

||Name|Description|
|--- |--- |--- |
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[FileName](configurationmessage-filename-property-microsoft-web-media-transformmanager.md)|Gets or sets the name of the configuration file.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[HelpLinkId](configurationmessage-helplinkid-property-microsoft-web-media-transformmanager.md)|Gets or sets a context-sensitive help link ID value.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[Message](configurationmessage-message-property-microsoft-web-media-transformmanager.md)|Gets or sets a configuration message.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[Name](configurationmessage-name-property-microsoft-web-media-transformmanager.md)|Gets or sets the name of the configuration object.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[ObjectId](configurationmessage-objectid-property-microsoft-web-media-transformmanager.md)|Gets or sets the ID of configuration object.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[ObjectType](configurationmessage-objecttype-property-microsoft-web-media-transformmanager.md)|Gets or set the type of the configuration object.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[RegKeyFound](configurationmessage-regkeyfound-property-microsoft-web-media-transformmanager.md)|Gets or sets a message to post when the registration key value is found.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[RegKeyNotFound](configurationmessage-regkeynotfound-property-microsoft-web-media-transformmanager.md)|Gets or sets a message to post when the registration key is not found.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[Severity](configurationmessage-severity-property-microsoft-web-media-transformmanager.md)|Gets or set the error severity.|

## Methods

||Name|Description|
|--- |--- |--- |
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[Equals](https://msdn.microsoft.com/library/bsc2ak47)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Protected method](images/Hh125771.protmethod(en-us,VS.90).gif "Protected method")|[Finalize](https://msdn.microsoft.com/library/4k87zsw7)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetHashCode](https://msdn.microsoft.com/library/zdee4b3y)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetType](https://msdn.microsoft.com/library/dfwy45w9)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Protected method](images/Hh125771.protmethod(en-us,VS.90).gif "Protected method")|[MemberwiseClone](https://msdn.microsoft.com/library/57ctke0a)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[ToString](https://msdn.microsoft.com/library/7bxwbwt2)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

### Reference

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
