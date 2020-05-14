---
title: "PagesSection Class"
ms.date: "10/07/2016"
ms.assetid: a6bf3790-3458-c37b-92b3-ce50c3ee59ba
---
# PagesSection Class
Represents the `<pages>` section of a Web.config file.  
  
## Syntax  
  
```vbs  
class PagesSection : ConfigurationSectionWithCollection  
```  
  
## Methods  
 The following table lists the methods exposed by the `PagesSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|[Add](../wmi-provider/configurationsectionwithcollection-add-method.md)|(Inherited from [ConfigurationSectionWithCollection](../wmi-provider/configurationsectionwithcollection-class.md).)|  
|[Clear](../wmi-provider/configurationsectionwithcollection-clear-method.md)|(Inherited from `ConfigurationSectionWithCollection`.)|  
|[Get](../wmi-provider/configurationsectionwithcollection-get-method.md)|(Inherited from `ConfigurationSectionWithCollection`.)|  
|[GetAllowDefinition](../wmi-provider/configurationsection-getallowdefinition-method.md)|(Inherited from [ConfigurationSection](../wmi-provider/configurationsection-class.md).)|  
|[GetAllowLocation](../wmi-provider/configurationsection-getallowlocation-method.md)|(Inherited from `ConfigurationSection`.)|  
|[Remove](../wmi-provider/configurationsectionwithcollection-remove-method.md)|(Inherited from `ConfigurationSectionWithCollection`.)|  
|[RevertToParent](../wmi-provider/configurationsection-reverttoparent-method.md)|(Inherited from `ConfigurationSection`.)|  
|[SetAllowDefinition](../wmi-provider/configurationsection-setallowdefinition-method.md)|(Inherited from `ConfigurationSection`.)|  
|[SetAllowLocation](../wmi-provider/configurationsection-setallowlocation-method.md)|(Inherited from `ConfigurationSection`.)|  
  
## Properties  
 The following table lists the properties exposed by the `PagesSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|`AsyncTimeout`|A read/write `datetime` value that specifies the time that the page will wait to perform asynchronous tasks. The default is 45 seconds.|  
|`AutoEventWireup`|A read/write `boolean` value. `true` if events for [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] pages are automatically connected to event-handling functions; otherwise, `false`. The default is `true`. **Note:**  When this property is `true`, [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] does not require events to specify event handlers such as `Page_Load` or `Page_Init`. This means that the `Handles` keyword in [!INCLUDE[vbprvb](../wmi-provider/includes/vbprvb-md.md)] is not required in the server script in the Web Forms page. By default, when the [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] Web application is created in [!INCLUDE[vsprvs](../wmi-provider/includes/vsprvs-md.md)], the value of the `AutoEventWireup` property is set to `false` in the .aspx page or .ascx control, and event handlers are not automatically created. Do not set `AutoEventWireup` to `true` if performance is a key consideration.|  
|`Buffer`|A read/write `boolean` value. `true` if .aspx pages and .ascx controls use response buffering; otherwise, `false`. The default is `true`. **Note:**  When response buffering is turned on, the page or control output is buffered until after the entire page or control is processed. Do not set this property to `true` if performance is a key consideration.|  
|`CompilationMode`|A read/write `sint32` enumeration that specifies whether .aspx pages and .ascx controls are compiled at run time. The possible values are listed later in the Remarks section.|  
|`Controls`|A [TagPrefixInfo](../wmi-provider/tagprefixinfo-class.md) value that contains configuration information for custom and user controls.|  
|`EnableEventValidation`|A `boolean` value. `true` if event validation should be performed; otherwise, `false`. The default is `true`.<br /><br /> The event-validation mechanism eliminates the risk of unauthorized postback requests and callbacks from a control. During rendering, a control registers its events and then validates only those specific events that can be raised on the control during a postback request or callback. All event-driven controls in [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] now use this feature by default. However, you can revert to [!INCLUDE[dnprdnshort](../wmi-provider/includes/dnprdnshort-md.md)] version 1.0 behavior by optionally disabling event validation for a Web application. **Note:**  The base control checks this property to determine whether it should validate events. A derived control does not inherit this base control setting, so by default it is exempt from event validation. You can still instruct [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] to perform event validation on the derived control by adding the `EnableEventValidation` property to the derived control itself and setting it to `true`.|  
|`EnableSessionState`|A read/write `sint32` value that specifies whether session state is enabled. The possible values are listed later in the Remarks section.|  
|`EnableViewState`|A read/write `boolean` value. `true` if view state is enabled; otherwise, `false.` The default is `true`.|  
|`EnableViewStateMac`|A read/write `boolean` value. `true` if [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] should run a message authentication check on the page's view state when the page is posted back from the client; otherwise, `false`. The default is `true`. **Note:**  For security reasons, this property should always be set to true.|  
|`Location`|(Inherited from `ConfigurationSection`.) A key property.|  
|`MaintainScrollPositionOnPostBack`|A read/write `boolean` value. `true` if the browser page-scroll position should be maintained after postback; otherwise, `false`. The default is `false`.|  
|`MasterPageFile`|A read/write `string` value that specifies a reference to the master page for the application. The string can contain either a relative or an absolute path.|  
|`MaxPageStateFieldLength`|A read/write `sint32` value that specifies the maximum number of characters that a single view-state field can contain. The default is –1 (no limit specified).<br /><br /> If the length of the stored data exceeds the value specified, the data is split between multiple view-state fields.|  
|`Namespaces`|A [NamespaceInfo](../wmi-provider/namespaceinfo-class.md) value that contains namespace references that are automatically imported into all the pages of a Web application. This makes the classes of the specified namespaces available for use on the page.|  
|`PageBaseType`|A read/write `string` value that specifies a code-behind class that .aspx pages inherit by default. The default is "System.Web.UI.Page".|  
|`PageParserFilterType`|A read/write `string` value that specifies the parser filter type. A parser filter is an instance of the [System.Web.UI.PageParserFilter](/dotnet/api/system.web.ui.pageparserfilter) class. At run time, the page compilation process calls the parser filter to check for changes to the source code before the page is parsed.|  
|`Path`|(Inherited from `ConfigurationSection`.) A key property.|  
|`SectionInformation`|(Inherited from `ConfigurationSection`.)|  
|`SmartNavigation`|A read/write `boolean` value. `true` if smart navigation is enabled; otherwise, `false`. The default is `false`. **Note:**  Smart navigation requires Microsoft Internet Explorer 5.5, 6, or 7.|  
|`StyleSheetTheme`|A read/write `string` value that specifies the name of an [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] style sheet theme.|  
|`TagMapping`|A [TagMapInfo](../wmi-provider/tagmapinfo-class.md) value that contains configuration tag remapping statements. This property allows you to remap the types of tags at compile time. The remapping causes the mapped type to be used in place of the original tag type for all pages and controls in the [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] application in the scope of the configuration file.|  
|`Theme`|A read/write `string` value that specifies the name of an [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] page theme.|  
|`UserControlBaseType`|A read/write `string` value that specifies a code-behind class that user controls inherit by default. The default is "System.Web.UI.UserControl".|  
|`ValidateRequest`|A read/write `boolean` value. `true` if [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] performs request validation on all input from the browser; otherwise, `false`. The default is `true`.<br /><br /> Request validation is performed by comparing input data to a list of potentially dangerous values. If a match occurs, [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] raises an [System.Web.HttpRequestValidationException](/dotnet/api/system.web.httprequestvalidationexception).|  
|`ViewStateEncryptionMode`|A read/write `sint32` enumeration that specifies the encryption mode that [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] uses for view-state values. The possible values are listed later in the Remarks section.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 The following table lists the possible values for the `CompilationMode` property. The default is 2 (`Always`).  
  
|Value|Keyword|Description|  
|-----------|-------------|-----------------|  
|0|`Auto`|[!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] does not compile the page, if possible.|  
|1|`Never`|The page or control is never dynamically compiled. This setting increases performance by disqualifying the specified page from the compilation process. If a page contains a script block or code construct that requires compilation, [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] returns an error and the page does not run.|  
|2|`Always`|The page should always be compiled.|  
  
 The following table lists the possible values for the `EnableSessionState` property. The default is 2 (`True`).  
  
|Value|Keyword|Description|  
|-----------|-------------|-----------------|  
|0|`False`|The session state is disabled.|  
|1|`ReadOnly`|The session state is read-only.|  
|2|`True`|The session state is enabled.|  
  
 The following table lists the possible values for the `ViewStateEncryptionMode` property. The default is 0 (`Auto`).  
  
|Value|Keyword|Description|  
|-----------|-------------|-----------------|  
|0|`Auto`|The view-state information is encrypted if a control requests encryption by calling the [System.Web.UI.Page.RegisterRequiresViewStateEncryption](/dotnet/api/system.web.ui.page.registerrequiresviewstateencryption) method.|  
|1|`Always`|The view-state information is always encrypted.|  
|2|`Never`|The view-state information is never encrypted, even if a control requests it.|  
  
## Inheritance Hierarchy  
 [ConfigurationSection](../wmi-provider/configurationsection-class.md)  
  
 [ConfigurationSectionWithCollection](../wmi-provider/configurationsectionwithcollection-class.md)  
  
 `PagesSection`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 Microsoft.Web.Management.Client.Win32.ModulePage.Microsoft.Web.Management.Client.IModulePage.Initialize  
 [System.Web.UI.Page.RegisterRequiresViewStateEncryption](/dotnet/api/system.web.ui.page.registerrequiresviewstateencryption)  
 [System.Web.Configuration.PagesSection](/dotnet/api/system.web.configuration.pagessection)
 [System.Web.HttpRequestValidationException](/dotnet/api/system.web.httprequestvalidationexception)  
 [AspSession Class](../wmi-provider/aspsession-class.md)
 [ConfigurationSectionWithCollection Class](../wmi-provider/configurationsectionwithcollection-class.md)
 [NamespaceInfo Class](../wmi-provider/namespaceinfo-class.md)
 [SessionPageStateSection Class](../wmi-provider/sessionpagestatesection-class.md)
 [SessionStateSection Class](../wmi-provider/sessionstatesection-class.md)
 [TagMapElement Class](../wmi-provider/tagmapelement-class.md)
 [TagMapInfo Class](../wmi-provider/tagmapinfo-class.md)
 [TagPrefixElement Class](../wmi-provider/tagprefixelement-class.md)
 [TagPrefixInfo Class](../wmi-provider/tagprefixinfo-class.md)
 [CompilationMode Enumeration](https://go.microsoft.com/fwlink/?LinkId=69310)
