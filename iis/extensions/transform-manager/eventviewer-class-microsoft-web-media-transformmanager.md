---
title: EventViewer Class (Microsoft.Web.Media.TransformManager)
TOCTitle: EventViewer Class
ms:assetid: T:Microsoft.Web.Media.TransformManager.EventViewer
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.eventviewer(v=VS.90)
ms:contentKeyID: 35520868
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.EventViewer
dev_langs:
- "csharp"
- "jscript"
- "vb"
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.EventViewer
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# EventViewer Class

Provides event details that are written to an event viewer for an IIS Transform Manager job. The default event viewer is the Windows Event Viewer. This type supports the IIS Transform Manager infrastructure and is not intended to be used directly from your code.

## Inheritance Hierarchy

[System.Object](https://msdn.microsoft.com/library/e5kfa45b)  
  Microsoft.Web.Media.TransformManager..::..EventViewer  

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public NotInheritable Class EventViewer
'Usage

  Dim instance As EventViewer
```

```csharp
  public sealed class EventViewer
```

```cpp
  public ref class EventViewer sealed
```

``` fsharp
[<SealedAttribute>]
type EventViewer =  class end
```

```jscript
  public final class EventViewer
```

The EventViewer type exposes the following members.

## Methods

||Name|Description|
|--- |--- |--- |
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[Equals](https://msdn.microsoft.com/library/bsc2ak47)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Protected method](images/Hh125771.protmethod(en-us,VS.90).gif "Protected method")|[Finalize](https://msdn.microsoft.com/library/4k87zsw7)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetHashCode](https://msdn.microsoft.com/library/zdee4b3y)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetType](https://msdn.microsoft.com/library/dfwy45w9)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Protected method](images/Hh125771.protmethod(en-us,VS.90).gif "Protected method")|[MemberwiseClone](https://msdn.microsoft.com/library/57ctke0a)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[ToString](https://msdn.microsoft.com/library/7bxwbwt2)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|

## Fields

||Name|Description|
|--- |--- |--- |
|![Public field](images/Hh125771.pubfield(en-us,VS.90).gif "Public field")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[EventIdError](eventviewer-eventiderror-field-microsoft-web-media-transformmanager.md)|Represents a constant that is used when error information is written to the event viewer. This member supports the IIS Transform Manager infrastructure and is not intended to be used directly from your code.|
|![Public field](images/Hh125771.pubfield(en-us,VS.90).gif "Public field")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[EventIdInformation](eventviewer-eventidinformation-field-microsoft-web-media-transformmanager.md)|Represents a constant that is used when information is written to the event viewer. This member supports the IIS Transform Manager infrastructure and is not intended to be used directly from your code.|
|![Public field](images/Hh125771.pubfield(en-us,VS.90).gif "Public field")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[EventIdSuccess](eventviewer-eventidsuccess-field-microsoft-web-media-transformmanager.md)|Represents a constant that is used when success information is written to the event viewer. This member supports the IIS Transform Manager infrastructure and is not intended to be used directly from your code.|
|![Public field](images/Hh125771.pubfield(en-us,VS.90).gif "Public field")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[EventIdWarning](eventviewer-eventidwarning-field-microsoft-web-media-transformmanager.md)|Represents a constant that is used when warning information is written to the event viewer. This member supports the IIS Transform Manager infrastructure and is not intended to be used directly from your code.|
|![Public field](images/Hh125771.pubfield(en-us,VS.90).gif "Public field")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[EventSource](eventviewer-eventsource-field-microsoft-web-media-transformmanager.md)|Represents a constant that is used when event source information is written to the event viewer. This member supports the IIS Transform Manager infrastructure and is not intended to be used directly from your code.|

## Remarks

The event viewer requires an event message to have a very specific format. Otherwise, the IIS Transform Manager provides a message that the product is not installed correctly.

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

### Reference

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

