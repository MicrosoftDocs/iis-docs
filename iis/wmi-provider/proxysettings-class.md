---
title: "ProxySettings Class"
ms.date: "10/07/2016"
ms.assetid: f5126ff9-aa48-48ca-ff1f-e1da8eb99fc1
---
# ProxySettings Class

Contains configuration settings for a Web proxy server.

## Syntax

```vbs
class ProxySettings : EmbeddedObject
```

## Methods

This class contains no methods.

## Properties

The following table lists the properties exposed by the `ProxySettings` class.

|Name|Description|
|----------|-----------------|
|`AutoDetect`|A read/write `sint32` value that specifies whether the proxy is automatically detected. The possible values are listed later in the Remarks section.|
|`BypassOnLocal`|A read/write `sint32` value that specifies whether the proxy is bypassed for local resources. The possible values are listed later in the Remarks section. **Note:**  Local resources include the local server (for example, `http://localhost`, `http://loopback`, or `http://127.0.0.1`) and a Uniform Resource Identifier (URI) without a period (for example, `http://webserver`).|
|`ProxyAddress`|A read/write `string` value that contains the URI of the Web proxy server to use.|
|`ScriptLocation`|A read/write `string` value that contains the URI of the automatic proxy detection script.|
|`UseSystemDefault`|A read/write `sint32` value that specifies whether local system proxy settings are used to determine how local resources are accessed. The possible values are listed later in the Remarks section.|

## Subclasses

This class contains no subclasses.

## Remarks

Instances of this class are contained in the `Proxy` property of the [DefaultProxySection](../wmi-provider/defaultproxysection-class.md) class.

The following table lists the possible values for the `AutoDetect` property. The default is –1 (`Unspecified`).

|Value|Keyword|Description|
|-----------|-------------|-----------------|
|0|`False`|The proxy is not automatically detected.|
|1|`True`|The proxy is automatically detected.|
|–1|`Unspecified`|The `AutoDetect` setting is not specified.|

The following table lists the possible values for the `BypassOnLocal` property. The default is –1 (`Unspecified`).

|Value|Keyword|Description|
|-----------|-------------|-----------------|
|0|`False`|Local resources should be accessed through the proxy.|
|1|`True`|Local resources should be accessed directly.|
|–1|`Unspecified`|The `BypassOnLocal` setting is not specified.|

The following table lists the possible values for the `UseSystemDefault` property. The default is –1 (`Unspecified`).

|Value|Keyword|Description|
|-----------|-------------|-----------------|
|0|`False`|Do not use system default proxy setting values.|
|1|`True`|Use system default proxy setting values.|
|–1|`Unspecified`|The `UseSystemDefault` setting is not specified.|

## Inheritance Hierarchy

[EmbeddedObject](../wmi-provider/embeddedobject-class.md)

`ProxySettings`

## Requirements

|Type|Description|
|----------|-----------------|
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|
|MOF file|WebAdministration.mof|

## See also

- [DefaultProxySection Class](../wmi-provider/defaultproxysection-class.md)
- [EmbeddedObject Class](../wmi-provider/embeddedobject-class.md)
