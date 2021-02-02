---
title: HttpExtensionProc function
ms.date: 06/16/2017
api_name:
  - HttpExtensionProc
api_location:
  - aspnet_isapi.dll
  - unknown
api_type:
  - IIS
topic_type:
  - apiref
---
# HttpExtensionProc function

The **HttpExtensionProc** function is the main entry point for an ISAPI extension called by IIS. It exposes methods that IIS uses to access the functionality exposed by the extension.

## Syntax

```cpp
DWORD WINAPI HttpExtensionProc(
    LPEXTENSION_CONTROL_BLOCK lpECB
);
```

## Parameters

`lpECB`\
Points to the [EXTENSION\_CONTROL\_BLOCK](/previous-versions/iis/6.0-sdk/ms525658(v=vs.90)) data structure that's associated with the current, active request.

## Return Values

Returns a DWORD containing HSE\_STATUS codes. Possible return values are:

| Option | Description |
|---|---|
| Help or /? | Displays information about available AXE.exe command-line options. |
| job_file | Specifies the job (.jobx) file that you want to run, and job_file can specify a relative path. If the job file is in the directory from which you're running AXE.exe, no path is required.
By default, when you create a job in the Windows Assessment Console, it's saved to %USERPROFILE%\Documents\Windows Assessment Console\Jobs\.
This option is required if no other parameter that performs an action is specified.
Example: `axe C:\Assessments\MyJobs\Job1.jobx` |
| /Job job_file | Specifies the path and file name of the job file, job_file, to use in locating the assessments to reanalyze within the results file.
 |
| /Analyze results_file | Reanalyzes the results from a job (.jobx) file specified by results_file. This option requires a job from a package or assessment manifest directly to locate the assessments to reanalyze. |
| /Assessment assessment_file | Specifies the path and file name of an assessment manifest, assessment_file, to reanalyze in the results file specified. |
| /Timeout seconds | Specifies the amount of time in seconds that the job will wait for another job to finish before it exits with an error. When seconds is zero, the default, the job will exit immediately without running if another job is already running.
Example: `axe C:\Assessments\myJobs\Job1.jobx /Timeout 30` |
| /NoPublish | Specifies to not publish the results file to the location that's specified in the job file. When you use this option, the results are saved to the default location, %LOCALAPPDATA%\Microsoft\Axe\Results\\.
Example: `axe C:\Assessments\myJobs\Job1.jobx /NoPublish` |
| /PublishToSource | Specifies that AXE.exe update the original results folder when running /Analyze. Using /PublishToSource is optional, and it is ignored when running a job.
/PublishToSource may be combined with the publish path, but the publish path will only be used if AXE.exe cannot publish to the original results folder. |
| /PublishPath folder_path | Specifies a location to publish the results file to. The path specified by folder_path overrides the publication path, ResultsPublishPath, that is specified in the job file. This option is ignored if it's combined with /NoPublish.
Example: `axe C:\Assessments\myJobs\Job1.jobx /PublishPath C:\Assessments\myResults` |
| /DisplayLog ETL_file | Displays the content of an Event Trace Log (ETL) file specified by ETL_file, which can contain wildcard characters in the path and file name. AXE.exe writes an ETL file when running a job, and it displays the path in the console window.
The default location of the log file is %LOCALAPPDATA%\Microsoft\Axe\Logs\GUID\, where GUID is a GUID that is generated randomly for each new job. The job results file in the SessionLogFiles node also contains the full location. This node specifies all of the log files.
Note   All of the ETL files are automatically converted into a single AxeLog.txt file that is saved in the results directory. You can open this file by using Notepad.
Example: `axe /DisplayLog %LOCALAPPDATA%\Microsoft\Axe\Logs\E5A6CB43-C1CE-4FC1-8170-13B002E250B36\AxeLog-000.etl` |
| /RemoveRestart | Specifies that any existing, pending job-restart task should be removed.
The /JobFile option isn't needed when you use this option.
When you run a job, the assessment creates a task to restart the job if there's a system failure, like a loss of power. When you use this option, the task is removed from the Task Scheduler. If no job-restart task is pending, the assessment will return an error to inform you that the task doesn't exist.
Example: `axe /RemoveRestart` |
| /NoWarnings | Suppresses warning messages. This is an optional parameter.
Example: `axe C:\Assessments\myJobs\Job1.jobx /NoWarnings` |
| /Pause | Pauses AXE.exe after the job finishes. You can then see any errors or other information in the console before AXE.exe exits and the console closes. Exiting continues when you press a key.
Example: `axe C:\Assessments\myJobs\Job1.jobx /Pause` |
| /JobParameter parameter=value | Specifies a value to override a job parameter that may exist in the job manifest. You can use /JobParameter up to 100 times to specify multiple job parameters. If duplicate parameter names appear, the assessment uses the last value supplied for that name. Using /JobParameter is optional.The /PublishPath option takes precedence over setting the ResultsPublishPath job parameter with this option. Example: `axe C:\Assessments\myJobs\Job1.jobx /JobParameter iterations=1` |

## Remarks

This entry point is similar to a **main()** function in a C++ program. The code in this entry point uses callback functions in the [EXTENSION\_CONTROL\_BLOCK](/previous-versions/iis/6.0-sdk/ms525658(v=vs.90)) structure to read client data and decide which action to take. Before returning to the server, a properly formatted response must be sent to the client through either the [WriteClient](/previous-versions/iis/6.0-sdk/ms525515(v=vs.90)) function or [ServerSupportFunction](/previous-versions/iis/6.0-sdk/ms525975(v=vs.90)). Return codes are defined in httpext.h.

> [!NOTE]
> In IIS versions 4.0 and later, the return values `HSE_STATUS_SUCCESS` and `HSE_STATUS_SUCCESS_AND_KEEP_CONN` are functionally identical: Keep-Alive connections are maintained, if supported by the client.

## Requirements

**Client:** Requires Windows XP Professional, Windows 2000 Professional, or Windows NT Workstation 4.0.

**Server:** Requires Windows Server 2003, Windows 2000 Server, or Windows NT Server 4.0.

**Product:** [IIS](/previous-versions/iis/6.0-sdk/ms525568(v=vs.90))

**Header:** Declared in httpext.h.
