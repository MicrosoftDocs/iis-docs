---
title: "OdbcLoggingSection Class1 | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 0969e9a7-d1f5-58a6-f045-14e4ed271880
caps.latest.revision: 25
author: "shirhatti"
manager: "wpickett"
---
# OdbcLoggingSection Class1
Specifies configuration settings for logging IIS events to a database through an Open Database Connectivity (ODBC) connection.  
  
## Syntax  
  
```vbs  
class OdbcLoggingSection : ConfigurationSection  
```  
  
## Methods  
 The following table lists the methods exposed by the `OdbcLoggingSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|[GetAllowDefinition](../wmi-provider/configurationsection-getallowdefinition-method.md)|(Inherited from [ConfigurationSection](../wmi-provider/configurationsection-class1.md).)|  
|[GetAllowLocation](../wmi-provider/configurationsection-getallowlocation-method.md)|(Inherited from `ConfigurationSection`.)|  
|[RevertToParent](../wmi-provider/configurationsection-reverttoparent-method.md)|(Inherited from `ConfigurationSection`.)|  
|[SetAllowDefinition](../wmi-provider/configurationsection-setallowdefinition-method.md)|(Inherited from `ConfigurationSection`.)|  
|[SetAllowLocation](../wmi-provider/configurationsection-setallowlocation-method.md)|(Inherited from `ConfigurationSection`.)|  
  
## Properties  
 The following table lists the properties exposed by the `OdbcLoggingSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|`DataSource`|A read/write `string` value that specifies the system DSN (data source name) for the database to which the log is written. The default is "InternetDb".|  
|`Location`|(Inherited from `ConfigurationSection`.) A key property.|  
|`Password`|A read/write `string` value that specifies the ODBC database password used for writing to the database during event logging.|  
|`Path`|(Inherited from `ConfigurationSection`.) A key property.|  
|`SectionInformation`|(Inherited from `ConfigurationSection`.)|  
|`TableName`|A read/write `string` value that specifies the name of the ODBC database table where information is written during event logging. The default is "InternetLog".|  
|`UserName`|A read/write `string` value that specifies the ODBC database user name used for writing to the database during event logging. The default is "InternetAdmin".|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 ODBC logging allows the logging of IIS data to local Microsoft Access databases or to local or remote Microsoft SQL Server databases.  
  
## Example  
 The following code example specifies new values for the `DataSource`, `Tablename`, `Username`, and `Password` properties. A helper function displays the values before and after the change.  
  
```  
' Connect to the WMI WebAdministration namespace.  
Set oWebAdmin = GetObject( _  
    "winmgmts:root\WebAdministration")  
  
' Get the ODBCLoggingSection.  
Set oSection = oWebAdmin.Get("OdbcLoggingSection.Path=" & _  
    "'MACHINE/WEBROOT/APPHOST',Location=''")  
  
' Display the class name of the section.  
WScript.Echo "[ " & oSection.Path_.Class & " ]"  
  
' Display the initial values.  
Call DisplayValues("Initial Values", oSection)  
  
' Specify new ODBCLoggingSection property values.  
oSection.DataSource = "ODBCLoggingDB"  
oSection.TableName = "ODBCLoggingTable"  
oSection.Username = "ODBCLoggingAdmin"  
oSection.Password = "ODBCLoggingPassword"  
  
' Save the values to configuration.  
oSection.Put_  
  
' Refresh the oSection object variable with the new values.  
oSection.Refresh_  
  
' Show the changed values.  
Call DisplayValues("New Values", oSection)  
  
' ==== DisplayValues helper function. ====  
Function DisplayValues(HeadingText, oSection)  
    ' Display a heading.  
    WScript.Echo  
    WScript.Echo HeadingText  
    WScript.Echo String(Len(HeadingText), "-")  
  
    ' Display section properties.  
    WScript.Echo "Path: " & oSection.Path  
    WScript.Echo "Location: " & oSection.Location  
    WScript.Echo "DataSource: " & oSection.DataSource  
    WScript.Echo "TableName: " & oSection.TableName  
    WScript.Echo "Username: " & oSection.Username  
    WScript.Echo "Password: " & oSection.Password  
End Function  
  
```  
  
## Inheritance Hierarchy  
 [ConfigurationSection](../wmi-provider/configurationsection-class1.md)  
  
 `OdbcLoggingSection`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [CentralBinaryLogFile Class](../wmi-provider/centralbinarylogfile-class1.md)   
 [CentralW3CLogFile Class](../wmi-provider/centralw3clogfile-class1.md)   
 [ConfigurationSection Class](../wmi-provider/configurationsection-class1.md)   
 [HttpLoggingSection Class](../wmi-provider/httploggingsection-class1.md)   
 [LogSection Class](../wmi-provider/logsection-class1.md)   
 [SiteLogFile Class](../wmi-provider/sitelogfile-class1.md)   
 [How to configure ODBC logging in IIS](http://go.microsoft.com/fwlink/?LinkId=62470)