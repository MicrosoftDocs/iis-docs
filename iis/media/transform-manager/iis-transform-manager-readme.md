---
title: "IIS Transform Manager Readme"
author: rick-anderson
description: "IIS Transform Manager 1.0 is an extensible media transform engine that enables 'watch folder' job submission, queuing, management, integrated media transcodi..."
ms.date: 06/23/2011
ms.assetid: d2809ee8-0973-4be1-959a-42280c68f61b
msc.legacyurl: /learn/media/transform-manager/iis-transform-manager-readme
msc.type: authoredcontent
---
# IIS Transform Manager Readme

by Dave Nelson

[IIS Transform Manager 1.0](https://go.microsoft.com/?linkid=9735186) is an extensible media transform engine that enables "watch folder" job submission, queuing, management, integrated media transcoding/transmuxing, and batch-encryption of on-demand audio and video files. One example of a media transform is transcoding Windows Media-formatted and MP4-formatted files, or other encoder-supported file formats, to on-demand Smooth Streams for delivery to Smooth Streaming-compatible clients (such as Silverlight). Another example is transmuxing Smooth Streaming fragments encoded with H.264 (AVC) video and AAC-LC audio codecs to MPEG-2 Transport Stream (MPEG-2 TS) segments for delivery to Apple® mobile digital devices. Transform Manager can be integrated with the [IIS Smooth Streaming](https://go.microsoft.com/?linkid=9735190) feature in IIS Media Services, which delivers the "transformed" content.

## Licensing

IIS Transform Manager is designed to work with other programs, such as programs handling audio or video signals. It's solely your responsibility to ensure your compliance with any terms accompanying such other programs, and that you have obtained any necessary rights for your use of the programs.

## Installation Notes

This section describes the installation requirements for IIS Transform Manager 1.0.

### Requirements

The following prerequisites must be fulfilled to install IIS Transform Manager:

- You must use IIS 7 running on one of the following operating systems: 

  - Windows Server 2008 R2
  - Windows 7
- To manage the Transform Manager feature using the IIS Manager user interface, the **IIS Management Console** for IIS must be installed.
- To manage the Transform Manager feature using the IIS Manager user interface, [.NET Framework 3.5 Service Pack 1 (SP1)](https://go.microsoft.com/?linkid=9735191) must be installed.
- You must be an administrator on the computer. This can be accomplished by logging on to the computer using either the Administrator account or an account with administrative privileges.

The default installation of Transform Manager includes an **Expression Encoder 4 SP2** transcoding task that uses encoding presets that require the encoding profiles and Silverlight player templates provided by [Microsoft® Expression Encoder 4](https://go.microsoft.com/?linkid=9735194). Because you can choose from a variety of encoding presets, be sure to install the edition of Expression Encoder 4 that meets your needs. H.264 encoding presets and GPU-encoding are only supported by Expression Encoder 4 Pro. VC-1 encoding presets are supported by Expression Encoder 4 Pro and by Expression Encoder 4, which is included in a free Trial version of Expression Studio 4.

After installing your edition of Expression Encoder 4, you must then install [Microsoft Expression Encoder 4 with Service Pack 2 (SP2)](https://go.microsoft.com/?linkid=9770510).

> [!NOTE]
> If you purchased Expression Studio 3 from a store, and it's installed on your computer, you can download the Trial version of Expression Studio 4 Ultimate or Expression Studio 4 Web Professional, and the full version of Expression Studio 4 (which includes Expression Encoder 4 Pro) will automatically be enabled. If you choose to not purchase Expression Studio 3, you can download a 60-day free Trial of Expression Studio 4. However, the trial version of Expression Encoder 4 Pro that's enabled doesn't support H.264-encoding and you can only run the **Expression Encoder 4 SP2** transcoding task with VC-1-encoding presets. For more information, see [How to Upgrade](https://go.microsoft.com/?linkid=9770534).

The following software must be installed on the computer to use Expression Encoder 4:

- [.NET Framework 4](https://go.microsoft.com/?linkid=9735195)
- [Desktop Experience](https://go.microsoft.com/?linkid=9735196) (server operating systems only)

> [!NOTE]
>
> - You can integrate Transform Manager with a High Performance Computing (HPC) cluster. These computers run the [Windows HPC Server](https://go.microsoft.com/?linkid=9770530) operating system, a solution built on Windows Server technology that provides a platform for clustering computers to perform computation-intensive tasks, such as encoding, without specialized hardware. You can configure a local watch folder to use the HPC Task Scheduler on the head node in the HPC cluster. The HPC Task Scheduler will assign the jobs to compute nodes in the cluster and the CPU resources on the compute nodes will be used for running jobs.
> - If you plan to use the default **Expression Encoder 4 SP2** task in an HPC Cluster, you must run the HPC compute nodes on the Windows Server 2008 R2 operating system. The Windows HPC Server operating system doesn't include the Desktop Experience feature, which is required for encoding and transcoding tasks using Expression Encoder 4. For more information about how to configure Transform Manager to use an HPC cluster for transcoding media files to IIS Smooth Streaming format, using Expression Encoder presets, see [High-Performance Transcoding with IIS Transform Manager and Windows HPC Server](https://go.microsoft.com/?linkid=9770531).

### Downloading and Installing

IIS Transform Manager 1.0 can be installed by using either Microsoft Web Platform Installer (Web PI) or Windows Installer.

**Install Using Web PI**

1. Go to the [Microsoft Web Platform Installer webpage](https://go.microsoft.com/?linkid=9735198) and click **Download It Now** to download and run Web PI.
2. At the bottom of the **Web Platform Installer** dialog box, click **Options**.
3. In the **Change Options** dialog box, in **Select your preferred language for software installations**, select your preferred language, and then click **OK**.
4. Back in the **Web Platform Installer** dialog box, at the top of the dialog box, click **Products** in the **Spotlight** – **Products** – **Applications** row of options.
5. In the Contents pane, click **All**.
6. In the list of products that is displayed, click the **Add** button for **IIS Transform Manager 1.0 RTW**, and then click **Install**.

**Install Using Windows Installer**

Two separate downloadable installation packages are available for IIS Transform Manager 1.0. Click one of the following links to download the Windows Installer (.msi) file for your edition of Windows:

- [IIS Transform Manager 1.0 RTW (32-bit)](https://go.microsoft.com/?linkid=9735203)
- [IIS Transform Manager 1.0 RTW (64-bit)](https://go.microsoft.com/?linkid=9735204)

Follow the instructions on the **Download details** page to install the software.

### Upgrading from a Previous Version of IIS Transform Manager

Upgrading from previous versions of IIS Transform Manager to IIS Transform Manager 1.0 RTW isn't supported. You must uninstall the previous version of the software before you can install the RTW version. In addition, you must also uninstall any Expression Encoder task packages that you downloaded from Microsoft Connect that worked with previous versions of Transform Manager before you can install the RTW version.

### Uninstalling

To remove IIS Transform Manager, in **Control Panel** &gt; **Programs** &gt; **Programs and Features**, under **Uninstall or change a program**, click **IIS Transform Manager 1.0**, and then click **Uninstall**.

## Known Issues

This section describes the known issues for IIS Transform Manager 1.0.

- **Job templates and watch folders from a previous version of Transform Manager might not work or might be missing**. If you used an older version of Transform Manager, and then install the RTW version on the same computer, some job templates and watch folders might not work or might not be displayed in IIS Manager. This issue occurs for certain job templates that use tasks with assembly names that have changed in the RTW version. You can create new job templates that use the same settings as the old ones, or update the task assembly names in the **taskCode** property in the definition files for the affected tasks, which are located in `%SystemDrive%\ProgramData\Microsoft\IIS\Transform Manager\Configuration\Task Definitions`.

    | Task Name | Old Assembly Name | New Assembly Name |
    | --- | --- | --- |
    | Expression Encoder 4 | Microsoft.Web.Media.TransformManager.EETask | Microsoft.Web.Media.TransformManager.EE40SP2Task |
    | Smooth Streams to Apple HTTP Live Streams | Microsoft.Web.Media.TransformManager.Fmp42tsTask | Microsoft.Web.Media.TransformManager.SmoothToHLS |

- **Starting the Transform Manager service**. You must configure credentials for the Transform Manager service and start the service in IIS Manager so that permissions to resources for the user account that the Transform Manager service impersonates are configured correctly. Unexpected results can occur if you start the IIS Transform Manager Host service in the Services console, and then try to configure Transform Manager workflows in IIS Manager. For more information about how to create credentials for the Transform Manager service in IIS Manager, see [Configuring the Transform Manager Service](https://go.microsoft.com/?linkid=9770518).
- **Resetting the password for the Transform Manager service account**. If you reset the password for the user account that the Transform Manager service uses to log on, the user account will be removed from the credential store for the account and you won't be able to start the Transform Manager service after the user logs off. For more information about how to update the password of the user account for the IIS Transform Manager Host service, see [Configuring the Transform Manager Service](https://go.microsoft.com/?linkid=9770518).
- **Resetting the password for a watch folder impersonation account**. If you reset the password for the user account that the watch folder impersonates, the user account will be removed from the credential store for the account and you won't be able to start the watch folder. For more information about how to update the password of the user account that the watch folder impersonates, see [Creating Watch Folder Impersonation Accounts](https://go.microsoft.com/?linkid=9801075).
- **Storing user account credentials for network authentication**. If the Transform Manager computer's network access policy prevents Credential Manager from storing user account credentials on the computer for later use for domain authentication, the Transform Manager service might not start, or jobs might fail, with the error "A specified logon session does not exist. (HRESULT: 0x80070520)." If this occurs, update the security policy to enable storage of user account credentials by doing the following:  

    1. Open the Microsoft Management Console (MMC) **Local Security Policy** snap-in (click **Start**, click **Run**, type **secpol.msc** in the **Run** dialog box, and then click **OK**.
    2. In the navigation pane, expand **Local Policies**, and then click **Security Options**.
    3. In the console pane, right-click the **Network access: Do not allow storage of passwords and credentials for network authentication** policy, and then click **Properties**.
    4. In the **Properties** page, on the **Local Security Setting** tab, click **Disabled**.
- **Enabling communication through a firewall**. Transform Manager uses port **59999** for management and monitoring services. You must open this port in your firewall. If the port is open in the firewall, but another program or service is configured to use the port, Transform Manager or the other program or service might not work as expected. If this occurs, you can configure Transform Manager to use another available port by doing the following:

    1. In Notepad, open the Transform Manager service configuration file (`%SystemDrive%\Program Files\IIS\Transform Manager\TransformManagerHost.exe.config`).
    2. Update the port value shown in the following endpoint addresses to an available port:

      - `<endpoint address="net.tcp://localhost:59999/TransformManager/Management/Management"`
      - `<endpoint address="net.tcp://localhost:59999/TransformManager/Management/mex"`
      - `<endpoint address="net.tcp://localhost:59999/TransformManager/Management/Monitoring"`

- **Running encoding tasks**. Encoding tasks can consume large amounts of memory and CPU resources. If not enough memory and/or CPU processing power is available, Expression Encoder might display a generic message with error code 813A0002. Aside from adding additional memory and/or CPU, you can adjust the following watch folder settings to reduce resource consumption: 

  - Reduce the **Concurrent jobs** value for the watch folder so that fewer jobs run simultaneously.
  - Set **Priority** values for all of your configured watch folders. Low-priority watch folders must wait for all jobs to finish in high-priority watch folders before their jobs can start.

  For more information about how to adjust these settings, see [Configuring Watch Folders](https://go.microsoft.com/?linkid=9735221).

    > [!NOTE]
    >  
    > - To reliably run the encoding tasks, your system must have a minimum of 3 GB of memory. On a 64-bit version of Windows, Expression Encoder opportunistically uses all of the memory that's available on your system. On a 32-bit version of Windows, memory usage is limited to 2 GB. However, if you have more memory available, you can configure Expression Encoder to recognize up to 3 GB. Expression Encoder has been compiled with the /LARGEADDRESSAWARE option, which enables you to increase the amount of memory to 3 GB if it's available. To enable this option, run the following command from an elevated command prompt: **BCDEDIT /Set IncreaseUserVa 3072**.
    > - The default **Expression Encoder 4 SP2** task in Transform Manager supports [GPU-Encoding](https://go.microsoft.com/?linkid=9770703) scenarios.

- **Running the Command Line task**. If you edit the default **Command Line** task in Transform Manager to run an executable program file, you must wrap the path to the executable program file name and the file-name extension in the command-line string in quotation marks if the path or file name contains spaces. For example, for an executable program file that is named My Program.exe, in the **Command line and arguments** box for the task, enter: `%DirectoryPath%\My Program.exe`.
- **Running the Maintenance command**. On a watch folder's **Maintenance** tab, you can use a Windows PowerShell cmdlet, an executable program file (.exe), a Windows command file (.cmd), or a batch file (.bat) that performs custom file maintenance actions. The file path that you enter in **Maintenance command** must also be wrapped in quotation marks if the path or file name contains spaces. For more information about how to configure Transform Manager to delete job and logs files from the computer when they're no longer needed, see [Running File Maintenance](https://go.microsoft.com/?linkid=9801074).
- **Running the Command Line task on a network**. If you use the **Command Line** task to run an executable program file that is stored on a shared network, and you're using the local Task Scheduler to run jobs, the watch folder user account must have full permissions to the network share so that the task will run.  
  
   If you use the **Command Line** task to run an executable program file that is stored on a shared network, and you're using the HPC Task Scheduler to run jobs, the task might fail. If this occurs, copy the executable program file to the compute nodes in the HPC cluster, and then update the **Command line and arguments** value for the task to run the executable program file locally.
- **Chaining tasks**. When adding multiple tasks to a job template, where the input from one task depends upon the output of another task, make sure that they're displayed in the order that they should be performed in the job template's **Task definition** list. For example, a task that transcodes media files should be listed above a task that copies the transcoded media files to a Web root folder. For more information about adding tasks to job templates, see [Adding Tasks](https://go.microsoft.com/?linkid=9735222).
- **Chaining the MP4 to Smooth Streams default task**. The **MP4 to Smooth Streams** task in Transform Manager can't be used to get the output of any task that precedes it in a task-chaining workflow.
- **Adding multiple instances of a task to a job template**. If you want to add multiple instances of the same task to a job template, you must close and then re-open the job template property sheet to add each subsequent task instance. For example, if you want to add two instances of the default **Robocopy** task to a job template, do the following:

    1. Add the initial instance of the **Robocopy** task. For more information about how to add a task to a job template, see [Adding Tasks](https://go.microsoft.com/?linkid=9735222).
    2. Click **OK** to close the job template property sheet.
    3. In the **Job Templates** page, select the job template that contains the initial task instance, and then in the **Actions** pane, click **Edit**.
    4. Add the second **Robocopy** task instance.
    5. Click **OK** to close the job template property sheet.
- **Changing job template names**. If you edit a job template to change its name (for example, from JobTemplate1 to JobTemplate2), you can't reuse the old job template name (JobTemplate1) when you create a new job template. If you do, the previously edited job template, whose old name is shared with the new job template, will be overwritten.
- **Creating watch folders on a network**. If you specify the UNC path of a network share to use as a watch folder, after you have finished configuring watch folder settings, you must enable the watch folder (but don't start the watch folder) and then restart the Transform Manager service so that permissions can be created on the network share for the user account that the watch folder is configured to impersonate.

    1. Finish configuring watch folder settings. For more information about how to create a watch folder, see [Configuring Watch Folders](https://go.microsoft.com/?linkid=9735221).
    2. Click **OK** to close the watch folder property sheet.
    3. In the **Watch Folders** page, select the watch folder that you just created, and then in the **Actions** pane, click **Enable**.
    4. In the **Connections** pane, click **Transform Manager**, and then in the **Actions** pane, click **Stop Transform Manager Service**.
    5. In the **Actions** pane, click **Start Transform Manager Service**.
  
    The watch folder will automatically start after you restart the Transform Manager Service and permissions for the watch folder's user account will be applied to the watch folder directory on the network.
- **Performance bottleneck for watch folders on a network**. If you specify the UNC path of a network share to use as a watch folder, and encounter performance bottlenecks or timeout errors due to excessive reads from the network-attached storage (NAS), you can add a **workFolder** property to the watch folder XML configuration file (job definition file). This property defines a location on local computers, including the compute nodes in an HPC cluster, to which media assets are copied and processed, before they're returned to the watch folder's Finished folder on the network. To set up a local work folder and update the watch folder's job definition file to work with it, do the following:  

    1. Stop the watch folder if it's started.
    2. Create a folder on each local Transform Manager computer (or on each HPC compute node if you've integrated Transform Manager with an HPC cluster). This folder will be the local work folder and should be created in the same location on all of the computers. For example: `C:\%WorkFolderPath%`.
    3. Ensure that the watch folder impersonation account has Full Control permissions on the local work folder.
    4. Add the **workFolder** property to the configuration XML file for the watch folder's job definition. For example: `<workFolder>C:\%WorkFolderPath%</wFolder>`
    5. Start the watch folder.

    > [!NOTE]
    > The watch folder XML configuration files are located in `%ProgramData%\Microsoft\IIS\Transform Manager\Configuration\Job Definitions`. You might need to turn on the **Folder views** option in Windows that shows hidden files, folders, and drives in order to view them.

- **Specifying the watch folder root path**. When you configure watch folder settings, you can specify a watch folder location on the local Web server or on a network share in the **Watch folder path** list. Be aware of the following when specifying this value:

  - You must use a unique root path for each watch folder. Different watch folders that have the same physical path won't start.
  - Mapped drives to watch folders on a network aren't supported.
  - If you specify a root path on the local Web server, computation-intensive tasks, such as transcoding, that consume a large amount of memory and CPU resources might affect Web server performance. You shouldn't run Transform Manager on the local Web server if you plan to run computation-intensive tasks and also use the Web server in a production environment to fulfill HTTP requests.

  For more information about how to configure watch folder settings, see [Configuring Watch Folders](https://go.microsoft.com/?linkid=9735221).
- **Dropping playlist and manifest files in watch folders**. If you specified a playlist file name extension in the watch folder's **File filter** setting, you shouldn't simultaneously drop multiple playlist files in the watch folder that reference the same media files. The watch folder's job manager will schedule jobs for media files that are referenced in one playlist, and when all of the media files that are referenced in the playlist are present, move the playlist file and media assets as a group to the watch folder's WorkQueue directory. Another playlist that references the same media files then can't be processed because the media files have been removed from the watch folder with the previous playlist. To schedule jobs for this playlist, you must drop the missing media files into the watch folder again.
- **Performance degradation for large number of finished jobs**. If computer performance declines, or jobs take longer to finish, when a large number of finished jobs accumulate in a watch folder's Finished folder, you should configure the maintenance options in Transform Manager to retain these files for a shorter period of time so that they don't clutter the disk. For more information about how to configure Transform Manager to delete finished job files after a specified retention period, see [Running File Maintenance.](https://go.microsoft.com/?linkid=9801074)
- **Event IDs**. In previous releases of Transform Manager, error-level events were logged in Windows Event Viewer using the same event ID (3001). In IIS Transform Manager RTW, error-level events are now logged in Event Viewer with [unique event IDs](https://go.microsoft.com/?linkid=9801582).

## Product Support

### Self-Support

You can obtain support for IIS Transform Manager by using the following resources:

- [Knowledge Base](https://go.microsoft.com/?linkid=9735205)
- [Forum](https://go.microsoft.com/?linkid=9735206)

### Microsoft Support

To obtain support from Microsoft, go to [Microsoft Support](https://go.microsoft.com/?linkid=9801073).

## For More Information

To keep up-to-date with the latest Transform Manager feature news and developments, go to the [Transform Manager Home page](https://go.microsoft.com/?linkid=9735207) on IIS.net.