---
title: SmoothStreamingMediaElement.MergeExternalManifest Method  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: MergeExternalManifest Method
ms:assetid: M:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.MergeExternalManifest(System.Object)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.mergeexternalmanifest(v=VS.90)
ms:contentKeyID: 28440970
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.MergeExternalManifest
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.MergeExternalManifest
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# MergeExternalManifest Method

Replaces some elements of the main manifest with others from an external manifest or adds new elements to the main manifest.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Sub MergeExternalManifest ( _
    externalManifest As Object _
)
'Usage

  Dim instance As SmoothStreamingMediaElement
Dim externalManifest As Object

instance.MergeExternalManifest(externalManifest)
```

```csharp
  public void MergeExternalManifest(
    Object externalManifest
)
```

```cpp
  public:
void MergeExternalManifest(
    Object^ externalManifest
)
```

```jscript
  public function MergeExternalManifest(
    externalManifest : Object
)
```

### Parameters

  - externalManifest  
    Type: [System.Object](https://msdn.microsoft.com/library/e5kfa45b)  
    An object that represents the external manifest, as returned by the ParseExternalManifest()()()() method.  

## Remarks

For more information and for examples, see [Manifest Merge (IIS Smooth Streaming)](manifest-merge.md).

## Examples

Applications can call MergeExternalManifest only from the [ManifestMerge](smoothstreamingmediaelement-manifestmerge-event-microsoft-web-media-smoothstreaming_1.md) event handler. Outside the scope of this method, MergeExternalManifest throws an [InvalidOperationException](https://msdn.microsoft.com/library/2asft85a).

The MergeExternalManifest method integrates data in the client manifest with new XML data specified by the externalManifest parameter, which is the parsed data obtained from a previous call to [ParseExternalManifest](smoothstreamingmediaelement-parseexternalmanifest-method-microsoft-web-media-smoothstreaming_1.md).

The following example shows how to use the method to assign a delegate.

``` 
 SmoothPlayer.ManifestMerge += 
    new SmoothStreamingMediaElement.ManifestMergeHandler(SmoothPlayer_ManifestMerge);
```

The following example shows an implementation of the SmoothPlayer\_ManifestMerge delegate that includes options to load supplementary manifest data from sources represented by the mediaSelection variable, which is an integer assigned when the source is selected. The methods that load the new data can load manifest data from two sources and initialize the parsedExternManifest and parsedExternManifest2 objects. For more information, see [Manifest Merge (IIS Smooth Streaming)](manifest-merge.md).

``` 
    void SmoothPlayer_ManifestMerge(SmoothStreamingMediaElement ssme)
    {
        // Out parameter for ParseExternalManifest function.
        object parsedExternManifest = null;
        object parsedExternManifest2 = null;

        try
        {
            if (mediaSelection.Equals(0))
            {
                Uri uriExtManifest = new Uri("http://<serverName>/BigBuckBunnyCaptions.xml");
                SmoothPlayer.ParseExternalManifest(uriExtManifest, 3000, out parsedExternManifest);
                SmoothPlayer.MergeExternalManifest(parsedExternManifest);
            }

            if (mediaSelection.Equals(1))
            {
    
                Uri uriExtManifest = new Uri("http://<serverName>/AdrenalineRush.xml");
                SmoothPlayer.ParseExternalManifest(uriExtManifest, 3000, out parsedExternManifest);
                SmoothPlayer.MergeExternalManifest(parsedExternManifest);

                Uri uriExtManifest2 = new Uri("http://<serverName>/AdrenalineRushCaptions.xml");
                SmoothPlayer.ParseExternalManifest(uriExtManifest2, 3000, out parsedExternManifest2);
                SmoothPlayer.MergeExternalManifest(parsedExternManifest2);
            }
        }
        catch(Exception ex )
        {
            OutputText.Text = ex.Message + " Inner Exception: " + ex.InnerException;
        }
    }
```

## Version Information

### Silverlight

Supported in: 4  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

