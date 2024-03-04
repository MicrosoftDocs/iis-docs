---
title: "Scenario: Build an FTP Site on IIS"
author: rmcmurray
description: "File Transfer Protocol (FTP) simple is a protocol for transferring files between computer systems. IIS 8 includes an FTP server that is easy to configure. Th..."
ms.date: 04/14/2013
ms.assetid: c85c0160-ae3d-4fe9-a1c6-c1e24d3858aa
msc.legacyurl: /learn/publish/using-the-ftp-service/scenario-build-an-ftp-site-on-iis
msc.type: authoredcontent
---
# Scenario: Build an FTP Site on IIS

by Keith Newman and [Robert McMurray](https://github.com/rmcmurray)

File Transfer Protocol (FTP) simple is a protocol for transferring files between computer systems. IIS 8 includes an FTP server that is easy to configure.

The document shows how to install and configure the FTP server on an existing IIS 8 web server. The first two steps are required. All other steps are optional but recommended.

<a id="00"></a>

## Prerequisites

To get the most from this tutorial, you must have access to a computer that is running one of the following operating systems:

- Windows Server® 2012
- Windows® 8

<a id="01"></a>

## Step 1: Install FTP on an Existing IIS Web Server

This step shows you how to install the FTP service on an existing IIS web server that runs on either Windows Server 2012 or Windows 8.

### To install FTP on Windows Server 2012

1. On the **Start** screen, click the **Server Manager** tile, then click **Yes**.
2. In the **Server Manager Dashboard**, click **Add roles and features**.
3. If the **Before you begin** page of **Add Roles and Features Wizard** is displayed, click **Next**.
4. On the **Select installation type** page, select **Role-based or feature-based installation**, and click **Next**.
5. On the **Select destination server** page, select **Select a server from the server pool**, select your server from the **Server Pool** list, and then click **Next**.
6. On the **Select server roles** page, expand the **Web Server (IIS)** node, and then expand the **FTP Server** node.
7. Select the **FTP Server** check box and the **FTP Service** check box, and then click **Next**.
8. On the **Select features** page, click **Next**.
9. On the **Confirm installation selections** page, click **Install**.

### To install FTP on Windows 8

1. On the **Start** screen, type **Control Panel**, and then click the **Control Panel** icon in the search results.
2. Click **Programs**, and then click **Turn Windows features on or off**.
3. In the **Windows Features** dialog box, expand the **Internet Information Services** node.
4. Expand the **FTP Server** node.
5. Select the **FTP Server** check box and the **FTP Service** check box, and then click **OK**.

<a id="02"></a>

## Step 2: Add an FTP Site

Once the FTP service is installed on your IIS web server, you can add one or more FTP sites. Add an FTP site when you want to enable clients to transfer files to and from a site by using the File Transfer Protocol (FTP).

> [!NOTE]
> Because FTP settings are contained in the sites section, changing any FTP setting also forces website application recycling. If you want to avoid this side effect, add a site that is configured exclusively for FTP, instead of for both HTTP and FTP.

### To add an FTP site

1. Open IIS Manager.
2. In the **Connections** pane, expand the server node and click the **Sites** node.
3. In the **Actions** pane, click **Add FTP Site** to open the **Add FTP Site** wizard.
4. On the **Site Information** page, in the **FTP site name** box, type a unique friendly name for the FTP site.
5. In the **Physical path** box, type the physical path or click the browse button (**...**) to locate the physical path of the content directory.
6. Click **Next** to open the **Binding and SSL Settings** page.
7. Under **Binding**, in the **IP Address** list, select or type an IP address if you do not want the IP address to remain **All Unassigned**.
8. In the **Port** box, type the port number.
9. Optionally, in the **Virtual Host** box, type a host name if you want to host multiple FTP sites on a single IP address. For example, type `www.contoso.com`.
10. Clear the **Start FTP site automatically** box if you want to start the site manually.
11. Under **SSL**, from the **SSL Certificate** list, select a certificate. Optionally, click **View** to open the **Certificates** dialog box and verify information about the selected certificate.
12. Select one of the following options:

    - **Allow SSL**: Allows the FTP server to support both non-SSL and SSL connections with a client.
    - **Require SSL**: Requires SSL encryption for communication between the FTP server and a client.
13. Click **Next** to open the **Authentication and Authorization Information** page.
14. Under **Authentication**, select the authentication method or methods that you want to use:

    - **Anonymous**: Allows any user to access content providing only the user name **anonymous** or **ftp**. (Most, but not all, FTP clients enter user name for you automatically.)
    - **Basic**: Requires users to provide a valid user name and password to access content. Because Basic authentication transmits unencrypted passwords across the network, use this authentication method only when you know that the connection between the client and FTP server is secure, such as by using Secure Sockets Layer (SSL).
15. Under **Authorization**, from the **Allow access to** list, select one of the following options:

    - **All Users**: All users, whether they are anonymous or identified, can access the content.
    - **Anonymous Users**: Anonymous users can access the content.
    - **Specified Roles or User Groups**: Only members of certain roles or user groups can access the content. Type the role or user group in the corresponding box.
    - **Specified Users**: Only specified users can access the content. Type the user name in the corresponding box.
16. If you selected an option from the **Allow access to** list, select one or both of the following permissions:

    - **Read**: Permits authorized users to read content from the directory.
    - **Write**: Permits authorized users to write to the directory.
17. Click **Finish**.

<a id="03"></a>

## Step 3: Configure FTP Site Defaults

Change an FTP site default value when you want new FTP sites to use a different default value.

> [!NOTE]
> When you change a default value, existing sites are not overridden with the new value. Change the value for any existing sites manually.

### To configure FTP site defaults

1. Open IIS Manager.
2. In the **Connections** pane, click the server node and the **Sites** node.
3. In the **Actions** pane, click **FTP Site Defaults**.
4. Edit the settings, and then click **OK**.

The following table lists the settings available for configuration in the **FTP Site Defaults** dialog box.

| Setting Category | Setting Name | Description |
| --- | --- | --- |
| General | Allow UTF-8 | Specifies whether to use UTF8 encoding. Default is true. |
| General | Start Automatically | If true, the FTP site is started upon creation or when the FTP service is started. Default is true. |
| Connections | Control Channel Time-out | Specifies the time-out (in seconds) when a connection times out due to inactivity. |
| Connections | Data Channel Time-out | Specifies the time-out (in seconds) when the data channel times out due to inactivity. |
| Connections | Disable Socket Pooling | Specifies whether socket pooling is used for sites distinguished by IP address rather than port number or host name. |
| Connections | Max Connections | Specifies the maximum simultaneous connections to a server. |
| Connections | Reset On Max Connections | Specifies whether to disconnect FTP session when sending max connections response. |
| Connections | Server Listen Backlog | Specifies the number of outstanding sockets that can be queued. |
| Connections | Unauthenticated Time-out | Specifies the timeout (in seconds) between when a new connection is made and authentication succeeds. |
| Credential Caching | Enabled | Specifies whether credential caching is enabled for the FTP service. |
| Credential Caching | Flush Interval | Specifies the cache lifetime, in seconds, for the credentials that are stored in the cache. |
| File Handling | Allow Reading Files While Uploading | Specifies whether files can be read while being transferred to the server. |
| File Handling | Allow Replace on Rename | Specifies whether files can overwrite other files when renamed. |
| File Handling | Keep Partial Uploads | Specifies whether to keep files that have been partially uploaded. |

<a id="04"></a>

## Step 4: Configure Firewall Support

Use the **FTP Firewall Support** feature to configure the following settings that enable the FTP server to accept passive data connections from a firewall:

- **Data Channel Port Range**: Specify a range of ports for passive data connections. You must also open that same range of ports on your firewall. This option can only be configured at the server-level, and the port range of &quot;0-0&quot; means to use the ephemeral port range of the server. An ephemeral port is a short-lived transport protocol port that TCP/IP allocates from a predefined range.
- **External IP Address of Firewall**: Specify the external IP address of your firewall so that clients know which IP address to use when they communicate with the FTP server through the firewall.

### To configure firewall support

1. Open IIS Manager.
2. In the **Connections** pane, select the server node.
3. In **Features View**, double-click **FTP Firewall Support**.
4. In the **Data Channel Port Range** box, type a range of port numbers (separated by a hyphen). For example, type **5000-6000**. Or type **0-0** to use the default port range specified in Windows TCP/IP settings.

    > [!NOTE]
    > Do not use ports 0-1024 because these ports are reserved ports.

5. In the **External IP Address of Firewall** box, type the IP address of your firewall.
6. In the **Actions** pane, click **Apply**.

<a id="05"></a>

## Step 5: Configure User Isolation

The user isolation feature allows you to configure your FTP server to isolate users, which prevents users from accessing the directories of other users on the same FTP site. If you choose not to isolate users, they share a common directory structure.

For example, you can choose not to isolate users on a site that offers only download capabilities for shared content or for a site that does not require the protection of data between users.

If you want to isolate users on your site, you can choose one of the following isolation options:

1. **User name directory**: Isolates user sessions to the physical or virtual directory with the same name of the FTP user account. The user sees only their FTP root location and is, therefore, restricted from navigating higher up the physical or virtual directory tree. Any global virtual directories that are created are ignored.
2. **User name physical directory**: Isolates user sessions to the physical directory with the same name of the FTP user account. The user sees only their FTP root location and is, therefore, restricted from navigating higher up the physical directory tree. Any global virtual directories that are created apply to all users.
3. **FTP home directory configured in Active Directory**: Isolates user sessions to the home directory that is configured in the Active Directory account settings for each FTP user.

### To configure user isolation

1. Open IIS Manager.
2. In **Features View**, double-click **FTP User Isolation**.
3. If you don't want to isolate users, under **Do not isolate users. Start users in**, select one of the following options:

    - **FTP root directory**: specifies that all FTP sessions start in the root directory for the FTP site. This option disables all user isolation and starting folder logic.
    - **User name directory**: specifies that all FTP sessions start in the physical or virtual directory with the same name of the currently logged-on user if the folder exists; otherwise, the FTP session starts in the root directory for the FTP site.
4. If you want to isolate users, under **Isolate users. Restrict users to the following directory**, select one of the following options:

    - **User name directory (disable global virtual directories)**: isolates user sessions to the physical or virtual directory with the same name of the FTP user account.
    - **User name physical directory (enable global virtual directories)**: isolates user sessions to the physical directory with the same name of the FTP user account.
    - **FTP home directory configured in Active Directory**: isolates user sessions to the home directory that is configured in the Active Directory account settings for each FTP user.
    - **Custom**: This option is an advanced feature, and enables developers to create custom providers that provide home directory lookups based on their unique business needs.
5. If you selected **FTP home directory configured in Active Directory** in the previous step, click the **Set** button, and then type a user name and password in the **User name** and **Password** boxes of the **Set Credentials** dialog box that has access to your Active Directory server. Enter the password again in the **Confirm Password** box, then click **OK**.
6. In the **Actions** pane, click **Apply**.

<a id="06"></a>

## Step 6: Configure Directory Browsing Options

The directory browsing feature gives you control over what is displayed when users browse FTP directories.

### To configure directory browsing options

1. Open IIS Manager.
2. In the **Connections** pane, select either the server level or the site level.
3. In **Features View**, double-click **FTP Directory Browsing**.
4. On the **FTP Directory Browsing** page, under **Directory Listing Style**, select one of the following options:

    - **MS-DOS**: Displays directory content in a manner consistent with MS-DOS.
    - **UNIX**: Displays directory content in a manner consistent with UNIX.
5. Under **Directory Listing Options**, select the information you want to display in directory listings. You can select any of the following options:

    1. **Virtual directories**: Shows virtual directories.
    2. **Available bytes**: Displays file size in bytes.
    3. **Four-digit years**: Displays years by using four digits rather than two.
6. In the **Actions** pane, click **Apply**.

<a id="07"></a>

## Step 7: Configure Logon Attempt Restrictions

This feature enables you to configure the maximum number of failed sign-on attempts that you allow within a specified time before the IP address is denied.

### To configure logon attempt restrictions

1. Open IIS Manager.
2. In the **Connections** pane, select the server level.
3. In **Features View**, double click **FTP Logon Attempt Restrictions**.
4. On the **FTP Logon Attempt Restrictions** page, select the **Enable FTP Logon Attempt Restrictions** check box.
5. In the **Maximum number of failed login attempts** box, type a positive integer. The default value is 4.
6. In the **Time period (in seconds)** box, type a positive integer. The default is 30.
7. Select either **Deny IP addresses based on the number of failed login attempts** or **Write to the log only**. If you choose **Write to the log only**, IIS will not restrict clients even if the maximum number of failed attempts is exceeded.
8. In the **Actions** page, click **Apply**.

<a id="08"></a>

## Step 8: Configure Request Filtering

Use the **FTP Request Filtering** feature page to define the request filtering settings for your FTP site. FTP request filtering is a security feature that allows internet service providers (ISPs) and application service providers to restrict protocol and content behavior.

### To configure request filtering

1. Open IIS Manager.
2. In the **Connections** pane, select either the server level or the site level.
3. In **Feature View**, double click the **FTP Request Filtering** icon.
4. To change the general request filtering settings, click **Edit Feature Settings** in the **Actions** pane. Then edit the general settings as required.
5. To add a filter based on file name extensions, select the **File Name Extension** tab. In the **Actions** pane, click either **Allow File Name Extension** or **Deny File Name Extensions**. Then type the extension in the **File name extension** box, and click **OK**.
6. To add a filter based on a URL segment (for example, a folder name), select the **Hidden Segments** tab. In the Actions pane, click **Add Hidden Segment**. Then type the segment in the **Hidden segment** box, and click **OK**.
7. To add a filter based on a URL sequence, select the **Denied URL Sequences** tab. In the **Actions** pane, click **Add URL Sequence**. Then type the sequence in the **URL sequence** box, and click **OK**.
8. To add a filter based on a command, select the **Commands** tab. In the **Actions** pane, click either **Allow Command** or **Deny Command**. Then type the command in the **Command** box, and click **OK**. (**Warning**: The ability to add a command-based filter is an advanced feature. If you use this feature incorrectly, you could deny access to all FTP clients on your server.)

<a id="09"></a>

## Step 9: Configure FTP Logging

You can use the **FTP Logging** feature to configure logging features at the server or site level, and to configure logging settings.

### To configure FTP logging

1. Open IIS Manager.
2. In the **Connections** pane, select either the server level or the site level.
3. In **Feature View**, double click the **FTP Logging** icon.
4. In the **One log file per** menu, select either **Site** or **Server**.
5. Under **Log File**, click **Select W3C Fields**, and then select the information you want go log.
6. Under **Directory**, either type the path to the base folder where you want the FTP log files stored, or click **Browse** to browse to the base folder.
7. Under **Encoding**, select either **UTF8** (single-byte and multi-byte characters) or **ANSI** (single-byte characters only).
8. Under **Log File Rollover**, select how you want FTP to create new log files from the following list:

    1. **Schedule**: select **Hourly**, **Daily**, **Weekly**, or **Monthly** to create new log files on a fixed time interval.
    2. **Maximum file size (in bytes)**: enter a positive integer to create new log files when the file size exceeds that number of bytes.
    3. **Do not create new log files**
9. Select the **Use local time for file naming and rollover** check box when you want log file naming and rollover to be based on the local time zone instead of Coordinated Universal Time (UTC).
10. In the **Actions** pane, click **Apply**.

<a id="10"></a>

## Step 10: Configure FTP Messages

Use the **FTP Messages** feature to modify the settings for messages sent when a user connects to your FTP site.

### To configure FTP messages

1. In the **Connections** pane, select either the server level or the site level.
2. In **Features View**, double-click **FTP Messages**.
3. On the **FTP Messages** page, under **Message Behavior**, select how you want your FTP messages to behave. You can select any of the following options:

    - **Suppress default banner**: Specifies whether to display the default identification banner for the FTP server.
    - **Support user variables in messages**: Specifies whether to display a specific set of user variables in FTP messages. The following user variables are supported:

        - **%BytesReceived%** - The number of bytes sent from the server to the client for the current session.
        - **%BytesSent%** - The number of bytes sent from the client to the server for the current session.
        - **%SessionID%** - The unique identifier for the current session.
        - **%SiteName%** - The name of the FTP site that is hosting the current session.
        - **%UserName%** - The account name of the currently logged-on user.
    - **Show detailed messages for local requests**: Specifies whether to display detailed error messages when the FTP client is connecting to the FTP server on the server itself (local host).
4. Under Message Text, type messages in the following boxes:

    - **Banner**: Specifies the message the FTP server displays when FTP clients first connect to the FTP server.
    - **Welcome**: Specifies the message the FTP server displays when FTP clients have logged in to the FTP server.
    - **Exit**: Specifies the message the FTP server displays when FTP clients log off the FTP server.
    - **Maximum Connections**: Specifies the message the FTP server displays when clients try to connect and cannot because the FTP service has reached the maximum number of client connections allowed.
5. In the **Actions** pane, click **Apply**.

## See Also

- [Hosting-Friendly Web Server Platform (IIS): Scenario Overview](../../get-started/introduction-to-iis/hosting-friendly-web-server-platform-iis-scenario-overview.md)
- [Build a Static Website on IIS](../../manage/creating-websites/scenario-build-a-static-website-on-iis.md)
- [Build an ASP.NET Website on IIS](../../application-frameworks/scenario-build-an-aspnet-website-on-iis/overview-build-an-asp-net-website-on-iis.md)
- [Build a Web Farm with IIS Servers](../../web-hosting/scenario-build-a-web-farm-with-iis-servers/overview-build-a-web-farm-with-iis-servers.md)
