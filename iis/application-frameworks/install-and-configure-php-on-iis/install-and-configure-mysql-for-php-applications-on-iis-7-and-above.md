---
title: "Install and Configure MySQL for PHP Applications on IIS 7"
author: ruslany
description: "While Microsoft ® SQL Server ® 2008 is the recommended database to use when hosting PHP applications on an Internet Information Services 7 (IIS 7) and above..."
ms.date: 02/14/2008
ms.assetid: c65623d5-5bf5-4bed-8dbc-87245bb621bc
msc.legacyurl: /learn/application-frameworks/install-and-configure-php-on-iis/install-and-configure-mysql-for-php-applications-on-iis-7-and-above
msc.type: authoredcontent
---
# Install and Configure MySQL for PHP Applications on IIS 7

by [Ruslan Yakushev](https://github.com/ruslany)

## Introduction

While Microsoft® SQL Server® 2008 is the recommended database to use when hosting PHP applications on an Internet Information Services 7 (IIS 7) and above Web server, you can also use MySQL as the database. Currently, many popular PHP applications use MySQL Server for data storage. Using MySQL requires hosting providers to include MySQL database support with the hosting packages.

MySQL cannot currently be installed with the Microsoft® Web Platform Installer (Web PI). This article provides guidance for installing MySQL manually.

## Install MySQL Server on Windows Server 2008 or Windows Server 2008 R2

It is recommended that you install MySQL on a dedicated server rather than installing MySQL on the same server that is running IIS. The separation of database server and Web server makes overall installation more secure and manageable and avoids resource contentions between the database and Web server processes.

1. Download **[MySQL Community Server](https://dev.mysql.com/downloads/)**. We recommend downloading Windows® Installer.
2. Start **Windows Installer**, or extract all the files from the archive, and then start **Setup.exe**.
3. You can use a **Typical Setup** or customize the installation to suit your needs.
4. Once the installation wizard is completed, it is recommended that you leave the **Configure the MySQL Server now** check box selected.

## Configure a MySQL Instance

1. Run the **MySQL Server Instance Configuration Wizard**, and then choose the configurations options that most closely match your environment.   
 For more information, see the [Server Instance Configuration Wizard](https://dev.mysql.com/doc/refman/5.0/en/mysql-config-wizard.html).   
 Best practice recommendations are as follows:  

    - Click **Next** in the **Instance Configuration Wizard**.
    - Select **Detailed Configuration**, and then click **Next**.
    - Select a server type that best suits your environment. It is recommended to set up a separate MySQL server; when prompted to select a server type, select **Dedicated MySQL Server Machine**, and then click **Next**.
    - Select a database option, and then click **Next**.  

        - Select either the **Multifunctional Database** or **Transactional Database Only** options if you are using the InnoDB storage engine or the high-speed MyISAM storage engine (for example, if the Web applications on your server require multi-statement transactions, advanced isolation levels and row-level locking, foreign key constraints, or atomic, consistent, isolated, and durable [ACID] features). These options provides fully ACID transactional capabilities, but at the cost of more aggressive usage of disk space and memory.
        - Otherwise, use the **Non-Transactional Database Only** option, which is optimized for high-performance SELECT operations. It has low overhead, in terms of memory usage and disk utilization, but at the cost of not supporting transactions.
    - Choose the option that sets the number of concurrent connections you need.  

        > [!NOTE]
        > Connections require memory; if the number you choose is too big, your server may not have enough memory.
    - You may adjust networking settings to suit your environment or accept defaults, and then click **Next**.
    - Select the default character set that best suits you, and then click **Next**.
    - We recommend enabling both Windows options here. Select both check boxes, and then click **Next**.
    - Type the *password* you want to use for the root account, and then click **Next**.
    - Click **Execute** to apply your settings.
    - Click **Finish** to close the wizard.

- For PHP to work with MySQL, it is necessary to perform the following modifications to the **Php.ini** file:  

  - Confirm that the **extension\_dir** points to the folder where all PHP loadable extensions are located, frequently in the Ext folder (for example, extension\_dir=".\ext").
  - Enable dynamic extension for MySQL by uncommenting the corresponding line for the MySQL extension: **extension=php\_mysql.dll**
  - c. Save and close the **Php.ini** file.

### Secure MySQL

1. Remove the anonymous database account (if it exists). Open the MySQL command prompt by clicking **Start -&gt; All Programs -&gt; MySQL -&gt; MySQL Server 5.1 -&gt; MySQL Command Line Client**:
2. Enter the *password* for the root account.
3. Once logged on to MySQL, use the following sequence of commands:  

    [!code-sql[Main](install-and-configure-mysql-for-php-applications-on-iis-7-and-above/samples/sample1.sql)]
4. Next, restrict the root account to log on only from localhost. Open a MySQL command prompt, and use the following sequence of commands:  

    [!code-sql[Main](install-and-configure-mysql-for-php-applications-on-iis-7-and-above/samples/sample2.sql)]
5. Change the name of the root user with the following sequence of commands from the command prompt:  

    [!code-sql[Main](install-and-configure-mysql-for-php-applications-on-iis-7-and-above/samples/sample3.sql)]

## Provision the User and Database

1. To provision a new user, type the following command from the MySQL command prompt:  

    [!code-console[Main](install-and-configure-mysql-for-php-applications-on-iis-7-and-above/samples/sample4.cmd)]
2. The newly created user does not have any privileges on the MySQL server by default. To create a new database, type the following command:  

    [!code-console[Main](install-and-configure-mysql-for-php-applications-on-iis-7-and-above/samples/sample5.cmd)]
3. To grant access to this database for a particular user, type the following command:  

    [!code-console[Main](install-and-configure-mysql-for-php-applications-on-iis-7-and-above/samples/sample6.cmd)]

## Configure PHP to Access MySQL

1. Open the `c:\php\php.ini` file with your favorite text editor.
2. Uncomment the following lines by removing the semicolon:  

    [!code-console[Main](install-and-configure-mysql-for-php-applications-on-iis-7-and-above/samples/sample7.cmd)]
3. Restart the IIS service by clicking on **Start**, selecting the **Search Field**, typing **iisreset**, and then pressing ENTER.
4. If all went well, you should see the **mysqli** section on the PHP information page created earlier `http://localhost/phpinfo.php`.

    ![Table listing Mysqli version information.](install-and-configure-mysql-for-php-applications-on-iis-7-and-above/_static/image2.jpg)

    *Figure 1: The mysqli section on the PHP information page*

## Best Practices for MySQL

- **Enable TCP/IP Networking** — This is the default. Keep the TCP port that MySQL uses to listen at 3306. If the database will be running on a separate system from the Web server, select the **Add firewall exception for this port** check box.
- **Include Bin Directory in Windows PATH** — This makes the MySQL utilities available from the command prompt or from Windows PowerShell™.
- **Create an Anonymous Account** — The default is to keep this disabled. Adding anonymous user support may create a security risk for the database; additionally, enabling anonymous users causes the GRANT statements used to set up database to be unreliable.

## See also

- [MySQL Server Web site](https://dev.mysql.com/doc/)
- [Using the MySQL Installation Wizard](https://dev.mysql.com/doc/refman/5.0/en/windows-install-wizard.html)
- [Installing MySQL from a Noinstall Zip Archive](https://dev.mysql.com/doc/refman/5.0/en/windows-install-archive.html)
- [MySQL Windows Installation](https://dev.mysql.com/doc/refman/5.0/en/windows-installation.html)
