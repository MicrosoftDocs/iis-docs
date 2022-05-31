---
title: IisNamespaces Class (Microsoft.Web.Media.TransformManager)
description: Describes the IisNamespaces class and provides the class' inheritance hierarchy, namespace, assembly, syntax, properties, and thread safety.
TOCTitle: IisNamespaces Class
ms:assetid: T:Microsoft.Web.Media.TransformManager.IisNamespaces
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.iisnamespaces(v=VS.90)
ms:contentKeyID: 35520859
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IisNamespaces
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Sdk.dll
api_name:
- Microsoft.Web.Media.TransformManager.IisNamespaces
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# IisNamespaces Class

Provides the URIs of XML namespace schema documents.

## Inheritance Hierarchy

[System.Object](https://msdn.microsoft.com/library/e5kfa45b)  
  Microsoft.Web.Media.TransformManager..::..IisNamespaces  

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Sdk (in Microsoft.Web.Media.TransformManager.Sdk.dll)

## Syntax

```vb
'Declaration

  Public NotInheritable Class IisNamespaces
'Usage

  
```

```csharp
  public static class IisNamespaces
```

```cpp
  public ref class IisNamespaces abstract sealed
```

``` fsharp
[<AbstractClassAttribute>]
[<SealedAttribute>]
type IisNamespaces =  class end
```

```jscript
  public final class IisNamespaces
```

The IisNamespaces type exposes the following members.

## Properties

|Property Type|Name|Description|
|--- |--- |--- |
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[ExpressionEncoder](iisnamespaces-expressionencoder-property-microsoft-web-media-transformmanager.md)|Gets the URI of an expression encoder schema document.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[JobDefinitionNamespace](iisnamespaces-jobdefinitionnamespace-property-microsoft-web-media-transformmanager.md)|Gets the URI of a media services schema document that is related to job definitions.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[JobSchedulerNamespace](iisnamespaces-jobschedulernamespace-property-microsoft-web-media-transformmanager.md)|Gets the URI of a media services schema document that is related to job schedulers.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[JobTemplateNamespace](iisnamespaces-jobtemplatenamespace-property-microsoft-web-media-transformmanager.md)|Gets the URI of a media services schema document that is related to job templates.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[MediaServices](iisnamespaces-mediaservices-property-microsoft-web-media-transformmanager.md)|Gets the URI of a media services schema document.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[Rdf](iisnamespaces-rdf-property-microsoft-web-media-transformmanager.md)|Gets the URI of a specific XML namespace related to Resource Description Framework (RDF) schema that is used to represent information about Web resources.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[RdfSchema](iisnamespaces-rdfschema-property-microsoft-web-media-transformmanager.md)|Gets the URI of a specific XML namespace related to Resource Description Framework (RDF) schema that is used to represent information about Web resources.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[SharedData](iisnamespaces-shareddata-property-microsoft-web-media-transformmanager.md)|Gets the URI of an XML namespace that is related to shared data.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[Smil](iisnamespaces-smil-property-microsoft-web-media-transformmanager.md)|Gets the URI of an XML based Synchronized Multimedia Integration Language (SMIL) namespace that is used to represent information about audiovisual presentations.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[Smil20](iisnamespaces-smil20-property-microsoft-web-media-transformmanager.md)|Gets the URI of an XML based Synchronized Multimedia Integration Language (SMIL) namespace that is used to represent information about audiovisual presentations.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[Smil20Language](iisnamespaces-smil20language-property-microsoft-web-media-transformmanager.md)|Gets the URI of an XML based Synchronized Multimedia Integration Language (SMIL) namespace that is used to represent information about audiovisual presentations.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[TaskDefinitionNamespace](iisnamespaces-taskdefinitionnamespace-property-microsoft-web-media-transformmanager.md)|Gets the URI of an XML namespace that is related to task definitions.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[Xmlns](iisnamespaces-xmlns-property-microsoft-web-media-transformmanager.md)|Gets a URL to an XML namespace that is related to XML namespaces.|

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

### Reference

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
