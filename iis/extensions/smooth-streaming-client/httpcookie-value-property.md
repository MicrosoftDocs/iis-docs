---
title: HttpCookie.Value Property
description: Describes the HttpCookie.Value property and provides the property's syntax, property value, and requirements.
TOCTitle: Value Property
ms:assetid: 9d33fd25-e5d7-4ca0-bcc1-e97ff49617bf
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822795(v=VS.90)
ms:contentKeyID: 50079549
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# HttpCookie.Value Property

**Applies to:** Windows Store apps only

Gets the value of the http cookie.

## Syntax

```csharp
public string Value { get; set; }
```

```cpp
public:
virtual property String^ Value {
String^ get () sealed;
void set (String^ value) sealed;
}
```

```jscript
final function get Value () : String
final function set Value (value : String)
```

## Property Value

The value of the http cookie.

## Requirements

|Requirement|Description|
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|
