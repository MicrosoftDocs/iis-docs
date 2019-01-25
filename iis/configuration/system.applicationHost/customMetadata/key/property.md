---
title: "Custom Metadata Key Property &lt;property&gt;"
author: rick-anderson
description: "Overview The &lt;property&gt; element of the &lt;key&gt; element adds a metabase property to the collection of metabase properties. Important Note : The &lt;..."
ms.date: 09/26/2016
ms.assetid: fb89339d-de4a-40c3-9bd7-aa0770041da8
msc.legacyurl: /configreference/system.applicationhost/custommetadata/key/property
msc.type: config
---
Custom Metadata Key Property &lt;property&gt;
====================
<a id="001"></a>
## Overview

The `<property>` element of the `<key>` element adds a metabase property to the collection of metabase properties.

> [!IMPORTANT]
> The `<customMetadata>` section of the configuration should not be modified directly. Use the metabase APIs to set any metabase settings that are represented in this section.

In IIS 6.0, all of the IIS settings were kept in the metabase. In addition, any custom settings that were required by applications were stored in the metabase. In IIS 7, all IIS settings are now kept in ApplicationHost.config and Web.config Files. IIS 7 provides backwards-compatibility through the IIS 6 Metabase Compatibility feature, which is sometimes referred to as the Admin Base Object (ABO) mapper component. This feature listens for applications that attempt to write to the metabase, and maps all IIS 6.0 metabase settings to their IIS 7 equivalents. If an IIS 6.0 setting has no IIS 7 equivalent, the setting will be written to the `<customMetadata>` element.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<property>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<property>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<property>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<property>` element was not modified in IIS 7.5. |
| IIS 7.0 | The `<property>` element of the `<key>` element was introduced in IIS 7.0. |
| IIS 6.0 | The `<customMetadata>` element replaces any IIS 6.0 metabase objects that are not directly mapped to IIS 7 configuration elements. |

<a id="003"></a>
## Setup

The `<customMetadata>` element is not available on the default installation of IIS 7 and later. To install it, use the following steps.

### Windows Server 2012 or Windows Server 2012 R2

1. On the taskbar, click **Server Manager**.
2. In **Server Manager**, click the **Manage** menu, and then click **Add Roles and Features**.
3. In the **Add Roles and Features** wizard, click **Next**. Select the installation type and click **Next**. Select the destination server and click **Next**.
4. On the **Server Roles** page, expand **Web Server (IIS)**, expand **Management Tools**, expand **IIS 6 Management Compatibility**, and then select **IIS 6 Metabase Compatibility**. Click **Next**.  
    [![](property/_static/image2.png)](property/_static/image1.png) .
5. On the **Select features** page, click **Next**.
6. On the **Confirm installation selections** page, click **Install**.
7. On the **Results** page, click **Close**.

### Windows 8 or Windows 8.1

1. On the **Start** screen, move the pointer all the way to the lower left corner, right-click the **Start** button, and then click **Control Panel**.
2. In **Control Panel**, click **Programs and Features**, and then click **Turn Windows features on or off**.
3. Expand **Internet Information Services**, expand **Web Management Tools**, expand **IIS 6 Management Compatibility**, and then select **IIS Metabase and IIS 6 configuration compatibility**.  
    [![](property/_static/image4.png)](property/_static/image3.png)
4. Click **OK**.
5. Click **Close**.

### Windows Server 2008 or Windows Server 2008 R2

1. On the taskbar, click **Start**, point to **Administrative Tools**, and then click **Server Manager**.
2. In the **Server Manager** hierarchy pane, expand **Roles**, and then click **Web Server (IIS)**.
3. In the **Web Server (IIS)** pane, scroll to the **Role Services** section, and then click **Add Role Services**.
4. On the **Select Role Services** page of the **Add Role Services Wizard**, select **IIS 6 Metabase Compatibility**, and then click **Next**.  
    [![](property/_static/image6.png)](property/_static/image5.png)
5. On the **Confirm Installation Selections** page, click **Install**.
6. On the **Results** page, click **Close**.

### Windows Vista or Windows 7

1. On the taskbar, click **Start**, and then click **Control Panel**.
2. In **Control Panel**, click **Programs and Features**, and then click **Turn Windows Features on or off**.
3. Expand **Internet Information Services**, then select **IIS Metabase and IIS 6 configuration compatibility**, and then click **OK**.  
    [![](property/_static/image8.png)](property/_static/image7.png)
 
<a id="004"></a>
## How To

The `<customMetadata>` section of the configuration should not be modified directly; therefore, no examples are available.

<a id="005"></a>
## Configuration

### Attributes

| Attribute | Description |
| --- | --- |
| `id` | Optional unit attribute.<br><br>Specifies the unique identifier of the metabase entry. |
| `dataType` | Required enum attribute.<br><br>Specifies the type of data to retrieve.<br><br>The **dataType** attribute can be one of the following possible values. <table> <tbody> <tr> <th>Value</th> <th>Description</th></tr> <tr> <th><code>DWord</code></th> <td>An unsigned 32-bit number.<br><br>The numeric value is <code>1</code>. </td></tr> <tr> <th><code>String</code></th> <td>A null-terminated ASCII string.<br><br>The numeric value is <code>2</code>. </td></tr> <tr> <th><code>Binary</code></th> <td>Binary data in any form.<br><br>The numeric value is <code>3</code>. </td></tr> <tr> <th><code>ExpandSZ</code></th> <td>A null-terminated string that contains unexpanded environment variables, such as %PATH%.<br><br>The numeric value is <code>4</code>. </td></tr> <tr> <th><code>MultiSZ</code></th> <td>An array of null-terminated strings, terminated by two null characters.<br><br>The numeric value is <code>5</code>. </td></tr></tbody></table> |
| `userType` | Optional unit attribute. Specifies the user type of the data. <br><br> The default value is `1`. |
| Attributes | Optional flags attribute.<br><br>Specifies the flags, contained in the [METADATA\_RECORD](https://msdn.microsoft.com/en-us/library/ms524635.aspx) structure, that are used to get the data.<br><br>The attributes attribute can be one of the following possible values.<br><br>The default value is `Inherit`. <table> <tbody> <tr> <th>Value</th> <th>Description</th></tr> <tr> <th><code>None</code></th> <td>Specifies that no flags are set.<br><br>The numeric value is <code>0</code>. </td></tr> <tr> <th><code>Inherit</code></th> <td>Specifies that the data can be inherited.<br><br>The numeric value is <code>1</code>. </td></tr> <tr> <th><code>PartialPath</code></th> <td>Returns any inherited data even if the complete path is not available. This flag is only valid when the Inherit flag is also set.<br><br>The numeric value is <code>2</code>. </td></tr> <tr> <th><code>Secure</code></th> <td>Specifies that the data is stored and transported in a secure manner.<br><br>The numeric value is <code>4</code>. </td></tr> <tr> <th><code>Reference</code></th> <td>Specifies that the data was retrieved by reference.<br><br>The numeric value is <code>8</code>. </td></tr> <tr> <th><code>Volatile</code></th> <td>Specifies that the data is not stored in long-term storage.<br><br>The numeric value is <code>16</code>. </td></tr> <tr> <th><code>IsInherited</code></th> <td>Denotes that the data items were inherited.<br><br>The numeric value is <code>32</code>. </td></tr> <tr> <th><code>InsertPath</code></th> <td>Replaces MD_INSERT_PATH_STRINGW with the path of the data item relative to the handle.<br><br>The numeric value is <code>64</code>. </td></tr> <tr> <th><code>LocalMachineOnly</code></th> <td>Specifies that the data is not replicated during web cluster replication.<br><br>The numeric value is <code>128</code>. </td></tr> <tr> <th><code>NonSecureOnly</code></th> <td>Specifies that secure properties should not be retrieved when using metabase functions that return all data.<br><br>The numeric value is <code>256</code>. </td></tr></tbody></table> |
| `Value` | Optional case-sensitive string attribute.<br><br>Specifies a custom value. |

### Child Elements

None.

<a id="006"></a>
## Sample Code

The `<customMetadata>` section of the configuration should not be modified directly; therefore, no examples are available.