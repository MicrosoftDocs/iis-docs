---
title: IManifestProperty.Name Property (Microsoft.Web.Media.TransformManager)
TOCTitle: Name Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.IManifestProperty.Name
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.imanifestproperty.name(v=VS.90)
ms:contentKeyID: 31477590
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IManifestProperty.get_Name
- Microsoft.Web.Media.TransformManager.IManifestProperty.Name
dev_langs:
- "csharp"
- "jscript"
- "vb"
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.TransformManager.Sdk.dll
api_name:
- Microsoft.Web.Media.TransformManager.IManifestProperty.get_Name
- Microsoft.Web.Media.TransformManager.IManifestProperty.Name
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# Name Property

Gets the name of the manifest property.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Sdk (in Microsoft.Web.Media.TransformManager.Sdk.dll)

## Syntax

```vb
'Declaration

  ReadOnly Property Name As XName
    Get
'Usage

  Dim instance As IManifestProperty
Dim value As XName

value = instance.Name
```

```csharp
  XName Name { get; }
```

```cpp
  property XName^ Name {
    XName^ get ();
}
```

``` fsharp
  abstract Name : XName
```

```jscript
  function get Name () : XName
```

### Property Value

Type: [System.Xml.Linq.XName](https://msdn.microsoft.com/library/bb347810)  
The name of the XML manifest element.  

## Remarks

The properties are stored as elements in the manifest XML. For example, a manifest for an Expression Encoder job might override the presets file using the following manifest section:

    <rdf:RDF xmlns:iisms="http://schemas.microsoft.com/iis/media/v4/Metroplex#" xmlns:owl="http://www.w3.org/2002/07/owl#" xmlns:rdf="http://www.w3.org/1999/02/22-rdf-syntax-ns#" xmlns:rdfs="http://www.w3.org/2000/01/rdf-schema#" xmlns:ee="http://schemas.microsoft.com/Expression/Encoder/V4#">
      <iisms:Task xmlns:ee="http://schemas.microsoft.com/Expression/Encoder/V4#">
        <iisms:Id>A72D7A5D-3022-45f2-89B4-1DDC5457CC12</iisms:Id>
        <ee:Preset>%ProgramData%\Microsoft\IIS\Transformation Manager\Presets\VC1Profile.xml</ee:Preset>
      </iisms:Task>
    </rdf:RDF>

When an application calls [IJobMetadata..::..GetProperty(XName)](ijobmetadata-getproperty-method-microsoft-web-media-transformmanager.md) with the XName parameter set to ee:Preset, it is selecting the XML element preset in the http://schemas.microsoft.com/Expression/Encoder/V4 namespace .

## See Also

### Reference

[IManifestProperty Interface](imanifestproperty-interface-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

