---
title: "Transforming Media Files to On-Demand Smooth Streams"
author: rick-anderson
description: "IIS Smooth Streaming encoding presets that are integrated with the default installation of IIS Transform Manager 1.0 can be used to transform media files to..."
ms.date: 05/24/2012
ms.assetid: b019a9f2-a704-4032-bfa3-43714b9989ca
msc.legacyurl: /learn/media/transform-manager/transforming-media-files-to-on-demand-smooth-streams
msc.type: authoredcontent
---
Transforming Media Files to On-Demand Smooth Streams
====================
by Dave Nelson

IIS Smooth Streaming encoding presets that are integrated with the default installation of IIS Transform Manager 1.0 can be used to transform media files to on-demand Smooth Streaming presentations for delivery to Silverlight clients. This workflow is shown in the following diagram.  
![](transforming-media-files-to-on-demand-smooth-streams/_static/image1.png)

This article describes how to configure the default **Video files to VC-1 Smooth Streams** job template, which uses a built-in **Expression Encoder 4.0 SP2** transcoding task to transform media files to Smooth Streams. You can edit the task to select different VC-1 or H.264 IIS Smooth Streaming encoding presets to create the appropriate Smooth Streaming output for your Silverlight clients.

This article applies to the following watch folder in IIS Transform Manager 1.0:

- Video files to VC-1 Smooth Streams


<a id="license"></a>

## Licensing

IIS Transform Manager is designed to work with other programs, such as programs that handle audio or video signals. It's solely your responsibility to ensure your compliance with any terms accompanying such other programs, and that you have obtained any necessary rights for your use of the programs.

<a id="get_started"></a>

## Getting Started

This section describes the software configuration and other requirements in order to run the media transform that's described in this article.

<a id="install_tm"></a>

### Installing Transform Manager

For specific installation instructions, see **Downloading and Installing** in the [Transform Manager Readme](iis-transform-manager-readme.md).

<a id="choose_ee"></a>

### Choosing your Edition of Expression Encoder

Expression Encoder 4 is the only integrated encoder available for use with IIS Transform Manager 1.0. Other third-party encoders can be used with Transform Manager, provided that they offer a command-line executable interface or create an integrated task using the [Transform Manager Task API](https://msdn.microsoft.com/en-us/library/ff728121(v=vs.90).aspx).

This article describes the use of an integrated Expression Encoder 4.0 SP2 transcoding task in Transform Manager. This task uses encoding presets that require the encoding profiles and Silverlight player templates provided by [Microsoft® Expression Encoder 4 Service Pack 2 (SP2)](https://www.microsoft.com/expression/products/EncoderPro_Overview.aspx). Both Expression Encoder 4 and Expression Encoder 4 Pro include VC-1 IIS Smooth Streaming encoding presets for content that you transcode for Silverlight Clients. Expression Encoder 4 Pro is the only edition of Expression Encoder that includes H.264 IIS Smooth Streaming encoding presets.

You can get Expression Encoder 4 by downloading a 60-day free Trial edition of Expression Studio 4. If you purchased Expression Studio 3 from a store, and it's installed on your computer, you can download the Trial edition of Expression Studio 4 Ultimate or Expression Studio 4 Web Professional, and the full version of Expression Studio 4 (which includes Expression Encoder 4 Pro) will automatically be enabled. For more information, see [How to Upgrade](https://www.microsoft.com/expression/try-it/).

After installing your preferred edition of Expression Encoder 4, be sure to install [Expression Encoder 4 (SP2)](https://www.microsoft.com/download/en/details.aspx?id=27870) to enable the **Expression Encoder 4.0 SP2** transcoding task in Transform Manager.

For specific installation instructions, see **Installation Notes** in the [Transform Manager Readme](iis-transform-manager-readme.md).

> [!NOTE]
> You should install the Pro edition of Microsoft Expression Encoder 4 if you also want to repackage H.264-encoded Smooth Streams to Apple HTTP Live Streams in Transform Manager or if you want to deliver live Smooth Streaming output to IIS Live Smooth Streaming publishing points. Only Microsoft Expression Encoder 4 Pro supports these features.


<a id="configure_svc"></a>

### Configuring the Transform Manager Service

Create an account for the Transform Manager service, and then start the service. You must create the account and start the service in Internet Information Services (IIS) Manager. Unexpected results can occur if you start the Transform Manager service in the Services MMC console. For instructions, see [Configuring the Transform Manager Service](https://technet.microsoft.com/library/ff730170.aspx).

<a id="prod_notes"></a>

### Production Notes

- For a list of the video file formats that can be transcoded by the integrated **Expression Encoder 4.0 SP2** task, see [Supported file formats](https://msdn.microsoft.com/library/cc294687(Expression.40).aspx).
- You can add the default **Robocopy** task in Transform Manager to your job template in order to copy the transformed Smooth Streaming output to a Web server running [IIS Smooth Streaming](https://www.iis.net/downloads/microsoft/smooth-streaming) or to network-attached storage. For more information, see [Chaining the Robocopy Task to your Transformed Output](chaining-the-robocopy-task-to-your-transformed-output.md).
- You can add the default **PlayReady Protection** task in Transform Manager to your job template in order to encrypt the transformed Smooth Streaming output. For more information, see [Encrypting On-Demand Smooth Streams](encrypting-on-demand-smooth-streams.md).
- To learn how to create a webpage that Silverlight clients can use to play the Smooth Streaming output, see [Delivering Transform Manager Output to Clients](delivering-transform-manager-output-to-clients.md).
- If you configure your job template to output H.264-encoded IIS Smooth Streams, you can use the **Smooth Streams to Apple HTTP Live Streams** task in Transform Manager to transform the Smooth Streams to the MPEG-2 Transport Stream (MPEG-2 TS) container format in conformance with the [Apple HTTP Live Streaming Protocol Specification](https://developer.apple.com/library/ios/#documentation/NetworkingInternet/Conceptual/HTTPLiveStreaming/_index.html). This format can be delivered from a Web server running IIS Smooth Streaming to Apple mobile digital devices. To learn how to configure the **Smooth Streams to Apple HTTP Live Streams** task in Transform Manager, see [Transforming On-Demand Smooth Streams to Apple HTTP Live Streams](transforming-on-demand-smooth-streams-to-apple-http-live-streams.md).

> [!NOTE]
> Computation-intensive tasks, such as encoding and transcoding, can consume a large amount of memory and CPU resources and might affect Web server performance. You shouldn't run Transform Manager on the local Web server if it's also used in a production environment to fulfill HTTP requests.


<a id="configure_jt"></a>

## Configuring the Video files to VC-1 Smooth Streams Job Template

This section describes how to configure the default **Video files to VC-1 Smooth Streams** job template to create on-demand Smooth Streaming output for your Silverlight clients. Job templates are modifiable definitions of the tasks that are run during the transform. You can modify task properties for this job template to output alternate Smooth Streaming encodings by selecting from all of the IIS Smooth Streaming encoding presets that are integrated with the Transform Manager installation, including VC-1 and H.264 encoding presets.

<a id="configure_task"></a>

### Configuring the Expression Encoder 4.0 SP2 Task

1. In IIS Manager, in the **Connections** pane, click **Job Templates**.  
    [![](transforming-media-files-to-on-demand-smooth-streams/_static/image4.png)](transforming-media-files-to-on-demand-smooth-streams/_static/image3.png)
2. In the **Job Templates** page, select the **Video files to VC-1 Smooth Streams** job template.  
    [![](transforming-media-files-to-on-demand-smooth-streams/_static/image6.png)](transforming-media-files-to-on-demand-smooth-streams/_static/image5.png)  
  
 Note the name of the watch folder that this job template is bound to in **Watch folders that use this job template**. We'll configure this watch folder to run the transcoding jobs later in this article.
3. In the **Actions** pane, click **Edit**.  
    [![](transforming-media-files-to-on-demand-smooth-streams/_static/image8.png)](transforming-media-files-to-on-demand-smooth-streams/_static/image7.png)
4. In the **Edit Job Template** dialog box, you can edit the job template **Name** and **Description** to give it a more descriptive information for your environment. For example, if you decide to change the default VC-1 IIS Smooth Streaming encoding preset to an H.264 IIS Smooth Streaming encoding preset in the next step, you can edit the **Name** and **Description** to reflect your choice.  
    [![](transforming-media-files-to-on-demand-smooth-streams/_static/image10.png)](transforming-media-files-to-on-demand-smooth-streams/_static/image9.png)  
  
 The **Task definitions** list shows the task that's used by this job template.
5. To change the preset used by this task to another Expression Encoder preset, select the **Expression Encoder 4.0 SP2** task, and then click **Edit**.  
    [![](transforming-media-files-to-on-demand-smooth-streams/_static/image12.png)](transforming-media-files-to-on-demand-smooth-streams/_static/image11.png)
6. In the **Edit Expression Encoder 4.0 SP2 Task** dialog box, in **preset**, double-click the **Value** field, and then type the name of a new preset file that's included in the default installation of Transform Manager.  
    [![](transforming-media-files-to-on-demand-smooth-streams/_static/image14.png)](transforming-media-files-to-on-demand-smooth-streams/_static/image13.png)  
  
 You can choose from any of the following IIS Smooth Streaming encoding preset files that are installed with Transform Manager, or from any custom encoding presets that you designed in Expression Encoder.  
    [![](transforming-media-files-to-on-demand-smooth-streams/_static/image16.png)](transforming-media-files-to-on-demand-smooth-streams/_static/image15.png)
7. (Optional) Edit the following additional task default values in the **Properties** list. 

    - The **templateName** and **templatePath** properties are used to specify the Expression Encoder 4.0 SP2 Silverlight player template that's used. By default, the task is configured to use the Standard player template that's stored in the default installation path for Expression Encoder: `%ProgramFiles(x86)%\Microsoft Expression\Encoder 4\Templates\en\Standard`. Modify these values, if desired, to point to other Expression Encoder 4 Silverlight player templates that are included in the Transform Manager installation, or to custom Silverlight player templates that you designed in Expression Encoder.
    - Enable the **createSubDirectory** property if you want the **Expression Encoder 4.0 SP2** task to output to a uniquely named subdirectory for each job. This is disabled by default to give you better control of the naming of the output location when you use Transform Manager.
8. If you want to make the transcoded output available for a subsequent task in a task-chaining scenario, specify a virtual folder name in **Output folder name**.  
    [![](transforming-media-files-to-on-demand-smooth-streams/_static/image18.png)](transforming-media-files-to-on-demand-smooth-streams/_static/image17.png)
9. After reviewing or modifying the settings in the **Edit Expression Encoder 4.0 SP2 Task** dialog box, click **OK**.
10. In the **Edit Job Templates** dialog box, click **OK** to save your modifications to the job template.

<a id="configure_wf"></a>

## Configuring the Video files to VC-1 Smooth Streams Watch Folder

To run transform jobs on media files, you must configure the default watch folder in Transform Manager that uses the job template that you configured in the [previous section](transforming-media-files-to-on-demand-smooth-streams.md#configure_jt). The watch folder will detect when media file types that you specify arrive in it, and then Transform Manager will run the tasks that are included in the job template that's bound to the watch folder against the media files. You can use the **Edit Watch Folder** property sheet to specify the watch folder location, the media file types that it should "watch" for, the task scheduler that should run the tasks in it, the user account that tasks should impersonate, as well as many other settings.

1. In IIS Manager, in the **Connections** pane, click **Watch Folders**.  
    [![](transforming-media-files-to-on-demand-smooth-streams/_static/image20.png)](transforming-media-files-to-on-demand-smooth-streams/_static/image19.png)
2. In the **Watch Folders** page, select the **Video files to VC-1 Smooth Streams** watch folder, which uses the job template that you configured in the [previous section](transforming-media-files-to-on-demand-smooth-streams.md#configure_jt). You can confirm this by looking at the **Job template** value in the **Watch Folder Details** pane.  
    [![](transforming-media-files-to-on-demand-smooth-streams/_static/image22.png)](transforming-media-files-to-on-demand-smooth-streams/_static/image21.png)
3. In the **Actions** pane, click **Edit**.  
    [![](transforming-media-files-to-on-demand-smooth-streams/_static/image24.png)](transforming-media-files-to-on-demand-smooth-streams/_static/image23.png)
4. Configure required settings in the watch folder's property sheet using the instructions in [Configuring Watch Folders](https://technet.microsoft.com/library/ff730178.aspx). The following guidance applies to settings of particular importance for this workflow:  

    | Tab | Settings | Description |
    | --- | --- | --- |
    | Basic Settings | Input files | In **File filter**, specify one or more of the file formats supported by Expression Encoder. The supported string format is an asterisk (\*), followed by a period, and then the file name extension (for example, **\*.wmv** or **\*.mp4** are valid file filters). If you type **\*** to specify that the job template acts on all file types, only the [supported file formats](https://msdn.microsoft.com/library/cc294687(Expression.40).aspx) will be processed. Specifying multiple file formats (for example, in a comma-delimited list) isn't supported. |
    | Scheduler | Scheduler | In **Scheduler**, you'll typically select **Local Task Scheduler** to specify that Windows Task Scheduler on the local computer be used to run jobs, monitor and report job status, and allocate CPU resources to tasks. For large computation-intensive jobs (such as encoding and transcoding) where CPU resources might not be sufficient, you can shift the jobs from the local computer to computers in a High Performance Computing (HPC) cluster, and then configure the watch folder to use the HPC Task Scheduler on the head node in the HPC cluster. For more information about how to use Transform Manager with an HPC cluster, see [High-Performance Transcoding with IIS Transform Manager and Windows HPC Server](high-performance-transcoding-with-iis-transform-manager-and-windows-hpc-server.md). |
    | Scheduler | Concurrent jobs and Priority | Use these settings to manage computer resources. **Concurrent jobs** controls how many jobs can run at the same time in the watch folder. The value is **1** by default, which means that if you drop 10 files in the watch folder, only one will begin processing immediately while the rest will go straight into a job queue. You can adjust this setting depending on the amount of physical memory and number of CPUs that you have on your server. Encoding tasks can consume a lot of CPU and memory resources and encoding jobs might fail with high concurrency settings. If you encounter these types of job failures, increase the amount of available RAM and/or CPUs, or reduce the number of concurrent jobs to **1**. Selecting the **Unlimited** check box disables the concurrency setting and immediately schedules all files that are detected in the watch folder for processing. **Priority** controls the priority that jobs are given when scheduled by a watch folder. If multiple watch folders are running on the computer, you can assign a **Priority** value to each one. This setting enables jobs that are in high-priority watch folders to be created and run first. If you drop media assets in a watch folder, but another watch folder that has a higher priority level is actively running jobs, the jobs for the dropped media assets aren't created and queued for processing until the higher-priority watch folder finishes all of its jobs. |
    | Advanced Settings | Credentials | You must specify a user account for the watch folder to impersonate. The tasks in the job template that's bound to the watch folder will run under the security context of this user account. You must ensure that it has the required permissions for the tasks that are run. For more information about how to create this account, see [Creating Watch Folder Impersonation Accounts](https://technet.microsoft.com/library/hh147633.aspx). |

<a id="run_jobs"></a>

## Running your Transform Jobs

A job is created for each media asset that's dropped in a watch folder and meets the watch folder file filter requirements. For example, if the **File filter** setting for a watch folder is set to detect all Windows Media Video (.wmv) files, a job is created for each .wmv file that's dropped in the watch folder. Media files with file-name extensions that don't match the watch folder's **File filter** setting are ignored.

To begin transforming content, copy-and-paste the media assets into the watch folder directory using Windows Explorer or another file-movement mechanism such as command line, FTP, or WebDav.  
[![](transforming-media-files-to-on-demand-smooth-streams/_static/image26.png)](transforming-media-files-to-on-demand-smooth-streams/_static/image25.png)

The watch folder directory is specified in the **Watch folder path** setting on the **Basic Settings** tab of the watch folder property sheet.  
[![](transforming-media-files-to-on-demand-smooth-streams/_static/image28.png)](transforming-media-files-to-on-demand-smooth-streams/_static/image27.png)

After you drop specified assets in a watch folder, the watch folder's job manager creates a job for each file and moves them one at a time into the watch folder's WorkQueue directory. The files will be moved from the watch folder into the WorkQueue quickly if they're small. The watch folder might not discover larger files for up to 60 seconds. If the files don't disappear after 60 seconds, make sure that you're in the correct watch folder or that you have enabled and started the correct watch folder.

The WorkQueue directory contains folders that store the jobs as they're being processed. Assets that are processed successfully are placed in the watch folder's Finished folder while media assets that can't be processed are placed in the Failed folder. These folders are visible by default so that you can retrieve their contents more easily. The WorkQueue directory contains other folders that temporarily store jobs as they're run through the job workflow. These folders are hidden folders and to view them, you must turn on the **Folder views** option in Windows that shows hidden files, folders, and drives.  
[![](transforming-media-files-to-on-demand-smooth-streams/_static/image30.png)](transforming-media-files-to-on-demand-smooth-streams/_static/image29.png)

As jobs are run, job files (which include the original media source files, job manifest files, and the transformed output for completed jobs) accumulate in the watch folder WorkQueue folders. They can eventually clutter the disk and potentially impact performance. For more information about how to configure settings to automatically delete these files from the WorkQueue after a specified period of time, see [Running File Maintenance](https://technet.microsoft.com/library/hh147635.aspx).

<a id="manage_jobs"></a>

## Managing and Monitoring your Transform Jobs

As jobs are processed through the WorkQueue folders, you can use the **Job Monitor** pages in IIS Manager to view the progress of and manage the currently running and queued jobs. For more information, see [Running and Monitoring Jobs](https://technet.microsoft.com/en-us/library/ff730174(v=ws.10).aspx).