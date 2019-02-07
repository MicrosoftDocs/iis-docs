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
- CSharp
- JScript
- VB
- FSharp
- c++
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
ROBOTS: INDEX,FOLLOW
---

# EventViewer Class

Provides event details that are written to an event viewer for an IIS Transform Manager job. The default event viewer is the Windows Event Viewer. This type supports the IIS Transform Manager infrastructure and is not intended to be used directly from your code.

## Inheritance Hierarchy

[System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  
  Microsoft.Web.Media.TransformManager..::..EventViewer  

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration

  Public NotInheritable Class EventViewer
'Usage

  Dim instance As EventViewer
```

``` csharp
  public sealed class EventViewer
```

``` c++
  public ref class EventViewer sealed
```

``` fsharp
[<SealedAttribute>]
type EventViewer =  class end
```

``` jscript
  public final class EventViewer
```

The EventViewer type exposes the following members.

## Methods

||Name|Description|
|--- |--- |--- |
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
|![Public field](images/Hh125771.pubfield(en-us,VS.90).gif "Public field")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[EventIdError](eventviewer-eventiderror-field-microsoft-web-media-transformmanager.md)|Represents a constant that is used when error information is written to the event viewer. This member supports the IIS Transform Manager infrastructure and is not intended to be used directly from your code.|
|![Public field](images/Hh125771.pubfield(en-us,VS.90).gif "Public field")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[EventIdInformation](eventviewer-eventidinformation-field-microsoft-web-media-transformmanager.md)|Represents a constant that is used when information is written to the event viewer. This member supports the IIS Transform Manager infrastructure and is not intended to be used directly from your code.|
|![Public field](images/Hh125771.pubfield(en-us,VS.90).gif "Public field")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[EventIdSuccess](eventviewer-eventidsuccess-field-microsoft-web-media-transformmanager.md)|Represents a constant that is used when success information is written to the event viewer. This member supports the IIS Transform Manager infrastructure and is not intended to be used directly from your code.|
|![Public field](images/Hh125771.pubfield(en-us,VS.90).gif "Public field")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[EventIdWarning](eventviewer-eventidwarning-field-microsoft-web-media-transformmanager.md)|Represents a constant that is used when warning information is written to the event viewer. This member supports the IIS Transform Manager infrastructure and is not intended to be used directly from your code.|
|![Public field](images/Hh125771.pubfield(en-us,VS.90).gif "Public field")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[EventSource](eventviewer-eventsource-field-microsoft-web-media-transformmanager.md)|Represents a constant that is used when event source information is written to the event viewer. This member supports the IIS Transform Manager infrastructure and is not intended to be used directly from your code.|

Top

## Remarks

The event viewer requires an event message to have a very specific format. Otherwise, the IIS Transform Manager provides a message that the product is not installed correctly.

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

#### Reference

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

