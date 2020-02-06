---
title: SmoothStreamingMediaElement.ParseExternalManifest Method  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ParseExternalManifest Method
ms:assetid: M:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.ParseExternalManifest(System.Uri,System.Int32,System.Object@)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.parseexternalmanifest(v=VS.95)
ms:contentKeyID: 46307689
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.ParseExternalManifest
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.ParseExternalManifest
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SmoothStreamingMediaElement.ParseExternalManifest Method

Downloads, parses, and returns an object that represents the specified external manifest.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Sub ParseExternalManifest ( _
    externalManifestUri As Uri, _
    millisecondsTimeout As Integer, _
    <OutAttribute> ByRef externalManifest As Object _
)
'Usage

Dim instance As SmoothStreamingMediaElement
Dim externalManifestUri As Uri
Dim millisecondsTimeout As Integer
Dim externalManifest As Object

instance.ParseExternalManifest(externalManifestUri, _
    millisecondsTimeout, externalManifest)
```

```csharp
public void ParseExternalManifest(
    Uri externalManifestUri,
    int millisecondsTimeout,
    out Object externalManifest
)
```

```cpp
public:
void ParseExternalManifest(
    Uri^ externalManifestUri, 
    int millisecondsTimeout, 
    [OutAttribute] Object^% externalManifest
)
```

``` fsharp
member ParseExternalManifest : 
        externalManifestUri:Uri * 
        millisecondsTimeout:int * 
        externalManifest:Object byref -> unit 
```

```jscript
public function ParseExternalManifest(
    externalManifestUri : Uri, 
    millisecondsTimeout : int, 
    externalManifest : Object
)
```

### Parameters

  - externalManifestUri  
    Type: [System.Uri](https://msdn.microsoft.com/library/txt7706a\(v=vs.95\))  
    The URI of the manifest data to parse.

<!-- end list -->

  - millisecondsTimeout  
    Type: [System.Int32](https://msdn.microsoft.com/library/td2s409d\(v=vs.95\))  
    The timeout interval to avoid blocking if external data is not returned quickly.

<!-- end list -->

  - externalManifest  
    Type: [System.Object](https://msdn.microsoft.com/library/e5kfa45b\(v=vs.95\))%  
    When this method returns, contains the object that receives the external manifest data.

## Remarks

The manifest that is the result of calling this method can be passed to [MergeExternalManifest](smoothstreamingmediaelement-mergeexternalmanifest-method-microsoft-web-media-smoothstreaming_1.md) to override elements of the main manifest by elements from the external manifest. For more information and for examples, see [Manifest Merge](manifest-merge.md).

## Examples

Applications can call ParseExternalManifest only from the [ManifestMerge](smoothstreamingmediaelement-manifestmerge-event-microsoft-web-media-smoothstreaming_1.md) event handler. Outside the scope of this method, ParseExternalManifest throws an [InvalidOperationException](https://msdn.microsoft.com/library/2asft85a\(v=vs.95\)) exception.

The ParseExternalManifest method reads XML data from a source identified by the externalManifestUri parameter. To avoid blocking, the millisecondsTimeout parameter sets a timeout interval in milliseconds. The last parameter returns the new parsed data.

    // Out parameter for function.
      Uri uriExtManifest = new 
      Uri("http://serverName/BigBuckBunnyCaptions.xml");
        SmoothPlayer.ParseExternalManifest(uriExtManifest, 3000, out parsedExternManifest);

## Version Information

### Silverlight

Supported in: 5  

## See Also

### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

