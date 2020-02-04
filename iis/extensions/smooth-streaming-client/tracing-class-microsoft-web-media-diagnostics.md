---
title: Tracing Class (Microsoft.Web.Media.Diagnostics)
TOCTitle: Tracing Class
ms:assetid: T:Microsoft.Web.Media.Diagnostics.Tracing
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.diagnostics.tracing(v=VS.90)
ms:contentKeyID: 23961207
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.Diagnostics.Tracing
dev_langs:
- csharp
- jscript
- vb
- "cpp"
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.Diagnostics.Tracing
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# Tracing Class

Class of utilities that provide tracing and debugging routines.

## Inheritance Hierarchy

[System.Object](https://msdn.microsoft.com/library/e5kfa45b)  
  Microsoft.Web.Media.Diagnostics..::..Tracing  

**Namespace:**  [Microsoft.Web.Media.Diagnostics](microsoft-web-media-diagnostics-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public NotInheritable Class Tracing
'Usage

  Dim instance As Tracing
```

```csharp
  public sealed class Tracing
```

```cpp
  public ref class Tracing sealed
```

```jscript
  public final class Tracing
```

The Tracing type exposes the following members.

## Properties

||Name|Description|
|--- |--- |--- |
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")![Static member](images/Ff728153.static(en-us,VS.90).gif "Static member")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[ConfigLoaded](tracing-configloaded-property-microsoft-web-media-diagnostics_1.md)|Gets the [ConfigLoaded](tracing-configloaded-property-microsoft-web-media-diagnostics_1.md) property.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")![Static member](images/Ff728153.static(en-us,VS.90).gif "Static member")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[IsolatedStorageQuota](tracing-isolatedstoragequota-property-microsoft-web-media-diagnostics_1.md)|Gets or sets the [IsolatedStorageQuota](tracing-isolatedstoragequota-property-microsoft-web-media-diagnostics_1.md) property.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")![Static member](images/Ff728153.static(en-us,VS.90).gif "Static member")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[RemoteServerUri](tracing-remoteserveruri-property-microsoft-web-media-diagnostics_1.md)|Gets or sets the [Uri](https://msdn.microsoft.com/library/txt7706a) of the remote server.|


## Methods

||Name|Description|
|--- |--- |--- |
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Static member](images/Ff728153.static(en-us,VS.90).gif "Static member")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[DisableTraceArea](tracing-disabletracearea-method-microsoft-web-media-diagnostics_1.md)|Disables the trace area that is specified by the traceArea parameter.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Static member](images/Ff728153.static(en-us,VS.90).gif "Static member")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[DisableTraceDestination](tracing-disabletracedestination-method-microsoft-web-media-diagnostics_1.md)|Disables the trace destination that is specified by the destination parameter.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Static member](images/Ff728153.static(en-us,VS.90).gif "Static member")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[DisableTraceLevel](tracing-disabletracelevel-method-microsoft-web-media-diagnostics_1.md)|Disables the trace severity level that is specified by the tracelevel parameter.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Static member](images/Ff728153.static(en-us,VS.90).gif "Static member")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[EnableTraceArea](tracing-enabletracearea-method-microsoft-web-media-diagnostics_1.md)|Enables the trace area that is specified by the traceArea parameter.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Static member](images/Ff728153.static(en-us,VS.90).gif "Static member")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[EnableTraceDestination](tracing-enabletracedestination-method-microsoft-web-media-diagnostics_1.md)|Enables the trace destination that is specified by the destination parameter.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Static member](images/Ff728153.static(en-us,VS.90).gif "Static member")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[EnableTraceLevel](tracing-enabletracelevel-method-microsoft-web-media-diagnostics_1.md)|Enables the trace severity level that is specified by the tracelevel parameter.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[Equals](https://msdn.microsoft.com/library/bsc2ak47)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Protected method](images/Ff728153.protmethod(en-us,VS.90).gif "Protected method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[Finalize](https://msdn.microsoft.com/library/4k87zsw7)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Static member](images/Ff728153.static(en-us,VS.90).gif "Static member")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[FormatTraceOutput](tracing-formattraceoutput-method-microsoft-web-media-diagnostics_1.md)|Formats the trace output according to the current configuration settings.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[GetHashCode](https://msdn.microsoft.com/library/zdee4b3y)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Static member](images/Ff728153.static(en-us,VS.90).gif "Static member")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[GetTraceEntries](tracing-gettraceentries-method-microsoft-web-media-diagnostics_1.md)|Gets an array of trace entries.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[GetType](https://msdn.microsoft.com/library/dfwy45w9)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Static member](images/Ff728153.static(en-us,VS.90).gif "Static member")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[Initialize](tracing-initialize-method-microsoft-web-media-diagnostics_1.md)|Initializes the trace utility.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Static member](images/Ff728153.static(en-us,VS.90).gif "Static member")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[IsTraceAreaEnabled](tracing-istraceareaenabled-method-microsoft-web-media-diagnostics_1.md)|Returns a Boolean that value indicates whether the specified TraceArea is enabled.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Static member](images/Ff728153.static(en-us,VS.90).gif "Static member")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[IsTraceDestinationEnabled](tracing-istracedestinationenabled-method-microsoft-web-media-diagnostics_1.md)|Returns a Boolean value that indicates whether the specified TraceDestination is enabled.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Static member](images/Ff728153.static(en-us,VS.90).gif "Static member")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[IsTraceLevelEnabled](tracing-istracelevelenabled-method-microsoft-web-media-diagnostics_1.md)|Returns a Boolean value that indicates whether the specified TraceLevel severity is enabled.|
|![Protected method](images/Ff728153.protmethod(en-us,VS.90).gif "Protected method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[MemberwiseClone](https://msdn.microsoft.com/library/57ctke0a)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Static member](images/Ff728153.static(en-us,VS.90).gif "Static member")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[ReadTraceConfig(String)](tracing-readtraceconfig-method-string-microsoft-web-media-diagnostics_1.md)|Reads trace configuration settings from the XML data that is specified by xmlConfig.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Static member](images/Ff728153.static(en-us,VS.90).gif "Static member")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[ReadTraceConfig(Uri)](tracing-readtraceconfig-method-uri-microsoft-web-media-diagnostics_1.md)|Reads trace configuration settings from XML data returned by the uri that is specified by the parameter.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Static member](images/Ff728153.static(en-us,VS.90).gif "Static member")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[ReadTraceConfig(XmlReader)](tracing-readtraceconfig-method-xmlreader-microsoft-web-media-diagnostics_1.md)|Reads trace configuration settings from XML data returned by the xmlReader that is specified by the parameter.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Static member](images/Ff728153.static(en-us,VS.90).gif "Static member")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[Shutdown](tracing-shutdown-method-microsoft-web-media-diagnostics_1.md)|Shuts down tracing facilities and flushes any pending data to its destination.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[ToString](https://msdn.microsoft.com/library/7bxwbwt2)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Static member](images/Ff728153.static(en-us,VS.90).gif "Static member")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[Trace(TraceArea, TraceLevel)](tracing-trace-method-tracearea-tracelevel-microsoft-web-media-diagnostics_1.md)|Traces a diagnostic message that is specified by the parameters.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Static member](images/Ff728153.static(en-us,VS.90).gif "Static member")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[Trace(TraceArea, TraceLevel, String)](tracing-trace-method-tracearea-tracelevel-string-microsoft-web-media-diagnostics_1.md)|Traces a diagnostic message that is specified by the parameters.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Static member](images/Ff728153.static(en-us,VS.90).gif "Static member")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[Trace(String, String, TraceArea, TraceLevel)](tracing-trace-method-string-string-tracearea-tracelevel-microsoft-web-media-diagnostics_1.md)|Traces a diagnostic message that is specified by the parameters.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Static member](images/Ff728153.static(en-us,VS.90).gif "Static member")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[Trace(TraceArea, TraceLevel, String, array<Object> [] () [] [])](tracing-trace-method-tracearea-tracelevel-string-object%5B%5D-microsoft-web-media-diagnostics_1.md)|Traces a diagnostic message that is specified by the parameters.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Static member](images/Ff728153.static(en-us,VS.90).gif "Static member")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[Trace(String, String, TraceArea, TraceLevel, String)](tracing-trace-method-string-string-tracearea-tracelevel-string-microsoft-web-media-diagnostics_1.md)|Traces a diagnostic message that is specified by the parameters.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Static member](images/Ff728153.static(en-us,VS.90).gif "Static member")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[Trace(String, String, TraceArea, TraceLevel, String, array<Object> [] () [] [])](tracing-trace-method-string-string-tracearea-tracelevel-string-object%5B%5D-microsoft-web-media-diagnostics_1.md)|Traces a diagnostic message that is specified by the parameters.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Static member](images/Ff728153.static(en-us,VS.90).gif "Static member")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[Trace(String, String, String, TraceArea, TraceLevel, String)](tracing-trace-method-string-string-string-tracearea-tracelevel-string-microsoft-web-media-diagnostics_1.md)|Traces a diagnostic message that is specified by the parameters.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Static member](images/Ff728153.static(en-us,VS.90).gif "Static member")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[Trace(String, String, String, TraceArea, TraceLevel, String, array<Object> [] () [] [])](tracing-trace-method-string-string-string-tracearea-tracelevel-string-object%5B%5D-microsoft-web-media-diagnostics_1.md)|Traces a diagnostic message that is specified by the parameters.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Static member](images/Ff728153.static(en-us,VS.90).gif "Static member")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[TraceFunctionEntry(TraceArea)](tracing-tracefunctionentry-method-tracearea-microsoft-web-media-diagnostics_1.md)|Records the entry into a function as specified by the parameters.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Static member](images/Ff728153.static(en-us,VS.90).gif "Static member")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[TraceFunctionEntry(String, String, TraceArea)](tracing-tracefunctionentry-method-string-string-tracearea-microsoft-web-media-diagnostics_1.md)|Records the entry into a function as specified by the parameters.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Static member](images/Ff728153.static(en-us,VS.90).gif "Static member")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[TraceFunctionEntry(String, String, String, TraceArea)](tracing-tracefunctionentry-method-string-string-string-tracearea-microsoft-web-media-diagnostics_1.md)|Records the entry into a function as specified by the parameters.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Static member](images/Ff728153.static(en-us,VS.90).gif "Static member")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[TraceFunctionExit(TraceArea)](tracing-tracefunctionexit-method-tracearea-microsoft-web-media-diagnostics_1.md)|Records the exit from a function as specified by the parameter.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Static member](images/Ff728153.static(en-us,VS.90).gif "Static member")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[TraceFunctionExit(String, String, TraceArea)](tracing-tracefunctionexit-method-string-string-tracearea-microsoft-web-media-diagnostics_1.md)|Records the exit from a function as specified by the parameters.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Static member](images/Ff728153.static(en-us,VS.90).gif "Static member")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[TraceFunctionExit(String, String, String, TraceArea)](tracing-tracefunctionexit-method-string-string-string-tracearea-microsoft-web-media-diagnostics_1.md)|Records the exit from a function as specified by the parameters.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Static member](images/Ff728153.static(en-us,VS.90).gif "Static member")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[UpdateIsolatedStorageAvailableFreeSpace](tracing-updateisolatedstorageavailablefreespace-method-microsoft-web-media-diagnostics_1.md)|Updates the free space available for trace operations.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Static member](images/Ff728153.static(en-us,VS.90).gif "Static member")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[UploadTraces](tracing-uploadtraces-method-microsoft-web-media-diagnostics_1.md)|Uploads traces to the URL, if any, found in the tracing configuration.|

## Fields

||Name|Description|
|--- |--- |--- |
|![Public field](images/Ee532524.pubfield(en-us,VS.90).gif "Public field")![Static member](images/Ff728153.static(en-us,VS.90).gif "Static member")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[IncludeClassName](tracing-includeclassname-field-microsoft-web-media-diagnostics_1.md)|A Boolean value that indicates whether to include the class name in traces.|
|![Public field](images/Ee532524.pubfield(en-us,VS.90).gif "Public field")![Static member](images/Ff728153.static(en-us,VS.90).gif "Static member")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[IncludeDate](tracing-includedate-field-microsoft-web-media-diagnostics_1.md)|A Boolean value that indicates whether to include the date in traces.|
|![Public field](images/Ee532524.pubfield(en-us,VS.90).gif "Public field")![Static member](images/Ff728153.static(en-us,VS.90).gif "Static member")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[IncludeMediaElementId](tracing-includemediaelementid-field-microsoft-web-media-diagnostics_1.md)|A Boolean value that indicates whether to include the media element ID in traces.|
|![Public field](images/Ee532524.pubfield(en-us,VS.90).gif "Public field")![Static member](images/Ff728153.static(en-us,VS.90).gif "Static member")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[IncludeMethodName](tracing-includemethodname-field-microsoft-web-media-diagnostics_1.md)|A Boolean value that indicates whether to include the method name in traces.|
|![Public field](images/Ee532524.pubfield(en-us,VS.90).gif "Public field")![Static member](images/Ff728153.static(en-us,VS.90).gif "Static member")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[IncludeThreadId](tracing-includethreadid-field-microsoft-web-media-diagnostics_1.md)|A Boolean value that indicates whether to include the thread ID in traces.|
|![Public field](images/Ee532524.pubfield(en-us,VS.90).gif "Public field")![Static member](images/Ff728153.static(en-us,VS.90).gif "Static member")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[IncludeTime](tracing-includetime-field-microsoft-web-media-diagnostics_1.md)|A Boolean value that indicates whether to include the time in traces.|
|![Public field](images/Ee532524.pubfield(en-us,VS.90).gif "Public field")![Static member](images/Ff728153.static(en-us,VS.90).gif "Static member")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[IncludeTraceArea](tracing-includetracearea-field-microsoft-web-media-diagnostics_1.md)|A Boolean value that indicates whether to include the trace area in traces.|
|![Public field](images/Ee532524.pubfield(en-us,VS.90).gif "Public field")![Static member](images/Ff728153.static(en-us,VS.90).gif "Static member")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[IncludeTraceLevel](tracing-includetracelevel-field-microsoft-web-media-diagnostics_1.md)|A Boolean value that indicates whether to include the trace level severity in traces.|
|![Public field](images/Ee532524.pubfield(en-us,VS.90).gif "Public field")![Static member](images/Ff728153.static(en-us,VS.90).gif "Static member")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[PostInterval](tracing-postinterval-field-microsoft-web-media-diagnostics_1.md)|The interval at which to post traces.|
|![Public field](images/Ee532524.pubfield(en-us,VS.90).gif "Public field")![Static member](images/Ff728153.static(en-us,VS.90).gif "Static member")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[TraceHistoryMaxLines](tracing-tracehistorymaxlines-field-microsoft-web-media-diagnostics_1.md)|Maximum trace history size in number of lines.|


## Version Information

### Silverlight

Supported in: 4  

### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

### Reference

[Microsoft.Web.Media.Diagnostics Namespace](microsoft-web-media-diagnostics-namespace_1.md)

