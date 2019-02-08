---
title: ManifestProperty Class (Microsoft.Web.Media.TransformManager)
TOCTitle: ManifestProperty Class
ms:assetid: T:Microsoft.Web.Media.TransformManager.ManifestProperty
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.manifestproperty(v=VS.90)
ms:contentKeyID: 31477621
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.ManifestProperty
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Sdk.dll
api_name:
- Microsoft.Web.Media.TransformManager.ManifestProperty
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ManifestProperty Class

Defines the manifest properties that contain task-specific metadata for task definitions, in job templates, and in tasks.

## Inheritance Hierarchy

[System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  
  Microsoft.Web.Media.TransformManager..::..ManifestProperty  

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Sdk (in Microsoft.Web.Media.TransformManager.Sdk.dll)

## Syntax

``` vb
'Declaration
<DataContractAttribute> _
Public Class ManifestProperty _
    Implements IManifestProperty
'Usage

  Dim instance As ManifestProperty
```

``` csharp
[DataContractAttribute]
public class ManifestProperty : IManifestProperty
```

``` c++
[DataContractAttribute]
public ref class ManifestProperty : IManifestProperty
```

``` fsharp
[<DataContractAttribute>]
type ManifestProperty =  
    class
        interface IManifestProperty
    end
```

``` jscript
  public class ManifestProperty implements IManifestProperty
```

The ManifestProperty type exposes the following members.

## Constructors

||Name|Description|
|--- |--- |--- |
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[ManifestProperty() () () ()](manifestproperty-constructor-microsoft-web-media-transformmanager_1.md)|Initializes a new instance of the ManifestProperty class.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[ManifestProperty(String, XElement)](manifestproperty-constructor-string-xelement-microsoft-web-media-transformmanager.md)|Initializes a new instance of the ManifestProperty class using the specified namespace and XML metadata element.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[ManifestProperty(XName, String)](manifestproperty-constructor-xname-string-microsoft-web-media-transformmanager.md)|Initializes a new instance of the ManifestProperty class using the specified name and value.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[ManifestProperty(XName, XElement)](manifestproperty-constructor-xname-xelement-microsoft-web-media-transformmanager.md)|Initializes a new instance of the ManifestProperty class using the specified name and value.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[ManifestProperty(XName, String, Boolean)](manifestproperty-constructor-xname-string-boolean-microsoft-web-media-transformmanager.md)|Initializes a new instance of the ManifestProperty class using the specified name and value, and whether the property is required.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[ManifestProperty(String, String, String, Boolean)](manifestproperty-constructor-string-string-string-boolean-microsoft-web-media-transformmanager.md)|Initializes a new instance of the ManifestProperty class using the specified namespace, name, and value, and whether the property is required.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[ManifestProperty(XName, String, Boolean, CultureInfo)](manifestproperty-constructor-xname-string-boolean-cultureinfo-microsoft-web-media-transformmanager.md)|Initializes a new instance of the ManifestProperty class using the specified name, value, culture, and whether the property is required.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[ManifestProperty(String, String, String, Boolean, CultureInfo)](manifestproperty-constructor-string-string-string-boolean-cultureinfo-microsoft-web-media-transformmanager.md)|Initializes a new instance of the ManifestProperty class using the specified namespace, name, value, and culture, and whether the property is required.|

Top

## Properties

||Name|Description|
|--- |--- |--- |
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[CultureInfo](manifestproperty-cultureinfo-property-microsoft-web-media-transformmanager.md)|Gets or sets the culture information for the manifest property.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[CultureInfoMoniker](manifestproperty-cultureinfomoniker-property-microsoft-web-media-transformmanager.md)|Gets or sets a value that represents the culture language.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[HelpText](manifestproperty-helptext-property-microsoft-web-media-transformmanager.md)|Gets or sets the help text that is associated with the manifest property.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[LocalName](manifestproperty-localname-property-microsoft-web-media-transformmanager.md)|Gets or sets the LocalName element of the manifest property.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[Name](manifestproperty-name-property-microsoft-web-media-transformmanager.md)|Gets or sets the Name element of the manifest property.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[Required](manifestproperty-required-property-microsoft-web-media-transformmanager.md)|Get or sets a value that specifies whether the manifest property is required.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[Value](manifestproperty-value-property-microsoft-web-media-transformmanager.md)|Gets or sets the manifest property value.|

Top

## Methods

||Name|Description|
|--- |--- |--- |
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[CreatePropertyElement](manifestproperty-createpropertyelement-method-microsoft-web-media-transformmanager.md)|Creates a manifest property element.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[Equals](https://msdn.microsoft.com/en-us/library/bsc2ak47(v=vs.90))|(Inherited from [Object](https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)).)|
|![Protected method](images/Hh125771.protmethod(en-us,VS.90).gif "Protected method")|[Finalize](https://msdn.microsoft.com/en-us/library/4k87zsw7(v=vs.90))|(Inherited from [Object](https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetHashCode](https://msdn.microsoft.com/en-us/library/zdee4b3y(v=vs.90))|(Inherited from [Object](https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetType](https://msdn.microsoft.com/en-us/library/dfwy45w9(v=vs.90))|(Inherited from [Object](https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)).)|
|![Protected method](images/Hh125771.protmethod(en-us,VS.90).gif "Protected method")|[MemberwiseClone](https://msdn.microsoft.com/en-us/library/57ctke0a(v=vs.90))|(Inherited from [Object](https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[ToString](https://msdn.microsoft.com/en-us/library/7bxwbwt2(v=vs.90))|(Inherited from [Object](https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)).)|

Top

## Fields

||Name|Description|
|--- |--- |--- |
|![Public field](images/Hh125771.pubfield(en-us,VS.90).gif "Public field")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[PropertyElementName](manifestproperty-propertyelementname-field-microsoft-web-media-transformmanager.md)|The string "property".|


Top

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

#### Reference

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

