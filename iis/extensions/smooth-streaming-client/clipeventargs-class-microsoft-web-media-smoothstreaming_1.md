---
title: ClipEventArgs Class (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ClipEventArgs Class
ms:assetid: T:Microsoft.Web.Media.SmoothStreaming.ClipEventArgs
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.clipeventargs(v=VS.95)
ms:contentKeyID: 46307937
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ClipEventArgs
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ClipEventArgs
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# ClipEventArgs Class

Class used by media clips to pass event argument information that contains an associated clip context instance.

## Inheritance Hierarchy

 [System.Object](https://msdn.microsoft.com/library/e5kfa45b\(v=vs.95\))  
  [System.EventArgs](https://msdn.microsoft.com/library/118wxtk3\(v=vs.95\))  
    Microsoft.Web.Media.SmoothStreaming.ClipEventArgs  
      [Microsoft.Web.Media.SmoothStreaming.ClipPlaybackEventArgs](clipplaybackeventargs-class-microsoft-web-media-smoothstreaming_1.md)  

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Class ClipEventArgs _
    Inherits EventArgs
'Usage

Dim instance As ClipEventArgs
```

```csharp
public class ClipEventArgs : EventArgs
```

```cpp
public ref class ClipEventArgs : public EventArgs
```

``` fsharp
type ClipEventArgs =  
    class
        inherit EventArgs
    end
```

```jscript
public class ClipEventArgs extends EventArgs
```

The ClipEventArgs type exposes the following members.

## Properties

||Name|Description|
|--- |--- |--- |
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")|[Context](clipeventargs-context-property-microsoft-web-media-smoothstreaming_1.md)|Gets or sets the [Context](clipeventargs-context-property-microsoft-web-media-smoothstreaming_1.md) property.|


## Methods

||Name|Description|
|--- |--- |--- |
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[Equals](https://msdn.microsoft.com/library/bsc2ak47(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|
|![Protected method](images/Ff728153.protmethod(en-us,VS.90).gif "Protected method")|[Finalize](https://msdn.microsoft.com/library/4k87zsw7(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[GetHashCode](https://msdn.microsoft.com/library/zdee4b3y(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[GetType](https://msdn.microsoft.com/library/dfwy45w9(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|
|![Protected method](images/Ff728153.protmethod(en-us,VS.90).gif "Protected method")|[MemberwiseClone](https://msdn.microsoft.com/library/57ctke0a(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[ToString](https://msdn.microsoft.com/library/7bxwbwt2(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|

## Remarks

For more information, see [Scheduling Media Clips](scheduling-media-clips.md).

## Examples

If the user clicks on the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) surface while an inserted clip is playing, the delegate method that handles the event can access the Microsoft.Web.Media.SmoothStreaming.ClipContext from the ClipEventArgs. The [ClipInformation](clipcontext-clipinformation-property-microsoft-web-media-smoothstreaming_1.md) property contains the [Microsoft.Web.Media.SmoothStreaming.ClipInformation.ClickThroughUrl](https://msdn.microsoft.com/library/ee532602\(v=vs.95\)) that was assigned when the [ClipInformation](clipinformation-class-microsoft-web-media-smoothstreaming_1.md) object was initialized.

The following delegate opens a new browser window for the [Microsoft.Web.Media.SmoothStreaming.ClipInformation.ClickThroughUrl](https://msdn.microsoft.com/library/ee532602\(v=vs.95\)).

    void SmoothPlayer_ClipClickThrough(object sender, ClipEventArgs e)
        {
            System.Windows.Browser.HtmlPage.Window.Navigate(e.Context.ClipInformation.ClickThroughUrl, "_newWindow");
        }

## Version Information

### Silverlight

Supported in: 5  

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

### Reference

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

