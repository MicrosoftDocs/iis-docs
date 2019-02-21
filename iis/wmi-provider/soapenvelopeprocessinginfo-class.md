---
title: "SoapEnvelopeProcessingInfo Class"
ms.date: "10/07/2016"
ms.assetid: 05a66125-7647-f904-145a-9aae7f29272a
---
# SoapEnvelopeProcessingInfo Class
Configures a time-out that helps mitigate denial of service attacks.  
  
## Syntax  
  
```vbs  
class SoapEnvelopeProcessingInfo : EmbeddedObject  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `SoapEnvelopeProcessingInfo` class.  
  
|Name|Description|  
|----------|-----------------|  
|`ReadTimeout`|A read/write `sint32` value that specifies the time, in milliseconds, that the XML Web service waits before it terminates requests to the [System.Xml.XmlReader.Read](http://go.microsoft.com/fwlink/?LinkId=70965) and [System.Xml.XmlReader.MoveToContent](http://go.microsoft.com/fwlink/?LinkId=70966) methods. The default is 2147483647.<br /><br /> The time-out period is checked on every call to `Read` and `MoveToContent` and is used to mitigate denial of service attacks.|  
|`Strict`|A read/write `boolean` value. `true` if the Web service serializer throws an exception if it encounters unexpected elements or attributes; otherwise, `false`. The default is `false`.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are exposed as members of the `SoapEnvelopeProcessing` property on the [WebServicesSection](../wmi-provider/webservicessection-class.md) class.  
  
 Set the `Strict` property to `true` in order to help debug interoperation scenarios. In general, when the [System.Xml.Serialization.XmlSerializer](http://go.microsoft.com/fwlink/?LinkId=70923) class encounters an element or attribute that it does not expect, it raises an [UnknownNode](http://go.microsoft.com/fwlink/?LinkId=70964) event and continues processing. Setting the `Strict` property to `true` instructs the Web service run-time functions to handle that event and throw an [InvalidOperationException](http://go.microsoft.com/fwlink/?LinkId=66612) that contains a list of the expected elements and attributes.  
  
> [!NOTE]
>  Because exceptions are not thrown for all unexpected elements and attributes, you should not rely on the `Strict` property except as a debugging aid. For example, unexpected `xml:lang` and `xml:space` attributes may not cause an exception.  
  
## Inheritance Hierarchy  
 [EmbeddedObject](../wmi-provider/embeddedobject-class.md)  
  
 `SoapEnvelopeProcessingInfo`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [EmbeddedObject Class](../wmi-provider/embeddedobject-class.md)   
 [WebServicesSection Class](../wmi-provider/webservicessection-class.md)   
 [InvalidOperationException](http://go.microsoft.com/fwlink/?LinkId=66612)   
 [System.Web.Services.Configuration.SoapEnvelopeProcessingElement Properties](http://go.microsoft.com/fwlink/?LinkId=70967)   
 [System.Xml.XmlReader.MoveToContent Method](http://go.microsoft.com/fwlink/?LinkId=70966)   
 [System.Xml.XmlReader.Read Method](http://go.microsoft.com/fwlink/?LinkId=70965)   
 [System.Xml.Serialization.XmlSerializer Class](http://go.microsoft.com/fwlink/?LinkId=70923)   
 [System.Xml.Serialization.XmlSerializer.UnknownNode Event](http://go.microsoft.com/fwlink/?LinkId=70964)